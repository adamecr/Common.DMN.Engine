using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using net.adamec.lib.common.dmn.engine.engine.definition;

namespace net.adamec.lib.common.dmn.engine.engine.decisions.table
{
    public class DmnDecisionTableInput
    {
        public int Index { get; }
        public DmnVariableDefinition Variable { get; }
        public string Expression { get; }
        public List<string> AllowedValues { get; }

        public DmnDecisionTableInput(
            int index, DmnVariableDefinition variable,
            string expression = null, List<string> allowedValues = null)
        {
            Index = index;
            Variable = variable;
            Expression = expression;
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
