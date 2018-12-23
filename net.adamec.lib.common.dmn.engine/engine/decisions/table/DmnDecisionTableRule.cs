using System.Collections.Generic;

namespace net.adamec.lib.common.dmn.engine.engine.decisions.table
{
    public class DmnDecisionTableRule
    {
        public int Index { get; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<DmnDecisionTableRuleInput> Inputs { get; }
        public List<DmnDecisionTableRuleOutput> Outputs { get; }

        public DmnDecisionTableRule(int index, string name, List<DmnDecisionTableRuleInput> inputs, List<DmnDecisionTableRuleOutput> outputs, string description = null)
        {
            Name = name;
            Index = index;
            Inputs = inputs;
            Outputs = outputs;
            Description = description;
        }

        public override string ToString()
        {
            return $"#{Index}:{Name} {Description}";
        }

        
    }
}
