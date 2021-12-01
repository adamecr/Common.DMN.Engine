using System.Collections.Generic;
using net.adamec.lib.common.dmn.engine.engine.decisions;

namespace net.adamec.lib.common.dmn.engine.engine.definition
{
    /// <summary>
    /// DMN model definition for execution engine - encapsulates Decisions, Variables and Input data
    /// </summary>
    public interface IDmnDefinition
    {
        /// <summary>
        /// Variables used while executing the DMN model - can be used within the Decision Tables and/or Expressions
        /// In general, it holds the Input Data of DMN model and outputs from Decision Tables and/or Expressions
        /// </summary>
        IReadOnlyDictionary<string, IDmnVariable> Variables { get; }

        /// <summary>
        /// Input data interface. Input data will be stored as Variables, complex objects are supported
        /// </summary>
        IReadOnlyDictionary<string, IDmnVariable> InputData { get; }

        /// <summary>
        /// Dictionary of available decisions by name
        /// </summary>
        IReadOnlyDictionary<string, IDmnDecision> Decisions { get; }
    }
}
