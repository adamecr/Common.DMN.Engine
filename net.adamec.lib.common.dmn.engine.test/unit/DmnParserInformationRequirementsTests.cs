using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.runtime;
using net.adamec.lib.common.dmn.engine.parser;

namespace net.adamec.lib.common.dmn.engine.test.unit
{

    [TestClass]
    [TestCategory("Code tests - parser")]
    public class DmnParserInformationRequirementsTests
    {
        [TestMethod]
        public void NoInformationRequirementsSubElementsTest()
        {
            var def = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
            def += "<definitions xmlns = \"http://www.omg.org/spec/DMN/20151101/dmn.xsd\" >";
            def += "<decision id = \"test\" name=\"Test\">";
            def += "<informationRequirement>";
            def += "</informationRequirement>";
            def += "</decision>";
            def += "</definitions>";

            Action act=()=> DmnExecutionContextFactory.CreateExecutionContext(DmnParser.ParseString(def));

            act.Should().Throw<DmnParserException>().WithMessage(
                "infromationRequirement element doesn't contain requiredDecision nor requiredInput elements or contains both");
        }

        [TestMethod]
        public void BothInformationRequirementsSubElementsTest()
        {
            var def = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
            def += "<definitions xmlns = \"http://www.omg.org/spec/DMN/20151101/dmn.xsd\" >";
            def += "<decision id = \"test\" name=\"Test\">";
            def += "<informationRequirement>";
            def += "<requiredDecision href = \"#d2\" />";
            def += "<requiredInput href=\"#InputData_1\" />";
            def += "</informationRequirement>";
            def += "</decision>";
            def += "</definitions>";

            Action act = () => DmnExecutionContextFactory.CreateExecutionContext(DmnParser.ParseString(def));

            act.Should().Throw<DmnParserException>().WithMessage(
                "infromationRequirement element doesn't contain requiredDecision nor requiredInput elements or contains both");
        }

        [TestMethod]
        [DataRow("")]
        [DataRow("href=\"\"")]
        [DataRow("href=\"\"")]
        [DataRow("href=\" \"")]
        public void MissingInformationRequirementReferenceTest(string hrefAttr)
        {
            var def = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
            def += "<definitions xmlns = \"http://www.omg.org/spec/DMN/20151101/dmn.xsd\" >";
            def += "<decision id = \"test\" name=\"Test\">";
            def += "<informationRequirement>";
            def += $"<requiredInput {hrefAttr} />";
            def += "</informationRequirement>";
            def += "</decision>";
            def += "</definitions>";

            Action act = () => DmnExecutionContextFactory.CreateExecutionContext(DmnParser.ParseString(def));

            act.Should().Throw<DmnParserException>().WithMessage(
                "Can't parse InformationRequirement - reference is null or empty");

        }

        [TestMethod]
        [DataRow("href=\"ref\"")]
        [DataRow("href=\" ref\"")]
        public void MissingHashInInformationRequirementReferenceTest(string hrefAttr)
        {
            var def = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
            def += "<definitions xmlns = \"http://www.omg.org/spec/DMN/20151101/dmn.xsd\" >";
            def += "<decision id = \"test\" name=\"Test\">";
            def += "<informationRequirement>";
            def += $"<requiredInput {hrefAttr} />";
            def += "</informationRequirement>";
            def += "</decision>";
            def += "</definitions>";

            Action act = () => DmnExecutionContextFactory.CreateExecutionContext(DmnParser.ParseString(def));

            act.Should().Throw<DmnParserException>().WithMessage(
                "Can't parse InformationRequirement - reference doesn't start with #");

        }

        [TestMethod]
        [DataRow("href=\"#\"")]
        [DataRow("href=\" #\"")]
        [DataRow("href=\" # \"")]
        public void TooShortInformationRequirementReferenceTest(string hrefAttr)
        {
            var def = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
            def += "<definitions xmlns = \"http://www.omg.org/spec/DMN/20151101/dmn.xsd\" >";
            def += "<decision id = \"test\" name=\"Test\">";
            def += "<informationRequirement>";
            def += $"<requiredInput {hrefAttr} />";
            def += "</informationRequirement>";
            def += "</decision>";
            def += "</definitions>";

            Action act = () => DmnExecutionContextFactory.CreateExecutionContext(DmnParser.ParseString(def));

            act.Should().Throw<DmnParserException>().WithMessage(
                "Can't parse InformationRequirement - reference too short/missing");
        }
    }
}
