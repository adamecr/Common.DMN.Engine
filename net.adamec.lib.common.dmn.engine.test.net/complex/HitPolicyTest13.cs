using System;
using System.IO;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.decisions;
using net.adamec.lib.common.dmn.engine.engine.runtime;
using net.adamec.lib.common.dmn.engine.parser;

namespace net.adamec.lib.common.dmn.engine.test.net.complex
{
    //TODO multi outputs tests
    [TestClass]
    [TestCategory("Complex tests - hit policy")]
    public class HitPolicyTest13
    {
        [TestMethod]
        [DataRow(2, 1, "<5 1", 1, 1)]
        [DataRow(2, 2, "<=5 2", 1, 1)]
        [DataRow(5, 1, "5 1", 1, 1)]
        [DataRow(5, 2, "5 2", -1, -1)] //exception non unique 
        [DataRow(6, 1, "6", 1, 1)]
        [DataRow(6, 2, "6", 1, 1)]
        [DataRow(6, 3, "6", -1, -1)] //exception non unique 
        [DataRow(6, 4, "6", 1, 1)]
        [DataRow(6, null, "6", 1, 1)]
        [DataRow(7, 2, ">6 2", 1, 1)]
        [DataRow(7, 1, null, 1, 0)] //hit, empty out
        [DataRow(1, 3, "- 3", 1, 1)]
        [DataRow(null, 3, "- 3", 1, 1)]
        [DataRow(null, null, null, 0, 0)] //no hit
        [DataRow(9, 9, null, 0, 0)] //no hit
        public void UniqueHitPolicyTest(int? a, int? b, string c, int hitsCount, int outVariableCount)
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_Unique.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));

            ctx.WithInputParameter("a", a);
            ctx.WithInputParameter("b", b);

            DmnDecisionResult result = null;
            Action act = () => { result = ctx.ExecuteDecision("Unique"); };

            if (hitsCount < 0)
            {
                act.Should().Throw<DmnExecutorException>().WithMessage("UNIQUE hit policy violation*");
                return;
            }

            act.Invoke();

            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();

            if (hitsCount <= 0)
            {
                result.Results.Should().HaveCount(0);
                result.HasResult.Should().Be(false);
                result.IsSingleResult.Should().Be(false);
                return;
            }

            result.Results.Should().HaveCount(hitsCount);
            result.HasResult.Should().Be(true);
            if (hitsCount == 1)
            {
                result.IsSingleResult.Should().Be(true);
                result.SingleResult.Should().NotBeNull();
                result.SingleResult.Should().HaveCount(outVariableCount);
            }

            if (outVariableCount <= 0) return;

            var output = result.SingleResult[0];
            output.Should().NotBeNull();
            output.Name.Should().Be("o");
            output.Value.Should().Be(c).And.BeOfType<string>();
            output.Type.Should().Be(typeof(string));
        }

        [TestMethod]
        [DataRow(2, 1, "<5 1", 1, 1)]
        [DataRow(2, 2, "<=5 2", 1, 1)]
        [DataRow(5, 1, "5 1", 1, 1)]
        [DataRow(5, 2, "<=5 2", 1, 1)]
        [DataRow(6, 1, "6", 1, 1)]
        [DataRow(6, 2, "6", 1, 1)]
        [DataRow(6, 3, "6", 1, 1)]
        [DataRow(6, 4, "6", 1, 1)]
        [DataRow(6, null, "6", 1, 1)]
        [DataRow(7, 2, " - 2", 1, 1)]
        [DataRow(7, 1, null, 1, 0)] //hit empty output
        [DataRow(null, 1, "<5 1", 1, 1)]
        [DataRow(1, 3, "fallback", 1, 1)]
        [DataRow(null, 3, "fallback", 1, 1)]
        [DataRow(null, null, "fallback", 1, 1)]
        public void FirstHitPolicyTest(int? a, int? b, string c, int hitsCount, int outVariableCount)
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_First.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));

            ctx.WithInputParameter("a", a);
            ctx.WithInputParameter("b", b);


            var result = ctx.ExecuteDecision("First");

            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();

            if (hitsCount <= 0)
            {
                result.Results.Should().HaveCount(0);
                result.HasResult.Should().Be(false);
                result.IsSingleResult.Should().Be(false);
                return;
            }

            result.Results.Should().HaveCount(hitsCount);
            result.HasResult.Should().Be(true);
            if (hitsCount == 1)
            {
                result.IsSingleResult.Should().Be(true);
                result.SingleResult.Should().NotBeNull();
                result.SingleResult.Should().HaveCount(outVariableCount);
            }

            if (outVariableCount <= 0) return;

            var output = result.SingleResult[0];
            output.Should().NotBeNull();
            output.Name.Should().Be("o");
            output.Value.Should().Be(c).And.BeOfType<string>();
            output.Type.Should().Be(typeof(string));
        }

        [TestMethod]
        [DataRow(2, 2, "x5 2", 1, 1)]
        [DataRow(5, 1, "5 1", 1, 1)]
        [DataRow(5, 2, "x5 2", 1, 1)] //any match
        [DataRow(6, 1, "6", 1, 1)]
        [DataRow(6, 2, "6", 1, 1)]
        [DataRow(6, 3, "6", -1, -1)] //exception not same matches
        [DataRow(6, 4, "6", 1, 1)]
        [DataRow(6, null, "6", 1, 1)]
        [DataRow(7, 2, ">6 2", 1, 1)]
        [DataRow(7, 1, null, 1, 0)] //hit, empty out
        [DataRow(1, 3, "- 3", 1, 1)]
        [DataRow(null, 3, "- 3", 1, 1)]
        [DataRow(null, null, null, 0, 0)]//no hit
        [DataRow(8, 8, null, 0, 0)] //no hit
        public void AnyHitPolicyTest(int? a, int? b, string c, int hitsCount, int outVariableCount)
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_Any.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));

            ctx.WithInputParameter("a", a);
            ctx.WithInputParameter("b", b);

            DmnDecisionResult result = null;
            Action act = () => { result = ctx.ExecuteDecision("Any"); };

            if (hitsCount < 0)
            {
                act.Should().Throw<DmnExecutorException>().WithMessage("ANY hit policy violation - the outputs don't match");
                return;
            }

            act.Invoke();

            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();

            if (hitsCount <= 0)
            {
                result.Results.Should().HaveCount(0);
                result.HasResult.Should().Be(false);
                result.IsSingleResult.Should().Be(false);
                return;
            }

            result.Results.Should().HaveCount(hitsCount);
            result.HasResult.Should().Be(true);
            if (hitsCount == 1)
            {
                result.IsSingleResult.Should().Be(true);
                result.SingleResult.Should().NotBeNull();
                result.SingleResult.Should().HaveCount(outVariableCount);
            }

            if (outVariableCount <= 0) return;

            var output = result.SingleResult[0];
            output.Should().NotBeNull();
            output.Name.Should().Be("o");
            output.Value.Should().Be(c).And.BeOfType<string>();
            output.Type.Should().Be(typeof(string));
        }

        [TestMethod]
        [DataRow(2, 1, "a", 1, 1)]
        [DataRow(5, 1, "a", 1, 1)]
        [DataRow(5, 2, "b", 1, 1)]
        [DataRow(6, 1, "d", 1, 1)]
        [DataRow(6, 2, "a", 1, 1)]
        [DataRow(6, 3, "c", 1, 1)]
        [DataRow(6, 4, "d", 1, 1)]
        [DataRow(6, null, "d", 1, 1)]
        [DataRow(7, 2, "a", 1, 1)]
        [DataRow(7, 1, null, 1, 0)]//hit, empty output
        [DataRow(1, 3, "c", 1, 1)]
        [DataRow(null, 3, "c", 1, 1)]
        [DataRow(null, null, null, 0, 0)] //no hit
        [DataRow(8, 8, null, 0, 0)] //no hit
        public void PriorityHitPolicyTest(int? a, int? b, string c, int hitsCount, int outVariableCount)
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_Priority.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));

            ctx.WithInputParameter("a", a);
            ctx.WithInputParameter("b", b);

            DmnDecisionResult result = null;
            Action act = () => { result = ctx.ExecuteDecision("Priority"); };

            act.Invoke();

            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();

            if (hitsCount <= 0)
            {
                result.Results.Should().HaveCount(0);
                result.HasResult.Should().Be(false);
                result.IsSingleResult.Should().Be(false);
                return;
            }

            result.Results.Should().HaveCount(hitsCount);
            result.HasResult.Should().Be(true);
            if (hitsCount == 1)
            {
                result.IsSingleResult.Should().Be(true);
                result.SingleResult.Should().NotBeNull();
                result.SingleResult.Should().HaveCount(outVariableCount);
            }

            if (outVariableCount <= 0) return;

            var output = result.SingleResult[0];
            output.Should().NotBeNull();
            output.Name.Should().Be("o");
            output.Value.Should().Be(c).And.BeOfType<string>();
            output.Type.Should().Be(typeof(string));
        }

        [TestMethod]
        public void Priority_NoOutWithAllowedHitPolicyTest()
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_Priority_NoOutWithAllowed.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));

            ctx.WithInputParameter("a", 2);
            ctx.WithInputParameter("b", 1);

            Action act = () => { ctx.ExecuteDecision("Priority"); };


            act.Should().Throw<DmnExecutorException>().WithMessage("PRIORITY hit policy violation - no outputs with Allowed Values");

        }

        [TestMethod]
        [DataRow(2, 1, new[] { "a" }, 1, new[] { 1 })]
        [DataRow(5, 1, new[] { "c", "a" }, 2, new[] { 1, 1 })]
        [DataRow(5, 2, new[] { "b", "a" }, 2, new[] { 1, 1 })]
        [DataRow(6, 1, new[] { "d", null }, 2, new[] { 1, 0 })]
        [DataRow(6, 2, new[] { "d", "a" }, 2, new[] { 1, 1 })]
        [DataRow(6, 3, new[] { "d", "c" }, 2, new[] { 1, 1 })]
        [DataRow(6, 4, new[] { "d" }, 1, new[] { 1 })]
        [DataRow(6, null, new[] { "d" }, 1, new[] { 1 })]
        [DataRow(7, 2, new[] { "a" }, 1, new[] { 1 })]
        [DataRow(7, 1, null, 1, new[] { 0 })]//hit, empty output
        [DataRow(9, 1, new[] { null, "a" }, 2, new[] { 0, 1 })]
        [DataRow(1, 3, new[] { "c" }, 1, new[] { 1 })]
        [DataRow(null, 3, new[] { "c" }, 1, new[] { 1 })]
        [DataRow(null, null, null, 0, new[] { 0 })] //no hit
        [DataRow(8, 8, null, 0, new[] { 0 })] //no hit
        public void RuleOrderHitPolicyTest(int? a, int? b, string[] c, int hitsCount, int[] outVariableCount)
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_RuleOrder.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));

            ctx.WithInputParameter("a", a);
            ctx.WithInputParameter("b", b);

            DmnDecisionResult result = null;
            Action act = () => { result = ctx.ExecuteDecision("RuleOrder"); };

            act.Invoke();

            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();

            if (hitsCount <= 0)
            {
                result.Results.Should().HaveCount(0);
                result.HasResult.Should().Be(false);
                result.IsSingleResult.Should().Be(false);
                return;
            }

            result.Results.Should().HaveCount(hitsCount);
            result.HasResult.Should().Be(true);
            if (hitsCount == 1)
            {
                result.IsSingleResult.Should().Be(true);
                result.SingleResult.Should().NotBeNull();
                result.SingleResult.Should().HaveCount(outVariableCount[0]);
            }

            for (var i = 0; i < hitsCount; i++)
            {
                if (outVariableCount[i] <= 0)
                {
                    result.Results[i].Variables.Should().HaveCount(0);
                    continue;
                }

                result.Results[i].Variables.Should().HaveCount(1);
                var output = result.Results[i].Variables[0];
                output.Should().NotBeNull();
                output.Name.Should().Be("o");
                output.Value.Should().Be(c[i]).And.BeOfType<string>();
                output.Type.Should().Be(typeof(string));
            }
        }

        [TestMethod]
        [DataRow(2, 1, new[] { "a" }, 1, new[] { 1 })]
        [DataRow(5, 1, new[] { "a", "c" }, 2, new[] { 1, 1 })]
        [DataRow(5, 2, new[] { "b", "a" }, 2, new[] { 1, 1 })]
        [DataRow(6, 1, new[] { "d", null }, 2, new[] { 1, 0 })]
        [DataRow(6, 2, new[] { "a", "d" }, 2, new[] { 1, 1 })]
        [DataRow(6, 3, new[] { "c", "d" }, 2, new[] { 1, 1 })]
        [DataRow(6, 4, new[] { "d" }, 1, new[] { 1 })]
        [DataRow(6, null, new[] { "d" }, 1, new[] { 1 })]
        [DataRow(7, 2, new[] { "a" }, 1, new[] { 1 })]
        [DataRow(7, 1, null, 1, new[] { 0 })]//hit, empty output
        [DataRow(9, 1, new[] { "a", null }, 2, new[] { 1, 0 })] //null at the end of ordered list
        [DataRow(1, 3, new[] { "c" }, 1, new[] { 1 })]
        [DataRow(null, 3, new[] { "c" }, 1, new[] { 1 })]
        [DataRow(null, null, null, 0, new[] { 0 })] //no hit
        [DataRow(8, 8, null, 0, new[] { 0 })] //no hit
        public void OutputOrderHitPolicyTest(int? a, int? b, string[] c, int hitsCount, int[] outVariableCount)
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_OutputOrder.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));

            ctx.WithInputParameter("a", a);
            ctx.WithInputParameter("b", b);

            DmnDecisionResult result = null;
            Action act = () => { result = ctx.ExecuteDecision("OutputOrder"); };

            act.Invoke();

            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();

            if (hitsCount <= 0)
            {
                result.Results.Should().HaveCount(0);
                result.HasResult.Should().Be(false);
                result.IsSingleResult.Should().Be(false);
                return;
            }

            result.Results.Should().HaveCount(hitsCount);
            result.HasResult.Should().Be(true);
            if (hitsCount == 1)
            {
                result.IsSingleResult.Should().Be(true);
                result.SingleResult.Should().NotBeNull();
                result.SingleResult.Should().HaveCount(outVariableCount[0]);
            }

            for (var i = 0; i < hitsCount; i++)
            {
                if (outVariableCount[i] <= 0)
                {
                    result.Results[i].Variables.Should().HaveCount(0);
                    continue;
                }

                result.Results[i].Variables.Should().HaveCount(1);
                var output = result.Results[i].Variables[0];
                output.Should().NotBeNull();
                output.Name.Should().Be("o");
                output.Value.Should().Be(c[i]).And.BeOfType<string>();
                output.Type.Should().Be(typeof(string));
            }
        }

        [TestMethod]
        public void OutputOrder_NoOutWithAllowedHitPolicyTest()
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_OutputOrder_NoOutWithAllowed.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));

            ctx.WithInputParameter("a", 2);
            ctx.WithInputParameter("b", 1);

            Action act = () => { ctx.ExecuteDecision("OutputOrder"); };


            act.Should().Throw<DmnExecutorException>().WithMessage("OUTPUT ORDER hit policy violation - no outputs with Allowed Values");

        }


        [TestMethod]
        [DataRow(2, 1, new[] { 5 }, 1, new[] { 1 })]
        [DataRow(5, 1, new[] { 4, 8 }, 2, new[] { 1, 1 })]
        [DataRow(5, 2, new[] { 3, 8 }, 2, new[] { 1, 1 })]
        [DataRow(6, 1, new[] { 2, 1 }, 2, new[] { 1, 1 })]
        [DataRow(6, 2, new[] { 2, -1 }, 2, new[] { 1, 0 })] //-1=null
        [DataRow(6, 3, new[] { 2, 2 }, 2, new[] { 1, 1 })]
        [DataRow(6, 4, new[] { 2 }, 1, new[] { 1 })]
        [DataRow(6, null, new[] { 2 }, 1, new[] { 1 })]
        [DataRow(7, 2, new[] { -1 }, 1, new[] { 0 })]//hit, empty output
        [DataRow(7, 1, new[] { 1 }, 1, new[] { 1 })]
        [DataRow(9, 1, new[] { 1, 3 }, 2, new[] { 1, 1 })]
        [DataRow(1, 3, new[] { 2 }, 1, new[] { 1 })]
        [DataRow(null, 3, new[] { 2 }, 1, new[] { 1 })]
        [DataRow(null, null, new int[] { }, 0, new[] { 0 })] //no hit
        [DataRow(8, 8, new int[] { }, 0, new[] { 0 })] //no hit
        public void CollectListHitPolicyTest(int? a, int? b, int[] cIn, int hitsCount, int[] outVariableCount)
        {
            var c = new int?[cIn.Length];
            for (var i = 0; i < cIn.Length; i++)
            {
                if (cIn[i] >= 0)
                {
                    c[i] = cIn[i];
                }
                else
                {
                    c[i] = null;
                }

            }
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_Collect_List.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));

            ctx.WithInputParameter("a", a);
            ctx.WithInputParameter("b", b);

            DmnDecisionResult result = null;
            Action act = () => { result = ctx.ExecuteDecision("Collect"); };

            act.Invoke();

            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();

            if (hitsCount <= 0)
            {
                result.Results.Should().HaveCount(0);
                result.HasResult.Should().Be(false);
                result.IsSingleResult.Should().Be(false);
                return;
            }

            result.Results.Should().HaveCount(hitsCount);
            result.HasResult.Should().Be(true);
            if (hitsCount == 1)
            {
                result.IsSingleResult.Should().Be(true);
                result.SingleResult.Should().NotBeNull();
                result.SingleResult.Should().HaveCount(outVariableCount[0]);
            }

            for (var i = 0; i < hitsCount; i++)
            {
                if (outVariableCount[i] <= 0)
                {
                    result.Results[i].Variables.Should().HaveCount(0);
                    continue;
                }

                result.Results[i].Variables.Should().HaveCount(1);
                var output = result.Results[i].Variables[0];
                output.Should().NotBeNull();
                output.Name.Should().Be("o");
                output.Value.Should().Be(c[i]).And.BeOfType<long>();
                output.Type.Should().Be(typeof(long));
            }
        }

        [TestMethod]
        [DataRow(2, 1, 5, 1)]
        [DataRow(5, 1, 12, 1)]
        [DataRow(5, 2, 11, 1)]
        [DataRow(6, 1, 3, 1)]
        [DataRow(6, 2, 2, 1)]
        [DataRow(6, 3, 4, 1)]
        [DataRow(6, 4, 2, 1)]
        [DataRow(6, null, 2, 1)]
        [DataRow(7, 2, null, 1)]//hit, empty output
        [DataRow(7, 1, 1, 1)]
        [DataRow(9, 1, 4, 1)]
        [DataRow(1, 3, 2, 1)]
        [DataRow(null, 3, 2, 1)]
        [DataRow(null, null, 0, 0)] //no hit
        [DataRow(8, 8, 0, 0)] //no hit
        public void CollectSumHitPolicyTest(int? a, int? b, int? c, int hitsCount)
        {

            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_Collect_Sum.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));

            ctx.WithInputParameter("a", a);
            ctx.WithInputParameter("b", b);

            DmnDecisionResult result = null;
            Action act = () => { result = ctx.ExecuteDecision("Collect"); };

            act.Invoke();

            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();

            if (hitsCount <= 0)
            {
                result.Results.Should().HaveCount(0);
                result.HasResult.Should().Be(false);
                result.IsSingleResult.Should().Be(false);
                return;
            }

            result.Results.Should().HaveCount(hitsCount);
            result.HasResult.Should().Be(true);

            result.IsSingleResult.Should().Be(true);
            result.SingleResult.Should().NotBeNull();
            result.SingleResult.Should().HaveCount(1);

            result.Results[0].Variables.Should().HaveCount(1);
            var output = result.Results[0].Variables[0];
            output.Should().NotBeNull();
            output.Name.Should().Be("o");
            if (c != null)
            {
                output.Value.Should().Be(c).And.BeOfType<long>();
                output.Type.Should().Be(typeof(long));
            }
            else
            {
                output.Value.Should().BeNull();
                output.Type.Should().Be(typeof(long));
            }
        }

        [TestMethod]
        [DataRow(2, 1, 5, 1)]
        [DataRow(5, 1, 4, 1)]
        [DataRow(5, 2, 3, 1)]
        [DataRow(6, 1, 1, 1)]
        [DataRow(6, 2, 2, 1)]
        [DataRow(6, 3, 2, 1)]
        [DataRow(6, 4, 2, 1)]
        [DataRow(6, null, 2, 1)]
        [DataRow(7, 2, null, 1)]//hit, empty output
        [DataRow(7, 1, 1, 1)]
        [DataRow(9, 1, 1, 1)]
        [DataRow(1, 3, 2, 1)]
        [DataRow(null, 3, 2, 1)]
        [DataRow(null, null, 0, 0)] //no hit
        [DataRow(8, 8, 0, 0)] //no hit
        public void CollectMinHitPolicyTest(int? a, int? b, int? c, int hitsCount)
        {

            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_Collect_Min.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));

            ctx.WithInputParameter("a", a);
            ctx.WithInputParameter("b", b);

            DmnDecisionResult result = null;
            Action act = () => { result = ctx.ExecuteDecision("Collect"); };

            act.Invoke();

            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();

            if (hitsCount <= 0)
            {
                result.Results.Should().HaveCount(0);
                result.HasResult.Should().Be(false);
                result.IsSingleResult.Should().Be(false);
                return;
            }

            result.Results.Should().HaveCount(hitsCount);
            result.HasResult.Should().Be(true);

            result.IsSingleResult.Should().Be(true);
            result.SingleResult.Should().NotBeNull();
            result.SingleResult.Should().HaveCount(1);

            result.Results[0].Variables.Should().HaveCount(1);
            var output = result.Results[0].Variables[0];
            output.Should().NotBeNull();
            output.Name.Should().Be("o");
            if (c != null)
            {
                output.Value.Should().Be(c).And.BeOfType<long>();
                output.Type.Should().Be(typeof(long));
            }
            else
            {
                output.Value.Should().BeNull();
                output.Type.Should().Be(typeof(long));
            }
        }

        [TestMethod]
        [DataRow(2, 1, 5, 1)]
        [DataRow(5, 1, 8, 1)]
        [DataRow(5, 2, 8, 1)]
        [DataRow(6, 1, 2, 1)]
        [DataRow(6, 2, 2, 1)]
        [DataRow(6, 3, 2, 1)]
        [DataRow(6, 4, 2, 1)]
        [DataRow(6, null, 2, 1)]
        [DataRow(7, 2, null, 1)]//hit, empty output
        [DataRow(7, 1, 1, 1)]
        [DataRow(9, 1, 3, 1)]
        [DataRow(1, 3, 2, 1)]
        [DataRow(null, 3, 2, 1)]
        [DataRow(null, null, 0, 0)] //no hit
        [DataRow(8, 8, 0, 0)] //no hit
        public void CollectMaxHitPolicyTest(int? a, int? b, int? c, int hitsCount)
        {

            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_Collect_Max.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));

            ctx.WithInputParameter("a", a);
            ctx.WithInputParameter("b", b);

            DmnDecisionResult result = null;
            Action act = () => { result = ctx.ExecuteDecision("Collect"); };

            act.Invoke();

            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();

            if (hitsCount <= 0)
            {
                result.Results.Should().HaveCount(0);
                result.HasResult.Should().Be(false);
                result.IsSingleResult.Should().Be(false);
                return;
            }

            result.Results.Should().HaveCount(hitsCount);
            result.HasResult.Should().Be(true);

            result.IsSingleResult.Should().Be(true);
            result.SingleResult.Should().NotBeNull();
            result.SingleResult.Should().HaveCount(1);

            result.Results[0].Variables.Should().HaveCount(1);
            var output = result.Results[0].Variables[0];
            output.Should().NotBeNull();
            output.Name.Should().Be("o");
            if (c != null)
            {
                output.Value.Should().Be(c).And.BeOfType<long>();
                output.Type.Should().Be(typeof(long));
            }
            else
            {
                output.Value.Should().BeNull();
                output.Type.Should().Be(typeof(long));
            }
        }

        [TestMethod]
        [DataRow(2, 1, 1, 1)]
        [DataRow(5, 1, 2, 1)]
        [DataRow(5, 2, 2, 1)]
        [DataRow(6, 1, 2, 1)]
        [DataRow(6, 2, 1, 1)]//two hits, but second value is null (ignored)
        [DataRow(6, 3, 1, 1)]//two hits, but same value
        [DataRow(6, 4, 1, 1)]
        [DataRow(6, null, 1, 1)]
        [DataRow(7, 2, 0, 1)]//hit, empty output
        [DataRow(7, 1, 1, 1)]
        [DataRow(9, 1, 2, 1)]
        [DataRow(1, 3, 1, 1)]
        [DataRow(null, 3, 1, 1)]
        [DataRow(null, null, 0, 0)] //no hit
        [DataRow(8, 8, 0, 0)] //no hit
        public void CollectCountHitPolicyTest(int? a, int? b, int? c, int hitsCount)
        {

            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_Collect_Count.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));

            ctx.WithInputParameter("a", a);
            ctx.WithInputParameter("b", b);

            DmnDecisionResult result = null;
            Action act = () => { result = ctx.ExecuteDecision("Collect"); };

            act.Invoke();

            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();

            if (hitsCount <= 0)
            {
                result.Results.Should().HaveCount(0);
                result.HasResult.Should().Be(false);
                result.IsSingleResult.Should().Be(false);
                return;
            }

            result.Results.Should().HaveCount(hitsCount);
            result.HasResult.Should().Be(true);

            result.IsSingleResult.Should().Be(true);
            result.SingleResult.Should().NotBeNull();
            result.SingleResult.Should().HaveCount(1);

            result.Results[0].Variables.Should().HaveCount(1);
            var output = result.Results[0].Variables[0];
            output.Should().NotBeNull();
            output.Name.Should().Be("o");
            if (c != null)
            {
                output.Value.Should().Be(c).And.BeOfType<long>();
                output.Type.Should().Be(typeof(long));
            }
            else
            {
                output.Value.Should().BeNull();
                output.Type.Should().Be(typeof(long));
            }
        }

        [TestMethod]
        [DataRow(2, 1, true, 1)]
        [DataRow(5, 1, true, 1)]//results false, true - sum is true if at least one result is true
        [DataRow(5, 2, true, 1)]
        [DataRow(6, 1, true, 1)]
        [DataRow(6, 2, true, 1)]
        [DataRow(6, 3, true, 1)]
        [DataRow(6, 4, true, 1)]
        [DataRow(6, null, true, 1)]
        [DataRow(7, 2, null, 1)]//hit, empty output
        [DataRow(7, 1, false, 1)]
        [DataRow(9, 1, true, 1)]
        [DataRow(1, 3, true, 1)]
        [DataRow(null, 3, true, 1)]
        [DataRow(null, null, false, 0)] //no hit
        [DataRow(8, 8, false, 0)] //no hit
        public void CollectSumBoolHitPolicyTest(int? a, int? b, bool? c, int hitsCount)
        {

            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_Collect_SumBool.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));

            ctx.WithInputParameter("a", a);
            ctx.WithInputParameter("b", b);

            DmnDecisionResult result = null;
            Action act = () => { result = ctx.ExecuteDecision("Collect"); };

            act.Invoke();

            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();

            if (hitsCount <= 0)
            {
                result.Results.Should().HaveCount(0);
                result.HasResult.Should().Be(false);
                result.IsSingleResult.Should().Be(false);
                return;
            }

            result.Results.Should().HaveCount(hitsCount);
            result.HasResult.Should().Be(true);

            result.IsSingleResult.Should().Be(true);
            result.SingleResult.Should().NotBeNull();
            result.SingleResult.Should().HaveCount(1);

            result.Results[0].Variables.Should().HaveCount(1);
            var output = result.Results[0].Variables[0];
            output.Should().NotBeNull();
            output.Name.Should().Be("o");
            if (c != null)
            {
                output.Value.Should().Be(c).And.BeOfType<bool>();
                output.Type.Should().Be(typeof(bool));
            }
            else
            {
                output.Value.Should().BeNull();
                output.Type.Should().Be(typeof(bool));
            }
        }

        [TestMethod]
        [DataRow(2, 1, true, 1)]
        [DataRow(5, 1, false, 1)]//results false, true - min is false if at least one result is false
        [DataRow(5, 2, true, 1)]
        [DataRow(6, 1, false, 1)]// min is false if at least one result is false
        [DataRow(6, 2, true, 1)]
        [DataRow(6, 3, true, 1)]
        [DataRow(6, 4, true, 1)]
        [DataRow(6, null, true, 1)]
        [DataRow(7, 2, null, 1)]//hit, empty output
        [DataRow(7, 1, false, 1)]
        [DataRow(9, 1, false, 1)]// min is false if at least one result is false
        [DataRow(1, 3, true, 1)]
        [DataRow(null, 3, true, 1)]
        [DataRow(null, null, false, 0)] //no hit
        [DataRow(8, 8, false, 0)] //no hit
        public void CollectMinBoolHitPolicyTest(int? a, int? b, bool? c, int hitsCount)
        {

            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_Collect_MinBool.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));

            ctx.WithInputParameter("a", a);
            ctx.WithInputParameter("b", b);

            DmnDecisionResult result = null;
            Action act = () => { result = ctx.ExecuteDecision("Collect"); };

            act.Invoke();

            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();

            if (hitsCount <= 0)
            {
                result.Results.Should().HaveCount(0);
                result.HasResult.Should().Be(false);
                result.IsSingleResult.Should().Be(false);
                return;
            }

            result.Results.Should().HaveCount(hitsCount);
            result.HasResult.Should().Be(true);

            result.IsSingleResult.Should().Be(true);
            result.SingleResult.Should().NotBeNull();
            result.SingleResult.Should().HaveCount(1);

            result.Results[0].Variables.Should().HaveCount(1);
            var output = result.Results[0].Variables[0];
            output.Should().NotBeNull();
            output.Name.Should().Be("o");
            if (c != null)
            {
                output.Value.Should().Be(c).And.BeOfType<bool>();
                output.Type.Should().Be(typeof(bool));
            }
            else
            {
                output.Value.Should().BeNull();
                output.Type.Should().Be(typeof(bool));
            }
        }

        [TestMethod]
        [DataRow(2, 1, true, 1)]
        [DataRow(5, 1, true, 1)]//results false, true - max is true if at least one result is true
        [DataRow(5, 2, true, 1)]
        [DataRow(6, 1, true, 1)]// max is true if at least one result is true
        [DataRow(6, 2, true, 1)]
        [DataRow(6, 3, true, 1)]
        [DataRow(6, 4, true, 1)]
        [DataRow(6, null, true, 1)]
        [DataRow(7, 2, null, 1)]//hit, empty output
        [DataRow(7, 1, false, 1)]
        [DataRow(9, 1, true, 1)]// max is true if at least one result is true
        [DataRow(1, 3, true, 1)]
        [DataRow(null, 3, true, 1)]
        [DataRow(null, null, false, 0)] //no hit
        [DataRow(8, 8, false, 0)] //no hit
        public void CollectMaxBoolHitPolicyTest(int? a, int? b, bool? c, int hitsCount)
        {

            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_Collect_MaxBool.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));

            ctx.WithInputParameter("a", a);
            ctx.WithInputParameter("b", b);

            DmnDecisionResult result = null;
            Action act = () => { result = ctx.ExecuteDecision("Collect"); };

            act.Invoke();

            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();

            if (hitsCount <= 0)
            {
                result.Results.Should().HaveCount(0);
                result.HasResult.Should().Be(false);
                result.IsSingleResult.Should().Be(false);
                return;
            }

            result.Results.Should().HaveCount(hitsCount);
            result.HasResult.Should().Be(true);

            result.IsSingleResult.Should().Be(true);
            result.SingleResult.Should().NotBeNull();
            result.SingleResult.Should().HaveCount(1);

            result.Results[0].Variables.Should().HaveCount(1);
            var output = result.Results[0].Variables[0];
            output.Should().NotBeNull();
            output.Name.Should().Be("o");
            if (c != null)
            {
                output.Value.Should().Be(c).And.BeOfType<bool>();
                output.Type.Should().Be(typeof(bool));
            }
            else
            {
                output.Value.Should().BeNull();
                output.Type.Should().Be(typeof(bool));
            }
        }

        [TestMethod]
        public void CollectCountBoolHitPolicyTest()
        {

            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_Collect_CountBool.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));

            ctx.WithInputParameter("a", 2);
            ctx.WithInputParameter("b", 1);

            Action act = () => { ctx.ExecuteDecision("Collect"); };

            act.Should().Throw<DmnExecutorException>().WithMessage("COLLECT hit policy violation - type Boolean not allowed for aggregation Count");
        }

        [TestMethod]
        [DataRow(2, 1, 1, 1)]
        [DataRow(5, 1, 1, 1)]//two hits, but one with the empty result
        [DataRow(5, 2, 1, 1)]//two hits, but one with the empty result
        [DataRow(6, 1, 2, 1)]
        [DataRow(6, 2, 2, 1)]
        [DataRow(6, 3, 1, 1)]//two hits, but same value
        [DataRow(6, 4, 1, 1)]
        [DataRow(6, null, 1, 1)]
        [DataRow(7, 2, 1, 1)]
        [DataRow(7, 1, 1, 1)]
        [DataRow(9, 1, 2, 1)]
        [DataRow(1, 3, 0, 1)]//hit, empty output
        [DataRow(null, 3, 0, 1)]//hit, empty output
        [DataRow(null, null, 0, 0)] //no hit
        [DataRow(8, 8, 0, 0)] //no hit
        public void CollectCountStrHitPolicyTest(int? a, int? b, int? c, int hitsCount)
        {

            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_Collect_CountStr.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));

            ctx.WithInputParameter("a", a);
            ctx.WithInputParameter("b", b);

            DmnDecisionResult result = null;
            Action act = () => { result = ctx.ExecuteDecision("Collect"); };

            act.Invoke();

            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();

            if (hitsCount <= 0)
            {
                result.Results.Should().HaveCount(0);
                result.HasResult.Should().Be(false);
                result.IsSingleResult.Should().Be(false);
                return;
            }

            result.Results.Should().HaveCount(hitsCount);
            result.HasResult.Should().Be(true);

            result.IsSingleResult.Should().Be(true);
            result.SingleResult.Should().NotBeNull();
            result.SingleResult.Should().HaveCount(1);

            result.Results[0].Variables.Should().HaveCount(1);
            var output = result.Results[0].Variables[0];
            output.Should().NotBeNull();
            output.Name.Should().Be("o");
            if (c != null)
            {
                output.Value.Should().Be(c.ToString()).And.BeOfType<string>();
                output.Type.Should().Be(typeof(string));
            }
            else
            {
                output.Value.Should().BeNull();
                output.Type.Should().Be(typeof(string));
            }
        }

        [TestMethod]
        public void CollectSumStrHitPolicyTest()
        {

            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_Collect_SumStr.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));

            ctx.WithInputParameter("a", 2);
            ctx.WithInputParameter("b", 1);

            Action act = () => { ctx.ExecuteDecision("Collect"); };

            act.Should().Throw<DmnExecutorException>().WithMessage("COLLECT hit policy violation - type String not allowed for aggregation Sum");
        }

        [TestMethod]
        public void WrongHitPolicyTest()
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_WrongPolicy.dmn");
            Action act = () => DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));
            act.Should().Throw<DmnParserException>().WithMessage("Wrong hit policy *");
        }

        [TestMethod]
        public void WrongHitPolicyAggregationTest()
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/hitpolicy_WrongAggregation.dmn");
            Action act = () => DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));
            act.Should().Throw<DmnParserException>().WithMessage("Wrong hit policy aggregation *");
        }
    }
}
