using System;
using System.IO;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.parser;

namespace net.adamec.lib.common.dmn.engine.test.unit
{
    [TestClass]
    [TestCategory("Code tests - parser")]
    public class DmnParserFileBasicTests13Ext : DmnParserFileBasicTests13
    {
        protected override SourceEnum Source => SourceEnum.File13ext;

        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        public override void ParseNullOrEmptyFileTest(string file)
        {
            Action act = () => DmnParser.Parse13ext(file);
            act.Should().Throw<DmnParserException>().WithMessage("filePath is null or empty");
        }

        [TestMethod]
        public override void ParseFileNotExistTest()
        {
            Action act = () => DmnParser.Parse13ext("dsadas");
            act.Should().Throw<DmnParserException>().WithMessage("File * doesn't exist");
        }
        [TestMethod]
        public override void ParseWrongFileTest()
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir ?? string.Empty, "nlog.config");
            Action act = () => DmnParser.Parse13ext(file);
            act.Should().Throw<DmnParserException>().WithMessage("Can't parse file *");
        }
    }
}
