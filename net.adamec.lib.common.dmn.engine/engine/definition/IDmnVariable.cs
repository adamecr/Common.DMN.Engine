using System;
using System.Collections.Generic;

namespace net.adamec.lib.common.dmn.engine.engine.definition
{
    /// <summary>
    /// Read only definition DMN model variable
    /// </summary>
    public interface IDmnVariable
    {
        /// <summary>
        /// Name of the variable
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Type of the variable when recognized from the decisions
        /// </summary>
        Type Type { get; }

        /// <summary>
        /// Flag whether the variable represents the input parameter of the decision model.
        /// Such variable will be read-only
        /// </summary>
        bool IsInputParameter { get; }

        /// <summary>
        /// Flag whether the variable has any "setter" - is there any output to Variable or is Input parameter
        /// </summary>
        bool HasValueSetter { get; }

        /// <summary>
        /// Information about value "setters" for the variable.
        /// </summary>
        /// <remarks>
        /// Can be "Input: {inputName}", "Table Decision {decisionName}" or "Expression Decision {decisionName}".
        /// </remarks>
        IEnumerable<string> ValueSetters { get; }
    }
}
