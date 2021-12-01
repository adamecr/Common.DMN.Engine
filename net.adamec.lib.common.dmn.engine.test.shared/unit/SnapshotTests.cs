using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.engine.definition.builder;
using net.adamec.lib.common.dmn.engine.engine.execution.context;
using net.adamec.lib.common.dmn.engine.parser.dto;

namespace net.adamec.lib.common.dmn.engine.test.unit
{
    [TestClass]
    public class SnapshotTests
    {
        [TestMethod]
        public void NoSnapshotTest()
        {
            var def = new DmnDefinitionBuilder()
                .WithInput<int>("input")
                .WithVariable<int>("output", out var outputRef)
                .WithExpressionDecision("decision", "input+1", outputRef)
                .Build();

            //default - no snapshot
            var ctx1 = DmnExecutionContextFactory.CreateExecutionContext(def);
            var result1 = ctx1.WithInputParameter("input", 5).ExecuteDecision("decision");
            result1.HasResult.Should().BeTrue();
            result1.First["output"].Value.Should().Be(6);
            ctx1.Snapshots.Should().NotBeNull();
            ctx1.Snapshots.Last.Should().BeNull();
            ctx1.Snapshots.Snapshots.Should().BeEmpty();

            //explicit no snapshot
            var ctx2 = DmnExecutionContextFactory.CreateExecutionContext(def, o => o.RecordSnapshots = false);
            var result2 = ctx2.WithInputParameter("input", 5).ExecuteDecision("decision");
            result2.HasResult.Should().BeTrue();
            result2.First["output"].Value.Should().Be(6);
            ctx2.Snapshots.Should().NotBeNull();
            ctx2.Snapshots.Last.Should().BeNull();
            ctx2.Snapshots.Snapshots.Should().BeEmpty();
        }

        private static DmnExecutionContext PrepSnapshotTestCtx(out DmnDefinition def)
        {
            def = new DmnDefinitionBuilder()
                .WithInput<int>("input1", out var input1Ref)
                .WithInput("input2")
                .WithVariable<int>("output1", out var output1Ref)
                .WithVariable<double>("output2", out var output2Ref)
                .WithVariable<string>("var3", out var var3Ref)
                .WithExpressionDecision("decision1", "input1+1", output1Ref, out var decision1Ref)
                .WithExpressionDecision("decision2", "input2+1", var3Ref, out var decision2Ref)
                .WithExpressionDecision("decision3", b => b
                    .Put("double.Parse(var3)")
                    .To(output2Ref)
                    .Requires(decision2Ref), out var decision3Ref)
                .WithTableDecision("decision4", t => t
                    .WithInput(input1Ref, out var tblInput1Ref)
                    .WithOutput(output1Ref, out var tblOutput1Ref)
                    .WithOutput(output2Ref, out var tblOutput2Ref)
                    .WithRule("r1", r => r
                        .When(tblInput1Ref, SFeel.Eq(1))
                        .Then(tblOutput1Ref, "1")
                        .And(tblOutput2Ref, "1.1"))
                    .WithRule("r2", r => r
                        .When(tblInput1Ref, SFeel.Eq(2))
                        .Then(tblOutput1Ref, "2"))
                    .WithRule("r3", r => r
                        .When(tblInput1Ref, SFeel.Eq(3))
                        .Then(tblOutput2Ref, "3.3"))
                    .WithRule("r4", r => r
                        .Always().SkipOutput())
                    .WithHitPolicy(HitPolicyEnum.First)
                    .Requires(decision3Ref)
                    .Requires(decision1Ref))
                .Build();

            // d1 (input1+1->output1) = d1
            // d2 (input2+1->var3)= d2
            // d3 (double.Parse(var3)->output2)<-d2 = d2, d3
            // d4 (i1:1->1,1.1; i1:2->2,N/A; i1:3->N/A,3.3; i1:other->N/A,N/A); <- d3, d1 = d2, d3, d1, d4

            var ctx = DmnExecutionContextFactory.CreateExecutionContext(def, o =>
            {
                o.ParsedExpressionCacheScope = ParsedExpressionCacheScopeEnum.None;
                o.RecordSnapshots = true;
            });
            return ctx;
        }

        [TestMethod]
        public void SnapshotTestD1_A()
        {
            var ctx = PrepSnapshotTestCtx(out var def);

            var result = ctx
                .WithInputParameter("input1", 5)
                .ExecuteDecision("decision1");
            result.HasResult.Should().BeTrue();
            ctx.Snapshots.Should().NotBeNull();
            ctx.Snapshots.Snapshots.Should().HaveCount(2);

            //snapshot 0 - initial
            ctx.Snapshots.Snapshots[0].Step.Should().Be(0);
            ctx.Snapshots.Snapshots[0].Decision.Should().BeNull();
            ctx.Snapshots.Snapshots[0].DecisionName.Should().BeNull();
            ctx.Snapshots.Snapshots[0].DecisionResult.Should().BeNull();
            ctx.Snapshots.Snapshots[0].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[0].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[0].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[0].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[0].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[0].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[0].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[0].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[0].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[0].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[0].Variables[0].Value.Should().Be(5);
            ctx.Snapshots.Snapshots[0].Variables[1].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[2].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[3].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[4].Value.Should().Be(null);

            //snapshot 1 - after d1 (input1+1->output1)
            ctx.Snapshots.Snapshots[1].Step.Should().Be(1);
            ctx.Snapshots.Snapshots[1].Decision.Should().Be(def.Decisions["decision1"]);
            ctx.Snapshots.Snapshots[1].DecisionName.Should().Be("decision1");
            ctx.Snapshots.Snapshots[1].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[1].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[1].DecisionResult.First["output1"].Value.Should().Be(6);

            ctx.Snapshots.Snapshots[1].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[1].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[1].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[1].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[1].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[1].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[1].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[1].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[1].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[1].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[1].Variables[0].Value.Should().Be(5);
            ctx.Snapshots.Snapshots[1].Variables[1].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[2].Value.Should().Be(6);
            ctx.Snapshots.Snapshots[1].Variables[3].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[4].Value.Should().Be(null);

            ctx.Snapshots.Last.Should().Be(ctx.Snapshots.Snapshots[1]);
        }

