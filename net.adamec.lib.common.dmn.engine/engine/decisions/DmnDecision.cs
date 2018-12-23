using System.Collections.Generic;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.engine.runtime;
using net.adamec.lib.common.dmn.engine.utils;

namespace net.adamec.lib.common.dmn.engine.engine.decisions
{
    public abstract class DmnDecision : IDmnDecision
    {
        public Logging Logger { get; }

        public string Name { get; }
    
        public List<DmnVariableDefinition> RequiredInputs { get; }
        public List<IDmnDecision> RequiredDecisions { get; }


        protected DmnDecision(string name, List<DmnVariableDefinition> requiredInputs, List<IDmnDecision> requiredDecisions)
        {
            Logger = Logging.CreateLogging(GetType());
            Name = name;
            RequiredInputs = requiredInputs;
            RequiredDecisions = requiredDecisions;
        }

        public DmnDecisionResult Execute(DmnExecutionContext context, string correlationId = null)
        {
            
            Logger.Info(correlationId,$"Executing decision {Name}...");
            if (Logger.IsTraceEnabled)
            {
                foreach (var input in RequiredInputs)
                {
                    Logger.Trace(correlationId,$"Decision {Name}, input {input.Name}, value {context.GetVariable(input).Value}");
                }
            }

            // ReSharper disable once InvertIf
            if (RequiredDecisions != null)
            {
                Logger.Info(correlationId, $"Resolving dependencies for decision {Name}...");
                foreach (var requiredDecision in RequiredDecisions)
                {
                    Logger.Info(correlationId, $"Executing dependency  {requiredDecision.Name} for decision {Name}...");
                    requiredDecision.Execute(context,correlationId);
                    Logger.Info(correlationId, $"Executed dependency  {requiredDecision.Name} for decision {Name}");
                }
                Logger.Info(correlationId, $"Resolved dependencies for decision {Name}");
            }

            var result =Evaluate(context,correlationId);

            Logger.Info(correlationId, $"Executed decision {Name}");
            // ReSharper disable once InvertIf
            if (Logger.IsTraceEnabled)
            {
                if (!result.HasResult)
                {
                    Logger.Trace(correlationId, $"Decision {Name} returned no result");
                }
                else
                {
                    if (result.IsSingleResult)
                    {
                        foreach (var output in result.SingleResult)
                        {
                            Logger.Trace(correlationId, $"Decision {Name} single result, output {output.Name}, value {output.Value}");
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
                                Logger.Trace(correlationId, $"Decision {Name} result #{idx}, output {output.Name}, value {output.Value}");
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
