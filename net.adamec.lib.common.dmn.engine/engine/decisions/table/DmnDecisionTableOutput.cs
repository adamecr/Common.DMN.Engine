using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using net.adamec.lib.common.dmn.engine.engine.definition;

namespace net.adamec.lib.common.dmn.engine.engine.decisions.table
{
    /// <summary>
    /// Definition of decision table output - contains index (order), mapping to the variable and optional list of allowed values
    /// </summary>
    public class DmnDecisionTableOutput
    {
        /// <summary>
        /// Index of the output (order)
        /// </summary>
        public int Index { get; }
        /// <summary>
        /// Variable to store the output to
        /// </summary>
        public DmnVariableDefinition Variable { get; }
        /// <summary>
        /// Optional list of allowed values
        /// </summary>
        public List<string> AllowedValues { get; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="index">Index of the output (order)</param>
        /// <param name="variable">Variable to store the output to</param>
        /// <param name="allowedValues">Optional list of allowed values</param>
        public DmnDecisionTableOutput(int index, DmnVariableDefinition variable, List<string> allowedValues = null)
        {
            Index = index;
            Variable = variable;
            AllowedValues = allowedValues;
        }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"#{Index}:{Variable}";
        }
    }
}
