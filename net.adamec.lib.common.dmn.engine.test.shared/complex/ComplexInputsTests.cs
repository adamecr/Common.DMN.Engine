using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.execution.context;

namespace net.adamec.lib.common.dmn.engine.test.complex
{
    [TestClass]
    [TestCategory("Complex tests")]
    public class ComplexInputsTests : DmnTestBase
    {
        protected DmnExecutionContext Ctx;
        [TestInitialize]
        public void InitCtx()
        {
            Ctx = CTX("dynamictypes.dmn");
        }

        [TestCleanup]
        public void ResetCtx()
        {
            Ctx.Reset();
        }

        [TestMethod]
        [DataRow("nnnn", true, "dir")]
        [DataRow("aaaa", false, "some value")]
        [DataRow(null, false, "another value")]
        [DataRow("rrrr", false, "over")]
        public void ComplexObjectInputTest(string name, bool isOk, string direct)
        {
            var dyna = new { Name = name, IsOk = isOk, Direct = direct };
            Ctx.WithInputParameter("dyna", dyna);

            var result = Ctx.Reset().ExecuteDecision("Test");

            result.Should().NotBeNull();
            result.IsSingleResult.Should().Be(true);
            result.SingleResult.Should().NotBeNull();
            result.SingleResult.Should().HaveCount(1);
            result.Results[0].HitRules.Should().HaveCount(1);

            var val = direct == "over" ? "dyna.Direct==over" : name + isOk + direct;
            var output = result.SingleResult[0];
            output.Should().NotBeNull();
            output.Value.Should().Be(val).And.BeOfType<string>();
            output.Type.Should().Be(typeof(string));
        }
    }
}
