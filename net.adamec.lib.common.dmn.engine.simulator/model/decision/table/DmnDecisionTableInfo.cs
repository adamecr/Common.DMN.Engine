using System.Data;
using System.Linq;
using net.adamec.lib.common.dmn.engine.engine.decisions;
using net.adamec.lib.common.dmn.engine.engine.decisions.table;
using net.adamec.lib.common.dmn.engine.parser.dto;

namespace net.adamec.lib.common.dmn.engine.simulator.model.decision.table
{
    /// <summary>
    /// Information about <see cref="DmnDecisionTable"/>
    /// </summary>
    public class DmnDecisionTableInfo : DmnDecisionInfo
    {
        /// <summary>
        /// Empty info
        /// </summary>
        public static DmnDecisionTableInfo Empty = new(null);
        /// <summary>
        /// Data of the decision table - rules 
        /// </summary>
        public DataTable Data { get; }
        /// <summary>
        /// Definition of the table view
        /// </summary>
        public DataView DataView { get; }

        /// <summary>
        /// Name of the hit policy
        /// </summary>
        public string HitPolicy { get; }
        /// <summary>
        /// Name of the aggregation policy
        /// </summary>
        public string AggregationPolicy { get; }
        /// <summary>
        /// Flag whether table has the aggregation policy
        /// </summary>
        public bool HasAggregationPolicy { get; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="dmnDecision">Source decision</param>
        public DmnDecisionTableInfo(IDmnDecision? dmnDecision) : base(dmnDecision)
        {
            if (dmnDecision is not DmnDecisionTable source)
            {
                Data = new DataTable("Empty");
                DataView = Data.DefaultView;
                HitPolicy = string.Empty;
                AggregationPolicy = string.Empty;
                HasAggregationPolicy = false;
                return;
            }

            HitPolicy = $"{source.HitPolicy}";
            HasAggregationPolicy = source.HitPolicy == HitPolicyEnum.Collect;
            AggregationPolicy = HasAggregationPolicy ? $"{source.Aggregation}" : string.Empty;

            var data = new DataTable(source.Name);
            data.Columns.Add(new IndexColumn(source));

            data.Columns.AddRange(source.Inputs.Select(i => new InputColumn(i)).Cast<DataColumn>().ToArray());
            data.Columns.AddRange(source.Outputs.Select(o => new OutputColumn(o)).Cast<DataColumn>().ToArray());
            
            data.Columns.Add(new OtherInfoColumn(OtherInfoColumn.RuleNameColumnName,"Rule Name"));
            data.Columns.Add(new OtherInfoColumn(OtherInfoColumn.RuleDescriptionColumnName,"Description "));

            foreach (var sourceRule in source.Rules)
            {
                var dataRow = data.NewRow();
                dataRow[IndexColumn.Name] = sourceRule.Index;


                foreach (var ruleInput in sourceRule.Inputs)
                {
                    dataRow[InputColumn.GetColumnName(ruleInput.Input)] = ruleInput.UnparsedExpression;
                }

                foreach (var ruleOutput in sourceRule.Outputs)
                {
                    dataRow[OutputColumn.GetColumnName(ruleOutput.Output)] = !string.IsNullOrWhiteSpace(ruleOutput.Expression) ? ruleOutput.Expression : "-";
                }

                dataRow[OtherInfoColumn.RuleNameColumnName] = sourceRule.Name;
                dataRow[OtherInfoColumn.RuleDescriptionColumnName] = sourceRule.Description;

                data.Rows.Add(dataRow);
            }

            InputVariableNames = source
                .Inputs
                .Where(i => !string.IsNullOrWhiteSpace(i.Variable?.Name))
                .Select(i => i.Variable.Name)
                .ToArray();
            OutputVariableNames = source
                .Outputs
                .Select(o => o.Variable.Name)
                .ToArray();
            Data = data;
            DataView = data.DefaultView;
        }
    }
}