        [TestMethod]
        public void SnapshotTestD1_B()
        {
            var ctx = PrepSnapshotTestCtx(out var def);

            var result = ctx
                .WithInputParameter("input1", 5)
                .WithInputParameter("input2", "dummy")
                .ExecuteDecision("decision1");
            result.HasResult.Should().BeTrue();
            ctx.Snapshots.Should().NotBeNull();
            ctx.Snapshots.Snapshots.Should().HaveCount(2);

            //snapshot 0 - initial
            ctx.Snapshots.Snapshots[0].Step.Should().Be(0);
            ctx.Snapshots.Snapshots[0].Decision.Should().BeNull();
            ctx.Snapshots.Snapshots[0].DecisionName.Should().BeNull();
            ctx.Snapshots.Snapshots[0].DecisionResult.Should().BeNull();
            ctx.Snapshots.Snapshots[0].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[0].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[0].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[0].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[0].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[0].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[0].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[0].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[0].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[0].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[0].Variables[0].Value.Should().Be(5);
            ctx.Snapshots.Snapshots[0].Variables[1].Value.Should().Be("dummy");
            ctx.Snapshots.Snapshots[0].Variables[2].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[3].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[4].Value.Should().Be(null);

            //snapshot 1 - after d1 (input1+1->output1)
            ctx.Snapshots.Snapshots[1].Step.Should().Be(1);
            ctx.Snapshots.Snapshots[1].Decision.Should().Be(def.Decisions["decision1"]);
            ctx.Snapshots.Snapshots[1].DecisionName.Should().Be("decision1");
            ctx.Snapshots.Snapshots[1].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[1].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[1].DecisionResult.First["output1"].Value.Should().Be(6);

            ctx.Snapshots.Snapshots[1].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[1].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[1].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[1].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[1].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[1].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[1].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[1].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[1].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[1].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[1].Variables[0].Value.Should().Be(5);
            ctx.Snapshots.Snapshots[1].Variables[1].Value.Should().Be("dummy");
            ctx.Snapshots.Snapshots[1].Variables[2].Value.Should().Be(6);
            ctx.Snapshots.Snapshots[1].Variables[3].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[4].Value.Should().Be(null);

            ctx.Snapshots.Last.Should().Be(ctx.Snapshots.Snapshots[1]);
        }

        [TestMethod]
        public void SnapshotTestD2()
        {
            var ctx = PrepSnapshotTestCtx(out var def);

            var result = ctx
                .WithInputParameter("input1", 5)
                .WithInputParameter("input2", "dummy")
                .ExecuteDecision("decision2");
            result.HasResult.Should().BeTrue();
            ctx.Snapshots.Should().NotBeNull();
            ctx.Snapshots.Snapshots.Should().HaveCount(2);

            //snapshot 0 - initial
            ctx.Snapshots.Snapshots[0].Step.Should().Be(0);
            ctx.Snapshots.Snapshots[0].Decision.Should().BeNull();
            ctx.Snapshots.Snapshots[0].DecisionName.Should().BeNull();
            ctx.Snapshots.Snapshots[0].DecisionResult.Should().BeNull();
            ctx.Snapshots.Snapshots[0].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[0].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[0].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[0].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[0].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[0].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[0].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[0].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[0].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[0].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[0].Variables[0].Value.Should().Be(5);
            ctx.Snapshots.Snapshots[0].Variables[1].Value.Should().Be("dummy");
            ctx.Snapshots.Snapshots[0].Variables[2].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[3].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[4].Value.Should().Be(null);

            //snapshot 1 - after d2 (input2+1->var3)
            ctx.Snapshots.Snapshots[1].Step.Should().Be(1);
            ctx.Snapshots.Snapshots[1].Decision.Should().Be(def.Decisions["decision2"]);
            ctx.Snapshots.Snapshots[1].DecisionName.Should().Be("decision2");
            ctx.Snapshots.Snapshots[1].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[1].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[1].DecisionResult.First["var3"].Value.Should().Be("dummy1");

            ctx.Snapshots.Snapshots[1].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[1].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[1].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[1].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[1].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[1].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[1].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[1].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[1].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[1].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[1].Variables[0].Value.Should().Be(5);
            ctx.Snapshots.Snapshots[1].Variables[1].Value.Should().Be("dummy");
            ctx.Snapshots.Snapshots[1].Variables[2].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[3].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[4].Value.Should().Be("dummy1");

            ctx.Snapshots.Last.Should().Be(ctx.Snapshots.Snapshots[1]);
        }

        [TestMethod]
        public void SnapshotTestD3()
        {
            var ctx = PrepSnapshotTestCtx(out var def);

            var result = ctx
                .WithInputParameter("input1", 5)
                .WithInputParameter("input2", "6")
                .ExecuteDecision("decision3");
            result.HasResult.Should().BeTrue();
            ctx.Snapshots.Should().NotBeNull();
            ctx.Snapshots.Snapshots.Should().HaveCount(3);

            //snapshot 0 - initial
            ctx.Snapshots.Snapshots[0].Step.Should().Be(0);
            ctx.Snapshots.Snapshots[0].Decision.Should().BeNull();
            ctx.Snapshots.Snapshots[0].DecisionName.Should().BeNull();
            ctx.Snapshots.Snapshots[0].DecisionResult.Should().BeNull();
            ctx.Snapshots.Snapshots[0].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[0].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[0].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[0].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[0].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[0].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[0].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[0].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[0].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[0].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[0].Variables[0].Value.Should().Be(5);
            ctx.Snapshots.Snapshots[0].Variables[1].Value.Should().Be("6");
            ctx.Snapshots.Snapshots[0].Variables[2].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[3].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[4].Value.Should().Be(null);

            //snapshot 1 - after d2 (input2+1->var3)
            ctx.Snapshots.Snapshots[1].Step.Should().Be(1);
            ctx.Snapshots.Snapshots[1].Decision.Should().Be(def.Decisions["decision2"]);
            ctx.Snapshots.Snapshots[1].DecisionName.Should().Be("decision2");
            ctx.Snapshots.Snapshots[1].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[1].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[1].DecisionResult.First["var3"].Value.Should().Be("61");

            ctx.Snapshots.Snapshots[1].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[1].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[1].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[1].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[1].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[1].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[1].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[1].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[1].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[1].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[1].Variables[0].Value.Should().Be(5);
            ctx.Snapshots.Snapshots[1].Variables[1].Value.Should().Be("6");
            ctx.Snapshots.Snapshots[1].Variables[2].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[3].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[4].Value.Should().Be("61");

            //snapshot 2 - after  d3 (double.Parse(var3)->output2)
            ctx.Snapshots.Snapshots[2].Step.Should().Be(2);
            ctx.Snapshots.Snapshots[2].Decision.Should().Be(def.Decisions["decision3"]);
            ctx.Snapshots.Snapshots[2].DecisionName.Should().Be("decision3");
            ctx.Snapshots.Snapshots[2].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[2].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[2].DecisionResult.First["output2"].Value.Should().Be(61.0);

            ctx.Snapshots.Snapshots[2].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[2].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[2].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[2].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[2].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[2].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[2].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[2].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[2].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[2].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[2].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[2].Variables[0].Value.Should().Be(5);
            ctx.Snapshots.Snapshots[2].Variables[1].Value.Should().Be("6");
            ctx.Snapshots.Snapshots[2].Variables[2].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[2].Variables[3].Value.Should().Be(61.0);
            ctx.Snapshots.Snapshots[2].Variables[4].Value.Should().Be("61");

            ctx.Snapshots.Last.Should().Be(ctx.Snapshots.Snapshots[2]);
        }

