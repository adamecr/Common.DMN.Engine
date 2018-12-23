using System.Collections.Generic;
using net.adamec.lib.common.dmn.engine.engine.runtime;

namespace net.adamec.lib.common.dmn.engine.engine.decisions.table
{
    public class DmnDecisionTableRuleExecutionResults
    {
        private readonly Dictionary<(DmnDecisionTableRule, DmnDecisionTableRuleOutput), DmnExecutionVariable> results = new Dictionary<(DmnDecisionTableRule, DmnDecisionTableRuleOutput), DmnExecutionVariable>();
        private readonly Dictionary<DmnDecisionTableRule, int> ruleResultHashCodes=new Dictionary<DmnDecisionTableRule, int>();
        public void SetResult(DmnDecisionTableRule rule, DmnDecisionTableRuleOutput output, DmnExecutionVariable result)
        {
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
                    ruleResultHashCodes.Add(rule,hash);
                }
            }
           
        }

        public DmnExecutionVariable GetResult(DmnDecisionTableRule rule, DmnDecisionTableRuleOutput output)
        {
            return results.ContainsKey((rule, output)) ? results[(rule, output)] : null;
        }

        public int GetResultsHashCode(DmnDecisionTableRule rule)
        {
            return ruleResultHashCodes[rule];
        }
    }
}
