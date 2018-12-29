using System;
using System.IO;
using System.Threading;
using System.Xml.Linq;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace build.tasks.sourceOnlyPackage
{
    /// <summary>
    /// <see cref="GenerateSourceOnlyPackageNuspecsTask"/> generates the temporary NuSpec files for source-only packages
    /// </summary>
    public class GenerateSourceOnlyPackageNuspecsTask : Task
    {
        /// <summary>
        /// Full package version
        /// </summary>
        [Required]
        public string PackageVersionFull { get; set; }
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
        public string Copyright { get; set; }
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
        /// .partnuspec files to generate the packages for
        /// </summary>
        [Required]
        public ITaskItem[] PartNuspecFiles { get; set; }
        /// <summary>
        /// Flag whether to debug task
        /// </summary>
        public bool DebugTasks { get; set; }

        /// <summary>
        /// Executes the task
        /// </summary>
        /// <remarks>
        /// Goes through all <see cref="PartNuspecFiles"/> and generates the temporary NuSpec files for source-only packages
        /// <para>The method get the partial NuSpec file, enriches it with data from parameters (properties) and saves the result to
        /// temporary NuSpec file (with additional extension ".tmp.nuspec"</para>
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

            if (PartNuspecFiles == null)
            {
                Log.LogMessage("No source-only packages found");
                return true; //nothing to process
            }

            //process the source files
            foreach (var sourceFile in PartNuspecFiles)
            {
                var partNuspecFileNameFull = sourceFile.GetMetadata("FullPath");

                //Get the partial (partnuspec) file
                var ns = XNamespace.Get("http://schemas.microsoft.com/packaging/2013/05/nuspec.xsd");
                var outFile = partNuspecFileNameFull + ".tmp.nuspec";
                Log.LogMessage($"Loading {partNuspecFileNameFull}");
                var partNuspecFileContent = File.ReadAllText(partNuspecFileNameFull);
                partNuspecFileContent = partNuspecFileContent.Replace("%%CURRENT_VERSION%%", PackageVersionFull);
                var outXDoc = XDocument.Parse(partNuspecFileContent);
                var packageXElement = GetOrCreateElement(outXDoc, "package", ns);
                var metadataXElement = GetOrCreateElement(packageXElement, "metadata", ns);

                //Check package ID
                var packageId = metadataXElement.Element(ns + "id")?.Value;
                if (packageId == null) throw new Exception($"Can't find the package ID for {partNuspecFileNameFull}");

                //Process version - global version from solution of base version from partial file
                var versionOriginal = GetOrCreateElement(metadataXElement, "version", ns)?.Value;
                var version = PackageVersionFull;
                if (!string.IsNullOrEmpty(versionOriginal))
                {
                    //base version set in NuProp
                    //get ext version from PackageVersionFull
                    //0.1.0-dev.441.181206212308+53.master.37f08fc-dirty
                    //0.1.0+442.181206212418.master.37f08fc-dirty
                    var idx = 0;
                    while (char.IsDigit(PackageVersionFull[idx]) || PackageVersionFull[idx] == '.')
                    {
                        idx++;
                    }

                    version = versionOriginal + PackageVersionFull.Substring(idx);
                }

                //Enrich the NuSpec
                SetOrCreateElement(metadataXElement, "version", ns, version);
                SetOrCreateElement(metadataXElement, "authors", ns, Authors);
                SetOrCreateElement(metadataXElement, "title", ns, packageId);
                SetOrCreateElement(metadataXElement, "owners", ns, Authors);
                SetOrCreateElement(metadataXElement, "description", ns, $"Source only package {packageId}", false); //don't override if exists
                SetOrCreateElement(metadataXElement, "requireLicenseAcceptance", ns, PackageRequireLicenseAcceptance);
                if (!string.IsNullOrEmpty(PackageLicense))
                {
                    SetOrCreateElement(metadataXElement, "license", ns, PackageLicense).
                        Add(new XAttribute("type","expression"));
                }
                else
                {
                    SetOrCreateElement(metadataXElement, "licenseUrl", ns, PackageLicenseUrl);
                }
                SetOrCreateElement(metadataXElement, "projectUrl", ns, PackageProjectUrl);
                SetOrCreateElement(metadataXElement, "iconUrl", ns, PackageIconUrl);
                SetOrCreateElement(metadataXElement, "copyright", ns, Copyright);
                SetOrCreateElement(metadataXElement, "developmentDependency", ns, "true");
                GetEmptyOrCreateElement(metadataXElement, "repository", ns).
                                    Add(new XAttribute("url", RepositoryUrl),
                                        new XAttribute("type", "git"),
                                        new XAttribute("branch", GitBranch),
                                        new XAttribute("commit", GitCommit));

                //Save the temporary NuSpec file
                var outXDocStr = outXDoc.ToString();
                File.WriteAllText(outFile, outXDocStr);
                Log.LogMessage($"Generated source only nuspec file {outFile}");
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
        /// <param name="canOverride">Flag whether  the existing value can be overriden when exist (if false, the new value will not be set)</param>
        /// <returns>Element</returns>
        // ReSharper disable once UnusedMethodReturnValue.Local
        private static XElement SetOrCreateElement(XContainer container, string name, XNamespace ns, string value, bool canOverride = true)
        {
            if (string.IsNullOrEmpty(value)) return null;
            var element = GetOrCreateElement(container, name, ns);
            if (element.IsEmpty || canOverride)
                element.SetValue(value);
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
    }
}
