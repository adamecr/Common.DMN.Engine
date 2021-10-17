using System;
using System.Linq;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.parser.dto;

namespace net.adamec.lib.common.dmn.engine.engine.execution.context
{
    /// <summary>
    /// Factory creating the DMN Model execution context from <see cref="DmnModel"/> or <see cref="DmnDefinition"/>
    /// </summary>
    public static class DmnExecutionContextFactory
    {

        /// <summary>
        /// Creates the execution context from <paramref name="sourceModel"/>
        /// </summary>
        /// <param name="sourceModel">Source model to create the execution context for</param>
        /// <param name="configure">Optional configuration action</param>
        /// <returns><paramref name="sourceModel"/> execution context</returns>
        /// <exception cref="ArgumentNullException"><paramref name="sourceModel"/> is null</exception>
        public static DmnExecutionContext CreateExecutionContext(
            DmnModel sourceModel,
            Action<DmnExecutionContextOptions> configure = null)
        {
            if (sourceModel == null) throw new ArgumentNullException(nameof(sourceModel));

            var definition = DmnDefinitionFactory.CreateDmnDefinition(sourceModel);
            return CreateExecutionContext(definition,configure);
        }

        /// <summary>
        /// Creates the execution context from <paramref name="sourceDefinition"/>
        /// </summary>
        /// <param name="sourceDefinition">Source model definition  to create the execution context for</param>
        /// <param name="configure">Optional configuration action</param>
        /// <returns><paramref name="sourceDefinition"/> execution context</returns>
        /// <exception cref="ArgumentNullException"><paramref name="sourceDefinition"/> is null</exception>
        public static DmnExecutionContext CreateExecutionContext(
            DmnDefinition sourceDefinition,
            Action<DmnExecutionContextOptions> configure = null)
        {
            if (sourceDefinition == null) throw new ArgumentNullException(nameof(sourceDefinition));
            if (sourceDefinition.Decisions == null || sourceDefinition.Decisions.Count < 1) throw new ArgumentException("No decisions in the sourceDefinition definition");
            if (sourceDefinition.Variables == null || sourceDefinition.Variables.Count < 1) throw new ArgumentException("No variables in the sourceDefinition definition");

            //Init runtime (execution) variables
            var variables = sourceDefinition
                  .Variables
                  .Values
                  .Select(sourceVariable => new DmnExecutionVariable(sourceVariable))
                  .ToDictionary(variable => variable.Name);

            // Decisions reference - Dictionary of available decisions by name
            var decisions = sourceDefinition
                .Decisions
                .ToDictionary(
                    sourceDecision => sourceDecision.Key,
                    sourceDecision => sourceDecision.Value);

            return new DmnExecutionContext(sourceDefinition, variables, decisions,configure);
        }
    }
}
