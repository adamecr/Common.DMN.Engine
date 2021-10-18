using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.execution.context;

namespace net.adamec.lib.common.dmn.engine.test.complex
{
    [TestClass]
    [TestCategory("Complex tests")]
    public class EndToEndTests : DmnTestBase
    {
        protected DmnExecutionContext Ctx;

        [TestInitialize]
        public void InitCtx()
        {
            Ctx = CTX("test.dmn");
        }

        [TestCleanup]
        public void ResetCtx()
        {
            Ctx.Reset();
        }

        [TestMethod]
        public void ExecAgePlus10()
        {
            Ctx.WithInputParameter("Age", 33);
            var result = Ctx.ExecuteDecision("Age +10");

            result.Should().NotBeNull();
            result.IsSingleResult.Should().Be(true);
            result.FirstResultVariables.Should().NotBeNull();
            result.FirstResultVariables.Should().HaveCount(1);
            result.Results[0].HitRules.Should().HaveCount(0);

            var output = result.FirstResultVariables[0];
            output.Should().NotBeNull();
            output.Name.Should().Be("age10");
            output.Value.Should().Be(43).And.BeOfType<int>();
            output.Type.Should().Be(typeof(int));
        }

        [TestMethod]
        public void ExecDoubleAgePlus10()
        {
            Ctx.WithInputParameter("Age", 33);
            var result = Ctx.ExecuteDecision("Double (Age+10)");

            result.Should().NotBeNull();
            result.IsSingleResult.Should().Be(true);
            result.FirstResultVariables.Should().NotBeNull();
            result.FirstResultVariables.Should().HaveCount(1);
            result.Results[0].HitRules.Should().HaveCount(0);

            var output = result.FirstResultVariables[0];
            output.Should().NotBeNull();
            output.Name.Should().Be("Age2");
            output.Value.Should().Be(86).And.BeOfType<int>();
            output.Type.Should().Be(typeof(int));
        }

        [TestMethod]
        public void ExecMainDt()
        {
            Ctx.WithInputParameter("Age", 33);

            Ctx.WithInputParameter("Pocet", 2);
            Ctx.WithInputParameter("Greeting", "po");
            Ctx.WithInputParameter("Rano", false);
            Ctx.WithInputParameter("Test", "druhy");
            var result = Ctx.Reset().ExecuteDecision("MainDT");

            result.Should().NotBeNull();
            result.IsSingleResult.Should().Be(true);
            result.FirstResultVariables.Should().NotBeNull();
            result.FirstResultVariables.Should().HaveCount(2);
            result.Results[0].HitRules.Should().HaveCount(1);

            var o1 = result.FirstResultVariables[0];
            o1.Should().NotBeNull();
            o1.Name.Should().Be("Category");
            o1.Value.Should().Be("c").And.BeOfType<string>();
            o1.Type.Should().Be(typeof(string));

            var o2 = result.FirstResultVariables[1];
            o2.Should().NotBeNull();
            o2.Name.Should().Be("Eligible");
            o2.Value.Should().Be(true).And.BeOfType<bool>();
            o2.Type.Should().Be(typeof(bool));

        }

        [TestMethod]
        public void ExecCategoryPlusSuffix()
        {
            Ctx.WithInputParameter("Age", 33);

            Ctx.WithInputParameter("Pocet", 2);
            Ctx.WithInputParameter("Greeting", "po");
            Ctx.WithInputParameter("Rano", false);
            Ctx.WithInputParameter("Test", "druhy");

            Ctx.WithInputParameter("Suffix", "<<");
            var result = Ctx.Reset().ExecuteDecision("Category + suffix");

            result.Should().NotBeNull();
            result.IsSingleResult.Should().Be(true);
            result.FirstResultVariables.Should().NotBeNull();
            result.FirstResultVariables.Should().HaveCount(1);
            result.Results[0].HitRules.Should().HaveCount(0);

            var output = result.FirstResultVariables[0];
            output.Should().NotBeNull();
            output.Name.Should().Be("CategoryExt");
            output.Value.Should().Be("c<<").And.BeOfType<string>();
            output.Type.Should().Be(typeof(string));
        }

        [TestMethod]
        public void ExecSecondaryDt()
        {
            Ctx.WithInputParameter("Age", 33);

            Ctx.WithInputParameter("Pocet", 2);
            Ctx.WithInputParameter("Greeting", "po");
            Ctx.WithInputParameter("Rano", false);
            Ctx.WithInputParameter("Test", "druhy");

            Ctx.WithInputParameter("Suffix", "<<");
            var result = Ctx.ExecuteDecision("Secondary DT");

            result.Should().NotBeNull();
            result.IsSingleResult.Should().Be(true);
            result.FirstResultVariables.Should().NotBeNull();
            result.FirstResultVariables.Should().HaveCount(1);
            result.Results[0].HitRules.Should().HaveCount(1);

            var output = result.FirstResultVariables[0];
            output.Should().NotBeNull();
            output.Name.Should().Be("Amount");
            output.Value.Should().Be(300).And.BeOfType<int>();
            output.Type.Should().Be(typeof(int));
        }

    }
}
