using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace net.adamec.lib.common.dmn.engine.parser.dto
{
    /// <inheritdoc />
    /// <summary>
    /// Element with id and name attributes
    /// </summary>
    public abstract class NamedElement : IdedElement
    {
        /// <summary>
        /// Name of the element
        /// </summary>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <inheritdoc />
        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"{Name} ({Id})";
        }
    }
}
