using System;
using System.Collections.Generic;
using net.adamec.lib.common.dmn.engine.engine.decisions.table.definition;
using net.adamec.lib.common.dmn.engine.engine.runtime;

namespace net.adamec.lib.common.dmn.engine.engine.decisions
{
    /// <summary>
    /// Single decision result
    /// </summary>
    public class DmnDecisionSingleResult
    {
        /// <summary>
        /// Internal list of result variables
        /// </summary>
        private readonly List<DmnExecutionVariable> variables = new List<DmnExecutionVariable>();
        /// <summary>
        /// List of result variables
        /// </summary>
        public IReadOnlyList<DmnExecutionVariable> Variables => variables;
        /// <summary>
        /// Capture of the rule that matched this decision
        /// </summary>
        public List<DmnDecisionTableRule> MatchedRules { get; internal set; } = new List<DmnDecisionTableRule>();
        /// <summary>
        /// Add result variable into the decision result
        /// </summary>
        /// <param name="instance">Single decision result</param>
        /// <param name="variable">Result variable to add</param>
        /// <returns>Decision result</returns>
        /// <exception cref="ArgumentException"><paramref name="instance"/> or <paramref name="variable"/> is null</exception>
        public static DmnDecisionSingleResult operator +(DmnDecisionSingleResult instance, DmnExecutionVariable variable)
        {
            if (instance == null) throw new ArgumentNullException(nameof(instance));
            if (variable == null) throw new ArgumentNullException(nameof(variable));

            instance.variables.Add(variable);

            return instance;
        }

    }
}
