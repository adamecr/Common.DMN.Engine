using System.Collections.Generic;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.engine.runtime;

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
        List<DmnVariableDefinition> RequiredInputs { get; }
        /// <summary>
        /// List of decisions, the decision depends on
        /// </summary>
        List<IDmnDecision> RequiredDecisions { get; }

        /// <summary>
        /// Executes the decision.
        /// </summary>
        /// <param name="context">DMN Engine execution context</param>
        /// <param name="correlationId">Optional correlation ID used while logging</param>
        /// <returns>Decision result</returns>
        DmnDecisionResult Execute(DmnExecutionContext context, string correlationId = null);
    }
}
