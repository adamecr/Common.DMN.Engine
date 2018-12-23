using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Xml.Serialization;

namespace net.adamec.lib.common.dmn.engine.parser.dto
{
    /// <summary>
    /// Defines the list of allowed values for decision table inputs and outputs
    /// </summary>
    public class AllowedValues
    {
        /// <summary>
        /// The source list of allowed values in form "value 1", "value 2", "value 3", "value n"
        /// </summary>
        [XmlElement("text")]
        public string Text {private get; set; }

        /// <summary>
        /// List of allowed values 
        /// </summary>
        [XmlIgnore]
        public string[] Values => 
            string.IsNullOrEmpty(Text) ? null : Text.Split(',').Select(i =>
            {
                var s = i.Trim();
                if (s.StartsWith("\"") && s.EndsWith("\"")) s = s.Substring(1, s.Length - 2);
                return s;

            }).ToArray();

        /// <inheritdoc />
        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return string.Join(",", Values ?? new string[] { });
        }
    }
}
