using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.definition.builder;
using net.adamec.lib.common.dmn.engine.engine.execution;
using net.adamec.lib.common.dmn.engine.engine.execution.context;

namespace net.adamec.lib.common.dmn.engine.test.unit
{
    [TestClass]
    public class ContextInputTests
    {
        [TestMethod]
        public void CtxInputTests()
        {
            var def = new DmnDefinitionBuilder()
               .WithInput<int>("input1", out var input1Ref)
               .WithInput("input2", out var input2Ref)
               .WithVariable<object>("output", out var outputRef)
               .WithExpressionDecision("decision1", "(input1+1).ToString()", outputRef)
               .WithExpressionDecision("decision2", "input2+1", outputRef)
               .Build();

            var ctx = DmnExecutionContextFactory.CreateExecutionContext(def);

            Action act = null;

            //override
            var result1 = ctx
                .WithInputParameter("input1", 5)
                .WithInputParameter("input1", 10)
                .ExecuteDecision("decision1");
            result1.First["output"].Value.Should().Be("11");

            //wrong type
            act = () =>
            {
                var result = ctx.WithInputParameter("input1", "dummy");
            };
            act.Should().Throw<DmnExecutorException>("Can't cast value to target type: Int32. Value is: dummy of type String");

            //type "on init" and the cache setting impact
            var ctx2 = DmnExecutionContextFactory.CreateExecutionContext(def);
            var result2 = ctx2
                .WithInputParameter("input2", 5)
                .ExecuteDecision("decision2");
            result2.First["output"].Value.Should().Be(6);

            //cached with 'input2+1' parsed with input2:int -> should throw
            act = () =>
            {
                var ctx3 = DmnExecutionContextFactory.CreateExecutionContext(def);
                var result3 = ctx3
                    .WithInputParameter("input2", "6")
                    .ExecuteDecision("decision2");
                result3.First["output"].Value.Should().Be("61");
            };
            act.Should().Throw<DmnExecutorException>("Exception while invoking the expression input2+1--->System.ArgumentException: Object of type 'System.String' cannot be converted to type 'System.Int32'");

            //bypass cache -> should parse and execute with input2:string
            var ctx4 = DmnExecutionContextFactory.CreateExecutionContext(def, o => o.ParsedExpressionCacheScope = ParsedExpressionCacheScopeEnum.None);
            var result4 = ctx4
                .WithInputParameter("input2", "6")
                .ExecuteDecision("decision2");
            result4.First["output"].Value.Should().Be("61");

        }
    }
}
