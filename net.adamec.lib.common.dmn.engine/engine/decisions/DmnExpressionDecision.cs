using System.Collections.Generic;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.engine.runtime;
using net.adamec.lib.common.logging;

namespace net.adamec.lib.common.dmn.engine.engine.decisions
{
    public class DmnExpressionDecision : DmnDecision
    {
        public string Expression { get; }
        public DmnVariableDefinition Output { get; }
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

        public override DmnDecisionResult Evaluate(DmnExecutionContext context, string correlationId = null)
        {
            Logger.Info(correlationId, message: $"Evaluating expressiong decision {Name} with expression {Expression}...");
            var result = context.EvalExpression(Expression, Output.Type);
            Logger.Info(correlationId, message: $"Evaluated expressiong decision {Name} with expression {Expression}");
            var outVariable= context.GetVariable(Output);
            outVariable.Value = result;
            return new DmnDecisionResult() + (new DmnDecisionSingleResult() + outVariable.Clone());
        }
    }
}
