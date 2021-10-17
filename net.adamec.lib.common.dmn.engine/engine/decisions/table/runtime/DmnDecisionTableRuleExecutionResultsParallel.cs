using System;
using System.Collections.Concurrent;
using System.Linq;
using net.adamec.lib.common.dmn.engine.engine.decisions.table.definition;
using net.adamec.lib.common.dmn.engine.engine.execution;
using net.adamec.lib.common.dmn.engine.engine.execution.context;

namespace net.adamec.lib.common.dmn.engine.engine.decisions.table.runtime
{
    /// <summary>
    /// Decision table rules execution results
    /// </summary>
    public class DmnDecisionTableRuleExecutionResultsParallel : DmnDecisionTableRuleExecutionResults
    {
        /// <summary>
        /// Internal dictionary of results per rule and output
        /// </summary>
        private readonly ConcurrentDictionary<(DmnDecisionTableRule, DmnDecisionTableRuleOutput), DmnExecutionVariable> concurrentResults =
            new ConcurrentDictionary<(DmnDecisionTableRule, DmnDecisionTableRuleOutput), DmnExecutionVariable>();

        /// <summary>
        /// Sets the <paramref name="result"/> of the single <paramref name="output"/> of the <paramref name="rule"/>.
        /// </summary>
        /// <remarks>When a result is set (updated), the hashcode of whole rule results is recalculated.</remarks>
        /// <param name="rule">Rule to set the <paramref name="result"/> for.</param>
        /// <param name="output">Output to set the <paramref name="result"/> for.</param>
        /// <param name="result">Result to set</param>
        /// <exception cref="ArgumentNullException"><paramref name="rule"/> or <paramref name="output"/> is null</exception>
        public override void SetResult(DmnDecisionTableRule rule, DmnDecisionTableRuleOutput output, DmnExecutionVariable result)
        {
            if (rule == null) throw new ArgumentNullException(nameof(rule));
            if (output == null) throw new ArgumentNullException(nameof(output));

            concurrentResults[(rule, output)] = result;
        }

        public DmnDecisionTableRuleExecutionResults FinalizeConcurrentResults()
        {
            foreach (var concurrentResult in concurrentResults)
            {
                Results[concurrentResult.Key] = concurrentResult.Value;
            }

            unchecked
            {

                var rules = Results.Keys.Select(r => r.Item1).Distinct();
                foreach (var rule in rules)
                {
                    var r = Results
                    .Where(i => i.Key.Item1 == rule)
                    .OrderBy(i => i.Key.Item2.Output.Index);

                    var hash = r.Aggregate(
                        17,
                        (current, item) =>
                            current * 23 + (item.Value?.GetHashCode() ?? 0));

                    RuleResultHashCodes.Add(rule, hash);
                }
            }

            return this;
        }

    }
}
