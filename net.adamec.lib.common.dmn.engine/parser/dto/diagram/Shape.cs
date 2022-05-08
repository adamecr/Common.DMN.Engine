using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace net.adamec.lib.common.dmn.engine.parser.dto.diagram
{
    /// <summary>
    /// Represents dmndi:DMNShape element in DMN XML
    /// </summary>
    public class Shape : IdedElement
    {
        /// <summary>
        /// Reference to DMN element in model (typically decision or input parameter)
        /// </summary>
        [XmlAttribute("dmnElementRef")]
        public string DmnElementRef { get; set; }

        /// <summary>
        /// Boundaries of the shape
        /// </summary>
        [XmlElement("Bounds", Namespace = "http://www.omg.org/spec/DMN/20180521/DC/")]
        public Bounds Bounds { get; set; }

        /// <inheritdoc />
        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"DI shape for {DmnElementRef} {Bounds}";
        }
    }
}