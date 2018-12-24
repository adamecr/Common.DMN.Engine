using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace net.adamec.lib.common.dmn.engine.engine.decisions.table
{
    /// <summary>
    /// Definition of table rule
    /// </summary>
    public class DmnDecisionTableRule
    {
        /// <summary>
        /// Index (order) of the rule within the decision table
        /// </summary>
        public int Index { get; }
        /// <summary>
        /// Rule name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Optional rule description (annotation)
        /// </summary>
        public string Description { get; set; }

        ///<summary>
        /// Definition of decision table rule inputs
        /// (each input contains the input match evaluation expression and mapping to table input)
        /// </summary>
        public List<DmnDecisionTableRuleInput> Inputs { get; }
        ///<summary>
        /// Definition of decision table rule outputs
        /// (each output contains the calculation expression and mapping to table output)
        /// </summary>
        public List<DmnDecisionTableRuleOutput> Outputs { get; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="index">Index (order) of the rule within the decision table</param>
        /// <param name="name">Rule name</param>
        /// <param name="inputs">Definition of decision table rule inputs</param>
        /// <param name="outputs">Definition of decision table rule outputs</param>
        /// <param name="description">Optional rule description (annotation)</param>
        public DmnDecisionTableRule(int index, string name, List<DmnDecisionTableRuleInput> inputs, List<DmnDecisionTableRuleOutput> outputs, string description = null)
        {
            Name = name;
            Index = index;
            Inputs = inputs;
            Outputs = outputs;
            Description = description;
        }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"#{Index}:{Name} {Description}";
        }

        
    }
}
