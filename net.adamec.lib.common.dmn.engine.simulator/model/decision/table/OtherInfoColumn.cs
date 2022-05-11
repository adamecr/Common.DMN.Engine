using System;
using System.Data;

namespace net.adamec.lib.common.dmn.engine.simulator.model.decision.table;

/// <summary>
/// Column showing (non specific) information within the decision table.
/// The header shows just the caption
/// </summary>
public class OtherInfoColumn : DataColumn
{
    /// <summary>
    /// Name of the "rule name" column
    /// </summary>
    public const string RuleNameColumnName = "RuleName";
    /// <summary>
    /// Name of the "rule description" column
    /// </summary>
    public const string RuleDescriptionColumnName = "RuleDecription";

    /// <summary>
    /// CTOR
    /// </summary>
    /// <param name="name">Name of the column</param>
    /// <param name="caption">Caption (header) of the column</param>
    public OtherInfoColumn(string name,string caption)
    {
        ColumnName = name ?? throw new ArgumentNullException(nameof(name));
        DataType = typeof(string);
        AllowDBNull = true;
        AutoIncrement = false;
        Caption = string.IsNullOrWhiteSpace(caption)?ColumnName:caption;
        ReadOnly = true;
        Unique = false;
    }
}