        [TestMethod]
        public void SnapshotTestD4_1()
        {
            var ctx = PrepSnapshotTestCtx(out var def);

            var result = ctx
                .WithInputParameter("input1", 1)
                .WithInputParameter("input2", "6")
                .ExecuteDecision("decision4");
            result.HasResult.Should().BeTrue();
            ctx.Snapshots.Should().NotBeNull();
            ctx.Snapshots.Snapshots.Should().HaveCount(5);

            //snapshot 0 - initial
            ctx.Snapshots.Snapshots[0].Step.Should().Be(0);
            ctx.Snapshots.Snapshots[0].Decision.Should().BeNull();
            ctx.Snapshots.Snapshots[0].DecisionName.Should().BeNull();
            ctx.Snapshots.Snapshots[0].DecisionResult.Should().BeNull();
            ctx.Snapshots.Snapshots[0].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[0].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[0].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[0].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[0].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[0].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[0].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[0].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[0].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[0].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[0].Variables[0].Value.Should().Be(1);
            ctx.Snapshots.Snapshots[0].Variables[1].Value.Should().Be("6");
            ctx.Snapshots.Snapshots[0].Variables[2].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[3].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[4].Value.Should().Be(null);

            //snapshot 1 - after d2 (input2+1->var3)
            ctx.Snapshots.Snapshots[1].Step.Should().Be(1);
            ctx.Snapshots.Snapshots[1].Decision.Should().Be(def.Decisions["decision2"]);
            ctx.Snapshots.Snapshots[1].DecisionName.Should().Be("decision2");
            ctx.Snapshots.Snapshots[1].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[1].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[1].DecisionResult.First["var3"].Value.Should().Be("61");

            ctx.Snapshots.Snapshots[1].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[1].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[1].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[1].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[1].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[1].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[1].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[1].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[1].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[1].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[1].Variables[0].Value.Should().Be(1);
            ctx.Snapshots.Snapshots[1].Variables[1].Value.Should().Be("6");
            ctx.Snapshots.Snapshots[1].Variables[2].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[3].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[4].Value.Should().Be("61");

            //snapshot 2 - after  d3 (double.Parse(var3)->output2)
            ctx.Snapshots.Snapshots[2].Step.Should().Be(2);
            ctx.Snapshots.Snapshots[2].Decision.Should().Be(def.Decisions["decision3"]);
            ctx.Snapshots.Snapshots[2].DecisionName.Should().Be("decision3");
            ctx.Snapshots.Snapshots[2].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[2].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[2].DecisionResult.First["output2"].Value.Should().Be(61.0);

            ctx.Snapshots.Snapshots[2].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[2].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[2].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[2].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[2].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[2].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[2].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[2].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[2].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[2].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[2].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[2].Variables[0].Value.Should().Be(1);
            ctx.Snapshots.Snapshots[2].Variables[1].Value.Should().Be("6");
            ctx.Snapshots.Snapshots[2].Variables[2].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[2].Variables[3].Value.Should().Be(61.0);
            ctx.Snapshots.Snapshots[2].Variables[4].Value.Should().Be("61");

            //snapshot 3 - after  d1 (input1+1->output1)
            ctx.Snapshots.Snapshots[3].Step.Should().Be(3);
            ctx.Snapshots.Snapshots[3].Decision.Should().Be(def.Decisions["decision1"]);
            ctx.Snapshots.Snapshots[3].DecisionName.Should().Be("decision1");
            ctx.Snapshots.Snapshots[3].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[3].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[3].DecisionResult.First["output1"].Value.Should().Be(2);

            ctx.Snapshots.Snapshots[3].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[3].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[3].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[3].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[3].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[3].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[3].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[3].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[3].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[3].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[3].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[3].Variables[0].Value.Should().Be(1);
            ctx.Snapshots.Snapshots[3].Variables[1].Value.Should().Be("6");
            ctx.Snapshots.Snapshots[3].Variables[2].Value.Should().Be(2);
            ctx.Snapshots.Snapshots[3].Variables[3].Value.Should().Be(61.0);
            ctx.Snapshots.Snapshots[3].Variables[4].Value.Should().Be("61");

            //snapshot 4 - after  d4 (i1:1->1,1.1; i1:2->2,N/A; i1:3->N/A,3.3; i1:other->N/A,N/A)
            ctx.Snapshots.Snapshots[4].Step.Should().Be(4);
            ctx.Snapshots.Snapshots[4].Decision.Should().Be(def.Decisions["decision4"]);
            ctx.Snapshots.Snapshots[4].DecisionName.Should().Be("decision4");
            ctx.Snapshots.Snapshots[4].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[4].DecisionResult.First.Variables.Should().HaveCount(2);
            ctx.Snapshots.Snapshots[4].DecisionResult.First["output1"].Value.Should().Be(1);
            ctx.Snapshots.Snapshots[4].DecisionResult.First["output2"].Value.Should().Be(1.1);

            ctx.Snapshots.Snapshots[4].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[4].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[4].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[4].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[4].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[4].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[4].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[4].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[4].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[4].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[4].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[4].Variables[0].Value.Should().Be(1);
            ctx.Snapshots.Snapshots[4].Variables[1].Value.Should().Be("6");
            ctx.Snapshots.Snapshots[4].Variables[2].Value.Should().Be(1);
            ctx.Snapshots.Snapshots[4].Variables[3].Value.Should().Be(1.1);
            ctx.Snapshots.Snapshots[4].Variables[4].Value.Should().Be("61");

            ctx.Snapshots.Last.Should().Be(ctx.Snapshots.Snapshots[4]);
        }

