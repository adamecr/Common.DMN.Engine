using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using net.adamec.lib.common.dmn.engine.engine.definition;

namespace net.adamec.lib.common.dmn.engine.engine.decisions.table
{
    public class DmnDecisionTableOutput
    {
        public int Index { get; }
        public DmnVariableDefinition Variable { get; }
        public List<string> AllowedValues { get; }

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
