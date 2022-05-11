using System.Windows.Input;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace;

/// <summary>
/// Routed commands available for DMN Workspace
/// </summary>
public class DmnWorkspaceCommands
{
    /// <summary>
    /// Routed command used to inform about the DMN element selection change
    /// </summary>
    public static readonly RoutedCommand SelectDmnElementRoutedCommand = new("SelectDmnElementRoutedCommand", typeof(DmnWorkspaceCommands));
}