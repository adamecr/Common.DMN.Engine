using System;
using System.Collections.Generic;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.engine.runtime;
using net.adamec.lib.common.logging;

namespace net.adamec.lib.common.dmn.engine.engine.decisions
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
        /// Decision output definition
        /// </summary>
        public DmnVariableDefinition Output { get; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="name">Unique name of the decision</param>
        /// <param name="expression">Decision expression</param>
        /// <param name="output">Decision output definition</param>
        /// <param name="requiredInputs">Decision required inputs (input variables)</param>
        /// <param name="requiredDecisions">List of decisions, the decision depends on</param>
        public DmnExpressionDecision(
            string name,
            string expression,
            DmnVariableDefinition output,
            List<DmnVariableDefinition> requiredInputs, List<IDmnDecision> requiredDecisions)
        : base(name, requiredInputs, requiredDecisions)
        {
            Expression = expression;
            Output = output;
        }

        /// <summary>
        /// Evaluates the decision.
        /// </summary>
        /// <param name="context">DMN Engine execution context</param>
        /// <param name="correlationId">Optional correlation ID used while logging</param>
        /// <returns>Decision result</returns>
        /// <exception cref="ArgumentNullException"><paramref name="context"/> is nul</exception>
        protected override DmnDecisionResult Evaluate(DmnExecutionContext context, string correlationId = null)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));

            Logger.Info(correlationId, message: $"Evaluating expressiong decision {Name} with expression {Expression}...");
            var result = context.EvalExpression(Expression, Output.Type);
            Logger.Info(correlationId, message: $"Evaluated expressiong decision {Name} with expression {Expression}");
            var outVariable= context.GetVariable(Output);
            outVariable.Value = result;
            return new DmnDecisionResult() + (new DmnDecisionSingleResult() + outVariable.Clone());
        }
    }
}
