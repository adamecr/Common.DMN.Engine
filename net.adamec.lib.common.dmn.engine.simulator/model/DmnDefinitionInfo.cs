using System;
using System.Linq;
using net.adamec.lib.common.dmn.engine.engine.decisions;
using net.adamec.lib.common.dmn.engine.engine.decisions.expression;
using net.adamec.lib.common.dmn.engine.engine.decisions.table;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.simulator.model.decision;
using net.adamec.lib.common.dmn.engine.simulator.model.decision.expression;
using net.adamec.lib.common.dmn.engine.simulator.model.decision.table;
using net.adamec.lib.common.dmn.engine.simulator.model.variable;
using net.adamec.lib.common.dmn.engine.simulator.mvvm;

namespace net.adamec.lib.common.dmn.engine.simulator.model
{
    /// <summary>
    /// Information about the <see cref="DmnDefinition"/>
    /// </summary>
    public class DmnDefinitionInfo:ViewModelBase
    {
        /// <summary>
        /// Title to be shown in the tab control (tab header)
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// DMN definition managed by workspace
        /// </summary>
        public DmnDefinition? DmnDefinition { get; set; }
        /// <summary>
        /// Flag whether the workspace has (valid) DMN definition
        /// </summary>
        public bool HasDmnDefinition => DmnDefinition != null;
        /// <summary>
        /// Error (if any) while loading the DMN definition
        /// </summary>
        public string? DmnDefinitionError { get; }
        /// <summary>
        /// Flag whether there is any <see cref="DmnDefinitionError"/>
        /// </summary>
        public bool HasDmnDefinitionError => !string.IsNullOrEmpty(DmnDefinitionError);
        
        /// <summary>
        /// Information about decisions in <see cref="DmnDefinition"/>
        /// </summary>
        public DmnDecisionInfo[] DmnDecisionInfos { get; }
        /// <summary>
        /// Information about variables in <see cref="DmnDefinition"/>
        /// </summary>
        public DmnVariableInfo[] DmnVariableInfos { get; }
        /// <summary>
        /// Information about inputs (input variables) in <see cref="DmnDefinition"/>
        /// </summary>
        public DmnVariableInfo[] DmnInputInfos { get; }

        /// <summary>
        /// CTOR - minimal (just set <see cref="Title"/> and the rest is empty)
        /// </summary>
        /// <param name="title">Title of the DMN definition</param>
        public DmnDefinitionInfo(string title)
        {
            Title = !string.IsNullOrWhiteSpace(title)?title: "[unknown]";
            DmnDecisionInfos = Array.Empty<DmnDecisionInfo>();
            DmnVariableInfos = Array.Empty<DmnVariableInfo>();
            DmnInputInfos = Array.Empty<DmnVariableInfo>();
            DmnDefinition=null;
            DmnDefinitionError = null;
        }

        /// <summary>
        /// CTOR - error
        /// </summary>
        /// <param name="title">Title of the DMN definition</param>
        /// <param name="error">Error while loading the DMN definition</param>
        public DmnDefinitionInfo(string title, string? error):this(title)
        {
            DmnDefinitionError=!string.IsNullOrWhiteSpace(error)?error:"[unknown error]";
        }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="title">Title of the DMN definition</param>
        /// <param name="dmnDefinition"></param>
        /// <exception cref="ArgumentNullException">When <paramref name="dmnDefinition"/> is null</exception>
        public DmnDefinitionInfo(string title, DmnDefinition dmnDefinition):this(title)
        {
            DmnDefinition = dmnDefinition ?? throw new ArgumentNullException(nameof(dmnDefinition));
            
            DmnDecisionInfos = DmnDefinition?.Decisions?.Values.Select(DecisionInfoFactory).ToArray() ?? Array.Empty<DmnDecisionInfo>();
            DmnVariableInfos = DmnDefinition?.Variables?.Values.Select(VariableInfoFactory).ToArray() ?? Array.Empty<DmnVariableInfo>();
            DmnInputInfos = DmnVariableInfos.Where(v => v.IsInput).ToArray();
        }

        /// <summary>
        /// Factory creating <see cref="DmnVariableInfo"/> from <paramref name="variable"/>.
        /// <remarks>The <see cref="DmnDecisionInfos"/> must be set before using the factory</remarks>
        /// </summary>
        /// <param name="variable">Source variable</param>
        /// <returns><see cref="DmnVariableInfo"/> from <paramref name="variable"/></returns>
        private DmnVariableInfo VariableInfoFactory(IDmnVariable? variable)
        {
            var v = new DmnVariableInfo(variable, DmnDecisionInfos);
            return v;
        }

        /// <summary>
        /// Factory creating <see cref="DmnDecisionInfo"/> from <paramref name="decision"/>.
        /// </summary>
        /// <param name="decision">Source variable</param>
        /// <returns><see cref="DmnDecisionInfo"/> from <paramref name="decision"/></returns>
        private static DmnDecisionInfo DecisionInfoFactory(IDmnDecision? decision)
        {
            return decision switch
            {
                DmnDecisionTable => new DmnDecisionTableInfo(decision),
                DmnExpressionDecision => new DmnDecisionExpressionInfo(decision),
                _ => new DmnDecisionInfo(decision)
            };
        }
    }
}
