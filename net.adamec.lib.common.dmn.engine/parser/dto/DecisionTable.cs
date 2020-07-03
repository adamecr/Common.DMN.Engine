using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace net.adamec.lib.common.dmn.engine.parser.dto
{
    /// <summary>
    /// Decision table definition
    /// </summary>
    public class DecisionTable : IdedElement, IXmlSerializable
    {
        /// <summary>
        /// Serializer used for the serialization proxy class - DMN version 1.1
        /// </summary>
        private static readonly XmlSerializer DecisionTableSerializableSerializer = new XmlSerializer(
            typeof(DecisionTableSerializable), null, new Type[] { },
            defaultNamespace: DmnParser.XmlNamespaceDmn11, root: new XmlRootAttribute("decisionTable") { Namespace = DmnParser.XmlNamespaceDmn11 });

        /// <summary>
        /// Serializer used for the serialization proxy class - DMN version 1.3
        /// </summary>
        private static readonly XmlSerializer DecisionTableSerializableSerializer13 = new XmlSerializer(
            typeof(DecisionTableSerializable), null, new Type[] { },
            defaultNamespace: DmnParser.XmlNamespaceDmn13, root: new XmlRootAttribute("decisionTable") { Namespace = DmnParser.XmlNamespaceDmn13 });

        /// <summary>
        /// Hit policy attribute
        /// Used just by deserializer, translated within <see cref="HitPolicy"/> property getter
        /// </summary>
        private string HitPolicySrc { get; set; }

        /// <summary>
        /// <see cref="HitPolicyEnum">Hit policy</see> defined for decision table
        /// If not defined, <see cref="HitPolicyEnum.Unique"/> is used as default
        /// </summary>
        ///<exception cref="DmnParserException">Wrong hit policy</exception>
        public HitPolicyEnum HitPolicy
        {
            get
            {
                //Translate the string attribute to enum
                switch (HitPolicySrc)
                {
                    case null:
                    case "UNIQUE": return HitPolicyEnum.Unique;
                    case "FIRST": return HitPolicyEnum.First;
                    case "PRIORITY": return HitPolicyEnum.Priority;
                    case "ANY": return HitPolicyEnum.Any;
                    case "COLLECT": return HitPolicyEnum.Collect;
                    case "RULE ORDER": return HitPolicyEnum.RuleOrder;
                    case "OUTPUT ORDER": return HitPolicyEnum.OutputOrder;
                    default:
                        throw new DmnParserException($"Wrong hit policy {HitPolicySrc}");
                }
            }
        }

        /// <summary>
        /// Aggregation attribute for "COLLECT" hit policy
        /// Used just by deserializer, translated within <see cref="Aggregation"/> property getter
        /// </summary>
        ///<exception cref="DmnParserException">Wrong hit policy aggregation</exception>
        private string AggregationSrc { get; set; }

        /// <summary>
        /// <see cref="CollectHitPolicyAggregationEnum">Aggregation</see> defined for "COLLECT" hit policy
        /// If not defined, <see cref="CollectHitPolicyAggregationEnum.List"/> is used as default
        /// </summary>
        /// <exception cref="DmnParserException">Wrong hit policy aggregation</exception>
        public CollectHitPolicyAggregationEnum Aggregation
        {
            get
            {
                switch (AggregationSrc)
                {
                    case null:
                    case "LIST": return CollectHitPolicyAggregationEnum.List;
                    case "SUM": return CollectHitPolicyAggregationEnum.Sum;
                    case "MIN": return CollectHitPolicyAggregationEnum.Min;
                    case "MAX": return CollectHitPolicyAggregationEnum.Max;
                    case "COUNT": return CollectHitPolicyAggregationEnum.Count;
                    default:
                        throw new DmnParserException($"Wrong hit policy aggregation {AggregationSrc}");
                }
            }
        }

        /// <summary>
        /// List of decision table <see cref="DecisionTableInput">inputs</see>
        /// </summary>
        public List<DecisionTableInput> Inputs { get; set; }

        /// <summary>
        /// List of decision table <see cref="DecisionTableOutput">outputs</see>
        /// </summary>
        public List<DecisionTableOutput> Outputs { get; set; }

        /// <summary>
        /// List of decision table <see cref="DecisionRule">rules</see>
        /// </summary>
        public List<DecisionRule> Rules { get; set; }

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
                ? DecisionTableSerializableSerializer
                : DecisionTableSerializableSerializer13;

            var proxy = (DecisionTableSerializable)serializer.Deserialize(r);
            Inputs = proxy.Inputs;
            AggregationSrc = proxy.Aggregation;
            HitPolicySrc = proxy.HitPolicy;
            Outputs = proxy.Outputs;
            Rules = proxy.Rules;
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
    /// Decision table (de)serialization proxy implemented to support the private getters in <see cref="DecisionTable"/>
    /// </summary>
    public class DecisionTableSerializable
    {
        /// <summary>
        /// Hit policy attribute
        /// Used just by deserializer, translated within <see cref="HitPolicy"/> property getter
        /// </summary>
        [XmlAttribute("hitPolicy")]
        public string HitPolicy { get; set; }

        /// <summary>
        /// Aggregation attribute for "COLLECT" hit policy
        /// Used just by deserializer, translated within <see cref="Aggregation"/> property getter
        /// </summary>
        ///<exception cref="DmnParserException">Wrong hit policy aggregation</exception>
        [XmlAttribute("aggregation")]
        public string Aggregation { get; set; }

        /// <summary>
        /// List of decision table <see cref="DecisionTableInput">inputs</see>
        /// </summary>
        [XmlElement("input")]
        public List<DecisionTableInput> Inputs { get; set; }

        /// <summary>
        /// List of decision table <see cref="DecisionTableOutput">outputs</see>
        /// </summary>
        [XmlElement("output")]
        public List<DecisionTableOutput> Outputs { get; set; }

        /// <summary>
        /// List of decision table <see cref="DecisionRule">rules</see>
        /// </summary>
        [XmlElement("rule")]
        public List<DecisionRule> Rules { get; set; }
    }

}
