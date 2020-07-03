using System;
using System.IO;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.runtime;
using net.adamec.lib.common.dmn.engine.parser;

namespace net.adamec.lib.common.dmn.engine.test.complex
{
    [TestClass]
    [TestCategory("Complex tests")]
    public class ComplexInputsTests13
    {
        private DmnExecutionContext ctx;
        [TestInitialize]
        public void InitCtx()
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/dynamictypes.dmn");
            ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));
        }

        [TestCleanup]
        public void ResetCtx()
        {
            ctx.Reset();
        }

        [TestMethod]
        [DataRow("nnnn", true, "dir")]
        [DataRow("aaaa", false, "some value")]
        [DataRow(null, false, "another value")]
        [DataRow("rrrr", false, "over")]
        public void ComplexObjectInputTest(string name, bool isOk, string direct)
        {
            var dyna = new { Name = name, IsOk = isOk, Direct = direct };
            ctx.WithInputParameter("dyna", dyna);

            var result = ctx.Reset().ExecuteDecision("Test");

            result.Should().NotBeNull();
            result.IsSingleResult.Should().Be(true);
            result.SingleResult.Should().NotBeNull();
            result.SingleResult.Should().HaveCount(1);
            
            var val = direct == "over" ? "dyna.Direct==over" : name + isOk + direct;
            var output = result.SingleResult[0];
            output.Should().NotBeNull();
            output.Value.Should().Be(val).And.BeOfType<string>();
            output.Type.Should().Be(typeof(string));
        }
    }
}
