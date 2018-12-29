# Customized build process for .NET Core projects #
The customized build process should simplify and unify the local build from Visual Studio providing higher level of control. It's used for building solutions .NET Core (.NET Standard) libraries, .NET Core applications or their mix.
The primary intention was to keep the common versioning across the whole solution and the process has been extended based on the needs in time.

- Ensure the same version for all projects within the solution
- Use the version information for NuGet packages and assemblies
- Pack the libraries to NuGet packages with higher level of control of the way, how the packages are created
- Provide the possibility to execute part of the build process once per solution
- Automate the code documentation (see [MarkupDoc](https://github.com/adamecr/MarkupDoc) for details)
- Make the build process reusable as a template (see [RAD Projects Extension](https://github.com/adamecr/RadProjectsExtension) for details)
- Make the build process (template) extensible

## How to use the custom build process ##
The details about the custom build process are described below, this is just a quick check list.
- Make sure that the property `RadUseCustomBuild` is set to `true` (either as an environment variable or in `custom/Build.props`)
- Ensure the proper build order by setting the build dependency of each project except `build.tasks` to `build` project
- Set the required version info within the `Version.props` file.
- Set the required information  (authors, repository info, etc. in `custom/Build.props`). The projects being packed using the custom build process, should not override the package information (use something like `<Authors>$(Authors)</Authors>` in `.csproj` file where is global property is to be used).
- Set `IsPackable` property in `.csproj` file for the projects producing the NuGet packages (including the source-only packages)
- Put the solution (repository) wide information into `readme.md` file in solution root directory.
- Provide the information about changes within the `changelog.md` file in solution root directory.

## Build process ##
High level build process:
 - Prepare the version info at the beginning of the build process
   - Increase the build number, add the information from the git system (branch, commit) 
 - Build individual projects
   - Apply the version information to assemblies 
   - Pack the NuGet libraries
   - Generate the code documentation  

### Master switch ###
The file `Directory.Build.targets` in the solution root directory is the main entry point to the custom build.
```xml
<Import  Project="build/master/Master.Build.targets" Condition="'$(RadUseCustomBuild)'=='true' AND Exists('build/master/Master.Build.targets')" />
```
It imports the master file of custom build based on two conditions:
- The master file exists (should exist by default, when a template is applied)
- The property `RadUseCustomBuild` is set to `true`. This is not set by template, so by default the custom build is not applied, allowing sharing the source code in public repositories without implicit use of the custom build process. To enable the custom build process, it's recommended to set the environment variable `RadUseCustomBuild` to `true` on the machine where the custom build process is intended to be run.
  
### Versioning ###
I wanted to have a common (same) version for all outputs (projects) within the solution based on Semantic Versioning 2.0.0. The version has three main parts `<major>.<minor>.<patch>`, that are to be defined manually and additional version info created automatically. 

The full version info has following syntax:
 - `<major>.<minor>.<patch>-dev.<build_number>.<YYMMDDHHMMSS>+<commit_number>.<branch>.<short_commit_sha>[-dirty]` for development (Debug) versions. The `-dirty` part is added to last commit SHA in case that there are any uncommited changes. 
 - `<major>.<minor>.<patch>+<build_number>.<YYMMDDHHMMSS>.<branch>.<short_commit_sha>[-dirty]` for release versions (`-dirty` part should not be seen for release version, but it depends on the release process).
 
The full version info is used as a NuGet package version and the `Product version` of assembly. The assembly `File version` is `<major>.<minor>.<patch>.<build_number>`.The package name is: 
 - `<package_id>.<major>.<minor>.<patch>-dev.<build_number>.<YYMMDDHHMMSS>.nupkg` for development versions
 - `<package_id>.<major>.<minor>.<patch>.nupkg` for release versions.

The version information is stored in `Version.props` file in the solution root. The file has standard MS Build props file structure with the data in elements under `/Project/PropertyGroup` tag:
```xml
<Project>
	<!--
	======================================================================================= 
	Version information shared between the projects within the whole solution.
	Major, Minor, Patch is to be set manually
	Build is set at the beginning of the build process using SetBuildNumberTask (once per solution/build)
	=======================================================================================
	-->
	<PropertyGroup>
		<RadMajor>0</RadMajor>
		<RadMinor>1</RadMinor>
		<RadPatch>0</RadPatch>
		<RadBuild>279</RadBuild>
		<PackageVersionShort>0.1.0-dev.279.181101121206</PackageVersionShort>
		<PackageVersionFull>0.1.0-dev.279.181101121206+38.master.6415348-dirty</PackageVersionFull>
		<GitCommit>6415348-dirty</GitCommit>
		<GitBranch>master</GitBranch>
	</PropertyGroup>
</Project> 
```

The version is updated within the `<Target Name="SetVersionInfo" DependsOnTargets="GetGitInfo" BeforeTargets="Build" > ` in `Build.Once.targets` by `SetVersionInfoTask`. The task is defined in `Version.tasks` using `build.tasks/SetVersionInfoTask.cs`. Set Version Info task updates the `Version.props` properties except the "manual" ones (major, minor, patch). Target `GetGitInfo` is called before and it executes several git commands to fill commit short SHA to `$(GitCommit)`, branch to `$(GitBranch)` and commit sequential number to `$(GitCommits)`.

Version properties are imported for "regular" projects build in `Master.Build.targets` and the `SetVersionProperties` target populates the common MS Build properties to ensure that the assemblies and packages get the proper version info.
```xml
<Target Name="SetVersionProperties" BeforeTargets="BeforeCompile" >
    <Message Text="Using version info: version $(RadMajor).$(RadMinor).$(RadPatch); Package $(PackageVersionFull); Build number set to $(BuildNumber)" />
    <PropertyGroup>
      <Version>$(RadMajor).$(RadMinor).$(RadPatch)</Version>

      <AssemblyVersion>$(RadMajor).$(RadMinor).$(RadPatch).$(BuildNumber)</AssemblyVersion>
      <FileVersion>$(RadMajor).$(RadMinor).$(RadPatch).$(BuildNumber)</FileVersion>
      <AssemblyFileVersion>$(RadMajor).$(RadMinor).$(RadPatch).$(BuildNumber)</AssemblyFileVersion>

      <PackageVersion>$(PackageVersionShort)</PackageVersion>

      <AssemblyInformationalVersion>$(PackageVersionFull)</AssemblyInformationalVersion>
      <InformationalVersion>$(PackageVersionFull)</InformationalVersion>

    </PropertyGroup>
  </Target>
```
### NuGet packages ###
When the project sets the property `IsPackable` to `true`, custom NuGet packages pack process is applied. `GenerateNuSpecFile`target generates the NuSpec file into project's intermediate output path (for example `obj/debug`). And uses this NuSpec file while packing the package using the standard pack target (the standard MS Build property `NuspecFile` is set accordingly).

Besides the NuSpec file, a file `package_dependency.txt` with "dependency to itself") is generated to the intermediate output path. When generating the NuSpec file, the `GenerateNuSpecFileTask` checks for the project references and when a project publishes the package (its `package_dependency.txt` file exists), the project reference is replaced by package reference retrieved from referenced project's `package_dependency.txt` file. When the referenced project doesn't publish the NuGet package, its outputs are added to the package of consuming project. 

After the standard `pack` target is executed, the custom build process executes `PublishNuGetLocal` target when property `PushPackagesToLocalFeed` is set to `true` and/or `PublishNuGetVsts` target when `PushPackagesToVstsFeed` propery is set to `true` (by default enabled for the `Release` configuration only).
The first one publishes the package to the local NuGet feed. Local NuGet feed source name (directory) is defined by `$(NuGetLocalFeedSourceName)` property. The other one publishes the package to VSTS (Azure DevOps) package repository. VSTS NuGet feed source name is identified by `$(NuGetVstsFeedSourceName)` - the NuGet source must be defined in advance in Visual Studio or using `nuget sources add`. Also the credentials are to be defined in advance `nuget sources update -Name "<source_name>" -username "<user_name>" -password "<password>"`.


#### Source-only NuGet packages ####
Source-only NuGet packages contain just the source code that is added to the project the package is added to. I use the source-only NuGet packages for the libraries containing the miscelaneous common code (utilities, helpers, extensions, etc.) where the individual pieces are too small that it doesn't make sense to build an assembly (regular package) for them and the whole stuff is a mixup of different functionalities that the consumers will use just a small part of the functionality but the dependency will be everywhere. For this case I create source-only packages that can have very small granularity (even the method) without polluting the consumer with huge amount of referenced assemblies that would need to be managed and distributed. When a source-only package is added to the project, it adds the source code to the compilation so the "binary" will be a part of project's assembly. It also makes easier to "read" the sources, debug and extend the libraries.
Long story short: source-only NuGet packages are the libraries providing the source code to be included in consumer, not the binary.  

The source-only package is created from the (partial) class or classes in the project folder based on the metadata provided as special XML Documentation Comments.
- `<NuProp.Id></NuProp.Id>` - unique package ID (mandatory) 
- `<NuProp.Version></NuProp.Version>` - package version base (major.minor.patch) - optional, if not defined, the custom build process uses the solution version information     
- `<NuProp.Description></NuProp.Description>` - package description - optional, if not defined, the custom build process uses the default generic description     
- `<NuProp.Tags></NuProp.Tags>` - package tags (optional) 
- `<NuProp.Includes type = "" />` - file includes (optional). If type is `Folder`, the package will include all compile files in folder, if type is `FolderRecursive` the subfolders will be also included.       
- `<NuProp.Using id = "" version=""/>` - package dependencies (optional). Version for a dependency is optional. These dependencies will be defined within the package     
- `<NuProp.Needs id="" />` - "external" dependencies (optional) - not included in package, just info when consuming!!! Meaning that the **consumer has to include the dependency on its own**.     

`GeneratePartNuSpecFilesForSourceOnly` target, executed during the build, checks all compilation files and generates the `.partnuspec` files for source files containing valid `<NuProp.Id>` XML Documentation Comments (metadata). `.partnuspec` file is a partial NuSpec file that is later on extended with solution wide properties and serves as a base for packaging of source-only packages.

Adding the following snippet to .NET Core project file will make the `.partnuspec` files linked (in hierarchy) to the file declaring the source-only package.
```xml  
<ItemGroup>
	<None Update="**\*.cs.partnuspec">
		<DependentUpon>%(FileName)</DependentUpon>
	</None>
</ItemGroup>
``` 

`GenerateSourceOnlyPackages` target, executed during the build, gets all `.partnuspec` files, extend them with the solution wide properties and creates the temporary (`*.tmp.nuspec`) files used to pack the source-only packages and store them into project's `.artifacts'` directory.

The packages can be published to local repository using the `PublishSourceOnlyNuGetLocal` target. Publishing to VSTS package repo or to NuGet is not supported out of the box - I do this manually to keep the control.

Note: **The project must have the property `IsPackable` set to `true` to create the source-only packages.**

### Code documentation ###
There is a `GenerateMarkupDoc` task executing the [MarkupDoc](https://github.com/adamecr/MarkupDoc) to generate the code documentation in MD (markdown) and HTML format.
The target uses some properties to adjust the configuration:
- `MarkupDocPath` - path to the MarkupDoc executable
- `MarkupDocGenerate` - flag whether to generate the code documentation. Set to `true` when the documentation is to be generated (by default disabled for `Debug` builds)
- `MarkupDocTargetDir` - path where to generate the documentation to
- `MarkupDocTargetName` - name of the main (index) file (without extension)
- `MarkupDocLocalMsDocDir` - path to the offline MS API documentation used to resolve the links to MS API

```xml
<PropertyGroup>
	<MarkupDocPath>$(USERPROFILE)\Documents\Visual Studio 2017\Projects\MarkupDoc\binaries\MarkupDoc.exe</MarkupDocPath>
	<MarkupDocGenerate>true</MarkupDocGenerate>
	<MarkupDocTargetDir>$(MSBuildProjectDirectory)/../doc/</MarkupDocTargetDir>
	<MarkupDocTargetName>$(MSBuildProjectName)</MarkupDocTargetName>
	<MarkupDocLocalMsDocDir>X:/_DEV/_dotnet-api-docs/dotnet-api-docs</MarkupDocLocalMsDocDir>
</PropertyGroup>
```

### Build order ###
Build order plays an important role in the custom build process. When a reference between projects is set, the proper build order is handled by standard tools well, allowing to add dependency for package created by project or to include the outputs of referenced project to the package.
However, Visual Studio (resp. solutions) also recognize the project build dependencies between non-referenced projects. This mechanism is used to have "build.once" (or build first) targets that are in fact part of the build process of project `build`. To ensure working custom  build process, **all projects except `build.targets` must have  a build dependency to `build` project** (so the `build` project is built first).  

## File structure and extensibility ##

```
01 Solution/
02 ├── Directory.Build.targets
03 ├── Version.props
04 ├── build/
05 │   ├── build.once
06 │   │   └── Build.Once.targets
07 │   ├── common/
08 │   │   ├── Common.Build.props
09 │   │   ├── Common.Build.props.debug
10 │   │   └── Common.Build.props.release
11 │   ├── custom/
12 │   │   ├── use/
13 │   │   │   ├── Custom.Build.Once.targets
14 │   │   │   └── Custom.Build.targets
15 │   │   ├── Build.props
16 │   │   ├── Build.props.debug
17 │   │   └── Build.props.release
18 │   ├── master/
19 │   │   ├── use/
20 │   │   │   ├── Git.targets
21 │   │   │   ├── NuGet.targets
22 │   │   │   ├── NuGet.tasks
23 │   │   │   ├── NuGetSourceOnly.targets
24 │   │   │   ├── Utils.tasks
25 │   │   │   └── Version.tasks
26 │   │   └── Master.Build.targets
27 │   └── Directory.Build.targets
28 └── build.tasks/
29     ├── sourceOnlyPackage
30     │   ├── GenerateNuSpecFileTask.cs
31     │   └── GenerateNuSpecFileTask.cs
32     ├── Directory.Build.targets
32     ├── DumpPropertiesTask.cs
34     └── SetVersionInfoTask.cs

```
Solution directory contains the **`Version.props`** file [#03] with the version information that is updated at the beginning of each build and used while building individual projects. It also contains **`Directory.Build.targets`** file [#02] that imports the master targets file for customized build.

```xml
<Import  Project="build/master/Master.Build.targets" Condition="Exists('build/master/Master.Build.targets')" />
```

That's the main "enabler" for the customized build. When the master file is not found, the customized build will not be used. It means that it's safe to remove `build` and `build.tasks` projects from solution directory without impact to the solution itself, it will just use the default build process.

The **`build`** project [#04] contains a hierarchy of the `props`, `tasks` and `target` files defining the customized build process.
 - **`Build.Once.targets`** [#06]- templated targets that run once per solution (on build of `build` project). Sets (increase) the build number for the whole solution (build process) and updates the `Version.props` file [#03], so the build of "regular" projects has the proper version info common for the whole solution build. *Note: "templated" means that the file is managed by template and should not be changed.*
 - **`common`** directory [#07] contains the templated property files (main [#08], debug [#09] and release [#10]) defining the common properties shared across the projects.
 - **`custom`** directory [#11] contains the files created by template but not further updated by template. These files can be modified for the particular solution to have the solution based customization of the build process. **This is the extension point, how to further customize the templated build process for particular solution.**
  - Use **`Custom.Build.Once.targets`** [#13] to extend the part of the process, that runs once per solution (at the beginning of the process).
  - Use **`Custom.Build.targets`** [#14] to extend the part of the process, that runs for each "regular" project. 
  - Use **`Build.props`** files [#15-#17] to add/update the properties. This can override the common (templated) properties for the particular solution.    
 - **`master`** directory [#18] is managed by template and contains tasks and targets of template defined customized build.
  - **`Master.Build.target`** [#26] is the main file defining the template defined customized build. It's imported by solutions `Directory.Build.targets` file [#02] to enable the customized build.
 - **`Directory.Build.targets`** [#27] overrides the solution based one to ensure it's not used for the `build` project and imports the `Build.Once.targets` [#06] instead, causing the the build once (per solution) process will be executed when the `build` project is built.

The **`build.tasks`** project [#28] defines the custom developed build tasks. By default, the customized build process uses the source files and executes them using the RoslynCodeTaskFactory as inline tasks.

Property files are imported in `Master.Build.targets` and `Build.Once.targets` in following order (the later imports can override the properties from the previous ones)
``` xml
<Import Project="../common/Common.Build.props" Condition="Exists('../common/Common.Build.props')" />
<Import Project="../common/Common.Build.props.debug" Condition="'$(Configuration)'=='Debug' AND Exists('../common/Common.Build.props.debug')" />
<Import Project="../common/Common.Build.props.release" Condition="'$(Configuration)'=='Release' AND Exists('../common/Common.Build.props.release')" />
<Import Project="../custom/Build.props" Condition="Exists('../custom/Build.props')" />
<Import Project="../custom/Build.props.debug" Condition="'$(Configuration)'=='Debug' AND Exists('../custom/Build.props.debug')" />
<Import Project="../custom/Build.props.release" Condition="'$(Configuration)'=='Release' AND Exists('../custom/Build.props.release')" />
<Import Project="../../Version.props" Condition="Exists('../../Version.props')" />

<!-- not in build.once.targets: -->  
<Import Project="$(MSBuildProjectDirectory)/Build.props" Condition="Exists('$(MSBuildProjectDirectory)/Build.props')" />
```

## build project ##
This is the dummy project allowing the run the MSBuild targets defined in "local" `Directory.Build.targets` exactly once during the solution build. 

**Set the build dependency for all projects within the solution - all project depends on the build project, so it will be the first in the build order.** This is the crucial setting that needs to be done to ensure the correct behavior of the custom build process.

The "local" `Directory.Build.targets` will read solution `Version.props` and update (increment) the `RadBuild` property, so the other projects will just import `Version.props` to get the (same) build number.

The `build.csproj` file has been modified to skip the standard build (compile and create assembly) by removing the `SDK` attribute from the `Project` element and using the explicit imports, so the `Build` target can be cleaned up after the imports

```
<Project >
  <Import Project="Sdk.props" Sdk="Microsoft.NET.Sdk" />
  
  <PropertyGroup>
    <TargetFramework>netstandard2.0</TargetFramework>
  </PropertyGroup>
  
  <Import Project="Sdk.targets" Sdk="Microsoft.NET.Sdk" />

  <!-- Clean standard target -->
  <Target Name="Build" />
  
</Project>
```

Besides using the `build` project to manage the "build.once" targets, the project also contains the definition of all targets (and tasks) used in custom build process. 

### Targets ###
#### Build.Once.targets ####

**`SetVersionInfo`** target - sets (increase) the build number for the whole solution (build process).
``` 
DependsOnTargets="GetGitInfo"
BeforeTargets="Build"
```   
Updates the Version.props file, so the other projects just imports it
Sets: *RadBuild, BuildNumber, PackageVersionShort, PackageVersionFull*

#### Git.targets ####
**`GetGitInfo`** target - executes git commands to get the current commit short SHA,  branch and commit number
Sets: *GitCommit, GitBranch, GitCommits*

#### NuGet.targets ####
**`GetProjectsPath`** target - displays relative project paths
```
AfterTargets="Build"
```
 
**`GenerateNuSpecFile`** target - generates the NuSpec file for project output package 
```
BeforeTargets="Pack" 
AfterTargets="Build"
DependsOnTargets="GetProjectsPath"
Condition="'$(IsPackable)' == 'true'"
```

Sets: *_SourceFiles (items), NuSpecFile (item), NuspecFile (property)*
      
**`PublishNuGetLocal`** target - pushes the project output package to local NuGet feed
```
AfterTargets="Pack"
DependsOnTargets="GenerateNuSpecFile"
Condition="'$(IsPackable)' == 'true' AND '$(PushPackagesToLocalFeed)' == 'true'"
```      
Local NuGet feed source name (directory) is identified by *$(NuGetLocalFeedSourceName)*

**`PublishNuGetVsts`** target - pushes the project output package to VSTS (Azure DevOps) NuGet feed
```
AfterTargets="Pack"
DependsOnTargets="GenerateNuSpecFile"
Condition="'$(IsPackable)' == 'true' AND '$(PushPackagesToVstsFeed)' == 'true'"
```      

VSTS NuGet feed source name is identified by $*(NuGetVstsFeedSourceName)* - the NuGet source must be defined in advance. Also set the credentials in advance: `nuget sources update -Name "<source_name>" -username "<user_name>" -password "<password>"`

#### NuGetSourceOnly.targets ####
Run before `Pack` target
```xml
<PackDependsOn>GeneratePartNuSpecFilesForSourceOnly; GenerateSourceOnlyPackages; PublishSourceOnlyNuGetLocal; $(PackDependsOn)</PackDependsOn>
```
**`GeneratePartNuSpecFilesForSourceOnly`** target - generates the `.partnuspec` files for source files containing valid `<NuProp.Id>` XML Documentation Comment 
```
Condition="'$(IsPackable)' == 'true'"
```      
This is used to generate the source-only packages. This target prepares partial NuSpec files for the individual source-only packages. The partial NuSpec files are subject of file versioning (git)
      
Sets: *_SourceFilesForSourceOnlyPackages (items)*
      
**`GenerateSourceOnlyPackages`** target - generates the source-only packages 
```
Condition="'$(IsPackable)' == 'true'"
```      
This is used to generate the source-only packages. This target gets the partial NuSpec files for the individual source-only packages, enriches them with solution wide properties (author, copyright, ...) and generates the NuGet  packages into `.artifacts` directory in project root (the directory is cleaned up before).
The temporary NuSpec files used to build the packages are deleted after processing. Artifacts directory should be git ignored.

Sets: *_PartNuspecFiles (items), _TmpNuspecFiles (items)*
      
**`PublishSourceOnlyNuGetLocal`** target - pushes the source-only packages to local NuGet feed
```
Condition="'$(IsPackable)' == 'true' AND '$(PushPackagesToLocalFeed)' == 'true'"
```      
Local NuGet feed source name (directory) is identified by *$(NuGetLocalFeedSourceName)*
      
Sets: *_NuGetLocalFeedPushSource (items)*

#### Master.Build.targets ####
**`CleanFull`** target - cleans out/<configuration> and bin/<configuration> directories
```
AfterTargets="Clean"
```
**`SetVersionProperties`** target - sets proper version infomation from Version.props to other relevant properties used by SDK.
```
BeforeTargets="BeforeCompile"
```

The Version.props is updated once per (solution)build via build project at the beginning (the build project has to be set as a build dependency and be the first in the order)
      
Sets: *Version, AssemblyVersion, FileVersion, AssemblyFileVersion, PackageVersion, AssemblyInformationalVersion, InformationalVersion*

**`GenerateMarkupDoc`** target - generates code documentation
```
AfterTargets="Build"
Condition="'$(MarkupDocGenerate)'=='true'"
```      
The output target and MS API Local dir is set here, for the other params, use `markupdoc.json` placed in the project directory.
 
**`DumpPropertiesTarget`** - dumps the build properties if needed
```
AfterTargets="Build"
Condition="'$(DumpPropertiesOnBuild)'=='true'" 
```

## build.tasks project ##
The `build.tasks` project defines the custom developed build tasks. By default, the customized build process uses the source files and executes them using the RoslynCodeTaskFactory as inline task. This allows the "immediate" changes in the custom tasks when needed without the need to rebuild the dll.   
```xml
<UsingTask TaskName="GenerateNuSpecFileTask" AssemblyFile="..\..\..\build.tasks\bin\debug\netstandard2.0\build.tasks.dll" Condition="'$(DebugTasks)'=='true'" />
 
<UsingTask
	TaskName="GenerateNuSpecFileTask"
	TaskFactory="RoslynCodeTaskFactory"
	AssemblyFile="$(MSBuildToolsPath)\Microsoft.Build.Tasks.Core.dll"
	Condition="'$(DebugTasks)'!='true'">
	...
	<Task>
		<Code Type="Class" Language="cs" Source="$(MSBuildProjectDirectory)/../build.tasks/GenerateNuSpecFileTask.cs" />
	</Task>
</UsingTask>
```
When the `DebugTasks` property is set to `true`, it will use the binary dll instead, so the tasks can be debugged.The `Execute` method of the task checks the `DebugTask` parameter (assigned from the property) and if true, it will display the process ID in the build console output and will wait until the debugger is attached.

```csharp
if (DebugTasks)
{
	//Wait for debugger
	Log.LogMessage(MessageImportance.High,
		$"Debugging task {GetType().Name}, set the breakpoint and attach debugger to process with PID = {System.Diagnostics.Process.GetCurrentProcess().Id}");

	while (!System.Diagnostics.Debugger.IsAttached)
	{
		Thread.Sleep(1000);
	}
}
```
Just make sure, that the `build.tasks` project is (re)build before using it in debug mode (there should be no build dependencies related to the `build.tasks` project). There is empty project's `Directory.Build.targets` file [#32] to prevent using the solution based Directory.Build.targets (the customized build is not to be used for the `build.tasks`)

