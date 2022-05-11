using System;
using System.Data;
using net.adamec.lib.common.dmn.engine.engine.decisions.table.definition;

namespace net.adamec.lib.common.dmn.engine.simulator.model.decision.table;

/// <summary>
/// Input column of the decision table.
/// The header shows the information about the table input
/// </summary>
public class InputColumn : DataColumn
{
    /// <summary>
    /// Prefix of the column name (numbered input)
    /// </summary>
    public const string NamePrefix = "Input";
    /// <summary>
    /// Get the column name - numbered input
    /// </summary>
    /// <param name="source">Decision table input</param>
    /// <returns>Column name</returns>
    public static string GetColumnName(DmnDecisionTableInput source) => $"{NamePrefix}{source.Index+1}";

    /// <summary>
    /// Flag whether the table input is variable
    /// </summary>
    public bool IsVariable => !IsExpression;
    /// <summary>
    /// Flag whether the table input is expression
    /// </summary>
    public bool IsExpression { get; }
    /// <summary>
    /// Name of the variable used in the table input (if the input is variable)
    /// </summary>
    public string VariableName { get; }
    /// <summary>
    /// Name of the type of variable used in the table input (if the input is variable)
    /// </summary>
    public string VariableType { get; }
    /// <summary>
    /// Expression used in the table input (if the input is expression)
    /// </summary>
    public string InputExpression { get; }

    /// <summary>
    /// List of allowed values for the input (if defined, otherwise empty array)
    /// </summary>
    public string[] AllowedValues { get; }

    /// <summary>
    /// Flag whether the input definition has the allowed values constraint
    /// </summary>
    public bool HasAllowedValues => AllowedValues.Length > 0;
    /// <summary>
    /// CTOR
    /// </summary>
    /// <param name="source">Decision table input</param>
    public InputColumn(DmnDecisionTableInput source)
    {
        ColumnName = GetColumnName(source);
        DataType = typeof(string);
        AllowDBNull = true;
        AutoIncrement = false;
        Caption = !string.IsNullOrWhiteSpace(source.Label)?source.Label:$"{NamePrefix}#{source.Index+1}";
        ReadOnly = true;
        Unique = false;
        DefaultValue = "-";

        IsExpression = !string.IsNullOrWhiteSpace(source.Expression);
        VariableName = source.Variable?.Name ?? string.Empty;
        VariableType = source.Variable?.Type?.Name ?? string.Empty;
        InputExpression = source.Expression ?? string.Empty;
        AllowedValues = source.AllowedValues ?? Array.Empty<string>();
    }
}