using System.Diagnostics.CodeAnalysis;
using net.adamec.lib.common.dmn.engine.parser;

namespace net.adamec.lib.common.dmn.engine.engine.decisions.table
{
    /// <summary>
    /// Definition of decision table rule input - contains the input match evaluation expression and mapping to table input
    /// </summary>
    public class DmnDecisionTableRuleInput
    {
        /// <summary>
        /// Corresponding table input
        /// </summary>
        public DmnDecisionTableInput Input { get; }
        /// <summary>
        /// Expression used to evaluate the rule input match
        /// </summary>
        public string Expression { get; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="input">Corresponding table input</param>
        /// <param name="expression">Expression used to evaluate the rule input match</param>
        public DmnDecisionTableRuleInput(DmnDecisionTableInput input, string expression)
        {
            Input = input;
            Expression = SfeelParser.ParseInput(expression, string.IsNullOrWhiteSpace(input.Expression) ? input.Variable.Name : input.Expression);
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
