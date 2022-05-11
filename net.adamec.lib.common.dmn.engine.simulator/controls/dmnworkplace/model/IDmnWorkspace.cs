using System.ComponentModel;
using net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace.execute.model;
using net.adamec.lib.common.dmn.engine.simulator.model;
using net.adamec.lib.common.dmn.engine.simulator.model.decision;
using net.adamec.lib.common.dmn.engine.simulator.model.element;
using net.adamec.lib.common.dmn.engine.simulator.model.variable;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace.model
{
    /// <summary>
    /// DMN Workspace interaction interface
    /// </summary>
    public interface IDmnWorkspace : INotifyPropertyChanged
    {
        /// <summary>
        /// Information about the DMN Definition managed by workspace
        /// </summary>
        DmnDefinitionInfo Definition { get; }

        /// <summary>
        /// Execute the <paramref name="decision"/> with <paramref name="inputs"/>
        /// </summary>
        void ExecuteDecision(DmnDecisionInfo decision, InputVariable[] inputs);

        /// <summary>
        /// Selects given <paramref name="element"/> in UI.
        /// </summary>
        /// <param name="element">Element to select</param>
        void SelectElement(DmnElement? element);

        /// <summary>
        /// Information about currently selected input (if any)
        /// </summary>
        DmnVariableInfo? SelectedInputInfo { get; }

    }
}
