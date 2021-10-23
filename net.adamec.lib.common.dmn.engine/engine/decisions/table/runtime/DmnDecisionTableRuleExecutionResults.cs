using System;
using System.Collections.Generic;
using System.Linq;
using net.adamec.lib.common.dmn.engine.engine.decisions.table.definition;

using net.adamec.lib.common.dmn.engine.engine.execution.context;

namespace net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime
{
    /// <summary>
    /// Decision table rules execution results
    /// </summary>
    public class DmnDecisionTableRuleExecutionResults
    {
        /// <summary>
        /// Internal dictionary of results per rule and output
        /// </summary>
        protected readonly Dictionary<(DmnDecisionTableRule, DmnDecisionTableRuleOutput), DmnExecutionVariable> Results = new Dictionary<(DmnDecisionTableRule, DmnDecisionTableRuleOutput), DmnExecutionVariable>();
        /// <summary>
        /// Internal dictionary of rule result hashcodes (hashcode per rule)
        /// </summary>
        protected readonly Dictionary<DmnDecisionTableRule, int> RuleResultHashCodes = new Dictionary<DmnDecisionTableRule, int>();
        /// <summary>
        /// Sets the <paramref name="result"/> of the single <paramref name="output"/> of the <paramref name="rule"/>.
        /// </summary>
        /// <remarks>When a result is set (updated), the hashcode of whole rule results is recalculated.</remarks>
        /// <param name="rule">Rule to set the <paramref name="result"/> for.</param>
        /// <param name="output">Output to set the <paramref name="result"/> for.</param>
        /// <param name="result">Result to set</param>
        /// <exception cref="ArgumentNullException"><paramref name="rule"/> or <paramref name="output"/> is null</exception>
        public virtual void SetResult(DmnDecisionTableRule rule, DmnDecisionTableRuleOutput output, DmnExecutionVariable result)
        {
            if (rule == null) throw new ArgumentNullException(nameof(rule));
            if (output == null) throw new ArgumentNullException(nameof(output));

            Results[(rule, output)] = result;

            //recalc hash code for rule results
            unchecked
            {
                var hash = Results
                    .Where(item => item.Key.Item1 == rule)
                    .Aggregate(
                        17,
                        (current, item) => current * 23 + (item.Value?.GetHashCode() ?? 0));

                RuleResultHashCodes[rule] = hash;
            }

        }

        /// <summary>
        /// Gets the result for given pair <paramref name="rule"/> - <paramref name="output"/>
        /// </summary>
        /// <param name="rule">Rule to get the result for</param>
        /// <param name="output">Output to get the result for</param>
        /// <returns>Result for given pair <paramref name="rule"/> - <paramref name="output"/> or null when the result is not found or <paramref name="output"/> is null</returns>
        /// <exception cref="ArgumentNullException"><paramref name="rule"/> is null</exception>
        public DmnExecutionVariable GetResult(DmnDecisionTableRule rule, DmnDecisionTableRuleOutput output)
        {
            if (rule == null) throw new ArgumentNullException(nameof(rule));
            if (output == null) return null;

            return Results.TryGetValue((rule, output), out var retVal) ? retVal : null;
        }

        /// <summary>
        /// Gets the hashcode of <paramref name="rule"/> results
        /// </summary>
        /// <param name="rule">Rule to get the hashcode for</param>
        /// <returns>Hashcode of rule results or zero when there are not results for given <paramref name="rule"/></returns>
        /// <exception cref="ArgumentNullException"><paramref name="rule"/> is null</exception>
        public int GetResultsHashCode(DmnDecisionTableRule rule)
        {
            if (rule == null) throw new ArgumentNullException(nameof(rule));

            return RuleResultHashCodes.TryGetValue(rule, out var retVal) ? retVal : 0;
        }
    }
}