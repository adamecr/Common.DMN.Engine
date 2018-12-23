using System.Diagnostics.CodeAnalysis;
using net.adamec.lib.common.dmn.engine.parser;

namespace net.adamec.lib.common.dmn.engine.engine.decisions.table
{
    public class DmnDecisionTableRuleInput
    {
        public DmnDecisionTableInput Input { get; }
        public string Expression { get; }

        public DmnDecisionTableRuleInput(DmnDecisionTableInput input, string expression)
        {
            Input = input;
            Expression = SfeelParser.ParseInput(expression, string.IsNullOrEmpty(input.Expression) ? input.Variable.Name : input.Expression);
        }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"#{Input.Index} {Input.Variable.Name}{(Input.Variable.Type == null ? "" : ":" + Input.Variable.Type)} <-- {Expression}";
        }
    }
}
