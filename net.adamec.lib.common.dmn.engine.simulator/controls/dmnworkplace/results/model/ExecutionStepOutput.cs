using System;
using net.adamec.lib.common.dmn.engine.engine.decisions.table.definition;
using net.adamec.lib.common.dmn.engine.simulator.controls.common;
using net.adamec.lib.common.dmn.engine.simulator.controls.common.compositeItems;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace.results.model;

/// <summary>
/// Single output of the decision execution
/// </summary>
public class ExecutionStepOutput
{
    /// <summary>
    /// Sequence number of the output
    /// </summary>
    public int SequenceNumber { get; }
    /// <summary>
    /// Title of the output
    /// </summary>
    public string Title => $"Output #{SequenceNumber}";
    /// <summary>
    /// Variables returned within the output (can be empty array)
    /// </summary>
    public ExecutionResultVariable[] Variables { get; }
    /// <summary>
    /// Table rules hit during the decision execution if any, otherwise an empty array
    /// </summary>
    public DmnDecisionTableRule[] HitRules { get; }
    /// <summary>
    /// Flag whether the output has any <see cref="HitRules"/>
    /// </summary>
    public bool HasHitRules => HitRules.Length > 0;

    /// <summary>
    /// Data for visualization within the <see cref="TreeViewEx"/>
    /// </summary>
    public object[] TreeViewSource { get; }

    /// <summary>
    /// CTOR
    /// </summary>
    /// <param name="sequenceNumber">Sequence number of the output</param>
    /// <param name="variables">Variables returned within the output if any, otherwise an empty array or null</param>
    /// <param name="hitRules">Table rules hit during the decision execution if any, otherwise an empty array or null</param>
    public ExecutionStepOutput(int sequenceNumber, ExecutionResultVariable[]? variables, DmnDecisionTableRule[]? hitRules)
    {
        SequenceNumber = sequenceNumber;
        Variables = variables ?? Array.Empty<ExecutionResultVariable>();
        HitRules = hitRules ?? Array.Empty<DmnDecisionTableRule>();
        TreeViewSource = new CompositeItemsHelper()
            .Add("Hit rules", HitRules, true)
            .Add("Variables", Variables, dataTemplateKey: "VariableInOutputTemplate")
            .Items
            .ToArray();
    }


    /// <inheritdoc />
    public override string ToString()
    {
        return $"{Title}, Variables count: {Variables.Length}, Hit rules count: {HitRules.Length}";
    }
}