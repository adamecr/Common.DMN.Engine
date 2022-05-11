using System;
using System.Collections.Generic;
using System.Linq;
using GraphShape;
using GraphShape.Algorithms.Layout;
using net.adamec.lib.common.dmn.engine.simulator.model.element;
using QuikGraph;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.dmngraph.algorithm
{

    /// <summary>
    /// DMN DI layout algorithm.
    /// Place the vertices with the known position (within the <see cref="DmnElement.ShapeBounds"/>) as defined,
    /// place the others (without defined shape) into "lines" (rows or columns) within the bounding box defined by the <see cref="DmnDiLayoutParameters"/>
    /// </summary>
    /// <typeparam name="TVertex">Vertex type.</typeparam>
    /// <typeparam name="TEdge">Edge type.</typeparam>
    /// <typeparam name="TGraph">Graph type.</typeparam>
    public class DmnDiLayoutAlgorithm<TVertex, TEdge, TGraph> : DefaultParameterizedLayoutAlgorithmBase<TVertex, TEdge, TGraph, DmnDiLayoutParameters>
        where TVertex : DmnElement
        where TEdge : IEdge<TVertex>
        where TGraph : IVertexAndEdgeListGraph<TVertex, TEdge>
    {

        /// <summary>
        /// Vertex sizes by vertex
        /// </summary>
        private readonly IDictionary<TVertex, Size> vertexSizes;
        /// <summary>
        /// Vertices having the fixed (known) positions
        /// </summary>
        private IDictionary<TVertex, Point>? fixedPositions;

        /// <summary>
        /// Initializes a new instance of the <see cref="DmnDiLayoutAlgorithm{TVertex,TEdge,TGraph}"/> class.
        /// </summary>
        /// <param name="visitedGraph">Graph to layout.</param>
        /// <param name="verticesSizes">Vertices sizes.</param>
        /// <param name="parameters">Optional algorithm parameters.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="visitedGraph"/> is <see langword="null"/>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="verticesSizes"/> is <see langword="null"/>.</exception>
        public DmnDiLayoutAlgorithm(
             TGraph visitedGraph,
             IDictionary<TVertex, Size> verticesSizes,
             DmnDiLayoutParameters? parameters = null)
            : this(visitedGraph, null, verticesSizes, parameters)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DmnDiLayoutAlgorithm{TVertex,TEdge,TGraph}"/> class.
        /// </summary>
        /// <param name="visitedGraph">Graph to layout.</param>
        /// <param name="verticesPositions">Vertices positions.</param>
        /// <param name="verticesSizes">Vertices sizes.</param>
        /// <param name="parameters">Optional algorithm parameters.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="visitedGraph"/> is <see langword="null"/>.</exception>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="verticesSizes"/> is <see langword="null"/>.</exception>
        public DmnDiLayoutAlgorithm(
             TGraph visitedGraph,
             IDictionary<TVertex, Point>? verticesPositions,
             IDictionary<TVertex, Size> verticesSizes,
             DmnDiLayoutParameters? parameters)
            : base(visitedGraph, verticesPositions, parameters!) //HACK: parameters can be null in base, just get rid of warning
        {
            vertexSizes = new Dictionary<TVertex, Size>(verticesSizes);
        }


        #region AlgorithmBase



        /// <summary>
        /// Called on algorithm initialization step.
        /// Place the vertices with the known position (within the <see cref="DmnElement.ShapeBounds"/>)
        /// </summary>
        protected override void Initialize()
        {
            base.Initialize();

            fixedPositions = VisitedGraph.Vertices
                .Where(v => v.ShapeBounds is { })
                .ToDictionary(v => v, v => new Point(v.ShapeBounds!.X, v.ShapeBounds!.Y));

            VerticesPositions.Clear();

            foreach (var pair in fixedPositions)
            {
                VerticesPositions.Add(pair);
            }
        }

        /// <summary>
        /// Algorithm compute step
        /// Place the vertices without known position.
        /// Simply place them into "lines" (rows or columns) within the bounding box defined by the <see cref="DmnDiLayoutParameters"/>
        /// </summary>
        protected override void InternalCompute()
        {
            var x = (double)Parameters.XOffset;
            var y = (double)Parameters.YOffset;
            var width = Parameters.Width;
            var height = Parameters.Height;
            var isVertical = true;
            if (width < 1)
            {
                if (height < 1)
                {
                    width = int.MaxValue;
                }
                else
                {
                    isVertical = false;
                }
            }

            var currentLineHeight = 0.0;
            var currentLineWidth = 0.0;
            var currentLinePos = 0.0;

            foreach (var vertex in VisitedGraph.Vertices.Except(fixedPositions?.Keys ?? Array.Empty<TVertex>()))
            {
                vertexSizes.TryGetValue(vertex, out var vertexSize);

                double posX;
                double posY;
                if (isVertical)
                {
                    posX = currentLinePos;


                    var posXRight = currentLinePos + vertexSize.Width;
                    if (posXRight > width && currentLinePos > 0) //have at least one item in line
                    {
                        //new line (row)
                        y += currentLineHeight + Parameters.HorizontalSpacing; //inc offset
                        currentLinePos = 0;
                        posX = 0;
                    }

                    currentLinePos += posX + Parameters.VerticalSpacing;
                    posY = y;

                    if (currentLineHeight < vertexSize.Height) currentLineHeight = vertexSize.Height;
                }
                else
                {
                    //horizontal
                    posY = currentLinePos;
                    var posYBottom = currentLinePos + vertexSize.Height;
                    if (posYBottom > height && currentLinePos > 0)
                    {
                        //new line (column)
                        x += currentLineWidth + Parameters.VerticalSpacing; //inc offset;
                        currentLinePos = 0;
                        posY = 0;
                    }

                    currentLinePos += posY + Parameters.HorizontalSpacing;
                    posX = x;

                    if (currentLineWidth < vertexSize.Width) currentLineWidth = vertexSize.Width;
                }

                VerticesPositions[vertex] = new Point(posX, posY);
            }
        }

        #endregion
    }
}
