using System;
using System.IO;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.decisions;
using net.adamec.lib.common.dmn.engine.engine.runtime;
using net.adamec.lib.common.dmn.engine.parser;

namespace net.adamec.lib.common.dmn.engine.test.net.complex
{
    [TestClass]
    [TestCategory("Complex tests")]
    public class AllowedValuesTests13
    {
        [TestMethod]
        [DataRow("one", "dog", "blue", true, true)]
        [DataRow("one", "cat", "white", true, true)]
        [DataRow("two", "cat", "white", true, true)]
        [DataRow("three", null, "red", true, true)]
        [DataRow("three", "cat", "red", true, true)]
        [DataRow("three", "whale", "red", true, true)] //If the rule input expression is omitted, the value for corresponding input is not checked for allowed values. 
        [DataRow("one", "whale", "blue", false, true)]
        [DataRow("four", "cat", "red", false, true)]
        [DataRow("one", "horse", "yellow", true, false)]
        public void AllowedValuesTest(string a, string b, string c, bool validIn, bool validOut)
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/allowedValues.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse(file,DmnParser.DmnVersionEnum.V1_3));

            ctx.WithInputParameter("a", a);
            ctx.WithInputParameter("b", b);

            DmnDecisionResult result = null;
            Action act = () => { result = ctx.ExecuteDecision("Test"); };

            if (!validIn && validOut)
            {
                act.Should().Throw<DmnExecutorException>().WithMessage("Decision table Test,* Input value * is not in allowed values list *");
                return;
            }

            if (!validOut)
            {
                act.Should().Throw<DmnExecutorException>().WithMessage("Decision table Test,* Output value * is not in allowed values list *");
                return;
            }

            act.Invoke();

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
            output.Name.Should().Be("c");
            output.Value.Should().Be(c).And.BeOfType<string>();
            output.Type.Should().Be(typeof(string));
        }
    }
}
