using System.Collections.Generic;
using net.adamec.lib.common.dmn.engine.engine.decisions;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.parser.dto;

namespace net.adamec.lib.common.dmn.engine.engine.runtime
{
    public class DmnExecutionContextFactory
    {
        /// <summary>
        /// Variables used while executing the DMN model - can be used within the Decision Tables and/or Expressions
        /// In general, it holds the Input Data of DMN model and outputs from Decision Tables and/or Expressions
        /// </summary>
        public IDictionary<string, DmnExecutionVariable> Variables { get; } = new Dictionary<string, DmnExecutionVariable>();

        /// <summary>
        /// Input data interface. Input data will be stored as Variables, complex objects are supported
        /// </summary>
        public IDictionary<string, DmnExecutionVariable> InputData { get; } = new Dictionary<string, DmnExecutionVariable>();

        /// <summary>
        /// Dictionary of available decisions by name
        /// </summary>
        public IDictionary<string, IDmnDecision> Decisions { get; } = new Dictionary<string, IDmnDecision>();

        public static DmnExecutionContext CreateExecutionContext(DmnModel sourceModel)
        {
            var definition = DmnDefinitionFactory.CreateDmnDefinition(sourceModel);
            return CreateExecutionContext(definition);
        }

        public static DmnExecutionContext CreateExecutionContext(DmnDefinition sourceDefinition)
        {
            var factory = new DmnExecutionContextFactory(sourceDefinition);
            return new DmnExecutionContext(sourceDefinition,factory.Variables, factory.InputData, factory.Decisions);
        }

        protected DmnExecutionContextFactory(DmnDefinition source)
        {
            //Decisions reference
            foreach (var sourceDecision in source.Decisions)
            {
                Decisions.Add(sourceDecision.Key,sourceDecision.Value);
            }

            //Init runtime (execution) variables
            foreach (var sourceVariable in source.Variables.Values)
            {
                var variable=new DmnExecutionVariable(sourceVariable);
                Variables.Add(variable.Name,variable);
                if (variable.IsInputParameter)
                {
                    InputData.Add(variable.Name,variable);
                }
            }
        }

      
    }
}
