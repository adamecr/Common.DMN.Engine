using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using net.adamec.lib.common.dmn.engine.simulator.controls.dmngraph.algorithm;
using net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace.model;
using net.adamec.lib.common.dmn.engine.simulator.model.element;
using net.adamec.lib.common.dmn.engine.simulator.mvvm;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.dmngraph.model
{
    /// <summary>
    /// View model for <see cref="DmnGraphControl"/>
    /// </summary>
    public class DmnGraphViewModel : ViewModelBase
    {
        /// <summary>
        /// Reference to <see cref="DmnGraphLayout"/> control used to visualize DMN graph
        /// </summary>
        public DmnGraphLayout? GraphLayout { get; set; }

        /// <summary>
        /// Available layout algorithms that can be used to render the DMN graph
        /// </summary>
        public List<string> LayoutAlgorithmTypes { get; } = DmnLayoutAlgorithmFactory.Default.AlgorithmTypes.ToList();

        /// <summary>
        /// Layout algorithm used to render the DMN graph 
        /// </summary>
        private string layoutAlgorithmType = DmnLayoutAlgorithmFactory.TreeAlgorithm;

        /// <summary>
        /// Layout algorithm used to render the DMN graph 
        /// </summary>       
        public string LayoutAlgorithmType
        {
            get => layoutAlgorithmType;
            set => Change(ref layoutAlgorithmType!, value, false);
        }

        /// <summary>
        /// DMN graph to be visualized
        /// </summary>
        public DmnGraph Graph { get; }


        /// <summary>
        /// Command to be called from UI requesting the DMN graph re-layout
        /// </summary>
        private RelayCommand? graphRelayoutCommand;
        /// <summary>
        /// Command to be called from UI requesting the DMN graph re-layout
        /// </summary>
        public ICommand GraphRelayoutCommand => graphRelayoutCommand ??= new RelayCommand(GraphRelayout, _ => Graph.IsNotEmpty);
       
        /// <summary>
        /// Parent DMN Workspace
        /// </summary>
        private DmnWorkspaceModel? Workspace { get; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="workspace">Parent DMN Workspace</param>
        /// <exception cref="ArgumentNullException">Parent DMN Workspace is null</exception>
        public DmnGraphViewModel(DmnWorkspaceModel workspace)
        {
            Workspace = workspace ?? throw new ArgumentNullException(nameof(workspace));
            Graph = GenerateGraph();
        }

        /// <summary>
        /// Generates and returns the DMN graph
        /// </summary>
        /// <returns>Generated DMN graph</returns>
        private DmnGraph GenerateGraph()
        {
            var dmnDefinition = Workspace?.Definition.DmnDefinition;
            var newGraph = new DmnGraph();
            if (dmnDefinition == null) return newGraph;

            //Create vertices - decisions and inputs
            var vertices = new List<DmnElement>();
            var hasShapeBounds = false;

            foreach (var d in Workspace!.DmnDecisionInfos)
            {
                if(d.ShapeBounds!=null) hasShapeBounds=true;
                vertices.Add(d);
                newGraph.AddVertex(d);
            }

            foreach (var i in Workspace.DmnInputInfos)
            {

                if (i.ShapeBounds != null) hasShapeBounds = true;
                vertices.Add(i);
                newGraph.AddVertex(i);
            }

            //Create edges - information requirements (inputs and decisions) for all decisions
            foreach (var d in Workspace.DmnDecisionInfos)
            {
                var decision = d.GetDecision();
                if (decision == null) continue;

                //target = decisions having the information requirement
                var target = vertices.First(v => v.IsDecision && v.Name == d.Name); //should never "fail"

                //source = information requirement (decision or input)
                foreach (var rd in decision.RequiredDecisions)
                {
                    var source = vertices.FirstOrDefault(v => v.IsDecision && v.Name == rd.Name);
                    if (source != null)
                        newGraph.AddEdge(new DmnGraphEdge(source, target));
                }

                // ReSharper disable once InvertIf
                foreach (var ri in decision.RequiredInputs)
                {
                    var source = vertices.FirstOrDefault(v => v.IsInput && v.Name == ri.Name);
                    if (source != null)
                        newGraph.AddEdge(new DmnGraphEdge(source, target));
                }
            }

            if (hasShapeBounds) LayoutAlgorithmType = DmnLayoutAlgorithmFactory.DmnDiAlgorithm;
            return newGraph;
        }

        /// <summary>
        /// Re-layout the DMN graph (if exists)
        /// </summary>
        /// <param name="parameter">Command parameter - Not used so far</param>
        private void GraphRelayout(object? parameter = null)
        {
            GraphLayout?.Relayout();
        }
    }
}
