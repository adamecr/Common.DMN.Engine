using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.decisions.expression;
using net.adamec.lib.common.dmn.engine.engine.decisions.table;
using net.adamec.lib.common.dmn.engine.engine.definition.builder;
using net.adamec.lib.common.dmn.engine.engine.execution.context;
using net.adamec.lib.common.dmn.engine.parser.dto;

namespace net.adamec.lib.common.dmn.engine.test.builder
{
    [TestClass]
    [TestCategory("Builder Basic Tests")]
    public class BuilderBasicTests
    {
        [TestMethod]
        [DataRow(5, 2)]
        [DataRow(3, 2)]
        [DataRow(2, 1)]
        [DataRow(1, 1)]
        [DataRow(-1, 1)]
        [DataRow(int.MinValue, 1)]
        public void TableAlwaysTest(int input, int output)
        {
            var def = new DmnDefinitionBuilder()
                .WithInput<int>("input", out var inputRef)
                .WithVariable<int>("output", out var outputRef)
                .WithTableDecision("tbl", table =>
                    table
                        .WithInput(inputRef, out var tblInputRef)
                        .WithOutput(outputRef, out var tblOutputRef)
                        .WithHitPolicy(HitPolicyEnum.First)
                        .WithRule("rule1", r =>
                            r.When(tblInputRef, ">2").Then(tblOutputRef, "2"))
                        .WithRule("rule2", r =>
                            r.Always().Then(tblOutputRef, "1")))
                .Build();

            def.InputData.Should().HaveCount(1);
            def.Variables.Should().HaveCount(2);
            def.Variables["input"].IsInputParameter.Should().BeTrue();
            def.Variables["input"].Type.Should().Be<int>();
            def.Variables["output"].IsInputParameter.Should().BeFalse();
            def.Variables["output"].Type.Should().Be<int>();
            def.Decisions.Should().HaveCount(1);
            def.Decisions["tbl"].Should().BeOfType<DmnDecisionTable>();

            var tbl = (DmnDecisionTable)def.Decisions["tbl"];
            tbl.Inputs.Should().HaveCount(1);
            tbl.Inputs[0].Variable.Name.Should().Be("input");
            tbl.Outputs[0].Variable.Name.Should().Be("output");
            tbl.Rules.Should().HaveCount(2);
            tbl.Rules[0].Inputs.Should().HaveCount(1);
            tbl.Rules[1].Inputs.Should().HaveCount(0);

            var ctx = DmnExecutionContextFactory.CreateExecutionContext(def);
            if (input > int.MinValue)
            {
                ctx.WithInputParameter("input", input);
            }

            var result = ctx.ExecuteDecision("tbl");

            result.IsSingleResult.Should().BeTrue();
            result.FirstResultVariables.Should().HaveCount(1);
            result.FirstResultVariables[0].Value.Should().Be(output);
        }

