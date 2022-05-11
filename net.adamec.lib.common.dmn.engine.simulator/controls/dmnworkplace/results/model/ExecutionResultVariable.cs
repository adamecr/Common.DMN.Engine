using net.adamec.lib.common.dmn.engine.simulator.model.decision;
using net.adamec.lib.common.dmn.engine.simulator.model.element;
using net.adamec.lib.common.dmn.engine.simulator.model.variable;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace.results.model;

/// <summary>
/// Information about a variable status within the execution result
/// </summary>
public class ExecutionResultVariable : IItemWithSelectableDmnElement
{
    /// <summary>
    /// Variable definition information
    /// </summary>
    public DmnVariableInfo VariableInfo { get; }

    /// <summary>
    /// Name of the variable
    /// </summary>
    public string Name => VariableInfo.Name;

    /// <summary>
    /// Label of the variable (primary for inputs)
    /// </summary>
    public string Label => VariableInfo.Label;

    /// <summary>
    /// Name with label information in case <see cref="Label"/> is different than <see cref="Name"/>
    /// </summary>
    public string NameWithLabel => VariableInfo.NameWithLabel;

    /// <summary>
    /// Flag whether the variable is input
    /// </summary>
    public bool IsInput => VariableInfo.IsInput;

    /// <summary>
    /// Name of the variable data type
    /// </summary>
    public string DataTypeName => VariableInfo.DataTypeName;


    /// <summary>
    /// Step for which the variable is evaluated
    /// </summary>
    public int Step { get; }

    /// <summary>
    /// Decision executed in <see cref="Step"/> or null when initial step (step 0)
    /// </summary>
    public DmnDecisionInfo? Decision { get; }

    /// <summary>
    /// Name of the decision executed in <see cref="Step"/>
    /// </summary>
    public string? DecisionName => Decision?.Name;


    /// <summary>
    /// Value of the variable (as in particular <see cref="Step"/>)
    /// </summary>
    public object? Value { get; }

    /// <summary>
    /// Value of the variable at the beginning of <see cref="Step"/> (value after the previous step) if any
    /// </summary>
    public object? OldValue { get; private set; }
    /// <summary>
    /// Flag whether the value of the variable changed within the <see cref="Step"/>
    /// </summary>
    public bool IsChanged => OldValue != Value;

    
    /// <summary>
    /// Returns the <see cref="Decision"/> as the selectable DMN element for the result visualization tree
    /// </summary>
    public DmnElement? SelectableDmnElement => Decision;

    /// <summary>
    /// CTOR
    /// </summary>
    /// <param name="variableInfo">Variable definition information</param>
    /// <param name="step">Step for which the variable is evaluated</param>
    /// <param name="decision">Decision executed in <paramref name="step"/> or null when initial step (step 0)</param>
    /// <param name="value">Value of the variable as at the end of<paramref name="step"/>)</param>
    public ExecutionResultVariable(DmnVariableInfo variableInfo, int step, DmnDecisionInfo? decision, object? value)
    {
        VariableInfo = variableInfo;
        Step = step;
        Decision = decision;
        Value = value;
    }

    /// <summary>
    /// Sets the old value based on the information about the previous step
    /// </summary>
    /// <param name="previousOne">Variable state from previous state</param>
    public void SetOldValue(ExecutionResultVariable? previousOne)
    {
        OldValue = previousOne?.Value;
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{Name} ={Value ?? "[null]"} @step#{Step} {(IsChanged ? "Changed" : "Not Changed")}";
    }
}