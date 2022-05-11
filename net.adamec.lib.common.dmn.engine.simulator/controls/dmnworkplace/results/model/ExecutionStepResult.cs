using System;
using net.adamec.lib.common.dmn.engine.simulator.controls.common;
using net.adamec.lib.common.dmn.engine.simulator.controls.common.compositeItems;
using net.adamec.lib.common.dmn.engine.simulator.model.decision;
using net.adamec.lib.common.dmn.engine.simulator.model.element;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace.results.model;

/// <summary>
/// State of the execution after given <see cref="Step"/>
/// </summary>
public class ExecutionStepResult : IItemWithSelectableDmnElement
{
    /// <summary>
    /// Decision executed within the <see cref="Step"/> if not step 0 (then Decision is null)
    /// </summary>
    public DmnDecisionInfo? Decision { get; }
    /// <summary>
    /// Name of the <see cref="Decision"/> executed within the <see cref="Step"/>
    /// </summary>
    public string? DecisionName => Decision?.Name;
    /// <summary>
    /// Step of the execution (sequence)
    /// </summary>
    public int Step { get; }

    /// <summary>
    /// Result title
    /// </summary>
    private string Title => $"Step #{Step}{(string.IsNullOrWhiteSpace(DecisionName) ? "" : $" - {DecisionName}")}";

    /// <summary>
    /// Outputs of the <see cref="Decision"/> executed within the <see cref="Step"/>
    /// </summary>
    public ExecutionStepOutput[] Outputs { get; }
    /// <summary>
    /// Flag whether the <see cref="Step"/> generated any <see cref="Outputs"/>
    /// </summary>
    public bool HasOutputs => Outputs.Length > 0;

    /// <summary>
    /// All variable states at the end of the <see cref="Step"/>
    /// </summary>
    public ExecutionResultVariable[] Variables { get; }

    /// <summary>
    /// Data for visualization within the <see cref="TreeViewEx"/>
    /// </summary>
    public object[] TreeViewSource { get; }

    /// <summary>
    /// Returns the <see cref="Decision"/> as the selectable DMN element for the <see cref="TreeViewEx"/>
    /// </summary>
    public DmnElement? SelectableDmnElement => Decision;

    /// <summary>
    /// CTOR - for step 0
    /// </summary>
    /// <param name="variables">All variable states at the beginning of execution (after step 0)</param>
    public ExecutionStepResult(ExecutionResultVariable[]? variables)
        : this(null, 0, null, variables)
    {
        //Step#0 - init variables only
    }

    /// <summary>
    /// CTOR
    /// </summary>
    /// <param name="decision">Decision executed within the <paramref name="step"/></param>
    /// <param name="step">Step of the execution (sequence)</param>
    /// <param name="outputs">Outputs of the <paramref name="decision"/> executed within the <paramref name="step"/> (if any)</param>
    /// <param name="variables">ll variable states at the end of the <paramref name="step"/></param>
    public ExecutionStepResult(DmnDecisionInfo? decision, int step, ExecutionStepOutput[]? outputs, ExecutionResultVariable[]? variables)
    {
        Decision = decision;
        Step = step;

        Outputs = outputs ?? Array.Empty<ExecutionStepOutput>();
        Variables = variables ?? Array.Empty<ExecutionResultVariable>();

        TreeViewSource = new CompositeItemsHelper()
            .Add(Outputs)
            .Add("Variables", Variables)
            .Items
            .ToArray();
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{Title}, Outputs count: {Outputs.Length}, Variables count: {Variables.Length}";
    }
}