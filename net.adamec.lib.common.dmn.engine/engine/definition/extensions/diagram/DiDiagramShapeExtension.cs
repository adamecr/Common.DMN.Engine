using System;
using System.Diagnostics.CodeAnalysis;

namespace net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram
{
    /// <summary>
    /// Extension containing the DMN DI Diagram shape bounds for single element
    /// </summary>
    public class DiDiagramShapeExtension : ICloneable
    {
        /// <summary>
        /// Height of shape in diagram
        /// </summary>
        public int Height { get; }

        /// <summary>
        /// Width of shape in diagram
        /// </summary>
        public int Width { get; }

        /// <summary>
        /// X position of shape in diagram
        /// </summary>
        public int X { get; }

        /// <summary>
        /// Y position of shape in diagram
        /// </summary>
        public int Y { get; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="x">X position of shape in diagram</param>
        /// <param name="y">Y position of shape in diagram</param>
        /// <param name="width">Width of shape in diagram</param>
        /// <param name="height">Height of shape in diagram</param>
        public DiDiagramShapeExtension(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        /// <inheritdoc />
        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"DI Diagram shape: X:{X}, Y:{Y}, W:{Width}, H{Height}";
        }

        /// <summary>
        /// Creates a new object that is a copy of the current instance
        /// </summary>
        /// <returns>A new object that is a copy of the current instance</returns>
        public DiDiagramShapeExtension Clone()
        {
            return new DiDiagramShapeExtension(X, Y, Width, Height);
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