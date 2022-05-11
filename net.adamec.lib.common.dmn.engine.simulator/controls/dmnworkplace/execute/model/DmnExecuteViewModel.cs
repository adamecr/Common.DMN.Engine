using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace.model;
using net.adamec.lib.common.dmn.engine.simulator.model.decision;
using net.adamec.lib.common.dmn.engine.simulator.mvvm;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace.execute.model;

/// <summary>
/// View Model managing the inputs for the execution of decision
/// </summary>
public class DmnExecuteViewModel : ViewModelBase
{
    /// <summary>
    /// Information about decision for execution (if any)
    /// </summary>
    private DmnDecisionInfo? decisionForExecution;
    /// <summary>
    /// Information about decision for execution (if any)
    /// </summary>
    public DmnDecisionInfo? DecisionForExecution
    {
        get => decisionForExecution;
        set => Change(ref decisionForExecution, value, afterUpdateAction: _ =>
        {
            Workspace?.SelectElement(value);
            ReloadInputsForExecution(HasInputsForExecutionDecisionOnly);
        });
    }

    /// <summary>
    /// Inputs to be used for decision execution
    /// </summary>
    private InputVariable[] inputsForExecution = Array.Empty<InputVariable>();

    /// <summary>
    /// Inputs to be used for decision execution
    /// </summary>
    public InputVariable[] InputsForExecution
    {
        get => inputsForExecution;
        set => Change(ref inputsForExecution!, value);
    }

    /// <summary>
    /// Flag whether <see cref="InputsForExecution"/> contains only the inputs that are the information requirements for <see cref="DecisionForExecution"/>
    /// </summary>
    private bool hasInputsForExecutionDecisionOnly;
    /// <summary>
    /// Flag whether <see cref="InputsForExecution"/> contains only the inputs that are the information requirements for <see cref="DecisionForExecution"/>
    /// </summary>
    public bool HasInputsForExecutionDecisionOnly
    {
        get => hasInputsForExecutionDecisionOnly;
        set => Change(ref hasInputsForExecutionDecisionOnly, value, afterUpdateAction: ReloadInputsForExecution);
    }

    /// <summary>
    /// Command to be called to execute <see cref="DecisionForExecution"/> with <see cref="InputsForExecution"/>
    /// </summary>
    private RelayCommand? resetInputCommand;
    /// <summary>
    /// Command to be called to execute <see cref="DecisionForExecution"/> with <see cref="InputsForExecution"/>
    /// </summary>
    public ICommand ResetInputCommand => resetInputCommand ??=
        new RelayCommand(
            input => (input as InputVariable)?.ResetInputValue(),
            input => resetInputCommand != null && input is InputVariable { RawInputValue: { } });

    /// <summary>
    /// Command to be called to execute <see cref="DecisionForExecution"/> with <see cref="InputsForExecution"/>
    /// </summary>
    private RelayCommand? executeDecisionCommand;
    /// <summary>
    /// Command to be called to execute <see cref="DecisionForExecution"/> with <see cref="InputsForExecution"/>
    /// </summary>
    public ICommand ExecuteDecisionCommand => executeDecisionCommand ??=
        new RelayCommand(
            _ => ExecuteDecision(),
            _ => executeDecisionCommand != null && Workspace != null && !InputsForExecution.Any(i=>i.IsInputValueInvalid));

    /// <summary>
    /// DMN Workspace interaction interface
    /// </summary>
    private IDmnWorkspace? Workspace { get; }

    /// <summary>
    /// Information about inputs 
    /// </summary>
    private InputVariable[] AllInputInfos { get; }

    /// <summary>
    /// Information about currently selected input (if any)
    /// </summary>
    public InputVariable? SelectedInputInfo
    {
        get => AllInputInfos.FirstOrDefault(i=>i.VariableInfo==Workspace?.SelectedInputInfo);
        set => Workspace?.SelectElement(value?.VariableInfo);

    }

    /// <summary>
    /// Information about decisions in <see cref="Workspace"/>
    /// </summary>
    public DmnDecisionInfo[] DmnDecisionInfos => Workspace?.Definition.DmnDecisionInfos ?? Array.Empty<DmnDecisionInfo>();

    /// <summary>
    /// CTOR - for design time only
    /// </summary>
    public DmnExecuteViewModel()
    {
        AllInputInfos = Array.Empty<InputVariable>();
    }

    /// <summary>
    /// CTOR
    /// </summary>
    /// <param name="workspace">DMN Workspace interaction interface</param>
    /// <exception cref="ArgumentNullException">Thrown when the <paramref name="workspace"/> is null or empty</exception>
    public DmnExecuteViewModel(IDmnWorkspace workspace)
    {

        Workspace = workspace ?? throw new ArgumentNullException(nameof(workspace));
        Workspace.PropertyChanged += OnWorkspacePropertyChanged;
        AllInputInfos = Workspace.Definition.DmnInputInfos.Select(i => new InputVariable(i)).ToArray();

        if (DmnDecisionInfos.Length > 0) DecisionForExecution = DmnDecisionInfos[0];
    }

    /// <summary>
    /// Handler of Workspace.PropertyChanged event used to propagate the input selection changes
    /// </summary>
    /// <param name="sender">Event sender</param>
    /// <param name="e">Event arguments</param>
    private void OnWorkspacePropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(IDmnWorkspace.SelectedInputInfo))
        {
            OnPropertyChanged(nameof(SelectedInputInfo));
        }
    }


    /// <summary>
    /// Builds the set of the inputs for the execution (<see cref="InputsForExecution"/>) based on <see cref="DecisionForExecution"/> and <paramref name="forSelectedDecisionOnly"/> parameter
    /// </summary>
    /// <param name="forSelectedDecisionOnly">Flag whether the list should contain only the inputs required by <see cref="DecisionForExecution"/> (when true)
    /// or all <see cref="AllInputInfos"/> (when false)</param>
    private void ReloadInputsForExecution(bool forSelectedDecisionOnly)
    {
        var newList = new List<InputVariable>();
        if (forSelectedDecisionOnly == false)
        {
            newList.AddRange(AllInputInfos);
        }
        else
        {
            if (decisionForExecution != null)
            {
                var decisionInputs = decisionForExecution.GetDecision()?.RequiredInputs ?? Array.Empty<IDmnVariable>();
                newList.AddRange(decisionInputs.Select(decisionInput => AllInputInfos.First(i => i.Name == decisionInput.Name)));
            }
            //else list is empty
        }

        //managed the selection when the list narrows due to forSelectedDecisionOnly toggle
        if (Workspace?.SelectedInputInfo != null)
        {
            var selectedInput = AllInputInfos.FirstOrDefault(i => i.VariableInfo == Workspace.SelectedInputInfo);
            if (selectedInput != null && !newList.Contains(selectedInput))
                //selected input is not in new list - deselect
                Workspace?.SelectElement(null);
        }

        foreach (var inputInfo in AllInputInfos.Where(v => !newList.Contains(v)))
        {
            inputInfo.ResetInputValue();
        }

        InputsForExecution = newList.ToArray();
    }

    /// <summary>
    /// Execute the <see cref="DecisionForExecution"/> with <see cref="InputsForExecution"/> within the <see cref="Workspace"/>
    /// </summary>
    private void ExecuteDecision()
    {
        if (Workspace != null && DecisionForExecution != null)
            Workspace?.ExecuteDecision(DecisionForExecution, InputsForExecution.ToArray());
    }
}