        [TestMethod]
        public void SnapshotTestD4_2()
        {
            var ctx = PrepSnapshotTestCtx(out var def);

            var result = ctx
                .WithInputParameter("input1", 2)
                .WithInputParameter("input2", "6")
                .ExecuteDecision("decision4");
            result.HasResult.Should().BeTrue();
            ctx.Snapshots.Should().NotBeNull();
            ctx.Snapshots.Snapshots.Should().HaveCount(5);

            //snapshot 0 - initial
            ctx.Snapshots.Snapshots[0].Step.Should().Be(0);
            ctx.Snapshots.Snapshots[0].Decision.Should().BeNull();
            ctx.Snapshots.Snapshots[0].DecisionName.Should().BeNull();
            ctx.Snapshots.Snapshots[0].DecisionResult.Should().BeNull();
            ctx.Snapshots.Snapshots[0].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[0].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[0].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[0].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[0].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[0].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[0].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[0].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[0].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[0].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[0].Variables[0].Value.Should().Be(2);
            ctx.Snapshots.Snapshots[0].Variables[1].Value.Should().Be("6");
            ctx.Snapshots.Snapshots[0].Variables[2].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[3].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[4].Value.Should().Be(null);

            //snapshot 1 - after d2 (input2+1->var3)
            ctx.Snapshots.Snapshots[1].Step.Should().Be(1);
            ctx.Snapshots.Snapshots[1].Decision.Should().Be(def.Decisions["decision2"]);
            ctx.Snapshots.Snapshots[1].DecisionName.Should().Be("decision2");
            ctx.Snapshots.Snapshots[1].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[1].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[1].DecisionResult.First["var3"].Value.Should().Be("61");

            ctx.Snapshots.Snapshots[1].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[1].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[1].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[1].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[1].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[1].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[1].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[1].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[1].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[1].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[1].Variables[0].Value.Should().Be(2);
            ctx.Snapshots.Snapshots[1].Variables[1].Value.Should().Be("6");
            ctx.Snapshots.Snapshots[1].Variables[2].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[3].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[4].Value.Should().Be("61");

            //snapshot 2 - after  d3 (double.Parse(var3)->output2)
            ctx.Snapshots.Snapshots[2].Step.Should().Be(2);
            ctx.Snapshots.Snapshots[2].Decision.Should().Be(def.Decisions["decision3"]);
            ctx.Snapshots.Snapshots[2].DecisionName.Should().Be("decision3");
            ctx.Snapshots.Snapshots[2].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[2].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[2].DecisionResult.First["output2"].Value.Should().Be(61.0);

            ctx.Snapshots.Snapshots[2].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[2].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[2].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[2].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[2].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[2].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[2].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[2].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[2].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[2].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[2].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[2].Variables[0].Value.Should().Be(2);
            ctx.Snapshots.Snapshots[2].Variables[1].Value.Should().Be("6");
            ctx.Snapshots.Snapshots[2].Variables[2].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[2].Variables[3].Value.Should().Be(61.0);
            ctx.Snapshots.Snapshots[2].Variables[4].Value.Should().Be("61");

            //snapshot 3 - after  d1 (input1+1->output1)
            ctx.Snapshots.Snapshots[3].Step.Should().Be(3);
            ctx.Snapshots.Snapshots[3].Decision.Should().Be(def.Decisions["decision1"]);
            ctx.Snapshots.Snapshots[3].DecisionName.Should().Be("decision1");
            ctx.Snapshots.Snapshots[3].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[3].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[3].DecisionResult.First["output1"].Value.Should().Be(3);

            ctx.Snapshots.Snapshots[3].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[3].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[3].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[3].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[3].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[3].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[3].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[3].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[3].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[3].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[3].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[3].Variables[0].Value.Should().Be(2);
            ctx.Snapshots.Snapshots[3].Variables[1].Value.Should().Be("6");
            ctx.Snapshots.Snapshots[3].Variables[2].Value.Should().Be(3);
            ctx.Snapshots.Snapshots[3].Variables[3].Value.Should().Be(61.0);
            ctx.Snapshots.Snapshots[3].Variables[4].Value.Should().Be("61");

            //snapshot 4 - after  d4 (i1:1->1,1.1; i1:2->2,N/A; i1:3->N/A,3.3; i1:other->N/A,N/A)
            ctx.Snapshots.Snapshots[4].Step.Should().Be(4);
            ctx.Snapshots.Snapshots[4].Decision.Should().Be(def.Decisions["decision4"]);
            ctx.Snapshots.Snapshots[4].DecisionName.Should().Be("decision4");
            ctx.Snapshots.Snapshots[4].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[4].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[4].DecisionResult.First["output1"].Value.Should().Be(2);

            ctx.Snapshots.Snapshots[4].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[4].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[4].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[4].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[4].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[4].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[4].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[4].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[4].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[4].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[4].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[4].Variables[0].Value.Should().Be(2);
            ctx.Snapshots.Snapshots[4].Variables[1].Value.Should().Be("6");
            ctx.Snapshots.Snapshots[4].Variables[2].Value.Should().Be(2);
            ctx.Snapshots.Snapshots[4].Variables[3].Value.Should().Be(61.0);
            ctx.Snapshots.Snapshots[4].Variables[4].Value.Should().Be("61");

            ctx.Snapshots.Last.Should().Be(ctx.Snapshots.Snapshots[4]);
        }

        [TestMethod]
        public void SnapshotTestD4_3()
        {
            var ctx = PrepSnapshotTestCtx(out var def);

            var result = ctx
                .WithInputParameter("input1", 3)
                .WithInputParameter("input2", "6")
                .ExecuteDecision("decision4");
            result.HasResult.Should().BeTrue();
            ctx.Snapshots.Should().NotBeNull();
            ctx.Snapshots.Snapshots.Should().HaveCount(5);

            //snapshot 0 - initial
            ctx.Snapshots.Snapshots[0].Step.Should().Be(0);
            ctx.Snapshots.Snapshots[0].Decision.Should().BeNull();
            ctx.Snapshots.Snapshots[0].DecisionName.Should().BeNull();
            ctx.Snapshots.Snapshots[0].DecisionResult.Should().BeNull();
            ctx.Snapshots.Snapshots[0].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[0].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[0].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[0].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[0].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[0].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[0].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[0].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[0].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[0].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[0].Variables[0].Value.Should().Be(3);
            ctx.Snapshots.Snapshots[0].Variables[1].Value.Should().Be("6");
            ctx.Snapshots.Snapshots[0].Variables[2].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[3].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[4].Value.Should().Be(null);

            //snapshot 1 - after d2 (input2+1->var3)
            ctx.Snapshots.Snapshots[1].Step.Should().Be(1);
            ctx.Snapshots.Snapshots[1].Decision.Should().Be(def.Decisions["decision2"]);
            ctx.Snapshots.Snapshots[1].DecisionName.Should().Be("decision2");
            ctx.Snapshots.Snapshots[1].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[1].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[1].DecisionResult.First["var3"].Value.Should().Be("61");

            ctx.Snapshots.Snapshots[1].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[1].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[1].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[1].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[1].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[1].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[1].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[1].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[1].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[1].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[1].Variables[0].Value.Should().Be(3);
            ctx.Snapshots.Snapshots[1].Variables[1].Value.Should().Be("6");
            ctx.Snapshots.Snapshots[1].Variables[2].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[3].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[4].Value.Should().Be("61");

            //snapshot 2 - after  d3 (double.Parse(var3)->output2)
            ctx.Snapshots.Snapshots[2].Step.Should().Be(2);
            ctx.Snapshots.Snapshots[2].Decision.Should().Be(def.Decisions["decision3"]);
            ctx.Snapshots.Snapshots[2].DecisionName.Should().Be("decision3");
            ctx.Snapshots.Snapshots[2].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[2].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[2].DecisionResult.First["output2"].Value.Should().Be(61.0);

            ctx.Snapshots.Snapshots[2].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[2].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[2].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[2].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[2].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[2].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[2].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[2].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[2].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[2].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[2].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[2].Variables[0].Value.Should().Be(3);
            ctx.Snapshots.Snapshots[2].Variables[1].Value.Should().Be("6");
            ctx.Snapshots.Snapshots[2].Variables[2].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[2].Variables[3].Value.Should().Be(61.0);
            ctx.Snapshots.Snapshots[2].Variables[4].Value.Should().Be("61");

            //snapshot 3 - after  d1 (input1+1->output1)
            ctx.Snapshots.Snapshots[3].Step.Should().Be(3);
            ctx.Snapshots.Snapshots[3].Decision.Should().Be(def.Decisions["decision1"]);
            ctx.Snapshots.Snapshots[3].DecisionName.Should().Be("decision1");
            ctx.Snapshots.Snapshots[3].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[3].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[3].DecisionResult.First["output1"].Value.Should().Be(4);

            ctx.Snapshots.Snapshots[3].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[3].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[3].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[3].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[3].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[3].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[3].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[3].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[3].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[3].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[3].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[3].Variables[0].Value.Should().Be(3);
            ctx.Snapshots.Snapshots[3].Variables[1].Value.Should().Be("6");
            ctx.Snapshots.Snapshots[3].Variables[2].Value.Should().Be(4);
            ctx.Snapshots.Snapshots[3].Variables[3].Value.Should().Be(61.0);
            ctx.Snapshots.Snapshots[3].Variables[4].Value.Should().Be("61");

            //snapshot 4 - after  d4 (i1:1->1,1.1; i1:2->2,N/A; i1:3->N/A,3.3; i1:other->N/A,N/A)
            ctx.Snapshots.Snapshots[4].Step.Should().Be(4);
            ctx.Snapshots.Snapshots[4].Decision.Should().Be(def.Decisions["decision4"]);
            ctx.Snapshots.Snapshots[4].DecisionName.Should().Be("decision4");
            ctx.Snapshots.Snapshots[4].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[4].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[4].DecisionResult.First["output2"].Value.Should().Be(3.3);

            ctx.Snapshots.Snapshots[4].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[4].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[4].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[4].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[4].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[4].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[4].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[4].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[4].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[4].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[4].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[4].Variables[0].Value.Should().Be(3);
            ctx.Snapshots.Snapshots[4].Variables[1].Value.Should().Be("6");
            ctx.Snapshots.Snapshots[4].Variables[2].Value.Should().Be(4);
            ctx.Snapshots.Snapshots[4].Variables[3].Value.Should().Be(3.3);
            ctx.Snapshots.Snapshots[4].Variables[4].Value.Should().Be("61");

            ctx.Snapshots.Last.Should().Be(ctx.Snapshots.Snapshots[4]);
        }

