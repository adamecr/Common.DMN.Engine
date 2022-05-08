using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace net.adamec.lib.common.dmn.engine.parser.dto.diagram
{
    /// <summary>
    /// Represents dc:Bounds element of <see cref="Shape"/> in DMN XML
    /// </summary>
    public class Bounds
    {
        /// <summary>
        /// X position of shape
        /// </summary>
        [XmlAttribute("x")]
        public int X { get; set; }

        /// <summary>
        /// Y position of shape
        /// </summary>
        [XmlAttribute("y")]
        public int Y { get; set; }

        /// <summary>
        /// Width of shape
        /// </summary>
        [XmlAttribute("width")]
        public int Width { get; set; }

        /// <summary>
        /// Height of shape
        /// </summary>
        [XmlAttribute("height")]
        public int Height { get; set; }

        /// <inheritdoc />
        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"X:{X}, Y:{Y}, W:{Width}, H{Height}";
        }
    }
}
