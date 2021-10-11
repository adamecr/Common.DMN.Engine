using System;
using System.IO;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.runtime;
using net.adamec.lib.common.dmn.engine.parser;

namespace net.adamec.lib.common.dmn.engine.test.net.complex
{
    [TestClass]
    [TestCategory("Complex tests")]
    public class EndToEndTests13
    {
        private DmnExecutionContext ctx;

        [TestInitialize]
        public void InitCtx()
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/test.dmn");
            ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));
        }

        [TestCleanup]
        public void ResetCtx()
        {
            ctx.Reset();
        }

        [TestMethod]
        public void ExecAgePlus10()
        {
            ctx.WithInputParameter("Age", 33);
            var result = ctx.ExecuteDecision("Age +10");

            result.Should().NotBeNull();
            result.IsSingleResult.Should().Be(true);
            result.SingleResult.Should().NotBeNull();
            result.SingleResult.Should().HaveCount(1);
            foreach (var r in result.Results)
            {
                r.MatchedRules.Should().NotBeNull();
                r.MatchedRules.Count.Should().Be(0);
            }

            var output = result.SingleResult[0];
            output.Should().NotBeNull();
            output.Name.Should().Be("age10");
            output.Value.Should().Be(43).And.BeOfType<int>();
            output.Type.Should().Be(typeof(int));
        }

        [TestMethod]
        public void ExecDoubleAgePlus10()
        {
            ctx.WithInputParameter("Age", 33);
            var result = ctx.ExecuteDecision("Double (Age+10)");

            result.Should().NotBeNull();
            result.IsSingleResult.Should().Be(true);
            result.SingleResult.Should().NotBeNull();
            result.SingleResult.Should().HaveCount(1);
            foreach (var r in result.Results)
            {
                r.MatchedRules.Should().NotBeNull();
                r.MatchedRules.Count.Should().Be(0);
            }

            var output = result.SingleResult[0];
            output.Should().NotBeNull();
            output.Name.Should().Be("Age2");
            output.Value.Should().Be(86).And.BeOfType<int>();
            output.Type.Should().Be(typeof(int));
        }

        [TestMethod]
        public void ExecMainDt()
        {
            ctx.WithInputParameter("Age", 33);

            ctx.WithInputParameter("Pocet", 2);
            ctx.WithInputParameter("Greeting", "po");
            ctx.WithInputParameter("Rano", false);
            ctx.WithInputParameter("Test", "druhy");
            var result = ctx.Reset().ExecuteDecision("MainDT");

            result.Should().NotBeNull();
            result.IsSingleResult.Should().Be(true);
            result.SingleResult.Should().NotBeNull();
            result.SingleResult.Should().HaveCount(2);
            foreach (var r in result.Results)
            {
                r.MatchedRules.Should().NotBeNull();
                r.MatchedRules.Count.Should().BeGreaterOrEqualTo(1);
            }

            var o1 = result.SingleResult[0];
            o1.Should().NotBeNull();
            o1.Name.Should().Be("Category");
            o1.Value.Should().Be("c").And.BeOfType<string>();
            o1.Type.Should().Be(typeof(string));

            var o2  = result.SingleResult[1];
            o2.Should().NotBeNull();
            o2.Name.Should().Be("Eligible");
            o2.Value.Should().Be(true).And.BeOfType<bool>();
            o2.Type.Should().Be(typeof(bool));

        }

        [TestMethod]
        public void ExecCategoryPlusSuffix()
        {
            ctx.WithInputParameter("Age", 33);

            ctx.WithInputParameter("Pocet", 2);
            ctx.WithInputParameter("Greeting", "po");
            ctx.WithInputParameter("Rano", false);
            ctx.WithInputParameter("Test", "druhy");

            ctx.WithInputParameter("Suffix", "<<");
            var result = ctx.Reset().ExecuteDecision("Category + suffix");

            result.Should().NotBeNull();
            result.IsSingleResult.Should().Be(true);
            result.SingleResult.Should().NotBeNull();
            result.SingleResult.Should().HaveCount(1);
            foreach (var r in result.Results)
            {
                r.MatchedRules.Should().NotBeNull();
                r.MatchedRules.Count.Should().Be(0);
            }

            var output = result.SingleResult[0];
            output.Should().NotBeNull();
            output.Name.Should().Be("CategoryExt");
            output.Value.Should().Be("c<<").And.BeOfType<string>();
            output.Type.Should().Be(typeof(string));
        }

        [TestMethod]
        public void ExecSecondaryDt()
        {
            ctx.WithInputParameter("Age", 33);

            ctx.WithInputParameter("Pocet", 2);
            ctx.WithInputParameter("Greeting", "po");
            ctx.WithInputParameter("Rano", false);
            ctx.WithInputParameter("Test", "druhy");

            ctx.WithInputParameter("Suffix", "<<");
            var result = ctx.ExecuteDecision("Secondary DT");

            result.Should().NotBeNull();
            result.IsSingleResult.Should().Be(true);
            result.SingleResult.Should().NotBeNull();
            result.SingleResult.Should().HaveCount(1);
            foreach (var r in result.Results)
            {
                r.MatchedRules.Should().NotBeNull();
                r.MatchedRules.Count.Should().BeGreaterOrEqualTo(1);
            }

            var output = result.SingleResult[0];
            output.Should().NotBeNull();
            output.Name.Should().Be("Amount");
            output.Value.Should().Be(300).And.BeOfType<int>();
            output.Type.Should().Be(typeof(int));
        }

    }
}
