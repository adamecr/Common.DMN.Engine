using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.engine.definition.extensions;
using net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram;
using net.adamec.lib.common.dmn.engine.simulator.mvvm;
using net.adamec.lib.common.dmn.engine.utils;

namespace net.adamec.lib.common.dmn.engine.simulator.model.element;

/// <summary>
/// DMN graph vertex representing either decision or input
/// </summary>
public abstract class DmnElement : ViewModelBase
{
    public const string UnknownName = "[unknown]";
    
    /// <summary>
    /// Name of the decision or input
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Label of the decision or input
    /// </summary>
    public string Label { get; }

    /// <summary>
    /// Name with label information in case <see cref="Label"/> is different than <see cref="Name"/>
    /// </summary>
    public string NameWithLabel => DmnUtils.NameWithLabel(Name, Label);

    /// <summary>
    /// Type of the element represented by the vertex
    /// </summary>
    public virtual DmnElementTypeEnum ElementType { get; protected set; } = DmnElementTypeEnum.Unknown;

    /// <summary>
    /// Flag whether the element represents a DMN decision
    /// </summary>
    public bool IsDecision => ElementType is DmnElementTypeEnum.DecisionExpression or DmnElementTypeEnum.DecisionTable
        or DmnElementTypeEnum.DecisionUnknown;

    /// <summary>
    /// Flag whether the element represents a DMN expression decision
    /// </summary>
    public bool IsDecisionExpression => ElementType == DmnElementTypeEnum.DecisionExpression;

    /// <summary>
    /// Flag whether the element represents a DMN decision table
    /// </summary>
    public bool IsDecisionTable => ElementType == DmnElementTypeEnum.DecisionTable;

    /// <summary>
    /// Flag whether the element is variable
    /// </summary>
    public bool IsVariable => ElementType is DmnElementTypeEnum.Input or DmnElementTypeEnum.NonInputVariable;

    /// <summary>
    /// Flag whether the element is Input variable
    /// </summary>
    public bool IsInput => ElementType == DmnElementTypeEnum.Input;

    /// <summary>
    /// Flag whether the element is non-Input variable
    /// </summary>
    public bool IsNonInputVariable => ElementType == DmnElementTypeEnum.NonInputVariable;

    /// <summary>
    /// Flag whether the decision is selected in UI
    /// </summary>
    private bool isSelected;
    /// <summary>
    /// Flag whether the decision is selected in UI
    /// </summary>
    public bool IsSelected
    {
        get => isSelected;
        set => Change(ref isSelected, value);
    }

    /// <summary>
    /// Shape boundaries if exist
    /// </summary>
    public ShapeBounds? ShapeBounds { get; }

    /// <summary>
    /// CTOR
    /// </summary>
    /// <param name="element">Source DMN element</param>
    protected DmnElement(IDmnElement? element)
    {
        var name=element?.Name;
        var label=element?.Label;
        var diShape = element?.GetExtension<DiDiagramShapeExtension>();

        Name = string.IsNullOrWhiteSpace(name) ? UnknownName : name;
        Label = string.IsNullOrWhiteSpace(label)?Name:label;
        ShapeBounds = diShape!=null? new ShapeBounds { X = diShape.X, Y = diShape.Y, Width = diShape.Width, Height = diShape.Height }:null;
    }

    /// <summary>
    /// Sets the <see cref="IsSelected"/> property
    /// </summary>
    /// <param name="newIsSelected">Flag whether the decision is selected in UI</param>
    public void SetIsSelected(bool newIsSelected)
    {
        IsSelected = newIsSelected;
    }
}