using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace;

/// <summary>
/// Base class for <see cref="DmnWorkspaceControl"/> providing the support for "multi control selection" of the DMN elements
/// using the <see cref="DmnWorkspaceCommands.SelectDmnElementRoutedCommand"/>
/// </summary>
public class DmnWorkspaceControlBase : UserControl
{
    /// <summary>
    /// View model command to be executed when <see cref="DmnWorkspaceCommands.SelectDmnElementRoutedCommand"/> arrives
    /// </summary>
    public static readonly DependencyProperty SelectDmnElementCommandProperty = DependencyProperty.Register(
        "SelectDmnElementCommand",
        typeof(ICommand),
        typeof(DmnWorkspaceControlBase),
        new UIPropertyMetadata(null));

    /// <summary>
    /// View model command to be executed when <see cref="DmnWorkspaceCommands.SelectDmnElementRoutedCommand"/> arrives
    /// </summary>
    public ICommand? SelectDmnElementCommand
    {
        get => (ICommand)GetValue(SelectDmnElementCommandProperty);
        set => SetValue(SelectDmnElementCommandProperty, value);
    }

    protected override void OnInitialized(EventArgs e)
    {
        base.OnInitialized(e);
        
        //Bind the SelectDmnElementRoutedCommand (receiver) to handlers
        CommandBindings.Add(new CommandBinding(DmnWorkspaceCommands.SelectDmnElementRoutedCommand, SelectDmnElementCommandExecuted, SelectDmnElementCommandCanExecute));
    }

    /// <summary>
    /// Handler of CanExecute of <see cref="DmnWorkspaceCommands.SelectDmnElementRoutedCommand"/>
    /// Calls CanExecute of <see cref="SelectDmnElementCommand"/> in view model
    /// </summary>
    /// <param name="sender">Sender</param>
    /// <param name="e">Event args, the parameter contains the selected DMN element</param>
    protected void SelectDmnElementCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
    {
        var command = SelectDmnElementCommand;
        if (command == null) return;

        e.Handled = true;
        e.CanExecute = command.CanExecute(e.Parameter);
    }

    /// <summary>
    /// Handler of Execute of <see cref="DmnWorkspaceCommands.SelectDmnElementRoutedCommand"/>
    /// Executes <see cref="SelectDmnElementCommand"/> in view model
    /// </summary>
    /// <param name="sender">Sender</param>
    /// <param name="e">Event args, the parameter contains the selected DMN element</param>
    protected void SelectDmnElementCommandExecuted(object sender, ExecutedRoutedEventArgs e)
    {
        var command = SelectDmnElementCommand;
        if (command == null) return;
        e.Handled = true;
        command.Execute(e.Parameter);
    }
}