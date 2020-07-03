using System;
using System.IO;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.decisions;
using net.adamec.lib.common.dmn.engine.engine.runtime;
using net.adamec.lib.common.dmn.engine.parser;

namespace net.adamec.lib.common.dmn.engine.test.net.complex
{
    [TestClass]
    [TestCategory("Complex tests - hit policy")]
    public class HitPolicyMultiOutTests13
    {
        [TestMethod]
        [DataRow(1, 1, "double one", 11, true)]
        [DataRow(1, 2, "b2", 3, true)]
        [DataRow(4, 2, "b2", 6, true)]
        [DataRow(1, 3, "13", 13, true)]
        [DataRow(5, 4, "54", null, true)]
        [DataRow(4, 5, null, 45, true)]
        [DataRow(5, 5, null, null, true)]
        [DataRow(6, 6, null, null, false)]
        [DataRow(null, null, null, null, false)]
        [DataRow(null, 2, "b2", 2, true)]
        public void UniqueHitPolicyMultiOutTest(int? a, int? b, string o1, int? o2, bool hasHit)
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_MultiOut_Unique.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));

            ctx.WithInputParameter("a", a);
            ctx.WithInputParameter("b", b);

            var result = ctx.ExecuteDecision("Unique");


            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();

            if (!hasHit)
            {
                result.Results.Should().HaveCount(0);
                result.HasResult.Should().Be(false);
                result.IsSingleResult.Should().Be(false);
                return;
            }

            result.Results.Should().HaveCount(1);
            result.HasResult.Should().Be(true);

            result.IsSingleResult.Should().Be(true);
            result.SingleResult.Should().NotBeNull();
            var outCount = 0;
            if (o1 != null) outCount++;
            if (o2 != null) outCount++;

            result.SingleResult.Should().HaveCount(outCount);

            if (o1 != null)
            {
                var output1 = result.SingleResult[0];
                output1.Should().NotBeNull();
                output1.Name.Should().Be("o1");
                output1.Value.Should().Be(o1).And.BeOfType<string>();
                output1.Type.Should().Be(typeof(string));

                if (o2 == null) return;

                var output2 = result.SingleResult[1];
                output2.Should().NotBeNull();
                output2.Name.Should().Be("o2");
                output2.Value.Should().Be(o2).And.BeOfType<int>();
                output2.Type.Should().Be(typeof(int));
            }
            else
            {
                if (o2 == null) return;
                var output2 = result.SingleResult[0];
                output2.Should().NotBeNull();
                output2.Name.Should().Be("o2");
                output2.Value.Should().Be(o2).And.BeOfType<int>();
                output2.Type.Should().Be(typeof(int));
            }
        }

        [TestMethod]
        [DataRow(1, 1, "double one", 11, true)]
        [DataRow(1, 2, "b2", 3, true)]
        [DataRow(4, 2, "b2", 6, true)]
        [DataRow(1, 3, "13", 13, true)]
        [DataRow(5, 4, "54", null, true)]
        [DataRow(4, 5, null, 45, true)]
        [DataRow(5, 5, null, null, true)]
        [DataRow(6, 6, null, null, false)]
        [DataRow(null, null, null, null, false)]
        [DataRow(null, 2, "b2", 2, true)]
        [DataRow(5, 2, "b2", 7, true)]
        public void FirstHitPolicyMultiOutTest(int? a, int? b, string o1, int? o2, bool hasHit)
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_MultiOut_First.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));

            ctx.WithInputParameter("a", a);
            ctx.WithInputParameter("b", b);

            var result = ctx.ExecuteDecision("First");


            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();

            if (!hasHit)
            {
                result.Results.Should().HaveCount(0);
                result.HasResult.Should().Be(false);
                result.IsSingleResult.Should().Be(false);
                return;
            }

            result.Results.Should().HaveCount(1);
            result.HasResult.Should().Be(true);

            result.IsSingleResult.Should().Be(true);
            result.SingleResult.Should().NotBeNull();
            var outCount = 0;
            if (o1 != null) outCount++;
            if (o2 != null) outCount++;

            result.SingleResult.Should().HaveCount(outCount);

            if (o1 != null)
            {
                var output1 = result.SingleResult[0];
                output1.Should().NotBeNull();
                output1.Name.Should().Be("o1");
                output1.Value.Should().Be(o1).And.BeOfType<string>();
                output1.Type.Should().Be(typeof(string));

                if (o2 == null) return;

                var output2 = result.SingleResult[1];
                output2.Should().NotBeNull();
                output2.Name.Should().Be("o2");
                output2.Value.Should().Be(o2).And.BeOfType<int>();
                output2.Type.Should().Be(typeof(int));
            }
            else
            {
                if (o2 == null) return;
                var output2 = result.SingleResult[0];
                output2.Should().NotBeNull();
                output2.Name.Should().Be("o2");
                output2.Value.Should().Be(o2).And.BeOfType<int>();
                output2.Type.Should().Be(typeof(int));
            }
        }

        [TestMethod]
        [DataRow(1, 4, "b", 7, "b", true)]
        [DataRow(3, 4, "a", 5, "b", true)]
        [DataRow(4, 4, "b", 4, "a", true)]
        [DataRow(5, 4, "b", 7, "b", true)]
        [DataRow(6, 4, "b", 7, "b", true)]
        [DataRow(8, 4, "b", null, "c", true)]
        [DataRow(9, 4, "b", null, "c", true)]
        [DataRow(3, 2, "a", 5, "b", true)]
        [DataRow(3, 8, "a", 5, "b", true)] //null result on o1 is at the end of list
        [DataRow(4, 8, null, 9, "a", true)]
        [DataRow(5, 8, null, 2, "b", true)]
        [DataRow(6, 8, "a", 2, "d", true)]
        [DataRow(7, 8, null, 2, "b", true)]
        [DataRow(8, 8, null, null, null, false)]
        [DataRow(null, 8, null, null, null, false)]
        [DataRow(null, 4, "b", 7, "b", true)] //null -> 0
        [DataRow(3, null, "a", 5, "b", true)] //null -> 0
        [DataRow(null, null, null, null, null, false)]//null -> 0
        public void PriorityHitPolicyMultiOutTest(int? a, int? b, string o1, int? o2, string o3, bool hasHit)
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_MultiOut_Priority.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));

            ctx.WithInputParameter("a", a);
            ctx.WithInputParameter("b", b);

            var result = ctx.ExecuteDecision("Priority");


            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();

            if (!hasHit)
            {
                result.Results.Should().HaveCount(0);
                result.HasResult.Should().Be(false);
                result.IsSingleResult.Should().Be(false);
                return;
            }

            result.Results.Should().HaveCount(1);
            result.HasResult.Should().Be(true);

            result.IsSingleResult.Should().Be(true);
            result.SingleResult.Should().NotBeNull();
            var outCount = 3;
            var o1Index = 0;
            var o2Index = 1;
            var o3Index = 2;
            if (o1 == null)
            {
                outCount--;
                o1Index = -1;
                o2Index--;
                o3Index--;
            }
            if (o2 == null)
            {
                outCount--;
                o2Index = -1;
                o3Index--;
            }

            if (o3 == null)
            {
                o3Index = -1;
                outCount--;
            }

            result.SingleResult.Should().HaveCount(outCount);

            if (o1Index >= 0)
            {
                var output1 = result.SingleResult[o1Index];
                output1.Should().NotBeNull();
                output1.Name.Should().Be("o1");
                output1.Value.Should().Be(o1).And.BeOfType<string>();
                output1.Type.Should().Be(typeof(string));
            }

            if (o2Index >= 0)
            {

                var output2 = result.SingleResult[o2Index];
                output2.Should().NotBeNull();
                output2.Name.Should().Be("o2");
                output2.Value.Should().Be(o2).And.BeOfType<int>();
                output2.Type.Should().Be(typeof(int));
            }

            // ReSharper disable once InvertIf
            if (o3Index >= 0)
            {
                var output3 = result.SingleResult[o3Index];
                output3.Should().NotBeNull();
                output3.Name.Should().Be("o3");
                output3.Value.Should().Be(o3).And.BeOfType<string>();
                output3.Type.Should().Be(typeof(string));
            }
        }

        [TestMethod]
        [DataRow(1, 1, "b", 1, true, false)]
        [DataRow(4, 1, "b", 1, true, false)]
        [DataRow(3, 1, null, null, false, true)]
        [DataRow(1, 2, "a", null, true, false)]
        [DataRow(4, 2, "a", null, true, false)]
        [DataRow(7, 2, "a", null, true, false)]
        [DataRow(9, 2, "a", null, true, false)]
        [DataRow(3, 2, null, null, false, true)]
        [DataRow(2, 2, null, null, false, true)]
        [DataRow(1, 3, null, 3, true, false)]
        [DataRow(4, 3, null, 3, true, false)]
        [DataRow(3, 3, null, null, false, true)]
        [DataRow(1, 4, null, null, true, false)]
        [DataRow(4, 4, null, null, true, false)]
        [DataRow(3, 4, null, null, false, true)]
        [DataRow(2, 4, null, null, false, true)]
        [DataRow(7, 4, null, null, false, false)]
        [DataRow(null, 2, "a", null, true, false)]
        [DataRow(null, 3, null, 3, true, false)]
        [DataRow(null, 5, null, null, false, false)]
        [DataRow(1, null, null, null, false, false)]
        [DataRow(null, null, null, null, false, false)]
        public void AnyHitPolicyMultiOutTest(int? a, int? b, string o1, int? o2, bool hasHit, bool isErr)
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_MultiOut_Any.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));

            ctx.WithInputParameter("a", a);
            ctx.WithInputParameter("b", b);

            DmnDecisionResult result = null;
            Action act = () => { result = ctx.ExecuteDecision("Any"); };

            if (isErr)
            {
                act.Should().Throw<DmnExecutorException>().WithMessage("ANY hit policy violation - the outputs don't match");
                return;
            }
            act.Invoke();


            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();

            if (!hasHit)
            {
                result.Results.Should().HaveCount(0);
                result.HasResult.Should().Be(false);
                result.IsSingleResult.Should().Be(false);
                return;
            }

            result.Results.Should().HaveCount(1);
            result.HasResult.Should().Be(true);

            result.IsSingleResult.Should().Be(true);
            result.SingleResult.Should().NotBeNull();
            var outCount = 2;
            var o1Index = 0;
            var o2Index = 1;

            if (o1 == null)
            {
                outCount--;
                o1Index = -1;
                o2Index--;
            }
            if (o2 == null)
            {
                outCount--;
                o2Index = -1;
            }

            result.SingleResult.Should().HaveCount(outCount);

            if (o1Index >= 0)
            {
                var output1 = result.SingleResult[o1Index];
                output1.Should().NotBeNull();
                output1.Name.Should().Be("o1");
                output1.Value.Should().Be(o1).And.BeOfType<string>();
                output1.Type.Should().Be(typeof(string));
            }

            // ReSharper disable once InvertIf
            if (o2Index >= 0)
            {

                var output2 = result.SingleResult[o2Index];
                output2.Should().NotBeNull();
                output2.Name.Should().Be("o2");
                output2.Value.Should().Be(o2).And.BeOfType<int>();
                output2.Type.Should().Be(typeof(int));
            }
        }

        [TestMethod]
        [DataRow(1, 4, new[] { "b", "b" }, new[] { 7, -1 }, new[] { "b", "c" }, true)]
        [DataRow(3, 4, new[] { "a", "a", "b", "b" }, new[] { 5, -1, 7, -1 }, new[] { "b", "e", "b", "c" }, true)]
        [DataRow(4, 4, new[] { "b", "b", "b" }, new[] { 4, 7, -1 }, new[] { "a", "b", "c" }, true)]
        [DataRow(5, 4, new[] { "b", "b", "b" }, new[] { 7, 5, -1 }, new[] { "b", "b", "c" }, true)]
        [DataRow(6, 4, new[] { "b", "b" }, new[] { 7, -1 }, new[] { "b", "c" }, true)]
        [DataRow(8, 4, new[] { "b" }, new[] { -1 }, new[] { "c" }, true)]
        [DataRow(9, 4, new[] { "b", "b" }, new[] { -1, -1 }, new[] { "c", "d" }, true)]
        [DataRow(3, 2, new[] { "a" }, new[] { 5 }, new[] { "b" }, true)]
        [DataRow(3, 8, new[] { "a", null }, new[] { 5, 2 }, new[] { "b", "b" }, true)]
        [DataRow(4, 8, new[] { (string)null, null }, new[] { 9, 2 }, new[] { "a", "b" }, true)]
        [DataRow(5, 8, new[] { (string)null, null }, new[] { 2, 1 }, new[] { "b", "c" }, true)]
        [DataRow(6, 8, new[] { "a", null }, new[] { 2, 2 }, new[] { "d", "b" }, true)]
        [DataRow(7, 8, new[] { (string)null }, new[] { 2 }, new[] { "b" }, true)]
        [DataRow(8, 8, new[] { "" }, new[] { -1 }, new[] { "" }, false)]
        [DataRow(null, 8, new[] { "" }, new[] { -1 }, new[] { "" }, false)]//null -> 0
        [DataRow(null, 4, new[] { "b", "b" }, new[] { 7, -1 }, new[] { "b", "c" }, true)]//null -> 0
        [DataRow(3, null, new[] { "a" }, new[] { 5 }, new[] { "b" }, true)]//null -> 0
        [DataRow(null, null, new[] { "" }, new[] { -1 }, new[] { "" }, false)]//null -> 0
        public void OutputOrderHitPolicyMultiOutTest(int? a, int? b, string[] o1, int[] o2, string[] o3, bool hasHit)
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_MultiOut_OutputOrder.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));

            ctx.WithInputParameter("a", a);
            ctx.WithInputParameter("b", b);

            DmnDecisionResult result = null;
            Action act = () => { result = ctx.ExecuteDecision("OutputOrder"); };

            act.Invoke();

            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();

            if (!hasHit)
            {
                result.Results.Should().HaveCount(0);
                result.HasResult.Should().Be(false);
                result.IsSingleResult.Should().Be(false);
                return;
            }

            var hitsCount = o1.Length;
            result.Results.Should().HaveCount(hitsCount);
            result.HasResult.Should().Be(true);

            if (hitsCount == 1)
            {
                result.IsSingleResult.Should().Be(true);
                result.SingleResult.Should().NotBeNull();
            }

            result.Results.Should().HaveCount(hitsCount);
            var idx = 0;
            foreach (var resultHit in result.Results)
            {
                var o1Result = resultHit.Variables?.FirstOrDefault(v => v.Name == "o1");
                var o2Result = resultHit.Variables?.FirstOrDefault(v => v.Name == "o2");
                var o3Result = resultHit.Variables?.FirstOrDefault(v => v.Name == "o3");
                var o1Asserrt = o1[idx];
                var o2Asserrt = o2[idx];
                var o3Asserrt = o3[idx];

                if (o1Result == null)
                {
                    o1Asserrt.Should().BeNull();
                }
                else
                {
                    o1Result.Should().NotBeNull();
                    o1Result.Value.Should().NotBeNull();
                    o1Result.Value.Should().Be(o1Asserrt).And.BeOfType<string>();
                    o1Result.Type.Should().Be(typeof(string));
                }
                if (o2Result == null)
                {
                    o2Asserrt.Should().Be(-1); //-1 means null
                }
                else
                {
                    o2Result.Should().NotBeNull();
                    o2Result.Value.Should().NotBeNull();
                    o2Result.Value.Should().Be(o2Asserrt).And.BeOfType<int>();
                    o2Result.Type.Should().Be(typeof(int));
                }
                if (o3Result == null)
                {
                    o3Asserrt.Should().BeNull();
                }
                else
                {
                    o3Result.Should().NotBeNull();
                    o3Result.Value.Should().NotBeNull();
                    o3Result.Value.Should().Be(o3Asserrt).And.BeOfType<string>();
                    o3Result.Type.Should().Be(typeof(string));
                }
                idx++;
            }
        }

        [TestMethod]
        [DataRow(1, 4, new[] { "b", "b" }, new[] { 7, -1 }, new[] { "b", "c" }, true)]
        [DataRow(3, 4, new[] { "b", "b", "a", "a" }, new[] { 7, -1, -1, 5 }, new[] { "b", "c", "e", "b" }, true)]
        [DataRow(4, 4, new[] { "b", "b", "b" }, new[] { 7, -1, 4 }, new[] { "b", "c", "a" }, true)]
        [DataRow(5, 4, new[] { "b", "b", "b" }, new[] { 7, 5, -1 }, new[] { "b", "b", "c" }, true)]
        [DataRow(6, 4, new[] { "b", "b" }, new[] { 7, -1 }, new[] { "b", "c" }, true)]
        [DataRow(8, 4, new[] { "b" }, new[] { -1 }, new[] { "c" }, true)]
        [DataRow(9, 4, new[] { "b", "b" }, new[] { -1, -1 }, new[] { "c", "d" }, true)]
        [DataRow(3, 2, new[] { "a" }, new[] { 5 }, new[] { "b" }, true)]
        [DataRow(3, 8, new[] { "a", null }, new[] { 5, 2 }, new[] { "b", "b" }, true)]
        [DataRow(4, 8, new[] { (string)null, null }, new[] { 2, 9 }, new[] { "b", "a" }, true)]
        [DataRow(5, 8, new[] { (string)null, null }, new[] { 2, 1 }, new[] { "b", "c" }, true)]
        [DataRow(6, 8, new[] { null,"a" }, new[] { 2, 2 }, new[] { "b", "d" }, true)]
        [DataRow(7, 8, new[] { (string)null }, new[] { 2 }, new[] { "b" }, true)]
        [DataRow(8, 8, new[] { "" }, new[] { -1 }, new[] { "" }, false)]
        [DataRow(null, 8, new[] { "" }, new[] { -1 }, new[] { "" }, false)]//null -> 0
        [DataRow(null, 4, new[] { "b", "b" }, new[] { 7, -1 }, new[] { "b", "c" }, true)]//null -> 0
        [DataRow(3, null, new[] { "a" }, new[] { 5 }, new[] { "b" }, true)]//null -> 0
        [DataRow(null, null, new[] { "" }, new[] { -1 }, new[] { "" }, false)]//null -> 0
        public void RuleOrderHitPolicyMultiOutTest(int? a, int? b, string[] o1, int[] o2, string[] o3, bool hasHit)
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_MultiOut_RuleOrder.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));

            ctx.WithInputParameter("a", a);
            ctx.WithInputParameter("b", b);

            DmnDecisionResult result = null;
            Action act = () => { result = ctx.ExecuteDecision("RuleOrder"); };

            act.Invoke();

            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();

            if (!hasHit)
            {
                result.Results.Should().HaveCount(0);
                result.HasResult.Should().Be(false);
                result.IsSingleResult.Should().Be(false);
                return;
            }

            var hitsCount = o1.Length;
            result.Results.Should().HaveCount(hitsCount);
            result.HasResult.Should().Be(true);

            if (hitsCount == 1)
            {
                result.IsSingleResult.Should().Be(true);
                result.SingleResult.Should().NotBeNull();
            }

            result.Results.Should().HaveCount(hitsCount);
            var idx = 0;
            foreach (var resultHit in result.Results)
            {
                var o1Result = resultHit.Variables?.FirstOrDefault(v => v.Name == "o1");
                var o2Result = resultHit.Variables?.FirstOrDefault(v => v.Name == "o2");
                var o3Result = resultHit.Variables?.FirstOrDefault(v => v.Name == "o3");
                var o1Asserrt = o1[idx];
                var o2Asserrt = o2[idx];
                var o3Asserrt = o3[idx];

                if (o1Result == null)
                {
                    o1Asserrt.Should().BeNull();
                }
                else
                {
                    o1Result.Should().NotBeNull();
                    o1Result.Value.Should().NotBeNull();
                    o1Result.Value.Should().Be(o1Asserrt).And.BeOfType<string>();
                    o1Result.Type.Should().Be(typeof(string));
                }
                if (o2Result == null)
                {
                    o2Asserrt.Should().Be(-1); //-1 means null
                }
                else
                {
                    o2Result.Should().NotBeNull();
                    o2Result.Value.Should().NotBeNull();
                    o2Result.Value.Should().Be(o2Asserrt).And.BeOfType<int>();
                    o2Result.Type.Should().Be(typeof(int));
                }
                if (o3Result == null)
                {
                    o3Asserrt.Should().BeNull();
                }
                else
                {
                    o3Result.Should().NotBeNull();
                    o3Result.Value.Should().NotBeNull();
                    o3Result.Value.Should().Be(o3Asserrt).And.BeOfType<string>();
                    o3Result.Type.Should().Be(typeof(string));
                }
                idx++;
            }
        }

    }
}
