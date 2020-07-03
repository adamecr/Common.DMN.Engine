using System;
using System.IO;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.parser;

namespace net.adamec.lib.common.dmn.engine.test.unit
{
    [TestClass]
    [TestCategory("Code tests - parser")]
    public class DmnParserFileBasicTests13
    {
        [TestMethod]
        public void ParseFileHappyTest()
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/test.dmn");
            var def = DmnParser.Parse13(file);
            
            def.Should().NotBeNull();
        }

        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        public void ParseNullOrEmptyFileTest(string file)
        {
            Action act = () => DmnParser.Parse13(file);
            act.Should().Throw<DmnParserException>().WithMessage("filePath is null or empty");
        }

        [TestMethod]
        public void ParseFileNotExistTest()
        {
            Action act=()=> DmnParser.Parse13("dsadas");
            act.Should().Throw<DmnParserException>().WithMessage("File * doesn't exist");
        }
        [TestMethod]
        public void ParseWrongFileTest()
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "nlog.config");
            Action act=()=> DmnParser.Parse13(file);
            act.Should().Throw<DmnParserException>().WithMessage("Can't parse file *");
        }

        
    }
}
