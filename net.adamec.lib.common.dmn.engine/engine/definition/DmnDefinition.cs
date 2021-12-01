using System;
using System.Collections.Generic;
using System.Linq;
using net.adamec.lib.common.dmn.engine.engine.decisions;

namespace net.adamec.lib.common.dmn.engine.engine.definition
{
    /// <summary>
    /// DMN model definition for execution engine - encapsulates Decisions, Variables (incl. Input data)
    /// </summary>
    public class DmnDefinition
    {
        /// <summary>
        /// Unique identifier of the definition (set at CTOR)
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Variables used while executing the DMN model - can be used within the Decision Tables and/or Expressions
        /// In general, it holds the Input Data of DMN model and outputs from Decision Tables and/or Expressions
        /// </summary>
        public IReadOnlyDictionary<string, IDmnVariable> Variables { get; }

        /// <summary>
        /// Input data interface. Input data are stored as Variables with <see cref="IDmnVariable.IsInputParameter"/> flag,
        /// complex objects are supported
        /// </summary>
        public IReadOnlyDictionary<string, IDmnVariable> InputData =>
            Variables
                .Where(v => v.Value.IsInputParameter)
                .ToDictionary(i => i.Key, i => i.Value);

        /// <summary>
        /// Dictionary of available decisions by name
        /// </summary>
        public IReadOnlyDictionary<string, IDmnDecision> Decisions { get; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="variables">Variables used while executing the DMN model</param>
        /// <param name="decisions">Dictionary of available decisions by name</param>
        public DmnDefinition(
            IReadOnlyDictionary<string, IDmnVariable> variables,
            IReadOnlyDictionary<string, IDmnDecision> decisions)
        {
            Id = Guid.NewGuid().ToString();
            Variables = variables;
            Decisions = decisions;
        }
    }
}
