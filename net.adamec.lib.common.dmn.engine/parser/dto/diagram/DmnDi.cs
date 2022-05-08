using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace net.adamec.lib.common.dmn.engine.parser.dto.diagram
{
    /// <summary>
    /// Represents dmndi:DMNDI element in DMN XML
    /// </summary>
    public class DmnDi
    {
        /// <summary>
        /// List of <see cref="Diagram">diagrams</see> within DMN Model
        /// </summary>
        [XmlElement("DMNDiagram", Namespace = "https://www.omg.org/spec/DMN/20191111/DMNDI/")]
        public List<Diagram> Diagrams { get; set; }

        /// <inheritdoc />
        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"DI extension - {Diagrams?.Count ?? 0} diagrams";
        }
    }
}