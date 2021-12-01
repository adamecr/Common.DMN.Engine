using System;
using System.Collections.Generic;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.engine.execution.context;
using net.adamec.lib.common.dmn.engine.engine.execution.result;

namespace net.adamec.lib.common.dmn.engine.engine.decisions.expression
{
    /// <summary>
    /// Expression decision definition
    /// </summary>
    public class DmnExpressionDecision : DmnDecision
    {
        /// <summary>
        /// Decision expression
        /// </summary>
        public string Expression { get; }

        /// <summary>
        /// Decision output variable
        /// </summary>
        public IDmnVariable Output { get; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="name">Unique name of the decision</param>
        /// <param name="expression">Decision expression</param>
        /// <param name="output">Decision output variable</param>
        /// <param name="requiredInputs">Decision required inputs (input variables)</param>
        /// <param name="requiredDecisions">List of decisions, the decision depends on</param>
        public DmnExpressionDecision(
            string name,
            string expression,
            IDmnVariable output,
            IReadOnlyCollection<IDmnVariable> requiredInputs,
            IReadOnlyCollection<IDmnDecision> requiredDecisions)
        : base(name, requiredInputs, requiredDecisions)
        {
            Expression = expression;
            Output = output;
        }

        /// <summary>
        /// Evaluates the decision.
        /// </summary>
        /// <param name="context">DMN Engine execution context</param>
        /// <param name="executionId">Identifier of the execution run</param>
        /// <returns>Decision result</returns>
        /// <exception cref="ArgumentNullException"><paramref name="context"/> is nul</exception>
        protected override DmnDecisionResult Evaluate(DmnExecutionContext context, string executionId)
        {
            if (context == null) throw Logger.FatalCorr<ArgumentNullException>(executionId,$"{nameof(context)} is null");

            Logger.InfoCorr(executionId, $"Evaluating expressiong decision {Name} with expression {Expression}...");
            var result = context.EvalExpression(Expression, Output.Type,executionId);
            Logger.InfoCorr(executionId, $"Evaluated expressiong decision {Name} with expression {Expression}");
            var outVariable = context.GetVariable(Output);
            outVariable.Value = result;
            return new DmnDecisionResult(new DmnDecisionSingleResult(context.GetVariable(Output)));
        }
    }
}
