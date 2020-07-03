using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace net.adamec.lib.common.dmn.engine.parser.dto
{
    /// <summary>
    /// Defines the input or decision needed for the decision to be evaluated.
    /// The inputs are referenced by <see cref="RequiredInput"/> sub-element and decisions by <see cref="RequiredDecision"/> one.
    /// Exactly one of the sub element must be present
    /// </summary>
    public class InformationRequirement : IXmlSerializable
    {
        /// <summary>
        /// Serializer used for the serialization proxy class - DMN version 1.1
        /// </summary>
        private static readonly XmlSerializer InformationRequirementSerializableSerializer = new XmlSerializer(
            typeof(InformationRequirementSerializable), null, new Type[] { },
            defaultNamespace: DmnParser.XmlNamespaceDmn11, root: new XmlRootAttribute("informationRequirement") { Namespace = DmnParser.XmlNamespaceDmn11 });

        /// <summary>
        /// Serializer used for the serialization proxy class - DMN version 1.3
        /// </summary>
        private static readonly XmlSerializer InformationRequirementSerializableSerializer13 = new XmlSerializer(
            typeof(InformationRequirementSerializable), null, new Type[] { },
            defaultNamespace: DmnParser.XmlNamespaceDmn13, root: new XmlRootAttribute("informationRequirement") { Namespace = DmnParser.XmlNamespaceDmn13 });

        /// <summary>
        /// Required input or decision reference
        /// </summary>
        public class InformationRequirementItem
        {
            /// <summary>
            /// Reference to input/decision by it's ID prefixed with "#" - for example href="#Input1"
            /// </summary>
            [XmlAttribute("href")]
            public string Ref { get; set; }
        }

        /// <summary>
        /// Reference to required decision
        /// </summary>
        private InformationRequirementItem RequiredDecision { get; set; }

        /// <summary>
        /// Reference to required input
        /// </summary>
        private InformationRequirementItem RequiredInput { get; set; }

        /// <summary>
        /// Gets the type of dependency (requirement) - input of decision
        /// </summary>
        ///<exception cref="DmnParserException">informationRequirement element doesn't contain requiredDecision nor requiredInput elements or contains both</exception>
        public InformationRequirementType RequirementType =>
            ((RequiredDecision == null && RequiredInput == null) || (RequiredDecision != null && RequiredInput != null))
                ? throw new DmnParserException(
                    "informationRequirement element doesn't contain requiredDecision nor requiredInput elements or contains both")
                : (RequiredDecision != null ? InformationRequirementType.Decision : InformationRequirementType.Input);

        /// <summary>
        /// Gets the reference to ID of decision or input the decision depends to
        /// </summary>
        public string Ref => RequirementType == InformationRequirementType.Decision
            ? ParseRef(RequiredDecision.Ref)
            : ParseRef(RequiredInput.Ref);

        /// <summary>
        /// Parses the reference attribute - get's the ID of the required decision/input from href attribute by removing the "#" prefix.
        /// </summary>
        /// <param name="reference">href attribute value (source reference with "#" prefix</param>
        /// <returns>The ID of required decision or input</returns>
        ///<exception cref="DmnParserException">Can't parse InformationRequirement - reference is null or empty</exception>
        ///<exception cref="DmnParserException">Can't parse InformationRequirement - reference doesn't start with #</exception>
        ///<exception cref="DmnParserException">Can't parse InformationRequirement - reference too short/missing</exception>
        private static string ParseRef(string reference)
        {
            reference = reference?.Trim();

            if (string.IsNullOrWhiteSpace(reference))
                throw new DmnParserException("Can't parse InformationRequirement - reference is null or empty");

            if (!reference.StartsWith("#"))
                throw new DmnParserException("Can't parse InformationRequirement - reference doesn't start with #");

            if (reference.Length < 2)
                throw new DmnParserException("Can't parse InformationRequirement - reference too short/missing");

            return reference.Substring(1);
        }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"{RequirementType}:{Ref}";
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
            var r = reader.ReadSubtree();

            var serializer = reader.NamespaceURI == DmnParser.XmlNamespaceDmn11
                ? InformationRequirementSerializableSerializer
                : InformationRequirementSerializableSerializer13;

            var proxy = (InformationRequirementSerializable)serializer.Deserialize(r);
            RequiredDecision = proxy.RequiredDecision;
            RequiredInput = proxy.RequiredInput;
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

    /// <summary>
    /// Type of the dependency
    /// </summary>
    public enum InformationRequirementType
    {
        /// <summary>
        /// Required decision
        /// </summary>
        Decision,

        /// <summary>
        /// Required input
        /// </summary>
        Input
    }

    /// <summary>
    /// Information Requirement (de)serialization proxy implemented to support the private getters in <see cref="InformationRequirement"/>
    /// </summary>
    public class InformationRequirementSerializable
    {
        /// <summary>
        /// Reference to required decision
        /// </summary>
        [XmlElement("requiredDecision")]
        public InformationRequirement.InformationRequirementItem RequiredDecision { get; set; }

        /// <summary>
        /// Reference to required input
        /// </summary>
        [XmlElement("requiredInput")]
        public InformationRequirement.InformationRequirementItem RequiredInput { get; set; }
    }
}
