using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.decisions.expression;
using net.adamec.lib.common.dmn.engine.engine.decisions.table;
using net.adamec.lib.common.dmn.engine.engine.definition.builder;
using net.adamec.lib.common.dmn.engine.engine.execution;
using net.adamec.lib.common.dmn.engine.engine.execution.context;
using net.adamec.lib.common.dmn.engine.parser.dto;
using Variable = net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable;

namespace net.adamec.lib.common.dmn.engine.test.builder
{
    [TestClass]
    [TestCategory("Builder Basic Tests")]
    public class BuilderBasicTests
    {
        [TestMethod]
        [DataRow("Str", typeof(string))]
        [DataRow("Boolean", typeof(bool))]
        [DataRow("Integer", typeof(int))]
        [DataRow("Double", typeof(double))]
        [DataRow("Obj", typeof(object))]
        public void InputAndVariableTest(string name, Type type)
        {
            var inputName = $"Input{name}";
            var varName = $"Var{name}";
            var builder = new DmnDefinitionBuilder()
                .WithVariable<string>("output", out var outputVarRef)
                .WithExpressionDecision("decision", "input", outputVarRef);

            var inputNames = new[]
            {
                $"{inputName}No_Type",
                $"{inputName}NoTypeOutRef",
                $"{inputName}TypeParam",
                $"{inputName}TypeParamOutRef",
                $"{inputName}GenParam",
                $"{inputName}GenParamOutRef"
            };


            builder.WithInput($" {inputName}No Type "); //To be normalized
            builder.WithInput(inputNames[1], out var inputNoTypeRef);
            builder.WithInput(inputNames[2], type);
            builder.WithInput(inputNames[3], type, out var inputTypeParamRef);

            //  def.WithInput<type>(inputNames[4]);
            var m1 = typeof(DmnDefinitionBuilder).GetMethod("WithInput", new[] { typeof(string) }, true).MakeGenericMethod(type);
            m1.Invoke(builder, new object[] { inputNames[4] });

            // def.WithInput<type>(inputNames[5], out var inputGenRef);
            var m2 = typeof(DmnDefinitionBuilder).GetMethod("WithInput", new[] { typeof(string), typeof(Variable.Ref).MakeByRefType() }, true).MakeGenericMethod(type);
            var m2Params = new object[] { inputNames[5], null };
            m2.Invoke(builder, m2Params);
            var inputGenRef = (Variable.Ref)m2Params[1];

            inputNoTypeRef.Name.Should().Be(inputNames[1]);
            inputNoTypeRef.IsInputParameter.Should().BeTrue();
            inputNoTypeRef.Type.Should().BeNull();

            inputTypeParamRef.Name.Should().Be(inputNames[3]);
            inputTypeParamRef.IsInputParameter.Should().BeTrue();
            inputTypeParamRef.Type.Should().Be(type);

            inputGenRef.Name.Should().Be(inputNames[5]);
            inputGenRef.IsInputParameter.Should().BeTrue();
            inputGenRef.Type.Should().Be(type);

            var varNames = new[]
            {
                $"{varName}Type_Param",
                $"{varName}TypeParamOutRef",
                $"{varName}GenParam",
                $"{varName}GenParamOutRef"
            };

            builder.WithVariable($" {varName}Type Param ", type);//To be normalized
            builder.WithVariable(varNames[1], type, out var varTypeParamRef);

            //  def.WithVariable<type>(varNames[2]);
            var m3 = typeof(DmnDefinitionBuilder).GetMethod("WithVariable", new[] { typeof(string) }, true).MakeGenericMethod(type);
            m3.Invoke(builder, new object[] { varNames[2] });

            // def.WithVariable<type>( varNames[3, out var varGenRef);
            var m4 = typeof(DmnDefinitionBuilder).GetMethod("WithVariable", new[] { typeof(string), typeof(Variable.Ref).MakeByRefType() }, true).MakeGenericMethod(type);
            var m4Params = new object[] { varNames[3], null };
            m4.Invoke(builder, m4Params);
            var varGenRef = (Variable.Ref)m4Params[1];

            varTypeParamRef.Name.Should().Be(varNames[1]);
            varTypeParamRef.IsInputParameter.Should().BeFalse();
            varTypeParamRef.Type.Should().Be(type);

            varGenRef.Name.Should().Be(varNames[3]);
            varGenRef.IsInputParameter.Should().BeFalse();
            varGenRef.Type.Should().Be(type);

            var def = builder.Build();

            builder.IsBuilt.Should().BeTrue();
            def.Should().NotBeNull();

            def.InputData.Should().HaveCount(inputNames.Length);
            for (var idx = 0; idx < inputNames.Length; idx++)
            {
                var n = inputNames[idx];
                def.InputData[n].Should().NotBeNull();
                def.InputData[n].IsInputParameter.Should().BeTrue();
                def.InputData[n].Name.Should().Be(n);
                if (idx > 1)
                {
                    def.InputData[n].Type.Should().Be(type);
                }
                else
                {
                    def.InputData[n].Type.Should().BeNull();
                }

                def.Variables[n].Should().NotBeNull();
                def.Variables[n].IsInputParameter.Should().BeTrue();
                def.Variables[n].Name.Should().Be(n);
                if (idx > 1)
                {
                    def.Variables[n].Type.Should().Be(type);
                }
                else
                {
                    def.Variables[n].Type.Should().BeNull();
                }
            }

            def.Variables.Should().HaveCount(1 + inputNames.Length + varNames.Length);//"output" variable+inputs+vars
            // ReSharper disable once ForCanBeConvertedToForeach
            for (var idx = 0; idx < varNames.Length; idx++)
            {
                var n = varNames[idx];
                def.Variables[n].Should().NotBeNull();
                def.Variables[n].IsInputParameter.Should().BeFalse();
                def.Variables[n].Name.Should().Be(n);
                def.Variables[n].Type.Should().Be(type);
            }
        }

