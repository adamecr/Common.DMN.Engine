using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using net.adamec.lib.common.dmn.engine.engine.execution.context;
using net.adamec.lib.common.dmn.engine.simulator.controls.dmngraph.model;
using net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace.execute.model;
using net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace.results.model;
using net.adamec.lib.common.dmn.engine.simulator.model;
using net.adamec.lib.common.dmn.engine.simulator.model.decision;
using net.adamec.lib.common.dmn.engine.simulator.model.element;
using net.adamec.lib.common.dmn.engine.simulator.model.variable;
using net.adamec.lib.common.dmn.engine.simulator.mvvm;
using net.adamec.lib.common.dmn.engine.simulator.service;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace.model;

/// <summary>
/// Model for DMN workspace (single tab content for work with the DMN model)
/// </summary>
public class DmnWorkspaceModel : ViewModelBase, IDmnWorkspace
{
    /// <summary>
    /// Information about the DMN Definition managed by workspace
    /// </summary>
    public DmnDefinitionInfo Definition { get; }

    /// <summary>
    /// Title to be shown in the tab control (tab header)
    /// </summary>
    public string Title => Definition.Title;

    /// <summary>
    /// Information about decisions in <see cref="DmnDefinitionInfo"/>
    /// </summary>
    public DmnDecisionInfo[] DmnDecisionInfos => Definition.DmnDecisionInfos;

    /// <summary>
    /// Information about variables in <see cref="DmnDefinitionInfo"/>
    /// </summary>
    public DmnVariableInfo[] DmnVariableInfos => Definition.DmnVariableInfos;

    /// <summary>
    /// Information about inputs (input variables) in <see cref="DmnDefinitionInfo"/>
    /// </summary>
    public DmnVariableInfo[] DmnInputInfos => Definition.DmnInputInfos;

    /// <summary>
    /// Flag whether the workspace has (valid) DMN definition
    /// </summary>
    public bool HasDmnDefinition => Definition.HasDmnDefinition;

    /// <summary>
    /// Error (if any) while loading the DMN definition
    /// </summary>
    public string? DmnDefinitionError => Definition.DmnDefinitionError;

    /// <summary>
    /// Flag whether there is any <see cref="DmnDefinitionError"/>
    /// </summary>
    public bool HasDmnDefinitionError => Definition.HasDmnDefinitionError;

    #region Execution input
    /// <summary>
    /// DMN execution inputs view model
    /// </summary>
    private DmnExecuteViewModel executeViewModel;

    /// <summary>
    /// DMN execution inputs view model
    /// </summary>
    public DmnExecuteViewModel ExecuteViewModel
    {
        get => executeViewModel;
        set => Change(ref executeViewModel!, value);
    }
    #endregion

    #region Execution result
    /// <summary>
    /// Result of the decision execution
    /// </summary>
    private DmnResultViewModel executionResult = DmnResultViewModel.Empty;
    /// <summary>
    /// Result of the decision execution
    /// </summary>
    public DmnResultViewModel ExecutionResult
    {
        get => executionResult;
        set => Change(ref executionResult!, value);
    }
    #endregion
    #region Graph

    /// <summary>
    /// DMN graph view model
    /// </summary>
    private DmnGraphViewModel graph;

    /// <summary>
    /// DMN graph view model
    /// </summary>
    public DmnGraphViewModel Graph
    {
        get => graph;
        set => Change(ref graph!, value);
    }

    #endregion
    #region UI controls integration properties
    //SelectedElementInfo is the master for others so it updates all Selected.... backing fields and do the notifications
    //Other Selected... properties just set the SelectedElementInfo property as well as the SelectElement method

    /// <summary>
    /// Information about currently selected DMN Element (if any)
    /// </summary>
    private DmnElement? selectedElementInfo;

    /// <summary>
    /// Information about currently selected DMN Element (if any)
    /// </summary>
    public DmnElement? SelectedElementInfo
    {
        get => selectedElementInfo;
        set
        {
            if (selectedElementInfo == value) return;
            OnSelectedElementChange(selectedElementInfo, value);
        }
    }

    /// <summary>
    /// Information about currently selected decision (if any)
    /// </summary>
    private DmnDecisionInfo? selectedDecisionInfo;
    /// <summary>
    /// Information about currently selected decision (if any)
    /// </summary>
    public DmnDecisionInfo? SelectedDecisionInfo
    {
        get => selectedDecisionInfo;
        set => SelectedElementInfo = value;
    }

    /// <summary>
    /// Information about currently selected input (if any)
    /// </summary>
    private DmnVariableInfo? selectedInputInfo;

    /// <summary>
    /// Information about currently selected input (if any)
    /// </summary>
    public DmnVariableInfo? SelectedInputInfo
    {
        get => selectedInputInfo;
        set => SelectedElementInfo = value;
    }

    /// <summary>
    /// Information about currently selected variable (if any)
    /// </summary>
    private DmnVariableInfo? selectedVariableInfo;

