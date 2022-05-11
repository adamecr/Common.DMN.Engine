using net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace.model;
using net.adamec.lib.common.dmn.engine.simulator.model.element;
using QuikGraph;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.dmngraph.model;

/// <summary>
/// Definition of the graph for DMN containing the <see cref="DmnElement">vertices</see> for inputs and decisions and <see cref="DmnGraphEdge">edges</see> for information requirements (dependencies)
/// </summary>
public class DmnGraph : BidirectionalGraph<DmnElement, DmnGraphEdge>
{
    /// <summary>
    /// Flag whether the graph contain any vertices (is not empty)
    /// </summary>
    public bool IsNotEmpty => VertexCount > 0;

    /// <summary>
    /// CTOR - no parallel edges allowed
    /// </summary>
    public DmnGraph() :base(false){}
    
}