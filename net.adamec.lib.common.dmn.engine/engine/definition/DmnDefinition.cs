using System.Collections.Generic;
using net.adamec.lib.common.dmn.engine.engine.decisions;

namespace net.adamec.lib.common.dmn.engine.engine.definition
{
    public class DmnDefinition
    {
  
        /// <summary>
        /// Variables used while executing the DMN model - can be used within the Decision Tables and/or Expressions
        /// In general, it holds the Input Data of DMN model and outputs from Decision Tables and/or Expressions
        /// </summary>
        public IDictionary<string, DmnVariableDefinition> Variables { get; }

        /// <summary>
        /// Input data interface. Input data will be stored as Variables, complex objects are supported
        /// </summary>
        public IDictionary<string, DmnVariableDefinition> InputData { get; }

        public IDictionary<string, IDmnDecision> Decisions { get; }

        internal DmnDefinition(
            IDictionary<string, DmnVariableDefinition> variables,
            IDictionary<string, DmnVariableDefinition> inputData,
            IDictionary<string, IDmnDecision> decisions)
        {
            Variables = variables;
            InputData = inputData;
            Decisions = decisions;
        }
    }
}
