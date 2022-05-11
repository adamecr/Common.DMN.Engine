using net.adamec.lib.common.dmn.engine.simulator.controls.common;
using net.adamec.lib.common.dmn.engine.simulator.model.element;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace.results;

/// <summary>
/// Interface for element of <see cref="TreeViewEx"/> that represent the DMN element that can be selected (in other controls)
/// </summary>
public interface IItemWithSelectableDmnElement
{
    /// <summary>
    /// Provide the selected DMN element
    /// </summary>
    public DmnElement? SelectableDmnElement { get; }
}