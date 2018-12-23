using System.Diagnostics.CodeAnalysis;

namespace net.adamec.lib.common.dmn.engine.engine.decisions.table
{
    public class DmnDecisionTableRuleOutput
    {
        public DmnDecisionTableOutput Output { get; }
        public string Expression { get; }
       

        public DmnDecisionTableRuleOutput(DmnDecisionTableOutput output, string expression)
        {
            Output = output;
            Expression = expression;
        }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"#{Output.Index} {Output.Variable.Name}{(Output.Variable.Type == null ? "" : ":" + Output.Variable.Type)} --> {Expression}";
        }
    }
}
