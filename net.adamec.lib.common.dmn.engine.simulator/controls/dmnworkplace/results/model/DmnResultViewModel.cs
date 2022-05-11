using System;
using System.Linq;
using net.adamec.lib.common.dmn.engine.simulator.model.dummy;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace.results.model;

/// <summary>
/// Execution result model
/// </summary>
public class DmnResultViewModel
{
    /// <summary>
    /// Empty result
    /// </summary>
    public static DmnResultViewModel Empty = new();

    /// <summary>
    /// Flag whether the result was created during the execution of decision
    /// </summary>
    public bool IsExecuted { get; }
  
    /// <summary>
    /// Name of the executed decision
    /// </summary>
    public string DecisionName { get; }
    /// <summary>
    /// Flag whether the execution was successful 
    /// </summary>
    public bool IsSuccess { get; }
    /// <summary>
    /// Flag whether the execution ended with error
    /// </summary>
    public bool HasError => !IsSuccess;
    /// <summary>
    /// Execution error message (empty on success)
    /// </summary>
    public string ErrorMessage { get; }

    /// <summary>
    /// Execution steps from the snapshot
    /// </summary>
    public ExecutionStepResult[] Steps { get; }
    /// <summary>
    /// Output of the execution - the last step from the snapshot
    /// </summary>
    public ExecutionStepResult? Output => HasOutput ? Steps[^1] : null;
    /// <summary>
    /// Flag whether the execution result has any output
    /// </summary>
    public bool HasOutput => Steps.Length > 0;

    /// <summary>
    /// History log of the individual variables
    /// </summary>
    public ExecutionResultVariableHistory[] VariablesHistory { get; }

    /// <summary>
    /// CTOR - for an empty result and design time
    /// </summary>
    public DmnResultViewModel()
    {
        IsExecuted = false;
        DecisionName = string.Empty;
        ErrorMessage = string.Empty;
        Steps = Array.Empty<ExecutionStepResult>();
        VariablesHistory = Array.Empty<ExecutionResultVariableHistory>();

        if (DummyModel.IsDesignTime)
        {
            var dummy = DummyModel.Workspace.ExecutionResult;
            IsExecuted = dummy.IsExecuted;
            IsSuccess = dummy.IsSuccess;
            DecisionName = dummy.DecisionName;
            ErrorMessage = dummy.ErrorMessage;
            Steps = dummy.Steps.ToArray();
            VariablesHistory = dummy.VariablesHistory.ToArray();
        }
    }

    /// <summary>
    /// CTOR - for error during the execution
    /// </summary>
    /// <param name="decisionName"></param>
    /// <param name="errorMessage">Execution error message</param>
    public DmnResultViewModel(string decisionName, string errorMessage)
        : this(decisionName, false, errorMessage, null, null)
    {

    }

    /// <summary>
    /// CTOR - for successful execution
    /// </summary>
    /// <param name="decisionName">Name of the executed decision</param>
    /// <param name="steps">Execution steps from the snapshot</param>
    /// <param name="variablesHistory">History log of the individual variables</param>
    public DmnResultViewModel(string decisionName, ExecutionStepResult[] steps, ExecutionResultVariableHistory[] variablesHistory)
        : this(decisionName, true, null, steps, variablesHistory)
    {

    }

    /// <summary>
    /// CTOR - internal implementation
    /// </summary>
    /// <param name="decisionName">Name of the executed decision</param>
    /// <param name="isSuccess">Flag whether the execution was successful</param>
    /// <param name="errorMessage">Execution error message</param>
    /// <param name="steps">Execution steps from the snapshot</param>
    /// <param name="variablesHistory">History log of the individual variables</param>
    private DmnResultViewModel(string decisionName, bool isSuccess, string? errorMessage, ExecutionStepResult[]? steps, ExecutionResultVariableHistory[]? variablesHistory)
    {
        IsExecuted = true;
        DecisionName = decisionName;
        IsSuccess = isSuccess;
        ErrorMessage = errorMessage ?? string.Empty;
        Steps = steps ?? Array.Empty<ExecutionStepResult>();
        VariablesHistory = variablesHistory ?? Array.Empty<ExecutionResultVariableHistory>();
    }
}