        [TestMethod]
        public void DecisionRefAndRequireTest()
        {
            // input1 -> decision 1
            // n/a -> decision 2
            // input2, decision 2 -> decision 3
            // decision 2 -> decision 4

            // input1, input3, decision 2, decision 3 ->decision 5
            // n/a -> decision 6
            // input1 -> decision 7
            // decision 2, decision 5, decision 6 -> decision 8

            var def = new DmnDefinitionBuilder()
                .WithInput("input1", out var input1Ref)
                .WithInput("input2", out var input2Ref)
                .WithInput("input3", out var input3Ref)
                .WithVariable<string>("output", out var outputVarRef)
                .WithExpressionDecision("decision1", ed => ed
                        .Put("input1").To(outputVarRef)
                        .Requires(input1Ref),
                    out var decision1Ref)
                .WithExpressionDecision("decision2", "output+2", outputVarRef, out var decision2Ref) //IMPORTANT: The "output" variable is string, so the "decision2" is not numeric addition but it's string concat
                .WithExpressionDecision("decision3", ed => ed
                        .Put("input2+output").To(outputVarRef)
                        .Requires(input2Ref)
                        .Requires(decision2Ref),
                    out var decision3Ref)
                .WithExpressionDecision("decision4", ed => ed
                        .Put("DateTime.Now()").To(outputVarRef)
                        .Requires(decision2Ref),
                    out var decision4Ref)

                .WithTableDecision("decision5", t => t
                        .WithInput(input1Ref, out _)
                        .WithOutput(outputVarRef, out _)
                        .WithRule("r1", r => r.Always().SkipOutput())
                        .Requires(input1Ref)
                        .Requires(decision2Ref)
                        .Requires(input3Ref)
                        .Requires(decision3Ref),
                    out var decision5Ref)
                .WithTableDecision("decision6", t => t
                        .WithInput(input1Ref, out _)
                        .WithOutput(outputVarRef, out _)
                        .WithRule("r1", r => r.Always().SkipOutput()),
                    out var decision6Ref)
                .WithTableDecision("decision7", t => t
                        .WithInput(input1Ref, out _)
                        .WithOutput(outputVarRef, out _)
                        .WithRule("r1", r => r.Always().SkipOutput())
                        .Requires(input1Ref),
                    out var decision7Ref)
                .WithTableDecision("decision8", t => t
                        .WithInput(input1Ref, out _)
                        .WithOutput(outputVarRef, out _)
                        .WithRule("r1", r => r.Always().SkipOutput())
                        .Requires(decision2Ref)
                        .Requires(decision5Ref)
                        .Requires(decision6Ref),
                    out var decision8Ref)
                .Build();

            decision1Ref.DecisionType.Should().Be<ExpressionDecision>();
            decision1Ref.Name.Should().Be("decision1");
            decision2Ref.DecisionType.Should().Be<ExpressionDecision>();
            decision2Ref.Name.Should().Be("decision2");
            decision3Ref.DecisionType.Should().Be<ExpressionDecision>();
            decision3Ref.Name.Should().Be("decision3");
            decision4Ref.DecisionType.Should().Be<ExpressionDecision>();
            decision4Ref.Name.Should().Be("decision4");

            decision5Ref.DecisionType.Should().Be<TableDecision>();
            decision5Ref.Name.Should().Be("decision5");
            decision6Ref.DecisionType.Should().Be<TableDecision>();
            decision6Ref.Name.Should().Be("decision6");
            decision7Ref.DecisionType.Should().Be<TableDecision>();
            decision7Ref.Name.Should().Be("decision7");
            decision8Ref.DecisionType.Should().Be<TableDecision>();
            decision8Ref.Name.Should().Be("decision8");

            def.Decisions.Should().HaveCount(8);
            // input1 -> decision 1
            // n/a -> decision 2
            // input2, decision 2 -> decision 3
            // decision 2 -> decision 4
            var d1 = def.Decisions["decision1"];
            d1.Name.Should().Be("decision1");
            d1.Should().BeOfType<DmnExpressionDecision>();
            d1.RequiredInputs.Should().HaveCount(1);
            d1.RequiredDecisions.Should().HaveCount(0);
            var ri1 = d1.RequiredInputs.ToArray();
            ri1[0].Name.Should().Be("input1");
            ri1[0].IsInputParameter.Should().BeTrue();

            var d2 = def.Decisions["decision2"];
            d2.Name.Should().Be("decision2");
            d2.Should().BeOfType<DmnExpressionDecision>();
            d2.RequiredInputs.Should().HaveCount(0);
            d2.RequiredDecisions.Should().HaveCount(0);

            var d3 = def.Decisions["decision3"];
            d3.Name.Should().Be("decision3");
            d3.Should().BeOfType<DmnExpressionDecision>();
            d3.RequiredInputs.Should().HaveCount(1);
            d3.RequiredDecisions.Should().HaveCount(1);
            var ri3 = d3.RequiredInputs.ToArray();
            ri3[0].Name.Should().Be("input2");
            ri3[0].IsInputParameter.Should().BeTrue();
            var rd3 = d3.RequiredDecisions.ToArray();
            rd3[0].Name.Should().Be("decision2");

            var d4 = def.Decisions["decision4"];
            d4.Name.Should().Be("decision4");
            d4.Should().BeOfType<DmnExpressionDecision>();
            d4.RequiredInputs.Should().HaveCount(0);
            d4.RequiredDecisions.Should().HaveCount(1);
            var rd4 = d4.RequiredDecisions.ToArray();
            rd4[0].Name.Should().Be("decision2");

            // input1, input3, decision 2, decision 3 ->decision 5
            // n/a -> decision 6
            // input1 -> decision 7
            // decision 2, decision 5, decision 6 -> decision 8
            var d5 = def.Decisions["decision5"];
            d5.Name.Should().Be("decision5");
            d5.Should().BeOfType<DmnDecisionTable>();
            d5.RequiredInputs.Should().HaveCount(2);
            d5.RequiredDecisions.Should().HaveCount(2);
            var ri5 = d5.RequiredInputs.ToArray();
            ri5[0].Name.Should().Be("input1");
            ri5[0].IsInputParameter.Should().BeTrue();
            ri5[1].Name.Should().Be("input3");
            ri5[1].IsInputParameter.Should().BeTrue();
            var rd5 = d5.RequiredDecisions.ToArray();
            rd5[0].Name.Should().Be("decision2");
            rd5[1].Name.Should().Be("decision3");

            var d6 = def.Decisions["decision6"];
            d6.Name.Should().Be("decision6");
            d6.Should().BeOfType<DmnDecisionTable>();
            d6.RequiredInputs.Should().HaveCount(0);
            d6.RequiredDecisions.Should().HaveCount(0);

            var d7 = def.Decisions["decision7"];
            d7.Name.Should().Be("decision7");
            d7.Should().BeOfType<DmnDecisionTable>();
            d7.RequiredInputs.Should().HaveCount(1);
            d7.RequiredDecisions.Should().HaveCount(0);
            var ri7 = d7.RequiredInputs.ToArray();
            ri7[0].Name.Should().Be("input1");
            ri7[0].IsInputParameter.Should().BeTrue();

            var d8 = def.Decisions["decision8"];
            d8.Name.Should().Be("decision8");
            d8.Should().BeOfType<DmnDecisionTable>();
            d8.RequiredInputs.Should().HaveCount(0);
            d8.RequiredDecisions.Should().HaveCount(3);
            var rd8 = d8.RequiredDecisions.ToArray();
            rd8[0].Name.Should().Be("decision2");
            rd8[1].Name.Should().Be("decision5");
            rd8[2].Name.Should().Be("decision6");

            var ctx = DmnExecutionContextFactory.CreateExecutionContext(def, options => options.RecordSnapshots = true);
            ctx
                .WithInputParameter("input1", 4)
                .WithInputParameter("input2", 8);

            var result = ctx.ExecuteDecision("decision8");

            result.HasResult.Should().BeTrue();
            result.IsSingleResult.Should().BeTrue();
            result.FirstResultVariables.Should().HaveCount(0);

            ctx.Snapshots.Snapshots.Should().HaveCount(8);
            //IMPORTANT:
            //Decision 8 depends on decisions 2,5,6
            //Decision 5 depends on decisions 2,3
            //Decision 3 depends on decision 2
            //Decision 6 has no dependency
            //So, the execution is: 2,2,2,3,5,6,8
            ctx.Snapshots.Snapshots[1].DecisionName.Should().Be("decision2");
            ctx.Snapshots.Snapshots[2].DecisionName.Should().Be("decision2");
            ctx.Snapshots.Snapshots[3].DecisionName.Should().Be("decision2");
            ctx.Snapshots.Snapshots[4].DecisionName.Should().Be("decision3");
            ctx.Snapshots.Snapshots[5].DecisionName.Should().Be("decision5");
            ctx.Snapshots.Snapshots[6].DecisionName.Should().Be("decision6");
            ctx.Snapshots.Snapshots[7].DecisionName.Should().Be("decision8");
            //IMPORTANT: The "output" variable is string, so the "decision2" is not numeric addition but it's string concat
            ctx.Snapshots.Last["output"].Value.Should().Be("8222");
        }

