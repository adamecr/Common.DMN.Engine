using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.parser;

namespace net.adamec.lib.common.dmn.engine.test.unit
{
    [TestClass]
    [TestCategory("Code tests - parser")]
    public class DmnParserStringBasicTests
    {
        [TestMethod]
        public void ParseStringMethodHappyTest()
        {
            var def = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
            def += "<definitions xmlns = \"http://www.omg.org/spec/DMN/20151101/dmn.xsd\" >";
            def += "</definitions>";

            var parsedDef=DmnParser.ParseString(def);
            parsedDef.Should().NotBeNull();
        }

        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        public void ParseNullOrEmptyDefStringTest(string xmlStr)
        {
            Action act = () => DmnParser.ParseString(xmlStr);
            act.Should().Throw<DmnParserException>().WithMessage("Missing Dmn Model definition");
        }

       
        [TestMethod]
        public void ParseWrongStringTest()
        {
            var def = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
            def += "<definitions xmlns = \"http://www.omg.org/spec/DMN/20151101/dmn.xsd\" >";
            def += "</efinitions>";

            Action act = () => DmnParser.ParseString(def);
            act.Should().Throw<DmnParserException>().WithMessage("Can't parse definition from given string*");
        }


    }
}
