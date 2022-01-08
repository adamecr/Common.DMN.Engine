using System;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.execution;
using net.adamec.lib.common.dmn.engine.engine.execution.context;

namespace net.adamec.lib.common.dmn.engine.test.issue
{
    [TestClass]
    [TestCategory("Issue Fix Tests")]
    public class Issue11NonAsciiVariableTestsDmn : DmnTestBase
    {
        protected override SourceEnum Source => SourceEnum.File13;

        [TestMethod]
        [DataRow(3, 6, false, false, 8, 0, false)]
        [DataRow(4, 1, false, false, 3, 1, true)]
        [DataRow(6, 1, false, true, 3, 1, true)]
        [DataRow(6, 6, false, true, 8, 0, false)]
        [DataRow(0.9, 7, false, false, 9, 1, false)]
        [DataRow(6.1, 6, false, true, 8, 0, false)]
        [DataRow("6", 6, true, true, 8, 0, false)] //input1 will be string, so the eval will fail
        public void NormalizedExpressionDecisionDmnTest(object input1, int input2, bool isExecErr, bool result1, int result2, int result3, bool result4)
        {

            var def = MODEL("issue11expressions.dmn");

            var ctx = DmnExecutionContextFactory.CreateExecutionContext(def);

            var inputParameters = new Dictionary<string, object>
            {
                { "input1_æøåščřáů", input1 },
                { "input_2_æøåščřáů", input2 }
            };
            ctx.WithInputParameters(inputParameters);

            if (!isExecErr)
            {
                var execResult1 = ctx.ExecuteDecision("decision1");
                var execResult2 = ctx.ExecuteDecision("decision2");
                var execResult3 = ctx.ExecuteDecision("decision3");
                var execResult4 = ctx.ExecuteDecision("decision4");
                
                execResult1.First["var1æøåščřáů"].Value.Should().Be(result1);
                execResult2.First["var2æøåšč_99_88___řáů"].Value.Should().Be(result2);
                execResult3.First["var2æøåšč_99_88___řáů"].Value.Should().Be(result3);
                execResult4.First["var1æøåščřáů"].Value.Should().Be(result4);
            }
            else
            {
                Action act = () => ctx.ExecuteDecision("decision1");
                act.Should().Throw<DmnExecutorException>();
            }
        }

        [TestMethod]
        [DataRow(6, "A", false, false, 11, "L", "r1")]
        [DataRow(6, "B", false, false, 22, "M", "r2")] //B is not allowed for tbl input 2, so the "r1" rule is no-match, "r2" is catch
        [DataRow(4, "C", false, false, 22, "M", "r2")]
        [DataRow(4, null, false, false, 22, "M", "r2")] //null is not allowed for tbl input 2, so the "r1" rule is no-match, "r2" is catch
        [DataRow(4, "A", true, false, 6, null, "r3")]
        [DataRow(5, "A", true, false, null, "K", "r4")]
        [DataRow(5, "B", true, false, null, "K", "r4")] //B is not allowed for tbl input 2, but fine with "r4" as the input is not used there
        [DataRow(2, "B", false, false, null, "K", "r4")] //B is not allowed for tbl input 2, but fine with "r4"
        [DataRow(99, "A", false, true, null, "O", "error")] //O is not allowed output
        public void TableDmnTest(int input1, string input2, bool input3, bool isErr, int? resultOut1, string resultOut2, string match)
        {
            var def = DmnTestBase.DEF("issue11tbl.dmn", SourceEnum.File13);

            var ctx = DmnExecutionContextFactory
                .CreateExecutionContext(def)
                .WithInputParameter("input_1_æøåščřáů", input1)
                .WithInputParameter("input2æøåščřáů", input2)
                .WithInputParameter("input3æøåščřáů", input3);

            if (!isErr)
            {
                var result = ctx.ExecuteDecision("tbl");
                result.HasResult.Should().BeTrue();
                if (resultOut1 != null)
                {
                    result.First["var_2_æøåščřáů"].Value.Should().Be(resultOut1);
                }
                else
                {
                    result.First["var_2_æøåščřáů"].Should().BeNull();
                }
                if (resultOut2 != null)
                {
                    result.First["var3æøåščřáů"].Value.Should().Be(resultOut2);
                }
                else
                {
                    result.First["var3æøåščřáů"].Should().BeNull();
                }

                result.First.HitRules.Should().HaveCount(1);
                result.First.HitRules[0].Name.Should().Be(match);
            }
            else
            {
                Action act = () => ctx.ExecuteDecision("tbl");
                act.Should().Throw<Exception>();
            }
        }
    }
}
