using System.Diagnostics.CodeAnalysis;

namespace net.adamec.lib.common.dmn.engine.engine.decisions.table.definition
{
    /// <summary>
    /// Definition of decision table rule output - contains the calculation expression and mapping to table output 
    /// </summary>
    public class DmnDecisionTableRuleOutput
    {
        /// <summary>
        /// Corresponding table output
        /// </summary>
        public DmnDecisionTableOutput Output { get; }
        /// <summary>
        /// Expression used to calculate the value of rule output
        /// </summary>
        public string Expression { get; }
       
        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="output">Corresponding table output</param>
        /// <param name="expression">Expression used to calculate the value of rule output</param>
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
            return $"#{Output.Index} {Output.Variable} --> {Expression}";
        }
    }
}