        [TestMethod]
        [DataRow(3, 6, false, false, 8, 0, false)]
        [DataRow(4, 1, false, false, 3, 1, true)]
        [DataRow(6, 1, false, true, 3, 1, true)]
        [DataRow(6, 6, false, true, 8, 0, false)]
        [DataRow(0.9, 7, false, false, 9, 1, false)]
        [DataRow(6.1, 6, false, true, 8, 0, false)]
        [DataRow("6", 6, true, true, 8, 0, false)] //input1 will be string, so the eval will fail
        public void ExpressionDecisionTest(object input1, int input2, bool isExecErr, bool result1, int result2, int result3, bool result4)
        {
            var builder = new DmnDefinitionBuilder()
                .WithInput("input1")
                .WithInput<int>("input2", out var input2Ref)
                .WithVariable<bool>("var1", out var var1Ref)
                .WithVariable<int>("var2", out var var2Ref)
                .WithExpressionDecision("decision1", "input1>5.1", var1Ref)
                .WithExpressionDecision("decision2", "input2+2", var2Ref, out var decision2Ref)
                .WithExpressionDecision("decision3", ed => ed
                    .Put("input2 % 2")
                    .To(var2Ref))
                .WithExpressionDecision("decision4", ed => ed
                    .Put("input1>var2")
                    .To(var1Ref)
                    .Requires(input2Ref)
                    .Requires(decision2Ref));

            var def = builder.Build();

            var ctx = DmnExecutionContextFactory.CreateExecutionContext(def);

            var inputParameters = new Dictionary<string, object>
            {
                { "input1", input1 },
                { "input2", input2 }
            };
            ctx.WithInputParameters(inputParameters);

            if (!isExecErr)
            {
                var execResult1 = ctx.ExecuteDecision("decision1");
                var execResult2 = ctx.ExecuteDecision("decision2");
                var execResult3 = ctx.ExecuteDecision("decision3");
                var execResult4 = ctx.ExecuteDecision("decision4");


                execResult1.First["var1"].Value.Should().Be(result1);
                execResult2.First["var2"].Value.Should().Be(result2);
                execResult3.First["var2"].Value.Should().Be(result3);
                execResult4.First["var1"].Value.Should().Be(result4);
            }
            else
            {
                Action act = () => ctx.ExecuteDecision("decision1");
                act.Should().Throw<DmnExecutorException>();
            }
        }