        [TestMethod]
        [DataRow(1, 2, true, "one", 2, true, "one")]
        [DataRow(2, 3, false, "two", 3, false, "two")]
        [DataRow(3, 4, false, "two", 4, false, "two")]
        [DataRow(4, null, true, "three", 99, true, "three")]
        [DataRow(5, 5, null, null, 5, true, "default")]
        [DataRow(6, null, null, null, 99, true, "default")]
        public void TableOutputsTest(int input, int? outputInt, bool? outputBool, string outputStr, int varInt, bool varBool, string varStr)
        {
            var def = new DmnDefinitionBuilder()
                .WithInput<int>("input", out var inputRef)
                .WithVariable<int>("output1", out var output1Ref)
                .WithVariable<bool>("output2", out var output2Ref)
                .WithVariable<string>("output3", out var output3Ref)
                .WithExpressionDecision("out1Default", "99", output1Ref, out var default1Ref)
                .WithExpressionDecision("out2Default", "true", output2Ref, out var default2Ref)
                .WithExpressionDecision("out3Default", "\"default\"", output3Ref, out var default3Ref)
                .WithTableDecision("tbl", table =>
                    table
                        .WithInput(inputRef, out var tblInputRef)
                        .WithOutput(output1Ref, out var tblOutput1Ref)
                        .WithOutput(output2Ref, out var tblOutput2Ref)
                        .WithOutput(output3Ref, out var tblOutput3Ref)
                        .WithHitPolicy(HitPolicyEnum.First)
                        .WithRule("rule1", r => r.When(tblInputRef, "1")
                            .Then(tblOutput1Ref, "2")
                            .And(tblOutput2Ref, "true")
                            .And(tblOutput3Ref, "\"one\""))
                        .WithRule("rule2", r => r.When(tblInputRef, "[2..3]")
                            .Then(tblOutput1Ref, "input+1")
                            .And(tblOutput2Ref, "false")
                            .And(tblOutput3Ref, "\"two\""))
                        .WithRule("rule3", r => r.When(tblInputRef, "4")
                            .Then(tblOutput2Ref, "true")
                            .And(tblOutput3Ref, "\"three\""))
                        .WithRule("rule4", r => r.When(tblInputRef, "5")
                            .Then(tblOutput1Ref, "5"))
                        .WithRule("rule5", r => r.When(tblInputRef, "6")
                            .SkipOutput())
                        .Requires(default1Ref)
                        .Requires(default2Ref)
                        .Requires(default3Ref))
                .Build();

            def.InputData.Should().HaveCount(1);
            def.Variables.Should().HaveCount(4);
            def.Variables["input"].IsInputParameter.Should().BeTrue();
            def.Variables["input"].Type.Should().Be<int>();
            def.Variables["output1"].IsInputParameter.Should().BeFalse();
            def.Variables["output1"].Type.Should().Be<int>();
            def.Variables["output2"].IsInputParameter.Should().BeFalse();
            def.Variables["output2"].Type.Should().Be<bool>();
            def.Variables["output3"].IsInputParameter.Should().BeFalse();
            def.Variables["output3"].Type.Should().Be<string>();
            def.Decisions.Should().HaveCount(4);
            def.Decisions["out1Default"].Should().BeOfType<DmnExpressionDecision>();
            def.Decisions["out2Default"].Should().BeOfType<DmnExpressionDecision>();
            def.Decisions["out2Default"].Should().BeOfType<DmnExpressionDecision>();
            def.Decisions["tbl"].Should().BeOfType<DmnDecisionTable>();

            var tbl = (DmnDecisionTable)def.Decisions["tbl"];
            tbl.Inputs.Should().HaveCount(1);
            tbl.Inputs[0].Variable.Name.Should().Be("input");
            tbl.Outputs.Should().HaveCount(3);
            tbl.Outputs[0].Variable.Name.Should().Be("output1");
            tbl.Outputs[1].Variable.Name.Should().Be("output2");
            tbl.Outputs[2].Variable.Name.Should().Be("output3");
            tbl.Rules.Should().HaveCount(5);
            tbl.Rules[0].Inputs.Should().HaveCount(1);
            tbl.Rules[1].Inputs.Should().HaveCount(1);
            tbl.RequiredDecisions.Should().HaveCount(3);

            var ctx = DmnExecutionContextFactory.CreateExecutionContext(def, configure => configure.RecordSnapshots = true);
            ctx.WithInputParameter("input", input);

            var result = ctx.ExecuteDecision("tbl");
            ctx.Snapshots.Snapshots.Should().HaveCount(5);
            var snap = ctx.Snapshots.Last;

            result.IsSingleResult.Should().BeTrue();
            if (outputInt != null) result.First["output1"].Value.Should().Be(outputInt);
            if (outputBool != null) result.First["output2"].Value.Should().Be(outputBool);
            if (outputStr != null) result.First["output3"].Value.Should().Be(outputStr);
            snap.Should().NotBeNull();
            snap["output1"].Value.Should().Be(varInt);
            snap["output2"].Value.Should().Be(varBool);
            snap["output3"].Value.Should().Be(varStr);
        }
    }
}
