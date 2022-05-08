using System;
using System.IO;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.parser;

namespace net.adamec.lib.common.dmn.engine.test.unit
{
    [TestClass]
    [TestCategory("Code tests - parser")]
    public class DmnParserFileBasicTests : DmnTestBase
    {
        [TestMethod]
        public void ParseFileHappyTest()
        {
            var model = MODEL("test.dmn");
            model.Should().NotBeNull();
            model.DmnVersion.Should().Be(ParserVersion);
        }

        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        public virtual void ParseNullOrEmptyFileTest(string file)
        {
            Action act = () => DmnParser.Parse(file);
            act.Should().Throw<DmnParserException>().WithMessage("filePath is null or empty");
        }

        [TestMethod]
        public virtual void ParseFileNotExistTest()
        {
            Action act = () => DmnParser.Parse("dsadas");
            act.Should().Throw<DmnParserException>().WithMessage("File * doesn't exist");
        }
        [TestMethod]
        public virtual void ParseWrongFileTest()
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir ?? string.Empty, "nlog.config");
            Action act = () => DmnParser.Parse(file);
            act.Should().Throw<DmnParserException>().WithMessage("Can't parse file *");
        }


    }
}
