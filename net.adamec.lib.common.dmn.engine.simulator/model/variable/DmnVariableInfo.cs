using System;
using System.Linq;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.simulator.model.decision;
using net.adamec.lib.common.dmn.engine.simulator.model.element;

namespace net.adamec.lib.common.dmn.engine.simulator.model.variable;

/// <summary>
/// Information about the DMN decision 
/// </summary>
public class DmnVariableInfo : DmnElement
{
    public static DmnVariableInfo DesignTime = new(null, null)
    {
        elementType = DmnElementTypeEnum.Input
    };

    /// <summary>
    /// Variable definition
    /// </summary>
    private IDmnVariable? Source { get; }

    /// <summary>
    /// Type of the variable (input, non-input)
    /// </summary>
    private DmnElementTypeEnum elementType;

    /// <summary>
    /// Type of the variable (input, non-input)
    /// </summary>
    public override DmnElementTypeEnum ElementType => elementType;

    /// <summary>
    /// Data type of the variable
    /// </summary>
    public Type DataType { get; }
    /// <summary>
    /// Name of the data type of the variable
    /// </summary>
    public string DataTypeName => KnownType.NameFromType(DataType) ?? DataType.Name;

  
    /// <summary>
    /// Decisions the variable is (direct) input for
    /// </summary>
    public DmnDecisionInfo[] IsInputFor { get; } = Array.Empty<DmnDecisionInfo>();
    /// <summary>
    /// Decisions the variable is output of
    /// </summary>
    public DmnDecisionInfo[] IsOutputOf { get; } = Array.Empty<DmnDecisionInfo>();

    /// <summary>
    /// CTOR
    /// </summary>
    /// <param name="dmnVariable">Variable definition</param>
    /// <param name="decisions">Decision infos</param>
    public DmnVariableInfo(IDmnVariable? dmnVariable, DmnDecisionInfo[]? decisions) : base(dmnVariable)
    {
        DataType = dmnVariable?.Type ?? typeof(object);
        
        if (dmnVariable is null)
        {
            elementType = DmnElementTypeEnum.Unknown;
        }
        else if (dmnVariable.IsInputParameter)
        {
            elementType = DmnElementTypeEnum.Input;
        }
        else
        {
            elementType = DmnElementTypeEnum.NonInputVariable;
        }
        

        Source = dmnVariable;

        if (decisions == null) return;
        IsInputFor = decisions.Where(d => d.InputVariableNames.Contains(Name)).ToArray();
        IsOutputOf = decisions.Where(d => d.OutputVariableNames.Contains(Name)).ToArray();

    }

    /// <summary>
    /// Gets the variable definition
    /// </summary>
    /// <returns></returns>
    public IDmnVariable? GetVariable() => Source;
    
}