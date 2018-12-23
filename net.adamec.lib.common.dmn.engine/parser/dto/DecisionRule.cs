using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Xml.Serialization;

namespace net.adamec.lib.common.dmn.engine.parser.dto
{
    /// <inheritdoc />
    /// <summary>
    /// Decision table rule
    /// </summary>
    public class DecisionRule : IdedElement
    {
        /// <summary>
        /// Label used to name the rule
        /// If not provided, the Id is used instead
        /// </summary>
        [XmlAttribute("label")]
        public string Label { get; set; }

        /// <summary>
        /// Optional description of the rule
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// List of expressions to be evaluated for individual inputs
        /// </summary>
        [XmlElement("inputEntry")]
        public List<Expression> InputEntries { get; set; }

        /// <summary>
        /// List of expressions to be evaluated when creating the outputs when rule matches
        /// </summary>
        [XmlElement("outputEntry")]
        public List<Expression> OutputEntries { get; set; }

        /// <inheritdoc />
        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"{string.Join(",", InputEntries?.Select(i => i?.ToString()) ?? new string[] { })}->{string.Join(",", OutputEntries?.Select(i => i?.ToString()) ?? new string[] { })}";
        }
    }
}
