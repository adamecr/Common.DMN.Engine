using System;
using System.IO;
using System.Text;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.engine.execution.context;
using net.adamec.lib.common.dmn.engine.parser;
using net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace.execute.model;
using net.adamec.lib.common.dmn.engine.simulator.model;

namespace net.adamec.lib.common.dmn.engine.simulator.service
{
    /// <summary>
    /// DMN Engine core functionality wrapper
    /// </summary>
    public class DmnService
    {
        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="fileFullName">Full path to the DMN file</param>
        /// <exception cref="ArgumentNullException">Thrown when the <paramref name="fileFullName"/> is null or empty</exception>
        public static DmnDefinitionInfo GetDmnDefinitionInfo(string fileFullName)
        {
            if (string.IsNullOrWhiteSpace(fileFullName)) throw new ArgumentNullException(nameof(fileFullName));

            var title =
                !string.IsNullOrWhiteSpace(fileFullName) ?
                    File.Exists(fileFullName) ?
                        Path.GetFileName(fileFullName) :
                        fileFullName :
                    "[unknown]";

            //Load DMN
            var dmnDefinition = GetDmnDefinition(fileFullName, out var error);
            return dmnDefinition == null ? new DmnDefinitionInfo(title, error) : new DmnDefinitionInfo(title, dmnDefinition);
        }
        

        /// <summary>
        /// Parses the DMN model from XML file with <paramref name="fileFullName"/> and creates the <see cref="DmnDefinition"/>
        /// Only DMN XML version 1.3 is supported and DMN Parser v1_3 ext is used!!!
        /// </summary>
        /// <param name="fileFullName">Full file name of DMN XML</param>
        /// <param name="error">Error message in case the method fails</param>
        /// <returns><see cref="DmnDefinition"/> read from DMN XML or null when the processing fails</returns>
        private static DmnDefinition? GetDmnDefinition(string fileFullName, out string? error)
        {
            if (!string.IsNullOrWhiteSpace(fileFullName) && File.Exists(fileFullName))
            {
                try
                {
                    var dmnModel = DmnParser.Parse13ext(fileFullName);
                    var dmnDefinition = DmnDefinitionFactory.CreateDmnDefinition(dmnModel);
                    error = null;
                    return dmnDefinition;
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return null;
                }
            }

            error = $"File {fileFullName} doesn't exist";
            return null;
        }

        /// <summary>
        /// Execute the decision with given <paramref name="decisionName"/> and <paramref name="inputs"/>
        /// </summary>
        /// <param name="definition">DMN Definition the decision belongs to</param>
        /// <param name="decisionName">Name of the decision to execute</param>
        /// <param name="inputs">Inputs for the execution</param>
        /// <param name="snapshots">Snapshots created during the execution when executed successfully</param>
        /// <param name="error">Error message  when not executed successfully</param>
        /// <returns>True when executed successfully</returns>
        public static bool ExecuteDecision(
            DmnDefinition definition,
            string decisionName,
            InputVariable[] inputs,
            out DmnExecutionSnapshots? snapshots,
            out string? error)
        {
            //"outputs" of execution
            var executedSuccessfully = true;
            var errorMessageBuilder = new StringBuilder();

            //is there any decision to execute?
            // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
            if (string.IsNullOrWhiteSpace(decisionName) || definition is null)
            {
                errorMessageBuilder.AppendLine($"There is no decision to execute");
                executedSuccessfully = false;
            }

            //Prepare the execution context including the input values
            DmnExecutionContext? ctx = null;
            if (executedSuccessfully)
            {
                //create the execution context
                ctx = DmnExecutionContextFactory.CreateExecutionContext(definition, o =>
                {
                    o.RecordSnapshots = true;
                    o.ParsedExpressionCacheScope = ParsedExpressionCacheScopeEnum.Execution; //to ensure you can use object parameters with proxy type 
                });
                //process the inputs
                foreach (var input in inputs)
                {
                    if (input.IsInputValueInvalid)
                    {
                        errorMessageBuilder.AppendLine($"Invalid input {input.Name}: {input.InputValueError}");
                        executedSuccessfully = false;
                        continue;
                    }

                    try
                    {
                        ctx.WithInputParameter(input.Name, input.InputValue);
                    }
                    catch (Exception ex)
                    {
                        var msg = ex.Message;
                        input.InvalidateInputValue(msg);
                        errorMessageBuilder.AppendLine($"Can't set input parameter {input.Name}: {msg}");
                        executedSuccessfully = false;
                    }
                }
            }
            
            //execute the decision
            snapshots = null;
            error = null;
            if (executedSuccessfully)
            {
                try
                {
                    ctx!.ExecuteDecision(decisionName);
                    snapshots = ctx.Snapshots;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    errorMessageBuilder.AppendLine($"Error while executing {decisionName}: {msg}");
                    executedSuccessfully = false;
                }
            }

            if (!executedSuccessfully) error = errorMessageBuilder.ToString();

            return executedSuccessfully;
        }
    }
}