        [TestMethod]
        public void SnapshotTestD4_4()
        {
            var ctx = PrepSnapshotTestCtx(out var def);

            var result = ctx
                .WithInputParameter("input1", 4)
                .WithInputParameter("input2", "6")
                .ExecuteDecision("decision4");
            result.HasResult.Should().BeTrue();
            ctx.Snapshots.Should().NotBeNull();
            ctx.Snapshots.Snapshots.Should().HaveCount(5);

            //snapshot 0 - initial
            ctx.Snapshots.Snapshots[0].Step.Should().Be(0);
            ctx.Snapshots.Snapshots[0].Decision.Should().BeNull();
            ctx.Snapshots.Snapshots[0].DecisionName.Should().BeNull();
            ctx.Snapshots.Snapshots[0].DecisionResult.Should().BeNull();
            ctx.Snapshots.Snapshots[0].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[0].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[0].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[0].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[0].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[0].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[0].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[0].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[0].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[0].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[0].Variables[0].Value.Should().Be(4);
            ctx.Snapshots.Snapshots[0].Variables[1].Value.Should().Be("6");
            ctx.Snapshots.Snapshots[0].Variables[2].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[3].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[4].Value.Should().Be(null);

            //snapshot 1 - after d2 (input2+1->var3)
            ctx.Snapshots.Snapshots[1].Step.Should().Be(1);
            ctx.Snapshots.Snapshots[1].Decision.Should().Be(def.Decisions["decision2"]);
            ctx.Snapshots.Snapshots[1].DecisionName.Should().Be("decision2");
            ctx.Snapshots.Snapshots[1].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[1].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[1].DecisionResult.First["var3"].Value.Should().Be("61");

            ctx.Snapshots.Snapshots[1].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[1].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[1].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[1].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[1].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[1].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[1].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[1].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[1].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[1].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[1].Variables[0].Value.Should().Be(4);
            ctx.Snapshots.Snapshots[1].Variables[1].Value.Should().Be("6");
            ctx.Snapshots.Snapshots[1].Variables[2].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[3].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[4].Value.Should().Be("61");

            //snapshot 2 - after  d3 (double.Parse(var3)->output2)
            ctx.Snapshots.Snapshots[2].Step.Should().Be(2);
            ctx.Snapshots.Snapshots[2].Decision.Should().Be(def.Decisions["decision3"]);
            ctx.Snapshots.Snapshots[2].DecisionName.Should().Be("decision3");
            ctx.Snapshots.Snapshots[2].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[2].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[2].DecisionResult.First["output2"].Value.Should().Be(61.0);

            ctx.Snapshots.Snapshots[2].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[2].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[2].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[2].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[2].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[2].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[2].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[2].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[2].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[2].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[2].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[2].Variables[0].Value.Should().Be(4);
            ctx.Snapshots.Snapshots[2].Variables[1].Value.Should().Be("6");
            ctx.Snapshots.Snapshots[2].Variables[2].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[2].Variables[3].Value.Should().Be(61.0);
            ctx.Snapshots.Snapshots[2].Variables[4].Value.Should().Be("61");

            //snapshot 3 - after  d1 (input1+1->output1)
            ctx.Snapshots.Snapshots[3].Step.Should().Be(3);
            ctx.Snapshots.Snapshots[3].Decision.Should().Be(def.Decisions["decision1"]);
            ctx.Snapshots.Snapshots[3].DecisionName.Should().Be("decision1");
            ctx.Snapshots.Snapshots[3].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[3].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[3].DecisionResult.First["output1"].Value.Should().Be(5);

            ctx.Snapshots.Snapshots[3].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[3].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[3].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[3].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[3].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[3].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[3].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[3].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[3].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[3].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[3].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[3].Variables[0].Value.Should().Be(4);
            ctx.Snapshots.Snapshots[3].Variables[1].Value.Should().Be("6");
            ctx.Snapshots.Snapshots[3].Variables[2].Value.Should().Be(5);
            ctx.Snapshots.Snapshots[3].Variables[3].Value.Should().Be(61.0);
            ctx.Snapshots.Snapshots[3].Variables[4].Value.Should().Be("61");

            //snapshot 4 - after  d4 (i1:1->1,1.1; i1:2->2,N/A; i1:3->N/A,3.3; i1:other->N/A,N/A)
            ctx.Snapshots.Snapshots[4].Step.Should().Be(4);
            ctx.Snapshots.Snapshots[4].Decision.Should().Be(def.Decisions["decision4"]);
            ctx.Snapshots.Snapshots[4].DecisionName.Should().Be("decision4");
            ctx.Snapshots.Snapshots[4].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[4].DecisionResult.First.Variables.Should().HaveCount(0);

            ctx.Snapshots.Snapshots[4].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[4].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[4].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[4].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[4].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[4].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[4].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[4].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[4].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[4].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[4].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[4].Variables[0].Value.Should().Be(4);
            ctx.Snapshots.Snapshots[4].Variables[1].Value.Should().Be("6");
            ctx.Snapshots.Snapshots[4].Variables[2].Value.Should().Be(5);
            ctx.Snapshots.Snapshots[4].Variables[3].Value.Should().Be(61.0);
            ctx.Snapshots.Snapshots[4].Variables[4].Value.Should().Be("61");

            ctx.Snapshots.Last.Should().Be(ctx.Snapshots.Snapshots[4]);
        }

