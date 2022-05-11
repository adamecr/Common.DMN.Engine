using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using net.adamec.lib.common.dmn.engine.simulator.controls.dmngraph.model;
using net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace.execute.model;
using net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace.model;
using net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace.results.model;
using net.adamec.lib.common.dmn.engine.simulator.model.decision;

namespace net.adamec.lib.common.dmn.engine.simulator.model.dummy;

/// <summary>
/// Dummy model that can be used for design time data context.
/// It uses the "dummy.dmn" in app's dmn folder as the source and executes the first decision (without any input values) to get additional data
/// </summary>
public class DummyModel
{
    /// <summary>
    /// Workspace of the dummy model (<see cref="DmnWorkspaceModel"/>)
    /// </summary>
    public static DmnWorkspaceModel Workspace { get; } = new DummyModel().workspace;

    /// <summary>
    /// Execution result Variable history array (<see cref="ExecutionResultVariableHistory"/>[])
    /// </summary>
    public static ExecutionResultVariableHistory[] VariablesHistory = Workspace.ExecutionResult.VariablesHistory;
    /// <summary>
    /// Execute view model (<see cref="ExecuteViewModel"/>)
    /// </summary>
    public static DmnExecuteViewModel ExecuteViewModel = Workspace.ExecuteViewModel;
    /// <summary>
    /// Detail view model (<see cref="DmnDecisionInfo"/> of the first decision in workspace)
    /// </summary>
    public static DmnDecisionInfo DetailViewModel = Workspace.DmnDecisionInfos[0];
    /// <summary>
    /// Graph view model (<see cref="GraphViewModel"/>)
    /// </summary>
    public static DmnGraphViewModel GraphViewModel = Workspace.Graph;

    /// <summary>
    /// Flag whether running in design time (mode) - used to check whether the app is running or it's just in designer
    /// </summary>
    public static bool IsDesignTime { get; } = DesignerProperties.GetIsInDesignMode(new DependencyObject());

    /// <summary>
    /// Workspace of the dummy model
    /// </summary>
    private readonly DmnWorkspaceModel workspace;

    /// <summary>
    /// CTOR - creates a dummy model that can be used for design time data context.
    /// It uses the "dummy.dmn" in app's dmn folder as the source and executes the first decision (without any input values) to get additional data
    /// </summary>
    private DummyModel()
    {
        var file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dmn", "dummy.dmn");
        workspace = new DmnWorkspaceModel(file);
        workspace.ExecuteViewModel.DecisionForExecution = workspace.DmnDecisionInfos[0];
        workspace.ExecuteDecision(workspace.DmnDecisionInfos[0], Array.Empty<InputVariable>());
    }
}