using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Linq;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace build.tasks.sourceOnlyPackage
{
    /// <summary>
    /// <see cref="ProcessNuPropsTask"/> generates the partial NuSpec files (.partnuspec) for source-only packages
    /// </summary>
    public class ProcessNuPropsTask : Task
    {
        /// <summary>
        /// All source files of compilation
        /// </summary>
        [Required]
        public ITaskItem[] SourceFiles { get; set; }
        /// <summary>
        /// Flag whether to debug the task
        /// </summary>
        public bool DebugTasks { get; set; }

        /// <summary>
        /// Executes the task
        /// </summary>
        /// <remarks>
        /// Goes through all <see cref="SourceFiles"/> and generates the partial NuSpec files for source-only packages
        /// <para>The method checks all source files whether is does contain any NuProp tags in XML Documentation comments.
        /// It get's the first <c>NuProp.Id</c>, <c>NuProp.Version</c>, <c>NuProp.Description</c>, <c>NuProp.Tags</c> and all <c>NuProp.Using</c>  tags
        /// and builds the partial NuSpec file (with additional extension ".partnuspec") using these values.
        ///</para>
        /// <para>Note: the XML documentation comments indicator "///" is hardcoded.</para>
        ///<para>NuProp XML documentation comments:</para>
        /// <list type="bullet">
        ///<item>< term>&lt;NuProp.Id&gt;&lt;/NuProp.Id&gt;</term><description>package ID (mandatory)</description></item> 
        ///<item>< term>&lt;NuProp.Version&gt;&lt;/NuProp.Version&gt;</term><description>package version base (major.minor.patch) - optional</description></item>     
        ///<item>< term>&lt;NuProp.Description&gt;&lt;/NuProp.Description&gt;</term><description>package description (optional)</description></item>     
        ///<item>< term>&lt;NuProp.Tags&gt;&lt;/NuProp.Tags&gt;</term><description>package tags (optional)</description></item> 
        ///<item>< term>&lt;NuProp.Using id = "" version=""/&gt;</term><description>package imports (optional). Version is optional</description></item>     
        ///<item>< term>&lt;NuProp.Needs id="" /&gt;</term><description>"external" imports needed (optional) - not included in package, just info when consuming!!!</description></item>     
        /// </list>
        /// </remarks>
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

            if (SourceFiles == null)
            {
                Log.LogMessage("No source code available");
                return true; //nothing to process
            }

            //process the source files
            var anyPackageAvailable = false;
            foreach (var sourceFile in SourceFiles)
            {
                var fileNameFull = sourceFile.GetMetadata("FullPath");
                var fileName = new FileInfo(fileNameFull).Name;

                //Get the NuProps from XML Documentation Comments <NuProp.xxxx>
                var sourceContent = File.ReadAllText(fileNameFull);
                var sourceLines = sourceContent.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                //Extract all comments
                var stringBuilder = new StringBuilder();
                foreach (var contentLine in sourceLines)
                {
                    var sourceLine = contentLine.Trim();
                    if (sourceLine.StartsWith("///"))
                    {
                        stringBuilder.AppendLine(sourceLine.Substring(3));
                    }
                }

                //Get all comments in single XML - encapsulate the whole bunch with dummy tag "doc" allowing the XDocument to parse it
                var xDocument = XDocument.Parse("<doc>" + stringBuilder + "</doc>");
                //Get NuProp comments
                var nuPropElements = xDocument.Descendants()
                    .Where(n => n is XElement e && e.Name.LocalName.StartsWith("NuProp.")).ToList();

                if (nuPropElements.Count <= 0) continue; //no NuProps - continue with the next file

                //Has some NuProp -> process
                //<NuProp.Id></NuProp.Id> - package ID (mandatory)
                //<NuProp.Version></NuProp.Version>   - package version base (major.minor.patch) - optional          
                //<NuProp.Description></NuProp.Description> - package description (optional)
                //<NuProp.Tags></NuProp.Tags> - package tags (optional)
                //<NuProp.Using id = "" version=""/> - package imports (optional). Version is optional
                //<NuProp.Needs id="" /> - "external" imports needed (optional) - not included in package, just info when consuming!!!

                var nuPropId = nuPropElements.FirstOrDefault(e => e.Name.LocalName == "NuProp.Id")?.Value.Trim();
                var nuPropVersion = nuPropElements.FirstOrDefault(e => e.Name.LocalName == "NuProp.Version")?.Value.Trim();
                var nuPropDescription = nuPropElements.FirstOrDefault(e => e.Name.LocalName == "NuProp.Description")?.Value.Trim();
                var nuPropTags = nuPropElements.FirstOrDefault(e => e.Name.LocalName == "NuProp.Tags")?.Value.Trim();

                var nuPropsIncludes = IncludesEnum.None;
                var nuPropIncludesStr = nuPropElements
                    .FirstOrDefault(e => e.Name.LocalName == "NuProp.Includes" && e.Attribute("type")?.Value != null)?
                    .Attribute("type")?.Value;
                // ReSharper disable once SwitchStatementMissingSomeCases
                switch (nuPropIncludesStr)
                {
                    case "Folder": nuPropsIncludes = IncludesEnum.Folder; break;
                    case "FolderRecursive": nuPropsIncludes = IncludesEnum.FolderRecursive; break;
                }

                var nuPropUsings = nuPropElements.Where(e => e.Name.LocalName == "NuProp.Using" && e.Attribute("id")?.Value != null).ToList();

                if (string.IsNullOrEmpty(nuPropId))
                {
                    Log.LogWarning($"NuProp.Id not found for {fileName}");
                    continue;
                }

                //Build the partial NuSpec file
                anyPackageAvailable = true;
                var ns = XNamespace.Get("http://schemas.microsoft.com/packaging/2013/05/nuspec.xsd");
                var outFile = fileNameFull + ".partnuspec";
                var outXDoc = File.Exists(outFile) ? XDocument.Load(outFile) : new XDocument();
                var outXDocStrOriginal = outXDoc.ToString();
                var packageXElement = GetOrCreateElement(outXDoc, "package", ns);
                var metadataXElement = GetOrCreateElement(packageXElement, "metadata", ns);

                SetOrCreateElement(metadataXElement, "id", ns, nuPropId);
                SetOrCreateElement(metadataXElement, "version", ns, nuPropVersion, false); //don't create if the nuPropVersion is empty/not set
                SetOrCreateElement(metadataXElement, "description", ns, nuPropDescription, false); //don't create if the nuPropDescription is empty/not set
                SetOrCreateElement(metadataXElement, "tags", ns, nuPropTags, false); //don't create if the nuPropTags is empty/not set

                GetEmptyOrCreateElement(metadataXElement, "contentFiles", ns)
                    .Add(new XElement(ns + "files", //<files include="cs/**/*.*" buildAction="Compile" />
                        new XAttribute("include", "cs/**/*.*"),
                        new XAttribute("buildAction", "Compile")));


                //Dependencies
                var dependenciesXElement = GetEmptyOrCreateElement(metadataXElement, "dependencies", ns);
                if (nuPropUsings.Count > 0)
                {
                    //have some dependencies
                    foreach (var nuPropUsing in nuPropUsings)
                    {
                        // ReSharper disable once PossibleNullReferenceException - should not be null based on Where clause for nuPropUsings
                        var depId = nuPropUsing.Attribute("id").Value;
                        var depVersion = nuPropUsing.Attribute("version")?.Value;
                        var dependencyXElement = new XElement(ns + "dependency", new XAttribute("id", depId), new XAttribute("include", "all"));
                        if (string.IsNullOrEmpty(depVersion)) depVersion = "%%CURRENT_VERSION%%";
                        dependencyXElement.Add(new XAttribute("version", depVersion));
                        dependenciesXElement.Add(dependencyXElement);
                    }
                }
                else
                {
                    //Clean dependencies
                    dependenciesXElement.Remove();
                }

                //<files>
                //    < file src = "src.cs" target = "content\App_Packages\pkg_id\src.cs" />
                //    < file src = "src.cs" target = "contentFiles\cs\any\App_Packages\pkg_id\src.cs" />
                //</ files >
                var files = GetEmptyOrCreateElement(packageXElement, "files", ns);
                files.Add(
                    new XElement(ns + "file", new XAttribute("src", fileName),
                        new XAttribute("target", $"content\\App_Packages\\{nuPropId}\\{fileName}")),
                    new XElement(ns + "file", new XAttribute("src", fileName),
                        new XAttribute("target", $"contentFiles\\cs\\any\\App_Packages\\{nuPropId}\\{fileName}")));

                if (nuPropsIncludes != IncludesEnum.None)
                {
                    var mainItemDir = sourceFile.GetMetadata("RootDir") + sourceFile.GetMetadata("Directory");
                    Log.LogMessage($"MainItemDir:{mainItemDir}");
                    IEnumerable<ITaskItem> itemsToAdd;
                    switch (nuPropsIncludes)
                    {
                        case IncludesEnum.Folder:
                            itemsToAdd = SourceFiles.Where(itm =>
                                itm.GetMetadata("RootDir") + itm.GetMetadata("Directory") == mainItemDir &&
                                itm.GetMetadata("FullPath") != fileNameFull);
                            break;
                        case IncludesEnum.FolderRecursive:
                            itemsToAdd = SourceFiles.Where(itm =>
                                (itm.GetMetadata("RootDir") + itm.GetMetadata("Directory")).StartsWith(mainItemDir) &&
                                itm.GetMetadata("FullPath") != fileNameFull);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    foreach (var item in itemsToAdd)
                    {
                        var itemFileFull = item.GetMetadata("FullPath");
                        Log.LogMessage($"itemFileFull:{itemFileFull}");
                        var itemFileRel = itemFileFull.Substring(mainItemDir.Length);
                        files.Add(
                            new XElement(ns + "file", new XAttribute("src", itemFileRel),
                                new XAttribute("target", $"content\\App_Packages\\{nuPropId}\\{itemFileRel}")),
                            new XElement(ns + "file", new XAttribute("src", itemFileRel),
                                new XAttribute("target", $"contentFiles\\cs\\any\\App_Packages\\{nuPropId}\\{itemFileRel}")));
                    }
                }

                var outXDocStrNew = outXDoc.ToString();
                if (outXDocStrNew == outXDocStrOriginal) continue;

                //change - > save
                File.WriteAllText(outFile, outXDocStrNew);
                Log.LogMessage($"Generated/updated {outFile}");
            }

            if (!anyPackageAvailable)
            {
                Log.LogMessage("No source-only packages found");
            }
            return true;
        }


        /// <summary>
        /// Sets the element value. The element is created first when doesn't exist 
        /// </summary>
        /// <param name="container">Element's container (parent)</param>
        /// <param name="name">Name of the element (tag)</param>
        /// <param name="ns">Namespace info</param>
        /// <param name="value">Value to be set</param>
        /// <param name="evenIfEmptyValue">Flag whether  the element should be set/updated when the <paramref name="value"/> is empty</param>
        /// <returns>Element or null when the element has not been set (while <paramref name="evenIfEmptyValue"/> is true and <paramref name="value"/> is empty</returns>
        // ReSharper disable once UnusedMethodReturnValue.Local
        private static XElement SetOrCreateElement(XContainer container, string name, XNamespace ns, string value, bool evenIfEmptyValue = true)
        {
            if (string.IsNullOrEmpty(value) && !evenIfEmptyValue) return null;
            var element = GetOrCreateElement(container, name, ns);
            element.SetValue(value ?? "");
            return element;
        }

        /// <summary>
        /// Get the element. The element is created first when doesn't exist 
        /// </summary>
        /// <param name="container">Element's container (parent)</param>
        /// <param name="name">Name of the element (tag)</param>
        /// <param name="ns">Namespace info</param>
        /// <returns>Element</returns>
        private static XElement GetOrCreateElement(XContainer container, string name, XNamespace ns)
        {
            var element = container.Element(ns + name);
            if (element != null) return element;

            element = new XElement(ns + name);
            container.Add(element);
            return element;
        }

        /// <summary>
        /// Get the empty element. Element's children (descendants) are removed. The element is created first when doesn't exist. 
        /// </summary>
        /// <param name="container">Element's container (parent)</param>
        /// <param name="name">Name of the element (tag)</param>
        /// <param name="ns">Namespace info</param>
        /// <returns>Element</returns>
        private static XElement GetEmptyOrCreateElement(XContainer container, string name, XNamespace ns)
        {
            var element = GetOrCreateElement(container, name, ns);
            element.Descendants().Remove();
            return element;
        }

        /// <summary>
        /// Flag whether to include other files to package
        /// </summary>
        private enum IncludesEnum
        {
            /// <summary>
            /// Don't include
            /// </summary>
            None,
            /// <summary>
            /// Include the files in the same folder
            /// </summary>
            Folder,
            /// <summary>
            /// Include the files in the same folder and all subfolders
            /// </summary>
            FolderRecursive
        }
    }
}
