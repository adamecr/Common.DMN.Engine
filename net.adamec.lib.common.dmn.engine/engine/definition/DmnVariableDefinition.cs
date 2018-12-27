using System;
using System.Collections.Generic;

namespace net.adamec.lib.common.dmn.engine.engine.definition
{
    /// <summary>
    /// Definition of DMN model variable
    /// </summary>
    public class DmnVariableDefinition

    {
        /// <summary>
        /// Name of the variable
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Type of the variable when recognized from the decisions
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// Flag whether the variable represents the input parameter of the decision model.
        /// Such variable will be read-only
        /// </summary>
        public bool IsInputParameter { get; set; }
        /// <summary>
        /// Flag whether the variable has any "setter" - is there any output to Variable or is Input parameter
        /// </summary>
        public bool HasValueSetter { get; set; }

        /// <summary>
        /// List of value "setters" for the variable.
        /// </summary>
        /// <remarks>
        /// Can be "Input: {inputName}", "Table Decision {decisionName}" or "Expression Decision {decisionName}".
        /// </remarks>
        public List<string> ValueSetters { get; } = new List<string>();

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="name">Name of the variable</param>
        public DmnVariableDefinition(string name)
        {
            Name = name;
        }

        /// <inheritdoc />
        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return $"{Name}{(Type == null ? "" : ":" + Type)}";
        }

    }
}
