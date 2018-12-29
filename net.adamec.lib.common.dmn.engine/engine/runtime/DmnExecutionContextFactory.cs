using System;
using System.Collections.Generic;
using net.adamec.lib.common.dmn.engine.engine.decisions;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.parser.dto;

namespace net.adamec.lib.common.dmn.engine.engine.runtime
{
    /// <summary>
    /// Factory creating the DMN Model execution context from <see cref="DmnModel"/> or <see cref="DmnDefinition"/>
    /// </summary>
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

        /// <summary>
        /// Creates the execution context from <paramref name="sourceModel"/>
        /// </summary>
        /// <param name="sourceModel">Source model to create the execution context for</param>
        /// <returns><paramref name="sourceModel"/> execution context</returns>
        /// <exception cref="ArgumentNullException"><paramref name="sourceModel"/> is null</exception>
        public static DmnExecutionContext CreateExecutionContext(DmnModel sourceModel)
        {
            if (sourceModel == null) throw new ArgumentNullException(nameof(sourceModel));

            var definition = DmnDefinitionFactory.CreateDmnDefinition(sourceModel);
            return CreateExecutionContext(definition);
        }

        /// <summary>
        /// Creates the execution context from <paramref name="sourceDefinition"/>
        /// </summary>
        /// <param name="sourceDefinition">Source model definition  to create the execution context for</param>
        /// <returns><paramref name="sourceDefinition"/> execution context</returns>
        /// <exception cref="ArgumentNullException"><paramref name="sourceDefinition"/> is null</exception>
        public static DmnExecutionContext CreateExecutionContext(DmnDefinition sourceDefinition)
        {
            if (sourceDefinition == null) throw new ArgumentNullException(nameof(sourceDefinition));

            var factory = new DmnExecutionContextFactory(sourceDefinition);
            return new DmnExecutionContext(sourceDefinition, factory.Variables, factory.InputData, factory.Decisions);
        }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="source">Source model definition  to create the execution context factory for</param>
        /// <exception cref="ArgumentNullException"><paramref name="source"/> is null</exception>
        /// <exception cref="ArgumentException">No decisions in the source definition</exception>
        /// <exception cref="ArgumentException">No variables in the source definition</exception>
        protected DmnExecutionContextFactory(DmnDefinition source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (source.Decisions == null || source.Decisions.Count < 1) throw new ArgumentException("No decisions in the source definition");
            if (source.Variables == null || source.Variables.Count < 1) throw new ArgumentException("No variables in the source definition");

            //Decisions reference
            foreach (var sourceDecision in source.Decisions)
            {
                Decisions.Add(sourceDecision.Key, sourceDecision.Value);
            }

            //Init runtime (execution) variables
            foreach (var sourceVariable in source.Variables.Values)
            {
                var variable = new DmnExecutionVariable(sourceVariable);
                Variables.Add(variable.Name, variable);
                if (variable.IsInputParameter)
                {
                    InputData.Add(variable.Name, variable);
                }
            }
        }


    }
}
