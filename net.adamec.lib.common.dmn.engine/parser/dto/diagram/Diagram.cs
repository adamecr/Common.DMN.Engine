using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace net.adamec.lib.common.dmn.engine.parser.dto.diagram
{
    /// <summary>
    /// Represents dmndi:DMNDiagram element in DMN XML
    /// </summary>
    public class Diagram : IdedElement
    {
        /// <summary>
        /// List of shapes within the diagram
        /// </summary>
        [XmlElement("DMNShape", Namespace = "https://www.omg.org/spec/DMN/20191111/DMNDI/")]
        public List<Shape> Shapes { get; set; }

        /// <summary>
        /// List of elements within the diagram
        /// </summary>
        [XmlElement("DMNEdge", Namespace = "https://www.omg.org/spec/DMN/20191111/DMNDI/")]
        public List<Edge> Edges { get; set; }

        /// <inheritdoc />
        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"DI diagram - {Shapes?.Count ?? 0} shapes, {Edges?.Count ?? 0} edges";
        }
    }
}