using System.Collections.Generic;
using System.Xml.Serialization;
using net.adamec.lib.common.dmn.engine.parser.dto.diagram;

namespace net.adamec.lib.common.dmn.engine.parser.dto
{
    /// <summary>
    /// Root of DMN definition XML - DMN Model
    /// </summary>
    public class DmnModel
    {
        /// <summary>
        /// List of input data parameters to be used by <see cref="Decisions"/> for DMN Model
        /// </summary>
        [XmlElement("inputData")]
        public List<InputData> InputData { get; set; }

        /// <summary>
        /// List of <see cref="Decision">decisions</see> within DMN Model
        /// </summary>
        [XmlElement("decision")]
        public List<Decision> Decisions { get; set; }

        /// <summary>
        /// Diagrams within DMN Model
        /// </summary>
        [XmlElement("DMNDI", Namespace = "https://www.omg.org/spec/DMN/20191111/DMNDI/")]
        public DmnDi DiagramExtension { get; set; }

        /// <summary>
        /// DMN Version used by parser
        /// </summary>
        [XmlIgnore]
        public DmnParser.DmnVersionEnum DmnVersion { get; set; }
    }
}
