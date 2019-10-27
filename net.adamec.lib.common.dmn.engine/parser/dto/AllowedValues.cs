using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace net.adamec.lib.common.dmn.engine.parser.dto
{
    /// <summary>
    /// Defines the list of allowed values for decision table inputs and outputs
    /// </summary>
    public class AllowedValues : IXmlSerializable
    {
        /// <summary>
        /// The source list of allowed values in form "value 1", "value 2", "value 3", "value n"
        /// </summary>
        private string Text { get; set; }

        /// <summary>
        /// List of allowed values 
        /// </summary>
        public string[] Values =>
            string.IsNullOrWhiteSpace(Text)
                ? null
                : Text.Split(',').Select(i =>
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

        /// <summary>This method is reserved and should not be used. When implementing the IXmlSerializable interface, you should return null (Nothing in Visual Basic) from this method, and instead, if specifying a custom schema is required, apply the <see cref="T:System.Xml.Serialization.XmlSchemaProviderAttribute"></see> to the class.</summary>
        /// <returns>An <see cref="T:System.Xml.Schema.XmlSchema"></see> that describes the XML representation of the object that is produced by the <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)"></see> method and consumed by the <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)"></see> method.</returns>
        public XmlSchema GetSchema()
        {
            return null;
        }

        /// <summary>Generates an object from its XML representation.</summary>
        /// <param name="reader">The <see cref="T:System.Xml.XmlReader"></see> stream from which the object is deserialized.</param>
        public void ReadXml(XmlReader reader)
        {
            reader.MoveToContent();
            reader.ReadStartElement();
            Text = reader.ReadElementString("text");
            reader.ReadEndElement();
        }

        /// <summary>Converts an object into its XML representation.</summary>
        /// <remarks>Not implemented - always throws <see cref="System.NotImplementedException"/> </remarks>
        /// <param name="writer">The <see cref="T:System.Xml.XmlWriter"></see> stream to which the object is serialized.</param>
        /// <exception cref="System.NotImplementedException">Method not implemented and should not be used</exception>
        public void WriteXml(XmlWriter writer)
        {
            throw new System.NotImplementedException();
        }
    }
}
