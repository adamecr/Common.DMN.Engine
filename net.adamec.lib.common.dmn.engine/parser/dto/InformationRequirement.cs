using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace net.adamec.lib.common.dmn.engine.parser.dto
{
    /// <summary>
    /// Defines the input or decision needed for the decision to be evaluated.
    /// The inputs are referenced by <see cref="RequiredInput"/> sub-element and decisions by <see cref="RequiredDecision"/> one.
    /// Exactly one of the sub element must be present
    /// </summary>
    public class InformationRequirement
    {
        /// <summary>
        /// Required input or decision reference
        /// </summary>
        public class InformationRequirementItem
        {
            /// <summary>
            /// Reference to input/decision by it's ID prefixed with "#" - for example href="#Input1"
            /// </summary>
            [XmlAttribute("href")]
            public string Ref {  get; set; }
        }
       
        /// <summary>
        /// Reference to required decision
        /// </summary>
        [XmlElement("requiredDecision")]
        public InformationRequirementItem RequiredDecision {private get; set; }
        /// <summary>
        /// Reference to required input
        /// </summary>
        [XmlElement("requiredInput")]
        public InformationRequirementItem RequiredInput { private get; set; }
       
        /// <summary>
        /// Gets the type of dependency (requirement) - input of decision
        /// </summary>
        [XmlIgnore]
        public InformationRequirementType RequirementType =>
            ((RequiredDecision == null && RequiredInput == null) || (RequiredDecision != null && RequiredInput != null))
                ? throw new DmnParserException("infromationRequirement element doesn't contain requiredDecision nor requiredInput elements or contains both")
                 : (RequiredDecision != null ? InformationRequirementType.Decision : InformationRequirementType.Input);

        /// <summary>
        /// Gets the reference to ID of decision or input the decision depends to
        /// </summary>
        [XmlIgnore]
        public string Ref => RequirementType == InformationRequirementType.Decision
            ? ParseRef(RequiredDecision.Ref)
            : ParseRef(RequiredInput.Ref);

        /// <summary>
        /// Parses the reference attribute - get's the ID of the required decision/input from href attribute by removing the "#" prefix.
        /// </summary>
        /// <param name="reference">href attribute value (source reference with "#" prefix</param>
        /// <returns>The ID of required decision or input</returns>
        private static string ParseRef(string reference)
        {
            reference = reference?.Trim();

            if (string.IsNullOrEmpty(reference))
                throw new DmnParserException("Can't parse InformationRequirement - reference is null or empty");

            if (!reference.StartsWith("#"))
                throw new DmnParserException("Can't parse InformationRequirement - reference doesn't start with #");

            if (reference.Length < 2)
                throw new DmnParserException("Can't parse InformationRequirement - reference too short/missing");

            return reference.Substring(1);
        }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>>
        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"{RequirementType}:{Ref}";
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
}
