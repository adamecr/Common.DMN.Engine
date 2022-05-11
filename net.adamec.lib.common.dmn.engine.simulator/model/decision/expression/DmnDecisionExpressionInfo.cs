using net.adamec.lib.common.dmn.engine.engine.decisions;
using net.adamec.lib.common.dmn.engine.engine.decisions.expression;

namespace net.adamec.lib.common.dmn.engine.simulator.model.decision.expression
{
    /// <summary>
    /// Information about <see cref="DmnExpressionDecision"/>
    /// </summary>
    public class DmnDecisionExpressionInfo : DmnDecisionInfo
    {
        /// <summary>
        /// Empty info
        /// </summary>
        public static DmnDecisionExpressionInfo Empty = new(null);

        /// <summary>
        /// Expression
        /// </summary>
        public string Expression { get; }
        /// <summary>
        /// Output variable name
        /// </summary>
        public string VariableName { get; }
        /// <summary>
        /// Name of the type of output variable
        /// </summary>
        public string VariableType { get; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="dmnDecision">Source decision</param>
        public DmnDecisionExpressionInfo(IDmnDecision? dmnDecision) : base(dmnDecision)
        {
            if (dmnDecision is not DmnExpressionDecision source)
            {
                Expression = string.Empty;
                VariableName = string.Empty;
                VariableType = string.Empty;
                return;
            }

            Expression = source.Expression;
            VariableName = source.Output.Name;
            VariableType = source.Output.Type.Name;
            OutputVariableNames = new[] { VariableName };
        }
    }
}