    /// <summary>
    /// Information about currently selected variable (if any)
    /// </summary>
    public DmnVariableInfo? SelectedVariableInfo
    {
        get => selectedVariableInfo;
        set => SelectedElementInfo = value;
    }

    /// <summary>
    /// Information about decision shown in detail (if any)
    /// </summary>
    private DmnDecisionInfo? detailDecisionInfo;
    /// <summary>
    /// Information about decision  shown in detail(if any)
    /// </summary>
    public DmnDecisionInfo? DetailDecisionInfo
    {
        get => detailDecisionInfo;
        set => SelectedElementInfo = value;
    }


    //SelectDmnElement Command flow:
    //DmnWorkspaceCommands.SelectDmnElementRoutedCommand - the routed command to be used "from children to workspace". It's just "a message"
    //DmnWorkspaceViewModel.SelectDmnElementRelayCommand
    // - executes the relay command
    //DmnWorkspaceControlBase - defines a "proxy" between routed and relay commands
    // - defines SelectDmnElementCommand dependency property that can (will) be bound to DmnWorkspaceViewModel.SelectDmnElementRelayCommand
    // - defines the handlers for SelectDmnElementCommandCanExecute and SelectDmnElementCommandExecute - it will execute the command of SelectDmnElementCommand dependency property ("send" the relay command)
    // - defines the CommandBinding for DmnWorkspaceCommands.SelectDmnElementRoutedCommand to the handlers SelectDmnElementCommandCanExecute/SelectDmnElementCommandExecute allowing to receive the routed command
    // DmnWorkspaceControl (XAML) - "configures" the target where to send the relay command when SelectDmnElementRoutedCommand is receiver
    // - sets the relay command target: defines the Binding between the SelectDmnElementCommand property and DmnWorkspaceViewModel.SelectDmnElementRelayCommand

    /// <summary>
    /// Command to be called from UI requesting the update of DMN Element selection
    /// </summary>
    private RelayCommand? selectDmnElementRelayCommand;
    /// <summary>
    /// Command to be called from UI requesting the update of DMN Element selection
    /// </summary>
    public ICommand SelectDmnElementCommand => selectDmnElementRelayCommand ??= new RelayCommand(p => SelectElement(p as DmnElement));
    #endregion


    /// <summary>
    /// CTOR
    /// </summary>
    /// <param name="fileFullName">Full path to the DMN file</param>
    /// <exception cref="ArgumentNullException">Thrown when the <paramref name="fileFullName"/> is null or empty</exception>
    public DmnWorkspaceModel(string fileFullName)
    {
        if (string.IsNullOrWhiteSpace(fileFullName)) throw new ArgumentNullException(nameof(fileFullName));
        Definition = DmnService.GetDmnDefinitionInfo(fileFullName);

        executeViewModel = new DmnExecuteViewModel(this);

        //Generate DMN graph
        graph = GenerateGraph();

    }

