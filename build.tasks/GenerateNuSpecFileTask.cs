using System.Collections.Generic;
using System.IO;
using System.Threading;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace build.tasks
{
    /// <summary>
    /// <see cref="GenerateNuSpecFileTask"/> generates the NuSpec file for project assembly output
    /// </summary>
    public class GenerateNuSpecFileTask : Task
    {
        /// <summary>
        /// Current build configuration (Debug, Release) - use $(Configuration) to fill it in by default
        /// </summary>
        [Required]
        public string Configuration { get; set; }

        /// <summary>
        /// Project name - use $(MSBuildProjectName) to fill it in by default
        /// </summary>
        [Required]
        public string ProjectName { get; set; }

        /// <summary>
        /// Project directory - use $(MSBuildProjectDirectory) to fill it in by default
        /// </summary>
        [Required]
        public string ProjectDirectory { get; set; }

        /// <summary>
        /// The intermediate output path. For example, \obj\debug\. - use $(BaseIntermediateOutputPath) to fill it in by default
        /// </summary>
        [Required]
        public string IntermediateOutputPath { get; set; }

        /// <summary>
        /// Specifies the path to the output directory, relative to the project directory, for example, bin\Debug. - use $(OutputPath) to fill it in by default
        /// </summary>
        [Required]
        public string OutputPath { get; set; }

        /// <summary>
        /// The name of the final output assembly after the project is built. - use $(AssemblyName) to fill it in by default
        /// </summary>
        [Required]
        public string AssemblyName { get; set; }

        /// <summary>
        /// Unique Package ID
        /// </summary>
        [Required]
        public string PackageId { get; set; }

        /// <summary>
        ///  Package title. <see cref="PackageId"/> will be used if not provided
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Full package version
        /// </summary>
        [Required]
        public string PackageVersionFull { get; set; }

        /// <summary>
        /// Short package version (can be used in file name)
        /// </summary>
        [Required]
        public string PackageVersionShort { get; set; }

        /// <summary>
        /// Package authors
        /// </summary>
        public string Authors { get; set; }

        /// <summary>
        /// Flag whether the package requires the license acceptance
        /// </summary>
        public string PackageRequireLicenseAcceptance { get; set; }

        /// <summary>
        /// URL to package license
        /// </summary>
        public string PackageLicenseUrl { get; set; }
        
        /// <summary>
        /// Package license type
        /// </summary>
        public string PackageLicense { get; set; }
        
        /// <summary>
        /// URL to package project
        /// </summary>
        public string PackageProjectUrl { get; set; }

        /// <summary>
        /// URL to package icon
        /// </summary>
        public string PackageIconUrl { get; set; }

        /// <summary>
        /// Package copyright info
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Package release notes
        /// </summary>
        public string PackageReleaseNotes { get; set; }

        /// <summary>
        /// Package copyright info
        /// </summary>
        public string Copyright { get; set; }

        /// <summary>
        /// Package tags split by space
        /// </summary>
        public string PackageTags { get; set; }

        /// <summary>
        /// URL of package git repository
        /// </summary>
        public string RepositoryUrl { get; set; }

        /// <summary>
        /// Name of  the current git branch
        /// </summary>
        public string GitBranch { get; set; }

        /// <summary>
        /// Short SHA of current git commit. May include "-dirty" suffix
        /// </summary>
        public string GitCommit { get; set; }

        /// <summary>
        /// Build target framework
        /// </summary>
        [Required]
        public string TargetFramework { get; set; }

        /// <summary>
        /// Package source files (target outputs)
        /// </summary>
        public ITaskItem[] SourceFiles { get; set; }

        /// <summary>
        /// Project package references (default MS build item @(PackageReference))
        /// </summary>
        public ITaskItem[] PackageReferences { get; set; }

        /// <summary>
        /// Project references to other projects (default MS build item @(ProjectReference))
        /// </summary>
        public ITaskItem[] ProjectReferences { get; set; }

        /// <summary>
        /// References that are marked as "CopyLocal" and their dependencies, including .pdbs, .xmls and satellites (default MS build item @(ReferenceCopyLocalPaths))
        /// </summary>
        public ITaskItem[] ReferenceCopyLocalPaths { get; set; }

        /// <summary>
        /// Full path to generated NuSpec file
        /// </summary>
        [Output]
        public string NuSpecFile { get; set; }

        /// <summary>
        /// Flag whether to debug the task
        /// </summary>
        public bool DebugTasks { get; set; }

        /// <summary>
        /// Executes the task - generates the NuSpec file based on the input parameters
        /// </summary>
        /// <returns>True</returns>
        public override bool Execute()
        {
            if (DebugTasks)
            {
                //Wait for debugger
                Log.LogMessage(
                    MessageImportance.High,
                    $"Debugging task {GetType().Name}, set the breakpoint and attach debugger to process with PID = {System.Diagnostics.Process.GetCurrentProcess().Id}");

                while (!System.Diagnostics.Debugger.IsAttached)
                {
                    Thread.Sleep(1000);
                }
            }

            var title = !string.IsNullOrEmpty(Title) ? Title : PackageId;

            var sb = new System.Text.StringBuilder(); //TODO refactor to LINQ XML
            sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            sb.AppendLine($"<package xmlns=\"http://schemas.microsoft.com/packaging/2013/05/nuspec.xsd\">");
            sb.AppendLine($" <metadata>");
            sb.AppendLine($"  <id>{PackageId}</id>");
            sb.AppendLine($"  <version>{PackageVersionFull}</version>");
            sb.AppendLine($"  <authors>{Authors}</authors>");
            sb.AppendLine($"  <title>{title}</title>");
            sb.AppendLine($"  <owners>{Authors}</owners>");
            sb.AppendLine($"  <requireLicenseAcceptance>{PackageRequireLicenseAcceptance}</requireLicenseAcceptance>");
            // ReSharper disable once ConvertIfStatementToConditionalTernaryExpression
            if (!string.IsNullOrEmpty(PackageLicense))
            {
                sb.AppendLine($"  <license type=\"expression\">{PackageLicense}</license>");
            }
            else
            {
                sb.AppendLine($"  <licenseUrl>{PackageLicenseUrl}</licenseUrl>");
            }
            sb.AppendLine($"  <projectUrl>{PackageProjectUrl}</projectUrl>");
            sb.AppendLine($"  <iconUrl>{PackageIconUrl}</iconUrl>");
            sb.AppendLine($"  <description>{Description}</description>");
            sb.AppendLine($"  <releaseNotes>{PackageReleaseNotes}</releaseNotes>");
            sb.AppendLine($"  <copyright>{Copyright}</copyright>");
            sb.AppendLine($"  <tags>{PackageTags}</tags>");
            sb.AppendLine(
                $"  <repository url=\"{RepositoryUrl}\" type=\"git\" branch=\"{GitBranch}\" commit=\"{GitCommit}\" />");
            sb.AppendLine($"  <dependencies>");
            sb.AppendLine($"   <group targetFramework=\"{TargetFramework}\">");

            if (PackageReferences != null)
            {
                foreach (var r in PackageReferences)
                {
                    var item = r.ItemSpec;
                    if (item != "NETStandard.Library")
                        sb.AppendLine(
                            $"    <dependency id=\"{r.ItemSpec}\" version=\"{r.GetMetadata("Version")}\" exclude=\"Build,Analyzers\" />");
                }
            }

            var resolvedProjectReferences =
                new List<string>(); //project references that has been resolved as NuGet packages
            if (ProjectReferences != null)
            {
                foreach (var src in ProjectReferences)
                {
                    var refPackageDependencyFile = Path.Combine(src.GetMetadata("RelativeDir"), IntermediateOutputPath,
                        Configuration, "package_dependency.txt");
                    if (!File.Exists(refPackageDependencyFile)) continue;

                    var refPackageDependency = File.ReadAllText(refPackageDependencyFile);

                    resolvedProjectReferences.Add(refPackageDependency);
                    sb.AppendLine(refPackageDependency);
                }
            }

            sb.AppendLine($"   </group>");
            sb.AppendLine($"  </dependencies>");
            sb.AppendLine($" </metadata>");

            sb.AppendLine($"  <files>");
            var dllFile = Path.Combine(ProjectDirectory, OutputPath, $"{AssemblyName}.dll");
            sb.AppendLine($@"    <file src=""{dllFile}"" target=""lib\{TargetFramework}\{AssemblyName}.dll"" />");

            var pdbFile = Path.Combine(ProjectDirectory, OutputPath, $"{AssemblyName}.pdb");
            if (File.Exists(pdbFile))
            {
                sb.AppendLine($@"    <file src=""{pdbFile}"" target=""lib\{TargetFramework}\{AssemblyName}.pdb"" />");
            }

            var xmlDocFile = Path.Combine(ProjectDirectory, OutputPath, $"{AssemblyName}.xml");
            if (File.Exists(xmlDocFile))
            {
                sb.AppendLine(
                    $@"    <file src=""{xmlDocFile}"" target=""lib\{TargetFramework}\{AssemblyName}.xml"" />");
            }

            if (SourceFiles != null && Configuration.ToLower() != "release")
            {
                sb.AppendLine("");

                foreach (var src in SourceFiles)
                {
                    var srcFileOriginal = src.GetMetadata("OriginalItemSpec");
                    var srcFileRel = srcFileOriginal.Replace($@"{ProjectDirectory}\", "");
                    if (Path.IsPathRooted(srcFileRel)) continue; //not a project file (probably source-only package) - project files have the relative path in srcFileRel, non project files have full path in srcFileRel 

                    var targetFile = Path.Combine("src", ProjectName, srcFileRel);
                    sb.AppendLine($@"    <file src=""{src}"" target=""{targetFile}"" />");
                }
            }

            //include project references that has NOT been resolved as NuGet packages
            if (ProjectReferences != null && ReferenceCopyLocalPaths != null)
            {
                foreach (var rf in ReferenceCopyLocalPaths)
                {
                    if (rf.GetMetadata("ReferenceSourceTarget") == "ProjectReference")
                    {
                        var fileName = rf.GetMetadata("FileName");
                        if (!resolvedProjectReferences.Exists(s => s.Contains($"id=\"{fileName}\"")))
                        {
                            sb.AppendLine(
                                $@"    <file src=""{rf.GetMetadata("FullPath")}"" target=""lib\{TargetFramework}\{rf.GetMetadata("FileName")}{rf.GetMetadata("Extension")}"" />");
                        }
                    }
                }
            }

            sb.AppendLine($"  </files>");

            sb.AppendLine($"</package>  ");

            //Write NuSpec file to /obj directory
            NuSpecFile = Path.Combine(ProjectDirectory, IntermediateOutputPath, Configuration,
                PackageVersionShort + ".nuspec");
            File.WriteAllText(NuSpecFile, sb.ToString());

            Log.LogMessage(sb.ToString());

            //Create dependency file for package in /obj directory
            var dep =
                $@"<dependency id=""{PackageId}"" version=""{PackageVersionFull}"" exclude=""Build,Analyzers"" />";
            var dependencyFile = Path.Combine(ProjectDirectory, IntermediateOutputPath, Configuration,
                "package_dependency.txt");
            File.WriteAllText(dependencyFile, dep);

            return true;
        }
    }
}
