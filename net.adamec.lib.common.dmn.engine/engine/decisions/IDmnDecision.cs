using System.Collections.Generic;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.engine.execution;
using net.adamec.lib.common.dmn.engine.engine.execution.context;
using net.adamec.lib.common.dmn.engine.engine.execution.result;

namespace net.adamec.lib.common.dmn.engine.engine.decisions
{
    /// <summary>
    /// Decision interface
    /// </summary>
    public interface IDmnDecision
    {
        /// <summary>
        /// Unique name of the decision
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Decision required inputs (input variables)
        /// </summary>
        IReadOnlyCollection<IDmnVariable> RequiredInputs { get; }
        /// <summary>
        /// List of decisions, the decision depends on
        /// </summary>
        IReadOnlyCollection<IDmnDecision> RequiredDecisions { get; }

        /// <summary>
        /// Executes the decision.
        /// </summary>
        /// <param name="context">DMN Engine execution context</param>
        /// <param name="executionId">Identifier of the execution run</param>
        /// <returns>Decision result</returns>
        DmnDecisionResult Execute(DmnExecutionContext context, string executionId);


    }
}
