using net.adamec.lib.common.dmn.engine.simulator.controls.dmngraph.model;
using net.adamec.lib.common.dmn.engine.simulator.model.element;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.dmngraph.algorithm;

/// <summary>
/// Layout algorithm factory for DMN graph
/// </summary>
/// <remarks>Non-generic representation of <see cref="LayoutAlgorithmFactory{TVertex,TEdge,TGraph}"/> supporting the XAML binding and static property <see cref="Default"/></remarks>
public class DmnLayoutAlgorithmFactory : LayoutAlgorithmFactory<DmnElement, DmnGraphEdge, DmnGraph>
{
    /// <summary>
    /// Default DMN graph layout algorithm factory
    /// </summary>
    public static DmnLayoutAlgorithmFactory Default = new();
}