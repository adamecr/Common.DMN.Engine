using System.Linq;
using System.Reflection;
using System.Threading;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using Microsoft.Build.Execution;

namespace build.tasks
{
    /// <summary>
    /// <see cref="DumpPropertiesTask"/> prints the full set of build properties and their values into the build oupupt
    /// </summary>
    public class DumpPropertiesTask : Task
    {
        /// <summary>
        /// Flag whether to debug the task
        /// </summary>
        public bool DebugTasks { get; set; }

        /// <summary>
        /// Executes the task - gets all build properties from <see cref="IBuildEngine"/> (using the reflection as the access to information is not public)
        /// and dump project build global and project properties to build output.
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

            //Get to the ProjectInstance
            var requestEntryField = BuildEngine.GetType().GetField("_requestEntry", BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.Instance);
            var requestEntry = requestEntryField?.GetValue(BuildEngine);

            var requestConfigurationProperty = requestEntry?.GetType().GetProperty("RequestConfiguration", BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.Instance);
            var requestConfiguration = requestConfigurationProperty?.GetValue(requestEntry);

            var projectProperty = requestConfiguration?.GetType().GetProperty("Project", BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.Instance);
            var projectRaw = projectProperty?.GetValue(requestConfiguration);
            var project = projectRaw as ProjectInstance;

            //Dump global properties
            var globalProperties = project?.GlobalProperties;
            if (globalProperties != null)
            {
                var globalPropertiesList = globalProperties.ToList();
                globalPropertiesList.Sort((a, b) => string.CompareOrdinal(a.Key, b.Key));
                foreach (var globalProperty in globalPropertiesList)
                {
                    Log.LogMessage(MessageImportance.High, $"Global Property: {globalProperty.Key} = {globalProperty.Value}");
                }
            }

            //Dump project properties
            var projectProperties = project?.Properties;
            // ReSharper disable once InvertIf
            if (projectProperties != null)
            {
                var propertyList = projectProperties.ToList();
                propertyList.Sort((a, b) => string.CompareOrdinal(a.Name, b.Name));
                foreach (var propertyInstance in propertyList)
                {
                    Log.LogMessage(MessageImportance.High, $"Project Property: {propertyInstance.Name} = {propertyInstance.EvaluatedValue}");
                }
            }

            return true;
        }
    }
}
