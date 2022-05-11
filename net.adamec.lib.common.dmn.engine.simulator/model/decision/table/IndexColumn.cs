using System.Data;
using net.adamec.lib.common.dmn.engine.engine.decisions.table;
using net.adamec.lib.common.dmn.engine.parser.dto;

namespace net.adamec.lib.common.dmn.engine.simulator.model.decision.table;

/// <summary>
/// Index column of the decision table.
/// The header shows the information about the hit and aggregation policy
/// </summary>
public class IndexColumn : DataColumn
{
    /// <summary>
    /// Name of the column
    /// </summary>
    public const string Name = "Index";
    /// <summary>
    /// Caption (acronym) of the hit policy
    /// </summary>
    public string HitPolicyCaption { get; }
    /// <summary>
    /// Caption (acronym) of the aggregation policy
    /// </summary>
    public string AggregationCaption { get; }
    /// <summary>
    /// Header tool tip with info about hit and aggregation policy
    /// </summary>
    public string HeaderToolTip { get; }
    /// <summary>
    /// CTOR
    /// </summary>
    /// <param name="source">Decision table</param>
    public IndexColumn(DmnDecisionTable source)
    {
        HitPolicyCaption = GetHitPolicyCaption(source.HitPolicy);
        AggregationCaption = source.HitPolicy == HitPolicyEnum.Collect
            ? GetAggregationCaption(source.Aggregation)
            : string.Empty;
        HeaderToolTip = source.HitPolicy.ToString();
        if (source.HitPolicy == HitPolicyEnum.Collect)
        {
            HeaderToolTip += $" {source.Aggregation}";
        }

        ColumnName = Name;
        DataType = typeof(int);
        AllowDBNull = false;
        AutoIncrement = false;
        Caption = HitPolicyCaption + AggregationCaption;
        ReadOnly = true;
        Unique = true;
    }

    /// <summary>
    /// Returns caption (acronym) of the hit policy
    /// </summary>
    /// <param name="policy">Hit policy</param>
    /// <returns>Caption (acronym) of the hit policy</returns>
    private string GetHitPolicyCaption(HitPolicyEnum policy)
    {
        return policy switch
        {
            HitPolicyEnum.First => "F",
            HitPolicyEnum.Any => "A",
            HitPolicyEnum.Unique => "U",
            HitPolicyEnum.Priority => "P",
            HitPolicyEnum.Collect => "C",
            HitPolicyEnum.RuleOrder => "R",
            HitPolicyEnum.OutputOrder => "O",
            _ => "X"
        };
    }

    /// <summary>
    /// Returns caption (acronym) of the aggregation policy
    /// </summary>
    /// <param name="policy">Aggregation policy</param>
    /// <returns>Caption (acronym) of the aggregation policy</returns>
    private string GetAggregationCaption(CollectHitPolicyAggregationEnum policy)
    {
        return policy switch
        {
            CollectHitPolicyAggregationEnum.List => "Lst",
            CollectHitPolicyAggregationEnum.Sum => "Sum",
            CollectHitPolicyAggregationEnum.Min => "Min",
            CollectHitPolicyAggregationEnum.Max => "Max",
            CollectHitPolicyAggregationEnum.Count => "Cnt",
            _ => "Unk"
        };
    }

}