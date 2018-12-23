using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace net.adamec.lib.common.dmn.engine.parser.dto
{
    /// <inheritdoc />
    /// <summary>
    /// Expression within the DMN definition file
    /// </summary>
    public class Expression : IdedElement
    {
        /// <summary>
        /// Currently not used (ignored)
        /// </summary>
        [ExcludeFromCodeCoverage]
        [XmlAttribute("expressionLanguage")]
        public string Language { get; set; }

        /// <summary>
        /// Expression text
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }

        /// <summary>
        /// Optional data type of the expression output
        /// </summary>
        [XmlAttribute("typeRef")]
        public string TypeRef { get; set; }

        /// <inheritdoc />
        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"{Text}";
        }
    }
}