    /// <summary>
    /// Execute the <paramref name="decision"/> with <paramref name="inputs"/> and build the <see cref="ExecutionResult"/>
    /// </summary>
    /// <param name="decision">Decision to execute</param>
    /// <param name="inputs">Inputs for the execution</param>
    public void ExecuteDecision(DmnDecisionInfo decision, InputVariable[] inputs)
    {
        var errorMessageBuilder = new StringBuilder();
        var executedSuccessfully = true;
        DmnExecutionSnapshots? snapshots = null;

        //is there any decision to execute?
        // ReSharper disable once ConditionalAccessQualifierIsNonNullableAccordingToAPIContract
        if (string.IsNullOrWhiteSpace(decision?.Name) || Definition.DmnDefinition is null)
        {
            errorMessageBuilder.AppendLine($"There is no decision to execute");
            executedSuccessfully = false;
        }

        if (executedSuccessfully)
        {
            if (!DmnService.ExecuteDecision(
                    Definition.DmnDefinition!,
                    decision!.Name,
                    inputs,
                    out snapshots,
                    out var executionError))
            {
                executedSuccessfully = false;
                errorMessageBuilder.Append(executionError);//should already have EoL
            }
        }

        //set the execution results
        ExecutionResult = DmnResultViewModel.Empty;
        DmnResultViewModel? newExecutionResult;
        if (executedSuccessfully)
        {
            var stepResults = new List<ExecutionStepResult>();
            foreach (var executionSnapshot in snapshots!.Snapshots)
            {
                var step = executionSnapshot.Step;
                var stepDecisionName = executionSnapshot.DecisionName;
                var stepDecision = DmnDecisionInfos.FirstOrDefault(d => d.Name == stepDecisionName);

                var stepVariables = (
                    from resultVariable in executionSnapshot.Variables
                    let name = resultVariable.Name
                    let value = resultVariable.Value
                    let type = resultVariable.Type
                    let variableInfoRef = DmnVariableInfos.First(v => v.Name == name)
                    select new ExecutionResultVariable(variableInfoRef, step, stepDecision, value))
                    .ToArray();

                ExecutionStepResult stepResult;
                if (step == 0)
                {
                    stepResult = new ExecutionStepResult(stepVariables);
                }
                else
                {
                    var outputs = new List<ExecutionStepOutput>();
                    foreach (var singleResult in executionSnapshot.DecisionResult.Results)
                    {
                        var seq = outputs.Count + 1;
                        var outputVariables = (
                            from singleResultVariable in singleResult.Variables
                            let decisionRef = DmnDecisionInfos.First(d => d.Name == stepDecisionName)
                            let variableInfoRef = DmnVariableInfos.First(vi => vi.Name == singleResultVariable.Name)
                            select new ExecutionResultVariable(variableInfoRef, step, decisionRef, singleResultVariable.Value))
                            .ToArray();


                        var output = new ExecutionStepOutput(seq, outputVariables, singleResult.HitRules.ToArray());
                        outputs.Add(output);
                    }
                    stepResult = new ExecutionStepResult(stepDecision, executionSnapshot.Step, outputs.ToArray(), stepVariables);
                }
                stepResults.Add(stepResult);
            }

            //variables history
            var variablesHistory = new List<ExecutionResultVariableHistory>();
            if (stepResults.Count > 0)
            {
                var varDict = new Dictionary<string, ExecutionResultVariableHistory>();
                //step 0
                foreach (var variable in stepResults[0].Variables)
                {
                    var item = new ExecutionResultVariableHistory(variable);
                    variablesHistory.Add(item);
                    varDict.Add(item.Name, item);
                }

                if (stepResults.Count > 1)
                {
                    for (var step = 1; step < stepResults.Count; step++)
                    {
                        foreach (var variable in stepResults[step].Variables)
                        {
                            var item = varDict[variable.Name];
                            item.Add(variable);
                        }
                    }
                }
            }
            newExecutionResult = new DmnResultViewModel(decision!.Name, stepResults.ToArray(), variablesHistory.ToArray());
        }
        else
        {
            newExecutionResult = new DmnResultViewModel(decision?.Name ?? "[unknown decision]", errorMessageBuilder.ToString().TrimEnd(Environment.NewLine.ToCharArray()));
        }

        //publish result
        ExecutionResult = newExecutionResult;
    }

    /// <summary>
    /// Selects given <paramref name="element"/> in UI.
    /// "Master" property <see cref="SelectedElementInfo"/> is set
    /// (setter calls <see cref="OnSelectedElementChange"/> to process the selection change)
    /// </summary>
    /// <param name="element">Element to select</param>
    public void SelectElement(DmnElement? element)
    {
        SelectedElementInfo = element;
    }

    /// <summary>
    /// Process the change of the DMN element selection in UI.
    /// <see cref="SelectedElementInfo"/> is the master for others, <see cref="OnSelectedElementChange"/> updates all selected.... backing fields and do the notifications
    /// </summary>
    /// <param name="oldElement">Previously selected element</param>
    /// <param name="newElement">Newly selected element</param>
    private void OnSelectedElementChange(DmnElement? oldElement, DmnElement? newElement)
    {
        if (oldElement == newElement) return;//no change

        //deselect
        oldElement?.SetIsSelected(false);

        //select
        newElement?.SetIsSelected(true);

        //propagate
        var newSelectedDecisionInfo = newElement as DmnDecisionInfo;
        if (newSelectedDecisionInfo != selectedDecisionInfo)
        {
            selectedDecisionInfo = newSelectedDecisionInfo;
            OnPropertyChanged(nameof(SelectedDecisionInfo));

            if (newSelectedDecisionInfo != null)
            {
                //update detail panel in case the decision is changed otherwise keep as is
                //meaning don't update detail panel when input/variable is selected (keep the last decision still in there)
                detailDecisionInfo = selectedDecisionInfo;
                OnPropertyChanged(nameof(DetailDecisionInfo));
            }

        }

        var newSelectedVariableInfo = newElement as DmnVariableInfo;
        if (newSelectedVariableInfo != selectedVariableInfo)
        {
            selectedVariableInfo = newSelectedVariableInfo;
            OnPropertyChanged(nameof(SelectedVariableInfo));

            var newSelectedInputInfo =
                newSelectedVariableInfo == null || newSelectedVariableInfo.IsInput == false
                ? null
                : newSelectedVariableInfo;
            if (newSelectedInputInfo != selectedInputInfo)
            {
                selectedInputInfo = newSelectedInputInfo;
                OnPropertyChanged(nameof(SelectedInputInfo));
            }
        }

        //update and notify
        selectedElementInfo = newElement;
        OnPropertyChanged(nameof(SelectedElementInfo));
    }

    /// <summary>
    /// Generates the Dmn Graph and returns its view model
    /// </summary>
    /// <returns>DMN Graph view model</returns>
    private DmnGraphViewModel GenerateGraph()
    {
        return new DmnGraphViewModel(this);
    }


}