using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace net.adamec.lib.common.dmn.engine.parser.dto
{
    /// <summary>
    /// Element with id attribute
    /// </summary>
    public abstract class IdedElement
    {
        /// <summary>
        /// ID of the element
        /// </summary>
        [XmlAttribute("id")]
        public string Id { get; set; }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"{Id}";
        }
    }
}
