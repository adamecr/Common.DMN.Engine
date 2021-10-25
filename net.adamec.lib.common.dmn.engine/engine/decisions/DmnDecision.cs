using System;
using System.Collections.Generic;
using net.adamec.lib.common.core.logging;
using net.adamec.lib.common.dmn.engine.engine.definition;

using net.adamec.lib.common.dmn.engine.engine.execution.context;
using net.adamec.lib.common.dmn.engine.engine.execution.result;

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
        public IReadOnlyCollection<IDmnVariable> RequiredInputs { get; }
        /// <summary>
        /// List of decisions, the decision depends on
        /// </summary>
        public IReadOnlyCollection<IDmnDecision> RequiredDecisions { get; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="name">Decision unique name</param>
        /// <param name="requiredInputs">Decision required inputs (input variables)</param>
        /// <param name="requiredDecisions">List of decisions, the decision depends on</param>
        /// <exception cref="ArgumentNullException"><paramref name="name"/>, <paramref name="requiredInputs"/> or <paramref name="requiredDecisions"/> is null</exception>
        /// <exception cref="ArgumentException">Name is empty</exception>
        protected DmnDecision(
            string name,
            IReadOnlyCollection<IDmnVariable> requiredInputs,
            IReadOnlyCollection<IDmnDecision> requiredDecisions)
        {
            Logger = CommonLogging.CreateLogger(GetType());
            Name = name ?? throw Logger.Fatal<ArgumentNullException>($"{nameof(name)} is null");
            RequiredInputs = requiredInputs ?? throw Logger.Fatal<ArgumentNullException>($"{nameof(requiredInputs)} is null");
            RequiredDecisions = requiredDecisions ?? throw Logger.Fatal<ArgumentNullException>($"{nameof(requiredDecisions)} is null");

            if (string.IsNullOrWhiteSpace(name)) throw Logger.Fatal<ArgumentNullException>($"{nameof(name)} is empty");
        }

        /// <summary>
        /// Executes the decision. The execution wrapper around <see cref="Evaluate"/>.
        /// </summary>
        /// <param name="context">DMN Engine execution context</param>
        /// <param name="executionId">Identified of the execution run</param>
        /// <returns>Decision result</returns>
        /// <exception cref="ArgumentNullException"><paramref name="context"/> is null</exception>
        public DmnDecisionResult Execute(DmnExecutionContext context, string executionId = null)
        {
            if (context == null) throw Logger.Fatal<ArgumentNullException>($"{nameof(context)} is null");

            Logger.InfoCorr(executionId, $"Executing decision {Name}...");
            if (Logger.IsTraceEnabled)
            {
                foreach (var input in RequiredInputs)
                {
                    Logger.TraceCorr(executionId, $"Decision {Name}, input {input.Name}, value {context.GetVariable(input).Value}");
                }
            }

            // ReSharper disable once InvertIf
            if (RequiredDecisions != null)
            {
                Logger.InfoCorr(executionId, $"Resolving dependencies for decision {Name}...");
                foreach (var requiredDecision in RequiredDecisions)
                {
                    Logger.InfoCorr(executionId, $"Executing dependency  {requiredDecision.Name} for decision {Name}...");
                    requiredDecision.Execute(context, executionId);
                    Logger.InfoCorr(executionId, $"Executed dependency  {requiredDecision.Name} for decision {Name}");
                }
                Logger.InfoCorr(executionId, $"Resolved dependencies for decision {Name}");
            }

            var result = Evaluate(context, executionId);
            context.CreateSnapshot(this,result);

            Logger.InfoCorr(executionId, $"Executed decision {Name}");
            // ReSharper disable once InvertIf
            if (Logger.IsTraceEnabled)
            {
                if (!result.HasResult)
                {
                    Logger.TraceCorr(executionId, $"Decision {Name} returned no result");
                }
                else
                {
                    if (result.IsSingleResult)
                    {
                        foreach (var output in result.FirstResultVariables)
                        {
                            Logger.TraceCorr(executionId, $"Decision {Name} single result, output {output.Name}, value {output.Value}");
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
                                Logger.TraceCorr(executionId, $"Decision {Name} result #{idx}, output {output.Name}, value {output.Value}");
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
        /// <param name="executionId">Identifier of the execution run</param>
        /// <returns>Decision result</returns>
        protected abstract DmnDecisionResult Evaluate(DmnExecutionContext context, string executionId);
    }
}
