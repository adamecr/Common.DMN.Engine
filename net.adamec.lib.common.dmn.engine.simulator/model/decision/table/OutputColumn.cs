using System;
using System.Data;
using net.adamec.lib.common.dmn.engine.engine.decisions.table.definition;

namespace net.adamec.lib.common.dmn.engine.simulator.model.decision.table;
/// <summary>
/// Output column of the decision table.
/// The header shows the information about the table output
/// </summary>
public class OutputColumn : DataColumn
{
    /// <summary>
    /// Prefix of the column name (numbered output)
    /// </summary>
    public const string NamePrefix = "Output";
    /// <summary>
    /// Get the column name - numbered output
    /// </summary>
    /// <param name="source">Decision table output</param>
    /// <returns>Column name</returns>
    public static string GetColumnName(DmnDecisionTableOutput source) => $"{NamePrefix}{source.Index+1}";
    /// <summary>
    /// Name of the variable used in the table output
    /// </summary>
    public string VariableName { get; }
    /// <summary>
    /// Name of the type of variable used in the table output
    /// </summary>
    public string VariableType { get; }

    /// <summary>
    /// List of allowed values for the output (if defined, otherwise empty array)
    /// </summary>
    public string[] AllowedValues { get; }
    
    /// <summary>
    /// Flag whether the output definition has the allowed values constraint
    /// </summary>
    public bool HasAllowedValues => AllowedValues.Length > 0;

    /// <summary>
    /// CTOR
    /// </summary>
    /// <param name="source">Data table output</param>
    public OutputColumn(DmnDecisionTableOutput source)
    {
        ColumnName = GetColumnName(source);
        DataType = typeof(string);
        AllowDBNull = true;
        AutoIncrement = false;
        Caption = !string.IsNullOrWhiteSpace(source.Label)?source.Label:$"{NamePrefix}#{source.Index+1}";
        ReadOnly = true;
        Unique = false;


        VariableName = source.Variable?.Name ?? string.Empty;
        VariableType = source.Variable?.Type?.Name ?? string.Empty;
        AllowedValues = source.AllowedValues ?? Array.Empty<string>();
    }
}