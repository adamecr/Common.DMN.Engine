using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace net.adamec.lib.common.dmn.engine.parser.dto
{
    /// <inheritdoc />
    /// <summary>
    /// Decision table output definition
    /// </summary>
    public class DecisionTableOutput : NamedElement
    {
        /// <summary>
        /// Label used to map to output variable
        /// </summary>
        [XmlAttribute("label")]
        public string Label { get; set; }

        /// <summary>
        /// Type of the output variable
        /// </summary>
        [XmlAttribute("typeRef")]
        public string TypeRef { get; set; }

        /// <summary>
        /// Allowed output values
        /// </summary>
        [XmlElement("outputValues")]
        public AllowedValues AllowedOutputValues { get; set; }

        /// <inheritdoc />
        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"{Name}{(string.IsNullOrWhiteSpace(TypeRef) ? "" : ":" + TypeRef)}/{Label}";
        }
    }
}