        [TestMethod]
        public void SnapshotTestD4_0()
        {
            var ctx = PrepSnapshotTestCtx(out var def);

            var result = ctx
                .WithInputParameter("input1", 0)
                .WithInputParameter("input2", "")
                .ExecuteDecision("decision4");
            result.HasResult.Should().BeTrue();
            ctx.Snapshots.Should().NotBeNull();
            ctx.Snapshots.Snapshots.Should().HaveCount(5);

            //snapshot 0 - initial
            ctx.Snapshots.Snapshots[0].Step.Should().Be(0);
            ctx.Snapshots.Snapshots[0].Decision.Should().BeNull();
            ctx.Snapshots.Snapshots[0].DecisionName.Should().BeNull();
            ctx.Snapshots.Snapshots[0].DecisionResult.Should().BeNull();
            ctx.Snapshots.Snapshots[0].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[0].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[0].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[0].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[0].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[0].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[0].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[0].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[0].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[0].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[0].Variables[0].Value.Should().Be(0);
            ctx.Snapshots.Snapshots[0].Variables[1].Value.Should().Be("");
            ctx.Snapshots.Snapshots[0].Variables[2].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[3].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[4].Value.Should().Be(null);

            //snapshot 1 - after d2 (input2+1->var3)
            ctx.Snapshots.Snapshots[1].Step.Should().Be(1);
            ctx.Snapshots.Snapshots[1].Decision.Should().Be(def.Decisions["decision2"]);
            ctx.Snapshots.Snapshots[1].DecisionName.Should().Be("decision2");
            ctx.Snapshots.Snapshots[1].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[1].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[1].DecisionResult.First["var3"].Value.Should().Be("1");

            ctx.Snapshots.Snapshots[1].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[1].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[1].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[1].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[1].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[1].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[1].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[1].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[1].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[1].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[1].Variables[0].Value.Should().Be(0);
            ctx.Snapshots.Snapshots[1].Variables[1].Value.Should().Be("");
            ctx.Snapshots.Snapshots[1].Variables[2].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[3].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[4].Value.Should().Be("1");

            //snapshot 2 - after  d3 (double.Parse(var3)->output2)
            ctx.Snapshots.Snapshots[2].Step.Should().Be(2);
            ctx.Snapshots.Snapshots[2].Decision.Should().Be(def.Decisions["decision3"]);
            ctx.Snapshots.Snapshots[2].DecisionName.Should().Be("decision3");
            ctx.Snapshots.Snapshots[2].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[2].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[2].DecisionResult.First["output2"].Value.Should().Be(1.0);

            ctx.Snapshots.Snapshots[2].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[2].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[2].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[2].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[2].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[2].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[2].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[2].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[2].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[2].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[2].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[2].Variables[0].Value.Should().Be(0);
            ctx.Snapshots.Snapshots[2].Variables[1].Value.Should().Be("");
            ctx.Snapshots.Snapshots[2].Variables[2].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[2].Variables[3].Value.Should().Be(1.0);
            ctx.Snapshots.Snapshots[2].Variables[4].Value.Should().Be("1");

            //snapshot 3 - after  d1 (input1+1->output1)
            ctx.Snapshots.Snapshots[3].Step.Should().Be(3);
            ctx.Snapshots.Snapshots[3].Decision.Should().Be(def.Decisions["decision1"]);
            ctx.Snapshots.Snapshots[3].DecisionName.Should().Be("decision1");
            ctx.Snapshots.Snapshots[3].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[3].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[3].DecisionResult.First["output1"].Value.Should().Be(1);

            ctx.Snapshots.Snapshots[3].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[3].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[3].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[3].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[3].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[3].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[3].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[3].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[3].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[3].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[3].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[3].Variables[0].Value.Should().Be(0);
            ctx.Snapshots.Snapshots[3].Variables[1].Value.Should().Be("");
            ctx.Snapshots.Snapshots[3].Variables[2].Value.Should().Be(1);
            ctx.Snapshots.Snapshots[3].Variables[3].Value.Should().Be(1.0);
            ctx.Snapshots.Snapshots[3].Variables[4].Value.Should().Be("1");

            //snapshot 4 - after  d4 (i1:1->1,1.1; i1:2->2,N/A; i1:3->N/A,3.3; i1:other->N/A,N/A)
            ctx.Snapshots.Snapshots[4].Step.Should().Be(4);
            ctx.Snapshots.Snapshots[4].Decision.Should().Be(def.Decisions["decision4"]);
            ctx.Snapshots.Snapshots[4].DecisionName.Should().Be("decision4");
            ctx.Snapshots.Snapshots[4].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[4].DecisionResult.First.Variables.Should().HaveCount(0);

            ctx.Snapshots.Snapshots[4].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[4].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[4].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[4].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[4].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[4].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[4].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[4].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[4].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[4].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[4].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[4].Variables[0].Value.Should().Be(0);
            ctx.Snapshots.Snapshots[4].Variables[1].Value.Should().Be("");
            ctx.Snapshots.Snapshots[4].Variables[2].Value.Should().Be(1);
            ctx.Snapshots.Snapshots[4].Variables[3].Value.Should().Be(1.0);
            ctx.Snapshots.Snapshots[4].Variables[4].Value.Should().Be("1");

            ctx.Snapshots.Last.Should().Be(ctx.Snapshots.Snapshots[4]);
        }

#if (NETCOREAPP2_1 != true ) //skip for netcore2.1 as it's not supported by the old test framework
        [TestMethod]
        [DataRow("decision1", 3, 1, "incCount", "decision1")]
        [DataRow("decision2", 4, 1, "incCount", "decision1", "decision2")]
        [DataRow("decision3", 7, 2, "incCount", "decision1", "incCount", "decision1", "decision2", "decision3")]
        [DataRow("decision4", 8, 3, "incCount", "decision1", "incCount", "incCount", "decision1", "decision2",
            "decision4")]
        public void ComplexDependencySnapshotTest(string decision, int snapshotCount, int expectedResult,
            params string[] decisions)
        {
            // incCount (count+1 ->count)
            // d1 (count->output) <- incCount = incCount, d1
            // d2 (count->output) <- d1 = incCount, d1, d2
            // d3 (count->output) <- d1,d2  = incCount, d1, incCount, d1, d2, d3
            // d4 (count->output) <- d1,incCount,d2  = incCount, d1,incCount, incCount, d1, d2, d4
            var def = new DmnDefinitionBuilder()
                .WithVariable<int>("output", out var outputRef)
                .WithVariable<int>("count", out var countRef)
                .WithExpressionDecision("incCount", "count+1", countRef, out var incCountRef)
                .WithExpressionDecision("decision1", b => b
                    .Put("count").To(outputRef)
                    .Requires(incCountRef), out var decision1Ref)
                .WithExpressionDecision("decision2", b => b
                    .Put("count").To(outputRef)
                    .Requires(decision1Ref), out var decision2Ref)
                .WithExpressionDecision("decision3", b => b
                    .Put("count").To(outputRef)
                    .Requires(decision1Ref)
                    .Requires(decision2Ref))
                .WithExpressionDecision("decision4", b => b
                    .Put("count").To(outputRef)
                    .Requires(decision1Ref)
                    .Requires(incCountRef)
                    .Requires(decision2Ref))
                .Build();

            var ctx = DmnExecutionContextFactory.CreateExecutionContext(def, o => o.RecordSnapshots = true);

            var result = ctx.ExecuteDecision(decision);
            result.HasResult.Should().BeTrue();
            ctx.Snapshots.Should().NotBeNull();
            ctx.Snapshots.Snapshots.Should().HaveCount(snapshotCount);

            result.First["output"].Value.Should().Be(expectedResult);

            for (var i = 0; i < decisions.Length; i++)
            {
                ctx.Snapshots.Snapshots[i + 1].DecisionName.Should().Be(decisions[i]);
            }
        }
#endif

