using System.IO;
using System.Linq;
using System.Threading;
using System.Xml.Linq;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace build.tasks
{
    /// <summary>
    /// <see cref="SetVersionInfoTask"/> initializes the build number and package version
    /// </summary>
    public class SetVersionInfoTask : Task
    {
        /// <summary>
        /// Path to the version.props file
        /// </summary>
        [Required]
        public string VersionFile { get; set; }
        /// <summary>
        /// Current build configuration (Debug, Release) - use $(Configuration) to fill it in by default
        /// </summary>
        [Required]
        public string Configuration { get; set; }
        /// <summary>
        /// Major version part
        /// </summary>
        [Required]
        public int Major { get; set; }
        /// <summary>
        /// Minor version part
        /// </summary>
        [Required]
        public int Minor { get; set; }
        /// <summary>
        /// Patch version part
        /// </summary>
        [Required]
        public int Patch { get; set; }
        /// <summary>
        /// Build number
        /// </summary>
        [Required]
        [Output]
        public int BuildNumber { get; set; }

        /// <summary>
        /// Short SHA of current git commit. May include "-dirty" suffix
        /// </summary>
        [Required]
        public string GitCommit { get; set; }
        /// <summary>
        /// Name of  the current git branch
        /// </summary>
        [Required]
        public string GitBranch { get; set; }
        /// <summary>
        /// Current git commit sequential number
        /// </summary>
        [Required]
        public string GitCommits { get; set; }

        /// <summary>
        /// Short package version (can be used in file name)
        /// </summary>
        [Output]
        public string PackageVersionShort { get; set; }
        /// <summary>
        /// Full package version
        /// </summary>
        [Output]
        public string PackageVersionFull { get; set; }

        /// <summary>
        /// Flag whether to debug the task
        /// </summary>
        public bool DebugTasks { get; set; }

        /// <summary>
        /// Executes the task - initialize the build number and package version.
        /// Build number is increased and the updated package version information is stored back to version.props file
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

            //increase the build number
            BuildNumber = BuildNumber + 1;

            //process the package version
            var ver = $"{Major}.{Minor}.{Patch}";

            var dt = System.DateTime.Now.ToString("yyMMddHHmmss");

            if (Configuration.ToLower() != "release")
            {
                PackageVersionShort = $"{ver}-dev.{BuildNumber}.{dt}";
                PackageVersionFull = $"{PackageVersionShort}+{GitCommits}.{GitBranch}.{GitCommit}";
            }
            else
            {
                PackageVersionShort = ver;
                PackageVersionFull = $"{PackageVersionShort}+{BuildNumber}.{dt}.{GitBranch}.{GitCommit}";
            }

            //update version file
            var document = XDocument.Load(VersionFile);
            var projectNode = GetOrCreateElement(document, "Project");

            SetProjectPropertyNode(projectNode, "RadBuild", BuildNumber.ToString());
            SetProjectPropertyNode(projectNode, "PackageVersionShort", PackageVersionShort);
            SetProjectPropertyNode(projectNode, "PackageVersionFull", PackageVersionFull);
            SetProjectPropertyNode(projectNode, "GitCommit", GitCommit);
            SetProjectPropertyNode(projectNode, "GitBranch", GitBranch);

            File.WriteAllText(VersionFile, document.ToString());

            Log.LogMessage($@"Updated version file: version {Major}.{Minor}.{Patch}, package: {PackageVersionFull}, build #{BuildNumber} to {VersionFile}");

            return true;
        }

        private static void SetProjectPropertyNode(XContainer projectNode, string nodeName, string nodeValue)
        {
            var propertyNode = projectNode
                .Elements("PropertyGroup")
                .SelectMany(it => it.Elements(nodeName))
                .SingleOrDefault();
            // If no  node exists, create it.
            if (propertyNode == null)
            {
                var propertyGroupNode = GetOrCreateElement(projectNode, "PropertyGroup");
                propertyNode = GetOrCreateElement(propertyGroupNode, nodeName);
            }
            propertyNode.SetValue(nodeValue);
        }
        private static XElement GetOrCreateElement(XContainer container, string name)
        {
            var element = container.Element(name);
            if (element != null) return element;

            element = new XElement(name);
            container.Add(element);
            return element;
        }
    }
}