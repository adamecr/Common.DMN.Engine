using System;
using net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace.model;
using net.adamec.lib.common.dmn.engine.simulator.model.element;
using QuikGraph;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.dmngraph.model;

/// <summary>
/// DMN graph edge representing the information requirement (dependency) between two <see cref="DmnElement">vertices</see> (input or decision)
/// </summary>
public class DmnGraphEdge : Edge<DmnElement>
{
    /// <summary>
    /// Flag whether the edge represents the input requirement
    /// </summary>
    public bool IsInputRequirement { get; }

    /// <summary>
    /// Flag whether the edge represents the decision requirement
    /// </summary>
    public bool IsDecisionRequirement => !IsInputRequirement;

    /// <summary>
    /// CTOR
    /// </summary>
    /// <param name="source">Source vertex - information requirement (input or decision)</param>
    /// <param name="target">Target vertex - decision</param>
    public DmnGraphEdge(DmnElement source, DmnElement target)
        : base(source, target)
    {
        if (source == null) throw new ArgumentNullException(nameof(source));
        if (target == null) throw new ArgumentNullException(nameof(target));
        if (!target.IsDecision) throw new ArgumentException("Target vertex must be DMN decision", nameof(target));

        IsInputRequirement = !source.IsDecision;
    }
}

