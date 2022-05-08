using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace net.adamec.lib.common.dmn.engine.parser.dto.diagram
{
    /// <summary>
    /// Represents dmndi:DMNEdge element in DMN XML
    /// </summary>
    public class Edge : IdedElement
    {
        /// <summary>
        /// Reference to DMN element in model (typically information requirement)
        /// </summary>
        [XmlAttribute("dmnElementRef")]
        public string DmnElementRef { get; set; }

        /// <summary>
        /// List of waypoints of the edge
        /// </summary>
        [XmlElement("waypoint", Namespace = "http://www.omg.org/spec/DMN/20180521/DI/")]
        public List<Waypoint> Waypoints { get; set; }

        /// <inheritdoc />
        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"DI edge for {DmnElementRef}, {Waypoints?.Count ?? 0} waypoints";
        }
    }
}