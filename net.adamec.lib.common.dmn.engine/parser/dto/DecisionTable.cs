using System.Collections.Generic;
using System.Xml.Serialization;

namespace net.adamec.lib.common.dmn.engine.parser.dto
{
    /// <inheritdoc />
    /// <summary>
    /// Decision table definition
    /// </summary>
    public class DecisionTable : IdedElement
    {
        /// <summary>
        /// Hit policy attribute
        /// Used just by deserializer, translated within <see cref="HitPolicy"/> property getter
        /// </summary>
        [XmlAttribute("hitPolicy")]
        public string HitPolicySrc { get;  set; }

        /// <summary>
        /// <see cref="HitPolicyEnum">Hit policy</see> defined for decision table
        /// If not defined, <see cref="HitPolicyEnum.Unique"/> is used as default
        /// </summary>
        ///<exception cref="DmnParserException">Wrong hit policy</exception>
        [XmlIgnore]
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
        [XmlAttribute("aggregation")]
        public string AggregationSrc { get; set; }

        /// <summary>
        /// <see cref="CollectHitPolicyAggregationEnum">Aggregation</see> defined for "COLLECT" hit policy
        /// If not defined, <see cref="CollectHitPolicyAggregationEnum.List"/> is used as default
        /// </summary>
        /// <exception cref="DmnParserException">Wrong hit policy aggregation</exception>
        [XmlIgnore]
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