        [TestMethod]
        public void SnapshotTestD4_NoParam()
        {
            var ctx = PrepSnapshotTestCtx(out var def);

            var result = ctx
                .WithInputParameter("input2", "")
                .ExecuteDecision("decision4");
            result.HasResult.Should().BeTrue();
            ctx.Snapshots.Should().NotBeNull();
            ctx.Snapshots.Snapshots.Should().HaveCount(5);

            //snapshot 0 - initial
            ctx.Snapshots.Snapshots[0].Step.Should().Be(0);
            ctx.Snapshots.Snapshots[0].Decision.Should().BeNull();
            ctx.Snapshots.Snapshots[0].DecisionName.Should().BeNull();
            ctx.Snapshots.Snapshots[0].DecisionResult.Should().BeNull();
            ctx.Snapshots.Snapshots[0].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[0].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[0].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[0].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[0].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[0].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[0].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[0].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[0].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[0].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[0].Variables[0].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[1].Value.Should().Be("");
            ctx.Snapshots.Snapshots[0].Variables[2].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[3].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[0].Variables[4].Value.Should().Be(null);

            //snapshot 1 - after d2 (input2+1->var3)
            ctx.Snapshots.Snapshots[1].Step.Should().Be(1);
            ctx.Snapshots.Snapshots[1].Decision.Should().Be(def.Decisions["decision2"]);
            ctx.Snapshots.Snapshots[1].DecisionName.Should().Be("decision2");
            ctx.Snapshots.Snapshots[1].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[1].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[1].DecisionResult.First["var3"].Value.Should().Be("1");

            ctx.Snapshots.Snapshots[1].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[1].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[1].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[1].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[1].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[1].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[1].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[1].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[1].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[1].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[1].Variables[0].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[1].Value.Should().Be("");
            ctx.Snapshots.Snapshots[1].Variables[2].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[3].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[1].Variables[4].Value.Should().Be("1");

            //snapshot 2 - after  d3 (double.Parse(var3)->output2)
            ctx.Snapshots.Snapshots[2].Step.Should().Be(2);
            ctx.Snapshots.Snapshots[2].Decision.Should().Be(def.Decisions["decision3"]);
            ctx.Snapshots.Snapshots[2].DecisionName.Should().Be("decision3");
            ctx.Snapshots.Snapshots[2].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[2].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[2].DecisionResult.First["output2"].Value.Should().Be(1.0);

            ctx.Snapshots.Snapshots[2].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[2].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[2].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[2].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[2].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[2].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[2].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[2].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[2].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[2].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[2].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[2].Variables[0].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[2].Variables[1].Value.Should().Be("");
            ctx.Snapshots.Snapshots[2].Variables[2].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[2].Variables[3].Value.Should().Be(1.0);
            ctx.Snapshots.Snapshots[2].Variables[4].Value.Should().Be("1");

            //snapshot 3 - after  d1 (input1+1->output1)
            ctx.Snapshots.Snapshots[3].Step.Should().Be(3);
            ctx.Snapshots.Snapshots[3].Decision.Should().Be(def.Decisions["decision1"]);
            ctx.Snapshots.Snapshots[3].DecisionName.Should().Be("decision1");
            ctx.Snapshots.Snapshots[3].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[3].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[3].DecisionResult.First["output1"].Value.Should().Be(1);

            ctx.Snapshots.Snapshots[3].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[3].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[3].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[3].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[3].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[3].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[3].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[3].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[3].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[3].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[3].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[3].Variables[0].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[3].Variables[1].Value.Should().Be("");
            ctx.Snapshots.Snapshots[3].Variables[2].Value.Should().Be(1);
            ctx.Snapshots.Snapshots[3].Variables[3].Value.Should().Be(1.0);
            ctx.Snapshots.Snapshots[3].Variables[4].Value.Should().Be("1");

            //snapshot 4 - after  d4 (i1:1->1,1.1; i1:2->2,N/A; i1:3->N/A,3.3; i1:other->N/A,N/A)
            ctx.Snapshots.Snapshots[4].Step.Should().Be(4);
            ctx.Snapshots.Snapshots[4].Decision.Should().Be(def.Decisions["decision4"]);
            ctx.Snapshots.Snapshots[4].DecisionName.Should().Be("decision4");
            ctx.Snapshots.Snapshots[4].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[4].DecisionResult.First.Variables.Should().HaveCount(0);

            ctx.Snapshots.Snapshots[4].Variables.Should().HaveCount(5);
            ctx.Snapshots.Snapshots[4].Variables[0].Name.Should().Be("input1");
            ctx.Snapshots.Snapshots[4].Variables[1].Name.Should().Be("input2");
            ctx.Snapshots.Snapshots[4].Variables[2].Name.Should().Be("output1");
            ctx.Snapshots.Snapshots[4].Variables[3].Name.Should().Be("output2");
            ctx.Snapshots.Snapshots[4].Variables[4].Name.Should().Be("var3");

            ctx.Snapshots.Snapshots[4].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[4].Variables[1].Type.Should().Be(null);
            ctx.Snapshots.Snapshots[4].Variables[2].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[4].Variables[3].Type.Should().Be(typeof(double));
            ctx.Snapshots.Snapshots[4].Variables[4].Type.Should().Be(typeof(string));

            ctx.Snapshots.Snapshots[4].Variables[0].Value.Should().Be(null);
            ctx.Snapshots.Snapshots[4].Variables[1].Value.Should().Be("");
            ctx.Snapshots.Snapshots[4].Variables[2].Value.Should().Be(1);
            ctx.Snapshots.Snapshots[4].Variables[3].Value.Should().Be(1.0);
            ctx.Snapshots.Snapshots[4].Variables[4].Value.Should().Be("1");

            ctx.Snapshots.Last.Should().Be(ctx.Snapshots.Snapshots[4]);
        }

