using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.parser;

namespace net.adamec.lib.common.dmn.engine.test.net.unit
{
    [TestClass]
    [TestCategory("Code tests - parser")]
    public class DmnParserStringBasicTests13
    {
        [TestMethod]
        public void ParseStringMethodHappyTest()
        {
            var def = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
            def += "<definitions xmlns = \"https://www.omg.org/spec/DMN/20191111/MODEL/\" >";
            def += "</definitions>";

            var parsedDef=DmnParser.ParseString13(def);
            parsedDef.Should().NotBeNull();
        }

        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        public void ParseNullOrEmptyDefStringTest(string xmlStr)
        {
            Action act = () => DmnParser.ParseString13(xmlStr);
            act.Should().Throw<DmnParserException>().WithMessage("Missing Dmn Model definition");
        }

       
        [TestMethod]
        public void ParseWrongStringTest()
        {
            var def = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
            def += "<definitions xmlns = \"https://www.omg.org/spec/DMN/20191111/MODEL/\" >";
            def += "</efinitions>";

            Action act = () => DmnParser.ParseString13(def);
            act.Should().Throw<DmnParserException>().WithMessage("Can't parse definition from given string*");
        }


    }
}
