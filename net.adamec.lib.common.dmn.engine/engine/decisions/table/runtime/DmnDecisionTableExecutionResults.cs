using System;
using System.Collections.Generic;
using net.adamec.lib.common.dmn.engine.engine.decisions.table.definition;
using net.adamec.lib.common.dmn.engine.engine.runtime;

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
        private readonly Dictionary<(DmnDecisionTableRule, DmnDecisionTableRuleOutput), DmnExecutionVariable> results = new Dictionary<(DmnDecisionTableRule, DmnDecisionTableRuleOutput), DmnExecutionVariable>();
        /// <summary>
        /// Internal dictionary of rule result hashcodes (hashcode per rule)
        /// </summary>
        private readonly Dictionary<DmnDecisionTableRule, int> ruleResultHashCodes = new Dictionary<DmnDecisionTableRule, int>();
        /// <summary>
        /// Sets the <paramref name="result"/> of the single <paramref name="output"/> of the <paramref name="rule"/>.
        /// </summary>
        /// <remarks>When a result is set (updated), the hashcode of whole rule results is recalculated.</remarks>
        /// <param name="rule">Rule to set the <paramref name="result"/> for.</param>
        /// <param name="output">Output to set the <paramref name="result"/> for.</param>
        /// <param name="result">Result to set</param>
        /// <exception cref="ArgumentNullException"><paramref name="rule"/> or <paramref name="output"/> is null</exception>
        public void SetResult(DmnDecisionTableRule rule, DmnDecisionTableRuleOutput output, DmnExecutionVariable result)
        {
            if (rule == null) throw new ArgumentNullException(nameof(rule));
            if (output == null) throw new ArgumentNullException(nameof(output));

            if (results.ContainsKey((rule, output)))
            {
                results[(rule, output)] = result;
            }
            else
            {
                results.Add((rule, output), result);
            }

            //recalc hash code for rule results
            unchecked
            {
                var hash = 17;
                foreach (var item in results)
                {
                    if (item.Key.Item1 == rule)
                    {
                        hash = hash * 23 + (item.Value?.GetHashCode() ?? 0);
                    }
                }

                if (ruleResultHashCodes.ContainsKey(rule))
                {
                    ruleResultHashCodes[rule] = hash;
                }
                else
                {
                    ruleResultHashCodes.Add(rule, hash);
                }
            }

        }

        /// <summary>
        /// Gets the result for given pair <paramref name="rule"/> - <paramref name="output"/>
        /// </summary>
        /// <param name="rule">Rule to get the result for</param>
        /// <param name="output">Output to get the result for</param>
        /// <returns>Result for given pair <paramref name="rule"/> - <paramref name="output"/> or null when the result is not found</returns>
        /// <exception cref="ArgumentNullException"><paramref name="rule"/> or <paramref name="output"/> is null</exception>
        public DmnExecutionVariable GetResult(DmnDecisionTableRule rule, DmnDecisionTableRuleOutput output)
        {
            if (rule == null) throw new ArgumentNullException(nameof(rule));
            if (output == null) throw new ArgumentNullException(nameof(output));

            return results.TryGetValue((rule, output), out var retVal) ? retVal : null;
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

            return ruleResultHashCodes.TryGetValue(rule, out var retVal) ? retVal : 0;
        }
    }
}
