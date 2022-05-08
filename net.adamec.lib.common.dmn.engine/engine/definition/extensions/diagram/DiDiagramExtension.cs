using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram
{
    /// <summary>
    /// Extension containing the DMN DI Diagram shapes with bounds for elements in definition
    /// </summary>
    public class DiDiagramExtension : ICloneable
    {
        /// <summary>
        /// DMN DI Diagram shapes with bounds for elements in definition
        /// </summary>
        private Dictionary<IDmnElement, DiDiagramShapeExtension> shapesByElement = new Dictionary<IDmnElement, DiDiagramShapeExtension>();

        /// <summary>
        /// DMN DI Diagram shapes with bounds for elements in definition
        /// </summary>
        public Dictionary<IDmnElement, DiDiagramShapeExtension> ShapesByElement
        {
            get => shapesByElement ?? (shapesByElement = new Dictionary<IDmnElement, DiDiagramShapeExtension>());
            set => shapesByElement = value ?? new Dictionary<IDmnElement, DiDiagramShapeExtension>();
        }

        /// <inheritdoc />
        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"DI Diagram {ShapesByElement?.Count ?? 0} shapes";
        }

        /// <summary>
        /// Creates a new object that is a copy of the current instance
        /// </summary>
        /// <returns>A new object that is a copy of the current instance</returns>
        public DiDiagramExtension Clone()
        {
            return new DiDiagramExtension() { ShapesByElement = new Dictionary<IDmnElement, DiDiagramShapeExtension>(ShapesByElement) };
        }

        /// <summary>
        /// Creates a new object that is a copy of the current instance
        /// </summary>
        /// <returns>A new object that is a copy of the current instance</returns>
        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
