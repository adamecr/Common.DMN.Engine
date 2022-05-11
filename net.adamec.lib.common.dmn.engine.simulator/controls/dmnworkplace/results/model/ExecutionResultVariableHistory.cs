using System.Collections.Generic;
using net.adamec.lib.common.dmn.engine.simulator.controls.common;
using net.adamec.lib.common.dmn.engine.simulator.model.element;
using net.adamec.lib.common.dmn.engine.simulator.model.variable;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace.results.model;

/// <summary>
/// Keeps the history for single variable
/// </summary>
public class ExecutionResultVariableHistory : IItemWithSelectableDmnElement
{
    /// <summary>
    /// Variable to keep the history for
    /// </summary>
    private ExecutionResultVariable Variable { get; }
    /// <summary>
    /// Name of the variable
    /// </summary>
    public string Name => Variable.Name;

    /// <summary>
    /// Label of the variable (primary for inputs)
    /// </summary>
    public string Label => Variable.Label;

    /// <summary>
    /// Name with label information in case <see cref="Label"/> is different than <see cref="Name"/>
    /// </summary>
    public string NameWithLabel => Variable.NameWithLabel;

    /// <summary>
    /// Name of the variable data type
    /// </summary>
    public string DataTypeName => Variable.DataTypeName;

    /// <summary>
    /// Flag whether the variable is input
    /// </summary>
    public bool IsInput => Variable.IsInput;

    /// <summary>
    /// Input info in case the variable <see cref="IsInput"/> otherwise null
    /// </summary>
    private DmnVariableInfo? Input => IsInput ? Variable.VariableInfo : null;

    /// <summary>
    /// Last value of the variable (at the end of execution)
    /// </summary>
    public object? LastValue => History.Count > 0 ? History[^1].Value : null;
    
    /// <summary>
    /// History of variable states during the execution steps
    /// </summary>
    public List<ExecutionResultVariable> History { get; protected init; }
    
    /// <summary>
    /// Gets the <see cref="Input"/> as the selectable element for <see cref="TreeViewEx"/>
    /// </summary>
    public DmnElement? SelectableDmnElement => Input;

#pragma warning disable CS8618
    /// <summary>
    /// CTOR
    /// </summary>
    protected ExecutionResultVariableHistory()
    {
        //DesignTime only
    }
#pragma warning restore CS8618

    /// <summary>
    /// CTOR - for step 0
    /// </summary>
    /// <param name="variable">Initial variable state</param>
    public ExecutionResultVariableHistory(ExecutionResultVariable variable)
    {
        //called for step 0
        Variable=variable;
        History = new List<ExecutionResultVariable> { variable };
    }

    /// <summary>
    /// Adds variable state for steps 1+
    /// </summary>
    /// <param name="variable"></param>
    public void Add(ExecutionResultVariable variable)
    {
        //called for step 1+
        var prev = History[^1];
        variable.SetOldValue(prev);
        History.Add(variable);
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{Name} - {History.Count} steps";
    }
}