using System;
using System.Linq;
using net.adamec.lib.common.dmn.engine.engine.decisions;
using net.adamec.lib.common.dmn.engine.engine.decisions.expression;
using net.adamec.lib.common.dmn.engine.engine.decisions.table;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.simulator.model.element;
using net.adamec.lib.common.dmn.engine.utils;

namespace net.adamec.lib.common.dmn.engine.simulator.model.decision;

/// <summary>
/// Information about the DMN decision 
/// </summary>
public class DmnDecisionInfo : DmnElement
{
    /// <summary>
    /// Type of the decision
    /// </summary>
    private readonly DmnElementTypeEnum decisionType;

    /// <summary>
    /// Type of the decision
    /// </summary>
    public override DmnElementTypeEnum ElementType => decisionType;
    /// <summary>
    /// Reference to decision definition
    /// </summary>
    /// <remarks>Private as it should not be used in bindings, use <see cref="GetDecision"/> method if needed in model</remarks>
    protected IDmnDecision? Source { get; }

    /// <summary>
    /// Names of the input variables (if any, otherwise empty)
    /// </summary>
    public string[] InputVariableNames { get; protected set; } = Array.Empty<string>();
    /// <summary>
    /// Names of the output variables (if any, otherwise empty)
    /// </summary>
    public string[] OutputVariableNames { get; protected set; } = Array.Empty<string>();

    /// <summary>
    /// List of names/labels of the directly required Inputs
    /// </summary>
    public string[] RequiredInputsDirect { get; } = Array.Empty<string>();
    /// <summary>
    /// List of names/labels of the directly required Decisions
    /// </summary>
    public string[] RequiredDecisionsDirect { get; } = Array.Empty<string>();
    /// <summary>
    /// List of names/labels of the indirectly required Inputs
    /// </summary>
    public string[] RequiredInputsIndirect { get; } = Array.Empty<string>();

    /// <summary>
    /// List of names/labels of the indirectly required Decisions
    /// </summary>
    public string[] RequiredDecisionsIndirect { get; } = Array.Empty<string>();

    /// <summary>
    /// CTOR
    /// </summary>
    /// <param name="dmnDecision">Decision definition</param>
    public DmnDecisionInfo(IDmnDecision? dmnDecision) : base(dmnDecision)
    {
        decisionType = dmnDecision switch
        {
            DmnDecisionTable => DmnElementTypeEnum.DecisionTable,
            DmnExpressionDecision => DmnElementTypeEnum.DecisionExpression,
            _ => DmnElementTypeEnum.DecisionUnknown
        };
        Source = dmnDecision;
        if (dmnDecision == null) return;

        RequiredInputsDirect = dmnDecision
            .RequiredInputs
            .Select(i => DmnUtils.NameWithLabel(i.Name, i.Label))
            .ToArray();
        RequiredDecisionsDirect = dmnDecision
            .RequiredDecisions
            .Select(i => DmnUtils.NameWithLabel(i.Name, i.Label))
            .ToArray();
        RequiredInputsIndirect = dmnDecision
            .GetAllRequiredInputs()
            .Except(dmnDecision.RequiredInputs ?? Array.Empty<IDmnVariable>())
            .Select(i => DmnUtils.NameWithLabel(i.Name, i.Label))
            .ToArray();
        RequiredDecisionsIndirect = dmnDecision
            .GetAllRequiredDecisions()
            .Except(dmnDecision.RequiredDecisions ?? Array.Empty<IDmnDecision>())
            .Select(i => DmnUtils.NameWithLabel(i.Name, i.Label))
            .ToArray();
    }

    /// <summary>
    /// Gets the decision definition
    /// </summary>
    /// <returns></returns>
    public IDmnDecision? GetDecision() => Source;

    /// <summary>
    /// Returns the string that represents the current object
    /// </summary>
    /// <returns>String that represents the current object</returns>
    public override string ToString()
    {
        return NameWithLabel;
    }
}