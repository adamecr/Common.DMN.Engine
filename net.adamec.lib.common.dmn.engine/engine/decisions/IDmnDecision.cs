using System.Collections.Generic;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.engine.execution.context;
using net.adamec.lib.common.dmn.engine.engine.execution.result;

namespace net.adamec.lib.common.dmn.engine.engine.decisions
{
    /// <summary>
    /// Decision interface
    /// </summary>
    public interface IDmnDecision : IDmnElement
    {
        /// <summary>
        /// Decision required inputs (input variables)
        /// <remarks>Only direct dependencies are here, use <see cref="GetAllRequiredInputs"/> method to get the full list</remarks>
        /// </summary>
        IReadOnlyCollection<IDmnVariable> RequiredInputs { get; }

        /// <summary>
        /// List of decisions, the decision depends on
        /// <remarks>Only direct dependencies are here, use <see cref="GetAllRequiredDecisions"/> method to get the full list</remarks>
        /// </summary>
        IReadOnlyCollection<IDmnDecision> RequiredDecisions { get; }

        /// <summary>
        /// Executes the decision.
        /// </summary>
        /// <param name="context">DMN Engine execution context</param>
        /// <param name="executionId">Identifier of the execution run</param>
        /// <returns>Decision result</returns>
        DmnDecisionResult Execute(DmnExecutionContext context, string executionId);

        /// <summary>
        /// Returns all required inputs (input variables) for decision.
        /// Takes also the required inputs from <see cref="RequiredDecisions"/> in recursion
        /// </summary>
        IReadOnlyCollection<IDmnVariable> GetAllRequiredInputs();

        /// <summary>
        /// List of all decisions, the decision depends on
        /// Takes also the required decisions from <see cref="RequiredDecisions"/> in recursion
        /// </summary>
        IReadOnlyCollection<IDmnDecision> GetAllRequiredDecisions();
    }
}
