using System;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace.results;
using net.adamec.lib.common.dmn.engine.simulator.model.element;
using net.adamec.lib.common.dmn.engine.simulator.model.variable;
using net.adamec.lib.common.dmn.engine.simulator.mvvm;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace.execute.model;

/// <summary>
/// Information about a input variable and it's input value and state
/// </summary>
public class InputVariable : ViewModelBase, IItemWithSelectableDmnElement
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
    /// Data type of the variable
    /// </summary>
    public Type DataType => VariableInfo.DataType;

    /// <summary>
    /// Name of the variable data type
    /// </summary>
    public string DataTypeName => VariableInfo.DataTypeName;

    /// <summary>
    /// Flag whether variable <see cref="DataType"/> is know type
    /// </summary>
    public bool IsKnownDataType => KnownType.IsKnownType(DataType);

    private KnownType? selectedProxyType = KnownType.FromType(typeof(string));

    public KnownType? SelectedProxyType
    {
        get => selectedProxyType;
        set => Change(ref selectedProxyType, value, afterUpdateAction: _=>ConvertFromRaw(RawInputValue));
    }

    /// <summary>
    /// Raw input value from the user input (text box)
    /// </summary>
    private object? rawInputValue;
    /// <summary>
    /// Raw input value from the user input (text box).
    /// <remarks><see cref="ConvertFromRaw"/> is called on change to validate the input and set the <see cref="InputValue"/></remarks>
    /// </summary>
    public object? RawInputValue
    {
        get => rawInputValue;
        set => Change(ref rawInputValue, value, afterUpdateAction: ConvertFromRaw);
    }

    /// <summary>
    /// Input value converted from the user input 
    /// </summary>
    private object? inputValue;

    /// <summary>
    /// Input value converted from the user input 
    /// </summary>
    public object? InputValue
    {
        get => inputValue;
        private set => Change(ref inputValue, value);
    }

    /// <summary>
    /// Flag whether the input value is valid
    /// </summary>
    private bool isInputValueValid = true;
    /// <summary>
    /// Flag whether the input value is valid
    /// </summary>
    public bool IsInputValueValid
    {
        get => isInputValueValid;
        private set => Change(ref isInputValueValid, value);
    }

    /// <summary>
    /// Flag whether the input value is invalid
    /// </summary>
    private bool isInputValueInvalid;
    /// <summary>
    /// Flag whether the input value is invalid
    /// </summary>
    public bool IsInputValueInvalid
    {
        get => isInputValueInvalid;
        private set => Change(ref isInputValueInvalid, value);
    }

    /// <summary>
    /// Input value validation error (or empty if the value is valid)
    /// </summary>
    private string inputValueError = string.Empty;
    /// <summary>
    /// Input value validation error (or empty if the value is valid)
    /// </summary>
    public string InputValueError
    {
        get => inputValueError;
        private set => Change(ref inputValueError!, value, true);
    }

    /// <summary>
    /// Returns the <see cref="VariableInfo"/> as the selectable DMN element
    /// </summary>
    public DmnElement SelectableDmnElement => VariableInfo;

    /// <summary>
    /// CTOR
    /// </summary>
    /// <param name="variableInfo">Variable definition information</param>
    public InputVariable(DmnVariableInfo variableInfo)
    {
        VariableInfo = variableInfo;
    }

    /// <summary>
    /// Resets (clear) the input value for execution
    /// </summary>
    public void ResetInputValue()
    {
        InputValueError = string.Empty;
        IsInputValueValid = true;
        IsInputValueInvalid = false;
        InputValue = null;
        RawInputValue = null;
    }

    /// <summary>
    /// Invalidates the input value
    /// </summary>
    /// <param name="errorMessage">Validation error message</param>
    public void InvalidateInputValue(string errorMessage)
    {
        InputValueError = errorMessage;
        IsInputValueInvalid = true;
        IsInputValueValid = false;
    }

    /// <summary>
    /// Validate and converts the <see cref="InputValue"/> from given <paramref name="rawValue"/>
    /// Sets the <see cref="InputValue"/>, <see cref="IsInputValueValid"/>, <see cref="IsInputValueInvalid"/> and <see cref="inputValueError"/>
    /// </summary>
    private void ConvertFromRaw(object? rawValue)
    {
        var error = string.Empty;
        var convertedValue = rawValue;
        
        //use SelectedProxyType in ConvertFromRaw if applicable
        var dataType = DataType;
        if (!IsKnownDataType && selectedProxyType != null)
        {
            dataType = selectedProxyType.Type;
        }
        
        if (rawValue != null && rawValue.ToString() != string.Empty)
        {
            try
            {
                convertedValue = Convert.ChangeType(rawValue, dataType);
            }
            catch (Exception ex)
            {
                error =
                    $"Can't cast value to target type: {dataType.Name}. Value is: {rawValue} of type {rawValue.GetType().Name}. {ex.Message}";
            }
        }
        else
        {
            convertedValue = null;
        }

        InputValueError = error;
        IsInputValueValid = error == string.Empty;
        IsInputValueInvalid = !IsInputValueValid;
        InputValue = convertedValue;
    }
}