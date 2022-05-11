using System;
using System.Windows;
using System.Windows.Input;
using GraphShape.Controls;
using net.adamec.lib.common.dmn.engine.simulator.controls.dmngraph.algorithm;
using net.adamec.lib.common.dmn.engine.simulator.controls.dmngraph.model;
using net.adamec.lib.common.dmn.engine.simulator.model.element;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.dmngraph;

/// <summary>
/// Control used to render DMN model graph (decisions and inputs only)
/// </summary>
public class DmnGraphLayout : GraphLayout<DmnElement, DmnGraphEdge, DmnGraph>
{
    /// <summary>
    /// Reference to itself (DMN graph control)
    /// </summary>
    public DmnGraphLayout SelfRef
    {
        get => (DmnGraphLayout)GetValue(SelfRefProperty);
        set => SetValue(SelfRefProperty, value);
    }

    /// <summary>
    /// Dependency property referencing the control - can be bound to MVVM model allowing the model to call the control methods
    /// </summary>
    public static readonly DependencyProperty SelfRefProperty = DependencyProperty.Register(
        "SelfRef",
        typeof(DmnGraphLayout),
        typeof(DmnGraphLayout),
        new PropertyMetadata(null));

    /// <summary>
    /// Command to be executed when an element (Decision or Input) is clicked within the graph
    /// </summary>
    public ICommand? ElementClickCommand
    {
        get => (ICommand)GetValue(ElementClickCommandProperty);

        set => SetValue(ElementClickCommandProperty, value);
    }

    /// <summary>
    /// Dependency property for Command to be executed when an element (Decision or Input) is clicked within the graph
    /// </summary>
    public static DependencyProperty ElementClickCommandProperty = DependencyProperty.Register(
            "ElementClickCommand",
            typeof(ICommand),
            typeof(DmnGraphLayout));

    /// <summary>
    /// CTOR - needed by XAML designer
    /// </summary>
    public DmnGraphLayout()
    {
        LayoutAlgorithmFactory = DmnLayoutAlgorithmFactory.Default;
    }

    /// <summary>
    /// OnInitialized event handler - used to set the reference to itself
    /// </summary>
    /// <param name="e">Event args</param>
    protected override void OnInitialized(EventArgs e)
    {
        base.OnInitialized(e);

        SelfRef = this;
    }

    /// <summary>
    /// Creates <see cref="VertexControl"/> from <see cref="DmnElement"/> vertex
    /// and adds <see cref="DmnElementClickHandler"/> to the <see cref="VertexControl.PreviewMouseDown"/>
    /// to handle the element selection by sending the <see cref="ElementClickCommand"/>.
    /// </summary>
    /// <param name="vertex"><see cref="DmnElement"/> vertex to present</param>
    /// <returns>Created <see cref="VertexControl"/></returns>
    protected override VertexControl CreateVertexControl(DmnElement vertex)
    {
        var control = base.CreateVertexControl(vertex);
        control.PreviewMouseDown += DmnElementClickHandler;
        return control;
    }

    /// <summary>
    /// Removes <see cref="VertexControl"/> for <see cref="DmnElement"/> vertex from layout
    /// and clears <see cref="DmnElementClickHandler"/> from the <see cref="VertexControl.PreviewMouseDown"/>
    /// </summary>
    /// <param name="vertex"><see cref="DmnElement"/> vertex to remove</param>
    protected override void RemoveVertexControl(DmnElement vertex)
    {
        if (VerticesControls.TryGetValue(vertex, out var control) && control != null)
        {
            control.PreviewMouseDown -= DmnElementClickHandler;
        }
        base.RemoveVertexControl(vertex);
    }

    /// <summary>
    /// Handle mouse click to <see cref="VertexControl"/> - sends the <see cref="ElementClickCommand"/>
    /// This is used to select the element on click
    /// </summary>
    /// <param name="sender">Clicked control</param>
    /// <param name="e">Event argument</param>
    private void DmnElementClickHandler(object sender, MouseButtonEventArgs e)
    {
        if (sender is VertexControl { Vertex: DmnElement element } &&
            // ReSharper disable once ConstantConditionalAccessQualifier
            (ElementClickCommand?.CanExecute(element) ?? false))
        {
            ElementClickCommand?.Execute(element);
        }
    }
}