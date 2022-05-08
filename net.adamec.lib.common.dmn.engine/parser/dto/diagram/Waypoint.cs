using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace net.adamec.lib.common.dmn.engine.parser.dto.diagram
{
    /// <summary>
    /// Represents di:waypoint element of <see cref="Edge"/> in DMN XML
    /// </summary>
    public class Waypoint
    {
        /// <summary>
        /// X position of waypoint
        /// </summary>
        [XmlAttribute("x")]
        public int X { get; set; }
        
        /// <summary>
        /// Y position of waypoint
        /// </summary>
        [XmlAttribute("y")]
        public int Y { get; set; }

        /// <inheritdoc />
        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"X:{X}, Y:{Y}";
        }
    }
}