using System.Collections.Generic;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.engine.runtime;
using net.adamec.lib.common.logging;

namespace net.adamec.lib.common.dmn.engine.engine.decisions
{
    public abstract class DmnDecision : IDmnDecision
    {
        protected ILogger Logger { get; }
   
        public string Name { get; }
    
        public List<DmnVariableDefinition> RequiredInputs { get; }
        public List<IDmnDecision> RequiredDecisions { get; }


        protected DmnDecision(string name, List<DmnVariableDefinition> requiredInputs, List<IDmnDecision> requiredDecisions)
        {
            Logger = CommonLogging.CreateLogger(GetType());
            Name = name;
            RequiredInputs = requiredInputs;
            RequiredDecisions = requiredDecisions;
        }

        public DmnDecisionResult Execute(DmnExecutionContext context, string correlationId = null)
        {
            
            Logger.Info(correlationId,message:$"Executing decision {Name}...");
            if (Logger.IsDebugEnabled)
            {
                foreach (var input in RequiredInputs)
                {
                    Logger.Debug(correlationId, message: $"Decision {Name}, input {input.Name}, value {context.GetVariable(input).Value}");
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
            if (Logger.IsDebugEnabled)
            {
                if (!result.HasResult)
                {
                    Logger.Debug(correlationId, message: $"Decision {Name} returned no result");
                }
                else
                {
                    if (result.IsSingleResult)
                    {
                        foreach (var output in result.SingleResult)
                        {
                            Logger.Debug(correlationId, message: $"Decision {Name} single result, output {output.Name}, value {output.Value}");
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
                                Logger.Debug(correlationId, message: $"Decision {Name} result #{idx}, output {output.Name}, value {output.Value}");
                            }
                        }
                    }
                }
            }
            return result;
        }

        public abstract DmnDecisionResult Evaluate(DmnExecutionContext context, string correlationId = null);
    }
}