        [TestMethod]
        public void ExpressionDecisionAdvancedTest()
        {

            var builder = new DmnDefinitionBuilder()
                .WithInput<int>("input1")
                .WithInput<int>("input2")
                .WithVariable<int>("var0", out var var0Ref);
            var variables = new Dictionary<string, Variable.Ref>();
            for (var i = 1; i <= 3; i++)
            {
                builder.WithVariable<int>($"var{i}", out var varRef);
                variables.Add(varRef.Name, varRef);
            }

            builder.WithExpressionDecision("decision0", ExpressionDecisionBuilder, out var decision0Ref);
            for (var i = 1; i <= 3; i++)
            {
                var varName = $"var{i}";
                var op = i % 2;
                var p = i;
                builder.WithExpressionDecision($"decision{i}", ed => ExpressionDecisionBuilderFactory(ed, op, p, varName));
            }

            //0: input1*3 -> var0 
            //1: input2+1 -> var1
            //2: input2*2 -> var2
            //3: input2+3 -> var3

            var input1 = 5;
            var input2 = 10;

            var def = builder.Build();
            var ctx = DmnExecutionContextFactory
                .CreateExecutionContext(def)
                .WithInputParameters(new Dictionary<string, object>
                {
                    { "input1", input1 },
                    { "input2", input2}

                });

            var result0 = ctx.ExecuteDecision(def.Decisions[decision0Ref.Name]);
            result0.First["var0"].Value.Should().Be(input1 * 3);
            var result1 = ctx.ExecuteDecision("decision1");
            result1.First["var1"].Value.Should().Be(input2 + 1);
            var result2 = ctx.ExecuteDecision("decision2");
            result2.First["var2"].Value.Should().Be(input2 * 2);
            var result3 = ctx.ExecuteDecision("decision3");
            result3.First["var3"].Value.Should().Be(input2 + 3);


            ExpressionDecision ExpressionDecisionBuilder(ExpressionDecision.ExpressionDecisionSrcBuilder b)
            {
                return b.Put("input1*3").To(var0Ref);

            }
            ExpressionDecision ExpressionDecisionBuilderFactory(ExpressionDecision.ExpressionDecisionSrcBuilder b, int op, int param, string varName)
            {
                switch (op)
                {
                    case 1: return ExpressionDecisionBuilderAdd(b, param, variables[varName]);
                    case 0: return ExpressionDecisionBuilderMultiply(b, param, variables[varName]);
                }

                throw new InvalidOperationException();
            }
            ExpressionDecision ExpressionDecisionBuilderAdd(ExpressionDecision.ExpressionDecisionSrcBuilder b, int i, Variable.Ref outVar)
            {
                return b.Put($"input2+{i}").To(outVar);
            }
            ExpressionDecision ExpressionDecisionBuilderMultiply(ExpressionDecision.ExpressionDecisionSrcBuilder b, int i, Variable.Ref outVar)
            {
                return b.Put($"input2*{i}").To(outVar);
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
        [DataRow(7, "A", true, false, null, null, "fallback")] // 3 (7%4) is no allowed for tbl input 4, so the "r4" rule is no-match, "fallback" is catch
        [DataRow(2, "B", false, false, null, "K", "r4")] //B is not allowed for tbl input 2, but fine with "r4"
        [DataRow(99, "A", false, true, null, "O", "error")] //O is not allowed output
        public void TableTest(int input1, string input2, bool input3, bool isErr, int? resultOut1, string resultOut2, string match)
        {
            //i1 - input1:int
            //i2 - input1%2==0 :bool (input1 is even)
            //i3 - input2:string; "A","C","E"
            //i4 - input1%4: int; 0,1,2 (input1 mod 4; 3 is not allowed)
            //i5 - !input3 : bool

            //"error" - input1 99->ERR(O is not allowed)
            //"r1" - input1 (even && >3 && %4 = 2), input2 = A | E, input3 = false-> 11,L
            //"r2" - input1 (even && >3), input3 = false-> 22,M
            //"r3" - input1 (even && %4 = 0)-> input1+2,N/A
            //"r4" - input1 %4 != 0 -> N/A, K
            //"fallback" - no prev match, no output

            var def = new DmnDefinitionBuilder()
                .WithInput<int>("input1", out var input1Ref)
                .WithInput<string>("input2", out var input2Ref)
                .WithInput<bool>("input3")
                .WithVariable<bool>("var1", out var var1Ref)
                .WithVariable<int>("var2", out var var2Ref)
                .WithVariable<string>("var3", out var var3Ref)
                .WithExpressionDecision("ed", "(input1 % 2)==0", var1Ref, out var edRef)
                .WithTableDecision("tbl", table =>
                    table
                        .WithInput(input1Ref, out var tblInput1Ref)
                        .WithInput(var1Ref, out var tblInput2Ref)
                        .WithInput(input2Ref, out var tblInput3Ref, "A", "C", "E")
                        .WithInput("(input1 % 4)", out var tblInput4Ref, "0", "1", "2")
                        .WithInput("!input3", out var tblInput5Ref)
                        .WithOutput(var2Ref, out var tblOutput1Ref)
                        .WithOutput(var3Ref, out var tblOutput2Ref, "K", "L", "M", "N")

                        .WithRule("error", "input1 99 -> ERR (O is not allowed)", r => r
                            .When(tblInput1Ref, "99")
                            .Then(tblOutput2Ref, "\"O\""))

                        .WithRule("r1", "input1 (even && >3 && %4 = 2), input2 = A | E, input3 = false-> 11,L", r => r
                              .When(tblInput1Ref, ">3")
                              .And(tblInput2Ref, "true")
                              .And(tblInput3Ref, "\"A\",\"E\"")
                              .And(tblInput4Ref, "2")
                              .And(tblInput5Ref, "not(false)")
                              .Then(tblOutput1Ref, "11")
                              .And(tblOutput2Ref, "\"L\""))

                        .WithRule("r2", "input1 (even && >3), input3 = false-> 22,M", r => r
                            .When(tblInput1Ref, ">3")
                            .And(tblInput2Ref, "true")
                            .And(tblInput5Ref, "true")
                            .Then(tblOutput1Ref, "22")
                            .And(tblOutput2Ref, "\"M\""))

                        .WithRule("r3", "input1 (even && %4 = 0)-> input1+2,N/A", r => r
                            .When(tblInput2Ref, "true")
                            .And(tblInput4Ref, "0")
                            .Then(tblOutput1Ref, "input1+2"))

                        .WithRule("r4", "input1 %4 != 0 -> N/A, K", r => r
                            .When(tblInput4Ref, "not(0)")
                            .Then(tblOutput2Ref, "\"K\""))

                        .WithRule("fallback", r => r.Always().SkipOutput()) //no prev match, no output 

                        .WithHitPolicy(HitPolicyEnum.First)
                        .Requires(edRef))
                .Build();

            def.InputData.Should().HaveCount(3);
            def.Variables.Should().HaveCount(3 + 3);
            def.Variables["input1"].IsInputParameter.Should().BeTrue();
            def.Variables["input1"].Type.Should().Be<int>();
            def.Variables["input2"].IsInputParameter.Should().BeTrue();
            def.Variables["input2"].Type.Should().Be<string>();
            def.Variables["input3"].IsInputParameter.Should().BeTrue();
            def.Variables["input3"].Type.Should().Be<bool>();

            def.Variables["var1"].IsInputParameter.Should().BeFalse();
            def.Variables["var1"].Type.Should().Be<bool>();
            def.Variables["var2"].IsInputParameter.Should().BeFalse();
            def.Variables["var2"].Type.Should().Be<int>();
            def.Variables["var3"].IsInputParameter.Should().BeFalse();
            def.Variables["var3"].Type.Should().Be<string>();
            def.Decisions.Should().HaveCount(2);
            def.Decisions["tbl"].Should().BeOfType<DmnDecisionTable>();

            var tbl = (DmnDecisionTable)def.Decisions["tbl"];
            tbl.HitPolicy.Should().Be(HitPolicyEnum.First);
            // tbl.Aggregation.Should().Be(CollectHitPolicyAggregationEnum.Count);
            tbl.Inputs.Should().HaveCount(5);
            tbl.Inputs[0].Variable.Name.Should().Be("input1");
            tbl.Inputs[0].Expression.Should().BeNull();
            tbl.Inputs[0].AllowedValues.Should().BeNull();
            tbl.Inputs[1].Variable.Name.Should().Be("var1");
            tbl.Inputs[1].Expression.Should().BeNull();
            tbl.Inputs[1].AllowedValues.Should().BeNull();
            tbl.Inputs[2].Variable.Name.Should().Be("input2");
            tbl.Inputs[2].Expression.Should().BeNull();
            tbl.Inputs[2].AllowedValues.Should().HaveCount(3);
            tbl.Inputs[2].AllowedValues.Should().Equal(new[] { "A", "C", "E" });

            tbl.Inputs[3].Expression.Should().Be("(input1 % 4)");
            tbl.Inputs[3].Variable.Should().BeNull();
            tbl.Inputs[3].AllowedValues.Should().HaveCount(3);
            tbl.Inputs[3].AllowedValues.Should().Equal(new[] { "0", "1", "2" });
            tbl.Inputs[4].Expression.Should().Be("!input3");
            tbl.Inputs[4].Variable.Should().BeNull();
            tbl.Inputs[4].AllowedValues.Should().BeNull();

            tbl.Outputs.Should().HaveCount(2);
            tbl.Outputs[0].Variable.Name.Should().Be("var2");
            tbl.Outputs[0].AllowedValues.Should().BeNull();
            tbl.Outputs[1].Variable.Name.Should().Be("var3");
            tbl.Outputs[1].AllowedValues.Should().Equal(new[] { "K", "L", "M", "N" });

            tbl.Rules.Should().HaveCount(6);
            tbl.Rules[0].Inputs.Should().HaveCount(1);
            tbl.Rules[0].Outputs.Should().HaveCount(1);
            tbl.Rules[1].Inputs.Should().HaveCount(5);
            tbl.Rules[1].Outputs.Should().HaveCount(2);
            tbl.Rules[2].Inputs.Should().HaveCount(3);
            tbl.Rules[2].Outputs.Should().HaveCount(2);
            tbl.Rules[3].Inputs.Should().HaveCount(2);
            tbl.Rules[3].Outputs.Should().HaveCount(1);
            tbl.Rules[4].Inputs.Should().HaveCount(1);
            tbl.Rules[4].Outputs.Should().HaveCount(1);
            tbl.Rules[5].Inputs.Should().HaveCount(0);
            tbl.Rules[5].Outputs.Should().HaveCount(0);

            var ctx = DmnExecutionContextFactory
                .CreateExecutionContext(def)
                .WithInputParameter("input1", input1)
                .WithInputParameter("input2", input2)
                .WithInputParameter("input3", input3);

            if (!isErr)
            {
                var result = ctx.ExecuteDecision("tbl");
                result.HasResult.Should().BeTrue();
                if (resultOut1 != null)
                {
                    result.First["var2"].Value.Should().Be(resultOut1);
                }
                else
                {
                    result.First["var2"].Should().BeNull();
                }
                if (resultOut2 != null)
                {
                    result.First["var3"].Value.Should().Be(resultOut2);
                }
                else
                {
                    result.First["var3"].Should().BeNull();
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


        [TestMethod]
        [DataRow(12, 3, 12 + 3 / 2 + 10 + 1000, "r1,r2,r3,r4")]
        [DataRow(6, 6, 6 / 2 + 1000, "r2,r4")]
        [DataRow(10, 10, 1000, "r4")]
        [DataRow(10, 3, 3 / 2 + 10 + 1000, "r2,r3,r4")]
        [DataRow(3, 3, 1000, "r4")]
        [DataRow(11, 11, 11 + 1000, "r1,r4")]
        public void TableTestCollectSum(int input1, int input2, int output, string match)
        {
            // input2 allowed 1-9 (incl.)
            var l = new List<string>();
            for (var i = 1; i < 10; i++)
            {
                l.Add(i.ToString());
            }

            // "r1" - input1 > 10 -> input1
            // "r2" - input1 (>=5 && <15), input2 is 1|3|input1 -> input2/2
            // "r3" - input2 (!5 && !input1) -> 10
            // "r4" - always -> 1000
            var def = new DmnDefinitionBuilder()
               .WithInput<int>("input1", out var inputVar1Ref)
               .WithInput<int>("input2", out var inputVar2Ref)
               .WithVariable<int>("output", out var outputVarRef)
               .WithTableDecision("tbl", table =>
                   table
                       .WithInput(inputVar1Ref, out var tblInput1Ref)
                       .WithInput(inputVar2Ref, out var tblInput2Ref, l.ToArray())
                       .WithOutput(outputVarRef, out var tblOutputRef)

                       .WithRule("r1", "input1 > 10 -> input1", r => r
                           .When(tblInput1Ref, ">10")
                           .Then(tblOutputRef, "input1"))

                       .WithRule("r2", "input1 >=5 && <15, input2 is 1|3|input1 -> input2/2", r => r
                           .When(tblInput1Ref, "[5..15[")
                           .And(tblInput2Ref, "1,3,input1")
                           .Then(tblOutputRef, "input2/2"))

                       .WithRule("r3", "input2 !5 && !input1 -> 10", r => r
                           .When(tblInput2Ref, "not(5,input1)")
                           .Then(tblOutputRef, "10"))

                       .WithRule("r4", "always-> 1000", r => r
                           .Always()
                           .Then(tblOutputRef, "1000"))

                       .WithHitPolicy(HitPolicyEnum.Collect)
                       .WithAggregation(CollectHitPolicyAggregationEnum.Sum))
               .Build();

            var tbl = (DmnDecisionTable)def.Decisions["tbl"];
            tbl.HitPolicy.Should().Be(HitPolicyEnum.Collect);
            tbl.Aggregation.Should().Be(CollectHitPolicyAggregationEnum.Sum);

            var ctx = DmnExecutionContextFactory
                .CreateExecutionContext(def)
                .WithInputParameter("input1", input1)
                .WithInputParameter("input2", input2);

            var result = ctx.ExecuteDecision("tbl");
            result.HasResult.Should().BeTrue();
            result.IsSingleResult.Should().BeTrue();
            result.First["output"].Value.Should().Be(output);

            var hits = match.Split(',');
            result.First.HitRules.Should().HaveCount(hits.Length);
            for (var i = 0; i < hits.Length; i++)
            {
                result.First.HitRules[i].Name.Should().Be(hits[i]);
            }
        }

        [TestMethod]
        [DataRow(12, 3, "r1,r2,r3,r4")]
        [DataRow(6, 6, "r2,r4")]
        [DataRow(10, 10, "r4")]
        [DataRow(10, 3, "r2,r3,r4")]
        [DataRow(3, 3, "r4")]
        [DataRow(11, 11, "r1,r4")]
        public void TableTestCollectList(int input1, int input2, string match)
        {
            // input2 allowed 1-9 (incl.)
            var l = new List<string>();
            for (var i = 1; i < 10; i++)
            {
                l.Add(i.ToString());
            }

            // "r1" - input1 > 10 -> input1
            // "r2" - input1 (>=5 && <15), input2 is 1|3|input1 -> input2/2
            // "r3" - input2 (!5 && !input1) -> 10
            // "r4" - always -> 1000
            var def = new DmnDefinitionBuilder()
               .WithInput<int>("input1", out var inputVar1Ref)
               .WithInput<int>("input2", out var inputVar2Ref)
               .WithVariable<int>("output", out var outputVarRef)
               .WithTableDecision("tbl", table =>
                   table
                       .WithInput(inputVar1Ref, out var tblInput1Ref)
                       .WithInput(inputVar2Ref, out var tblInput2Ref, l.ToArray())
                       .WithOutput(outputVarRef, out var tblOutputRef)

                       .WithRule("r1", "input1 > 10 -> input1", r => r
                           .When(tblInput1Ref, ">10")
                           .Then(tblOutputRef, "input1"))

                       .WithRule("r2", "input1 >=5 && <15, input2 is 1|3|input1 -> input2/2", r => r
                           .When(tblInput1Ref, "[5..15[")
                           .And(tblInput2Ref, "1,3,input1")
                           .Then(tblOutputRef, "input2/2"))

                       .WithRule("r3", "input2 !5 && !input1 -> 10", r => r
                           .When(tblInput2Ref, "not(5,input1)")
                           .Then(tblOutputRef, "10"))

                       .WithRule("r4", "always-> 1000", r => r
                           .Always()
                           .Then(tblOutputRef, "1000"))

                       .WithHitPolicy(HitPolicyEnum.Collect)
                       .WithAggregation(CollectHitPolicyAggregationEnum.List))
               .Build();

            var tbl = (DmnDecisionTable)def.Decisions["tbl"];
            tbl.HitPolicy.Should().Be(HitPolicyEnum.Collect);
            tbl.Aggregation.Should().Be(CollectHitPolicyAggregationEnum.List);

            var ctx = DmnExecutionContextFactory
                .CreateExecutionContext(def)
                .WithInputParameter("input1", input1)
                .WithInputParameter("input2", input2);

            var result = ctx.ExecuteDecision("tbl");
            result.HasResult.Should().BeTrue();
            var hits = match.Split(',');
            result.Results.Should().HaveCount(hits.Length);

            for (var i = 0; i < hits.Length; i++)
            {
                var singleResult = result.Results[i];
                singleResult.HitRules.Should().HaveCount(1);
                var ruleName = singleResult.HitRules[0].Name;
                if (ruleName == "r1") singleResult["output"].Value.Should().Be(input1);
                if (ruleName == "r2") singleResult["output"].Value.Should().Be(input2 / 2);
                if (ruleName == "r3") singleResult["output"].Value.Should().Be(10);
                if (ruleName == "r4") singleResult["output"].Value.Should().Be(1000);
            }

        }

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
