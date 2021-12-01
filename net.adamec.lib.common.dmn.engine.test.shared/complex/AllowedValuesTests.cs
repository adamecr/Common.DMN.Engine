using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.execution;
using net.adamec.lib.common.dmn.engine.engine.execution.result;

namespace net.adamec.lib.common.dmn.engine.test.complex
{
    [TestClass]
    [TestCategory("Complex tests")]
    public class AllowedValuesTests : DmnTestBase
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
            var ctx = CTX("allowedValues.dmn");
            ctx.WithInputParameter("a", a);
            ctx.WithInputParameter("b", b);

            DmnDecisionResult result = null;
            Action act = () => { result = ctx.ExecuteDecision("Test"); };

            if (!validIn && validOut)
            {
                act.Should().NotThrow();
                result.HasResult.Should().BeFalse();
                //act.Should().Throw<DmnExecutorException>().WithMessage("Decision table Test, *Input value * is not in allowed values list *");
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
            result.FirstResultVariables.Should().NotBeNull();
            result.FirstResultVariables.Should().HaveCount(1);
            result.Results[0].HitRules.Should().HaveCount(1);

            var output = result.FirstResultVariables[0];
            output.Should().NotBeNull();
            output.Name.Should().Be("c");
            output.Value.Should().Be(c).And.BeOfType<string>();
            output.Type.Should().Be(typeof(string));
        }
    }
}