        [TestMethod]
        public void TableCollectSnapshotTest()
        {
            // expr1: output+1 -> output
            // tbl <-expr1:
            //  "r1" - always -> input
            //  "r2" - input > 10 -> input+10
            //  "r3" - input (>=5 && <15) -> input+5
            // expr2: output*2 ->output <-tbl, expr1 = expr1, tbl, expr1, expr2
            var def = new DmnDefinitionBuilder()
                .WithInput<int>("input", out var inputVarRef)
                .WithVariable<int>("output", out var outputVarRef)
                .WithExpressionDecision("expr1", "output+1", outputVarRef, out var expDecision1Ref)

                .WithTableDecision("tbl", table =>
                    table
                        .WithInput(inputVarRef, out var tblInputRef)
                        .WithOutput(outputVarRef, out var tblOutputRef)

                        .WithRule("r1", r => r
                           .Always()
                           .Then(tblOutputRef, "input"))
                        .WithRule("r2", r => r
                            .When(tblInputRef, SFeel.Gt(10))
                            .Then(tblOutputRef, "input+10"))
                        .WithRule("r3", r => r
                            .When(tblInputRef, SFeel.RngIE(5, 15))
                            .Then(tblOutputRef, "input+5"))

                        .WithHitPolicy(HitPolicyEnum.Collect)
                        .WithAggregation(CollectHitPolicyAggregationEnum.List)
                        .Requires(expDecision1Ref), out var tblDecisionRef)

                .WithExpressionDecision("expr2", e => e
                    .Put("output*2")
                    .To(outputVarRef)
                    .Requires(tblDecisionRef)
                    .Requires(expDecision1Ref))

                .Build();

            const int input = 12;
            var ctx = DmnExecutionContextFactory
                .CreateExecutionContext(def, o => o.RecordSnapshots = true)
                .WithInputParameter("input", input);

            var dummy = ctx.ExecuteDecision("expr2");

            //snapshot 0 - initial
            ctx.Snapshots.Snapshots[0].Step.Should().Be(0);
            ctx.Snapshots.Snapshots[0].Decision.Should().BeNull();
            ctx.Snapshots.Snapshots[0].DecisionName.Should().BeNull();
            ctx.Snapshots.Snapshots[0].DecisionResult.Should().BeNull();

            ctx.Snapshots.Snapshots[0].Variables.Should().HaveCount(2);
            ctx.Snapshots.Snapshots[0].Variables[0].Name.Should().Be("input");
            ctx.Snapshots.Snapshots[0].Variables[1].Name.Should().Be("output");
            ctx.Snapshots.Snapshots[0].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[0].Variables[1].Type.Should().Be(typeof(int));

            ctx.Snapshots.Snapshots[0].Variables[0].Value.Should().Be(input);
            ctx.Snapshots.Snapshots[0].Variables[1].Value.Should().Be(null);


            //snapshot 1 - after expr1 (output+1 -> output)
            ctx.Snapshots.Snapshots[1].Step.Should().Be(1);
            ctx.Snapshots.Snapshots[1].Decision.Should().Be(def.Decisions["expr1"]);
            ctx.Snapshots.Snapshots[1].DecisionName.Should().Be("expr1");
            ctx.Snapshots.Snapshots[1].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[1].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[1].DecisionResult.First["output"].Value.Should().Be(1);

            ctx.Snapshots.Snapshots[1].Variables.Should().HaveCount(2);
            ctx.Snapshots.Snapshots[1].Variables[0].Name.Should().Be("input");
            ctx.Snapshots.Snapshots[1].Variables[1].Name.Should().Be("output");
            ctx.Snapshots.Snapshots[1].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[1].Variables[1].Type.Should().Be(typeof(int));

            ctx.Snapshots.Snapshots[1].Variables[0].Value.Should().Be(input);
            ctx.Snapshots.Snapshots[1].Variables[1].Value.Should().Be(1);

            //snapshot 2 - after  tbl ("r1" - always -> input; "r2" - input > 10 -> input+10; "r3" - input (>=5 && <15) -> input+5) 
            ctx.Snapshots.Snapshots[2].Step.Should().Be(2);
            ctx.Snapshots.Snapshots[2].Decision.Should().Be(def.Decisions["tbl"]);
            ctx.Snapshots.Snapshots[2].DecisionName.Should().Be("tbl");
            ctx.Snapshots.Snapshots[2].DecisionResult.Should().NotBeNull();

            var tblResult = ctx.Snapshots.Snapshots[2].DecisionResult;
            tblResult.HasResult.Should().BeTrue();
            tblResult.IsSingleResult.Should().BeFalse();
            tblResult.Results.Should().HaveCount(3);

            tblResult.Results[0].HitRules.Should().HaveCount(1);
            tblResult.Results[0].HitRules[0].Name.Should().Be("r1");
            tblResult.Results[0]["output"].Value.Should().Be(input);

            tblResult.Results[1].HitRules.Should().HaveCount(1);
            tblResult.Results[1].HitRules[0].Name.Should().Be("r2");
            tblResult.Results[1]["output"].Value.Should().Be(input + 10);

            tblResult.Results[2].HitRules.Should().HaveCount(1);
            tblResult.Results[2].HitRules[0].Name.Should().Be("r3");
            tblResult.Results[2]["output"].Value.Should().Be(input + 5);

            ctx.Snapshots.Snapshots[2].Variables.Should().HaveCount(2);
            ctx.Snapshots.Snapshots[2].Variables[0].Name.Should().Be("input");
            ctx.Snapshots.Snapshots[2].Variables[1].Name.Should().Be("output");
            ctx.Snapshots.Snapshots[2].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[2].Variables[1].Type.Should().Be(typeof(int));

            ctx.Snapshots.Snapshots[2].Variables[0].Value.Should().Be(input);
            ctx.Snapshots.Snapshots[2].Variables[1].Value.Should().Be(input + 5); //the last result goes to var

            //snapshot 3 - after  expr1 (output+1 -> output)
            ctx.Snapshots.Snapshots[3].Step.Should().Be(3);
            ctx.Snapshots.Snapshots[3].Decision.Should().Be(def.Decisions["expr1"]);
            ctx.Snapshots.Snapshots[3].DecisionName.Should().Be("expr1");
            ctx.Snapshots.Snapshots[3].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[3].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[3].DecisionResult.First["output"].Value.Should().Be(input + 5 + 1);

            ctx.Snapshots.Snapshots[3].Variables.Should().HaveCount(2);
            ctx.Snapshots.Snapshots[3].Variables[0].Name.Should().Be("input");
            ctx.Snapshots.Snapshots[3].Variables[1].Name.Should().Be("output");
            ctx.Snapshots.Snapshots[3].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[3].Variables[1].Type.Should().Be(typeof(int));

            ctx.Snapshots.Snapshots[3].Variables[0].Value.Should().Be(input);
            ctx.Snapshots.Snapshots[3].Variables[1].Value.Should().Be(input + 5 + 1);

            //snapshot 4 - after expr2 (output*2 ->output)
            ctx.Snapshots.Snapshots[4].Step.Should().Be(4);
            ctx.Snapshots.Snapshots[4].Decision.Should().Be(def.Decisions["expr2"]);
            ctx.Snapshots.Snapshots[4].DecisionName.Should().Be("expr2");
            ctx.Snapshots.Snapshots[4].DecisionResult.Should().NotBeNull();
            ctx.Snapshots.Snapshots[4].DecisionResult.First.Variables.Should().HaveCount(1);
            ctx.Snapshots.Snapshots[4].DecisionResult.First["output"].Value.Should().Be((input + 5 + 1) * 2);

            ctx.Snapshots.Snapshots[4].Variables.Should().HaveCount(2);
            ctx.Snapshots.Snapshots[4].Variables[0].Name.Should().Be("input");
            ctx.Snapshots.Snapshots[4].Variables[1].Name.Should().Be("output");
            ctx.Snapshots.Snapshots[4].Variables[0].Type.Should().Be(typeof(int));
            ctx.Snapshots.Snapshots[4].Variables[1].Type.Should().Be(typeof(int));

            ctx.Snapshots.Snapshots[4].Variables[0].Value.Should().Be(input);
            ctx.Snapshots.Snapshots[4].Variables[1].Value.Should().Be((input + 5 + 1) * 2);

            ctx.Snapshots.Last.Should().Be(ctx.Snapshots.Snapshots[4]);
        }
    }
}
