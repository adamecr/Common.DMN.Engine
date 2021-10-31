using System;
using System.Collections.Generic;
using System.Linq;
using net.adamec.lib.common.dmn.engine.engine.decisions.table.definition;
using net.adamec.lib.common.dmn.engine.engine.execution.context;

namespace net.adamec.lib.common.dmn.engine.engine.execution.result
{
    /// <summary>
    /// Single decision result
    /// </summary>
    public class DmnDecisionSingleResult
    {
        /// <summary>
        /// Internal list of result variables
        /// </summary>
        protected readonly List<DmnResultVariable> VariablesInternal = new List<DmnResultVariable>();
        /// <summary>
        /// List of result variables
        /// </summary>
        public IReadOnlyList<DmnResultVariable> Variables => VariablesInternal;

        /// <summary>
        /// Gets the variable by <paramref name="variableName"/>
        /// </summary>
        /// <param name="variableName">Name of the variable to retrieve</param>
        /// <returns>Variable with given <paramref name="variableName"/> or null when not found</returns>
        public DmnResultVariable this[string variableName] => Variables.FirstOrDefault(v => v.Name == variableName);

        /// <summary>
        /// Internal list of table rules with the positive hit (based on hit policy) leading to this decision result. Empty for expression decisions
        /// </summary>
        protected readonly List<DmnDecisionTableRule> HitRulesInternal = new List<DmnDecisionTableRule>();
        /// <summary>
        /// List of table rules with the positive hit (based on hit policy) leading to this decision result. Empty for expression decisions
        /// </summary>
        public IReadOnlyList<DmnDecisionTableRule> HitRules =>HitRulesInternal;

        /// <summary>
        /// CTOR
        /// </summary>
        public DmnDecisionSingleResult()
        {
            
        }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="variable">The execution variable to be added to the decision result</param>
        public DmnDecisionSingleResult (DmnExecutionVariable variable)
        {
            if (variable == null) throw new ArgumentNullException(nameof(variable));

            VariablesInternal.Add(new DmnResultVariable(variable));
        }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="variable">The execution variable to be added to the decision result</param>
        /// <param name="hitRule">The decision table rule with positive hit to be added to the decision result</param>
        public DmnDecisionSingleResult(DmnExecutionVariable variable, DmnDecisionTableRule hitRule):this(variable)

        {
            if (hitRule == null) throw new ArgumentNullException(nameof(hitRule));

            HitRulesInternal.Add(hitRule);
        }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="hitRule">The decision table rule with positive hit to be added to the decision result</param>
        public DmnDecisionSingleResult( DmnDecisionTableRule hitRule) : this()
        {
            if (hitRule == null) throw new ArgumentNullException(nameof(hitRule));

            HitRulesInternal.Add(hitRule);
        }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="variable">The execution variable to be added to the decision result</param>
        /// <param name="multipleHitRules">The decision table rules with positive hit to be added to the decision result</param>
        public DmnDecisionSingleResult(DmnExecutionVariable variable,IEnumerable<DmnDecisionTableRule> multipleHitRules) : this(variable)
        {
            if (multipleHitRules == null) throw new ArgumentNullException(nameof(multipleHitRules));

            HitRulesInternal.AddRange(multipleHitRules);
        }

        /// <summary>
        /// Add result variable into the decision result
        /// </summary>
        /// <param name="instance">Single decision result</param>
        /// <param name="variable">Execution variable to add as a result variable</param>
        /// <returns>Decision result</returns>
        /// <exception cref="ArgumentException"><paramref name="instance"/> or <paramref name="variable"/> is null</exception>
        public static DmnDecisionSingleResult operator +(DmnDecisionSingleResult instance, DmnExecutionVariable variable)
        {
            if (instance == null) throw new ArgumentNullException(nameof(instance));
            if (variable == null) throw new ArgumentNullException(nameof(variable));

            instance.VariablesInternal.Add(new DmnResultVariable(variable));

            return instance;
        }

        /// <summary>
        /// Clones the single result
        /// </summary>
        /// <returns>Cloned single result</returns>
        public virtual DmnDecisionSingleResult Clone()
        {
            var retVal = new DmnDecisionSingleResult();
            retVal.VariablesInternal.AddRange(Variables.Select(v => v.Clone()).ToList());
            retVal.HitRulesInternal.AddRange(HitRules);
            return retVal;
        }
    }
}
