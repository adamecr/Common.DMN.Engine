using System.Collections.Generic;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.engine.runtime;
using net.adamec.lib.common.logging;

namespace net.adamec.lib.common.dmn.engine.engine.decisions
{
    /// <summary>
    /// DMN Decision definition
    /// </summary>
    public abstract class DmnDecision : IDmnDecision
    {
        /// <summary>
        /// Logger
        /// </summary>
        protected ILogger Logger { get; }
   
        /// <summary>
        /// Decision unique name
        /// </summary>
        public string Name { get; }
    
        /// <summary>
        /// Decision required inputs (input variables)
        /// </summary>
        public List<DmnVariableDefinition> RequiredInputs { get; }
        /// <summary>
        /// List of decisions, the decision depends on
        /// </summary>
        public List<IDmnDecision> RequiredDecisions { get; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="name">Decision unique name</param>
        /// <param name="requiredInputs">Decision required inputs (input variables)</param>
        /// <param name="requiredDecisions">List of decisions, the decision depends on</param>
        protected DmnDecision(string name, List<DmnVariableDefinition> requiredInputs, List<IDmnDecision> requiredDecisions)
        {
            Logger = CommonLogging.CreateLogger(GetType());
            Name = name;
            RequiredInputs = requiredInputs;
            RequiredDecisions = requiredDecisions;
        }

        /// <summary>
        /// Executes the decision. The execution wrapper around <see cref="Evaluate"/>.
        /// </summary>
        /// <param name="context">DMN Engine execution context</param>
        /// <param name="correlationId">Optional correlation ID used while logging</param>
        /// <returns>Decision result</returns>
        public DmnDecisionResult Execute(DmnExecutionContext context, string correlationId = null)
        {
            
            Logger.Info(correlationId,message:$"Executing decision {Name}...");
            if (Logger.IsTraceEnabled)
            {
                foreach (var input in RequiredInputs)
                {
                    Logger.Trace(correlationId, message: $"Decision {Name}, input {input.Name}, value {context.GetVariable(input).Value}");
                }
            }

            // ReSharper disable once InvertIf
            if (RequiredDecisions != null)
            {
                Logger.Info(correlationId, message: $"Resolving dependencies for decision {Name}...");
                foreach (var requiredDecision in RequiredDecisions)
                {
                    Logger.Info(correlationId, message: $"Executing dependency  {requiredDecision.Name} for decision {Name}...");
                    requiredDecision.Execute(context,correlationId);
                    Logger.Info(correlationId, message: $"Executed dependency  {requiredDecision.Name} for decision {Name}");
                }
                Logger.Info(correlationId, message: $"Resolved dependencies for decision {Name}");
            }

            var result =Evaluate(context,correlationId);

            Logger.Info(correlationId, message: $"Executed decision {Name}");
            // ReSharper disable once InvertIf
            if (Logger.IsTraceEnabled)
            {
                if (!result.HasResult)
                {
                    Logger.Trace(correlationId, message: $"Decision {Name} returned no result");
                }
                else
                {
                    if (result.IsSingleResult)
                    {
                        foreach (var output in result.SingleResult)
                        {
                            Logger.Trace(correlationId, message: $"Decision {Name} single result, output {output.Name}, value {output.Value}");
                        }
                    }
                    else
                    {
                        var idx = 0;
                        foreach (var singleResult in result.Results)
                        {
                            idx++;
                            foreach (var output in singleResult.Variables)
                            {
                                Logger.Trace(correlationId, message: $"Decision {Name} result #{idx}, output {output.Name}, value {output.Value}");
                            }
                        }
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Evaluates the decision.
        /// </summary>
        /// <param name="context">DMN Engine execution context</param>
        /// <param name="correlationId">Optional correlation ID used while logging</param>
        /// <returns>Decision result</returns>
        public abstract DmnDecisionResult Evaluate(DmnExecutionContext context, string correlationId = null);
    }
}
