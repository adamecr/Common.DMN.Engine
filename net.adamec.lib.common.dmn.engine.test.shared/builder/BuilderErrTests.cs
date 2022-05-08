using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.definition.builder;
using net.adamec.lib.common.dmn.engine.parser.dto;
using Decision = net.adamec.lib.common.dmn.engine.engine.definition.builder.Decision;
using Variable = net.adamec.lib.common.dmn.engine.engine.definition.builder.Variable;

namespace net.adamec.lib.common.dmn.engine.test.builder
{
    [TestClass]
    [TestCategory("Builder Error Tests")]
    public class BuilderErrTests
    {
        [TestMethod]
        public void DefinitionBuilderErr()
        {
            // ReSharper disable once JoinDeclarationAndInitializer
            Action act;
            // ReSharper disable once NotAccessedVariable
            Variable.Ref varRef;
            // ReSharper disable once NotAccessedVariable
            Decision.Ref decRef;

            var def = new DmnDefinitionBuilder()
                .WithInput<string>("a")
                .WithVariable<string>("aa")
                .WithVariable<string>("b", out var variableRef)
                .WithExpressionDecision("ed", "input+1", variableRef);

            //inputs
            act = () => def.WithInputs<string>("i1", "i2", null, "i3");
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithInput(null);
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithInput(" ");
            act.Should().Throw<ArgumentException>();
            act = () => def.WithInput<string>(null);
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithInput<string>(" ");
            act.Should().Throw<ArgumentException>();
            act = () => def.WithInput<string>(null, out varRef);
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithInput<string>(" ", out varRef);
            act.Should().Throw<ArgumentException>();
            act = () => def.WithInput(null, typeof(string));
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithInput(" ", typeof(string));
            act.Should().Throw<ArgumentException>();
            act = () => def.WithInput(null, typeof(string), out varRef);
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithInput(" ", typeof(string), out varRef);
            act.Should().Throw<ArgumentException>();

            act = () => def.WithInput("a");
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate input variable name*");
            act = () => def.WithInput<string>("a");
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate input variable name*");
            act = () => def.WithInput<string>("a", out varRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate input variable name*");
            act = () => def.WithInput("a", typeof(string));
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate input variable name*");
            act = () => def.WithInput("a", typeof(string), out varRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate input variable name*");
            act = () => def.WithInput("aa");
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
            act = () => def.WithInput<string>("aa");
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
            act = () => def.WithInput<string>("aa", out varRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
            act = () => def.WithInput("aa", typeof(string));
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
            act = () => def.WithInput("aa", typeof(string), out varRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");

            //variables
            act = () => def.WithVariables<string>("v1", "v2", null, "v3");
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithVariable<string>(null);
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithVariable<string>(" ");
            act.Should().Throw<ArgumentException>();
            act = () => def.WithVariable<string>(null, out varRef);
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithVariable<string>(" ", out varRef);
            act.Should().Throw<ArgumentException>();
            act = () => def.WithVariable(null, typeof(string));
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithVariable(" ", typeof(string));
            act.Should().Throw<ArgumentException>();
            act = () => def.WithVariable(null, typeof(string), out varRef);
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithVariable(" ", typeof(string), out varRef);
            act.Should().Throw<ArgumentException>();

            act = () => def.WithVariable<string>("a");
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
            act = () => def.WithVariable<string>("b");
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
            act = () => def.WithVariable<string>("a", out varRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
            act = () => def.WithVariable<string>("b", out varRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
            act = () => def.WithVariable("a", typeof(string));
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
            act = () => def.WithVariable("b", typeof(string));
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
            act = () => def.WithVariable("a", typeof(string), out varRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
            act = () => def.WithVariable("b", typeof(string), out varRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");

            //expression decision
            act = () => def.WithExpressionDecision(null, "input+1", variableRef);
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithExpressionDecision(" ", "input+1", variableRef);
            act.Should().Throw<ArgumentException>();
            act = () => def.WithExpressionDecision(null, "input+1", variableRef, out decRef);
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithExpressionDecision(" ", "input+1", variableRef, out decRef);
            act.Should().Throw<ArgumentException>();
            act = () => def.WithExpressionDecision(null, b => b.Put("input+1").To(variableRef));
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithExpressionDecision(" ", b => b.Put("input+1").To(variableRef));
            act.Should().Throw<ArgumentException>();
            act = () => def.WithExpressionDecision(null, b => b.Put("input+1").To(variableRef), out decRef);
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithExpressionDecision(" ", b => b.Put("input+1").To(variableRef), out decRef);
            act.Should().Throw<ArgumentException>();

            act = () => def.WithExpressionDecision("ed", "input+2", variableRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Decision ed already exists");
            act = () => def.WithExpressionDecision("ed", "input+2", variableRef, out decRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Decision ed already exists");
            act = () => def.WithExpressionDecision("ed", b => b.Put("input+1").To(variableRef));
            act.Should().Throw<DmnBuilderException>().WithMessage("Decision ed already exists");
            act = () => def.WithExpressionDecision("ed", b => b.Put("input+1").To(variableRef), out decRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Decision ed already exists");

            act = () => def.WithExpressionDecision("ed2", null);
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithExpressionDecision("ed2", null, out decRef);
            act.Should().Throw<ArgumentNullException>();

            //table decision
            act = () => def.WithTableDecision(null, t => DummyTable(t, variableRef));
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithTableDecision(" ", t => DummyTable(t, variableRef));
            act.Should().Throw<ArgumentException>();
            act = () => def.WithTableDecision(null, t => DummyTable(t, variableRef), out decRef);
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithTableDecision(" ", t => DummyTable(t, variableRef), out decRef);
            act.Should().Throw<ArgumentException>();

            act = () => def.WithTableDecision("ed", t => DummyTable(t, variableRef));
            act.Should().Throw<DmnBuilderException>().WithMessage("Decision ed already exists");
            act = () => def.WithTableDecision("ed", t => DummyTable(t, variableRef), out decRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Decision ed already exists");

            act = () => def.WithTableDecision("f", null);
            act.Should().Throw<ArgumentException>();
            act = () => def.WithTableDecision("f", null, out decRef);
            act.Should().Throw<ArgumentNullException>();


            // --------------------------
            //  BUILD
            // --------------------------
            def.IsBuilt.Should().Be(false);
            def.Build();
            def.IsBuilt.Should().Be(true);
            // --------------------------
            //  AFTER BUILD
            // --------------------------
            act = () => def.Build();
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");


            act = () => def.WithInputs<string>("a", "b");
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithInput("a");
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithInput<string>("a");
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithInput<string>("a", out varRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithInput("b", typeof(string));
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithInput("c", typeof(string), out varRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");


            act = () => def.WithVariables<string>("a", "b");
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithVariable<string>("c");
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithVariable<string>("c", out varRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithVariable("c", typeof(string));
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithVariable("c", typeof(string), out varRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");


            act = () => def.WithExpressionDecision("eded", "input+2", variableRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithExpressionDecision("eded", "input+2", variableRef, out decRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithExpressionDecision("eded", b => b.Put("input+1").To(variableRef));
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithExpressionDecision("eded", b => b.Put("input+1").To(variableRef), out decRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");

            act = () => def.WithTableDecision("td", t => DummyTable(t, variableRef));
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithTableDecision("td", t => DummyTable(t, variableRef), out decRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");

        }

        [TestMethod]
        public void DefinitionErr()
        {
            // ReSharper disable once JoinDeclarationAndInitializer
            Action act;
            var def = new DmnDefinitionBuilder();

            act = () => def.Build();
            act.Should().Throw<DmnBuilderException>().WithMessage("No decision in DMN definition");
        }

        [TestMethod]
        public void VariableErr()
        {
            // ReSharper disable once JoinDeclarationAndInitializer
            Action act;
            var def = new DmnDefinitionBuilder()
                .WithVariable<string>("a_a");

            //normalize name 
            //act = () => def.WithVariable<string>("v&v"); - this is OK in v1.1
            //act.Should().Throw<ArgumentException>().WithMessage($"Variable name * contains invalid character*"); 
            act = () => def.WithVariable<string>("v|v"); //still invalid in v1.1
            act.Should().Throw<ArgumentException>().WithMessage($"Variable name * contains invalid character*");
            act = () => def.WithVariable<string>("1v");
            act.Should().Throw<ArgumentException>().WithMessage($"Variable name * must start with letter*");
            act = () => def.WithVariable<string>(" 1v");
            act.Should().Throw<ArgumentException>().WithMessage($"Variable name * must start with letter*");

            //normalize name - duplicate
            act = () => def.WithVariable<string>("  a a");
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
            act = () => def.WithVariable<string>("  a_a   ");
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
            act = () => def.WithVariable<string>("  a a&   "); //new in v1.1
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
        }

        [TestMethod]
        public void DecisionErr()
        {
            // ReSharper disable once JoinDeclarationAndInitializer
            Action act;

            // ReSharper disable once UnusedVariable
            var defDummy = new DmnDefinitionBuilder()
                .WithInput<string>("Input", out var defDummyInputRef)
                .WithVariable<string>("Variable", out var defDummyVariableRef)
                .WithExpressionDecision("Decision", "Input", defDummyVariableRef, out var defDummyDecisionRef);

            act = () =>
            {
                // ReSharper disable once UnusedVariable
                var def1 = new DmnDefinitionBuilder()
                    .WithInput<string>("Input")
                    .WithVariable<string>("Variable", out var def1VariableRef)
                    .WithExpressionDecision("Decision", d => d
                        .Put("Input")
                        .To(def1VariableRef)
                        .Requires(defDummyInputRef));
            };
            act.Should().Throw<DmnBuilderException>().WithMessage("Can't get the variable from reference *");

            act = () =>
            {
                // ReSharper disable once UnusedVariable
                var def2 = new DmnDefinitionBuilder()
                    .WithInput<string>("Input")
                    .WithVariable<string>("Variable", out var def2VariableRef)
                    .WithExpressionDecision("Decision", d => d
                        .Put("Input")
                        .To(def2VariableRef)
                        .Requires(defDummyDecisionRef));
            };
            act.Should().Throw<DmnBuilderException>().WithMessage("Can't get the decision from reference *");

            act = () =>
            {
                // ReSharper disable once UnusedVariable
                var def3 = new DmnDefinitionBuilder()
                .WithInput<string>("Input")
                .WithVariable<string>("Variable", out var def3VariableRef)
                .WithExpressionDecision("Decision", d => d
                    .Put("Input")
                    .To(def3VariableRef)
                    .Requires(def3VariableRef));
            };
            act.Should().Throw<DmnBuilderException>().WithMessage("Variable * is not an input parameter");
        }

        [TestMethod]
        public void ExpressionDecisionErr()
        {
            // ReSharper disable once JoinDeclarationAndInitializer
            Action act;

            // ReSharper disable once UnusedVariable
            var defDummy = new DmnDefinitionBuilder()
                .WithInput<string>("Input", out _)
                .WithVariable<string>("Variable", out var defDummyVariableRef)
                .WithExpressionDecision("Decision", "Input", defDummyVariableRef, out _);

            act = () =>
            {
                // ReSharper disable once UnusedVariable
                var def = new DmnDefinitionBuilder()
                    .WithInput<string>("Input")
                    .WithVariable<string>("Variable", out var defVariableRef)
                    .WithExpressionDecision("Decision", null, defVariableRef);
            };
            act.Should().Throw<ArgumentNullException>();

            act = () =>
            {
                // ReSharper disable once UnusedVariable
                var def = new DmnDefinitionBuilder()
                    .WithInput<string>("Input")
                    .WithVariable<string>("Variable", out var defVariableRef)
                    .WithExpressionDecision("Decision", "  ", defVariableRef);
            };
            act.Should().Throw<ArgumentException>().WithMessage("Missing expression*");

            act = () =>
            {
                // ReSharper disable once UnusedVariable
                var def = new DmnDefinitionBuilder()
                    .WithInput<string>("Input")
                    .WithVariable<string>("Variable", out _)
                    .WithExpressionDecision("Decision", "Input", null);
            };
            act.Should().Throw<ArgumentNullException>();

            act = () =>
            {
                // ReSharper disable once UnusedVariable
                var def = new DmnDefinitionBuilder()
                    .WithInput<string>("Input")
                    .WithVariable<string>("Variable")
                    .WithExpressionDecision("Decision", "Input", defDummyVariableRef);
            };
            act.Should().Throw<DmnBuilderException>().WithMessage("Can't get the variable from reference*");

            ExpressionDecision.ExpressionDecisionSrcBuilder builderSrc = null;
            ExpressionDecision.ExpressionDecisionVarBuilder builderVar = null;
            var def2 = new DmnDefinitionBuilder()
                .WithInput<string>("Input")
                .WithVariable<string>("Variable", out var variableRef)
                .WithVariable<string>("Variable2", out var variable2Ref)
                .WithExpressionDecision("Decision", BuilderDelegate);

            builderSrc.Put("Input+1");
            builderVar.To(variable2Ref);
            def2.Build();
            act = () => builderSrc.Put("Input");
            act.Should().Throw<DmnBuilderException>().WithMessage("Decision is already built");

            act = () => builderVar.To(variable2Ref);
            act.Should().Throw<DmnBuilderException>().WithMessage("Decision is already built");

            ExpressionDecision BuilderDelegate(ExpressionDecision.ExpressionDecisionSrcBuilder builderArg)
            {
                builderSrc = builderArg;
                builderVar = builderArg.Put("Input");
                return builderVar.To(variableRef);
            }
        }



        [TestMethod]
        public void TableDecisionErr()
        {
            // ReSharper disable once JoinDeclarationAndInitializer
            Action act;
            TableDecision tableDecision = null;

            // ReSharper disable once UnusedVariable
            var defDummy = new DmnDefinitionBuilder()
                .WithInput<string>("Input", out _)
                .WithVariable<string>("Variable", out var defDummyVariableRef)
                .WithExpressionDecision("Decision", "Input", defDummyVariableRef, out _);

            var def = new DmnDefinitionBuilder()
                .WithInput<string>("Input")
                .WithVariable<string>("Variable", out var variableRef)
                .WithTableDecision("Table", t => DummyTable(t, variableRef, out tableDecision));

            act = () => tableDecision.WithInput((Variable.Ref)null, out _);
            act.Should().Throw<ArgumentNullException>();
            act = () => tableDecision.WithInput((Variable.Ref)null, out _, "a", "b");
            act.Should().Throw<ArgumentNullException>();
            act = () => tableDecision.WithInput((string)null, out _);
            act.Should().Throw<ArgumentNullException>();
            act = () => tableDecision.WithInput((string)null, out _, "a", "b");
            act.Should().Throw<ArgumentNullException>();
            act = () => tableDecision.WithInput(" ", out _);
            act.Should().Throw<ArgumentException>().WithMessage("Missing expression*");
            act = () => tableDecision.WithInput(" ", out _, "a", "b");
            act.Should().Throw<ArgumentException>().WithMessage("Missing expression*");
            act = () => tableDecision.WithInput(defDummyVariableRef, out _);
            act.Should().Throw<DmnBuilderException>().WithMessage("Can't get the variable from reference*");
            act = () => tableDecision.WithInput(defDummyVariableRef, out _, "a", "b");
            act.Should().Throw<DmnBuilderException>().WithMessage("Can't get the variable from reference*");

            act = () => tableDecision.WithOutput(null, out _);
            act.Should().Throw<ArgumentNullException>();
            act = () => tableDecision.WithOutput(null, out _, "a", "b");
            act.Should().Throw<ArgumentNullException>();
            act = () => tableDecision.WithOutput(defDummyVariableRef, out _);
            act.Should().Throw<DmnBuilderException>().WithMessage("Can't get the variable from reference*");
            act = () => tableDecision.WithOutput(defDummyVariableRef, out _, "a", "b");
            act.Should().Throw<DmnBuilderException>().WithMessage("Can't get the variable from reference*");

            act = () => tableDecision.WithRule(null, r => r.Always().SkipOutput());
            act.Should().Throw<ArgumentNullException>();
            act = () => tableDecision.WithRule(null, "desc", r => r.Always().SkipOutput());
            act.Should().Throw<ArgumentNullException>();
            act = () => tableDecision.WithRule(" ", r => r.Always().SkipOutput());
            act.Should().Throw<ArgumentException>().WithMessage("Missing rule name*");
            act = () => tableDecision.WithRule(" ", "desc", r => r.Always().SkipOutput());
            act.Should().Throw<ArgumentException>().WithMessage("Missing rule name*");
            act = () => tableDecision.WithRule("r", r => r.Always().SkipOutput());
            act.Should().Throw<DmnBuilderException>().WithMessage("Rule * already exists");
            act = () => tableDecision.WithRule("r", "desc", r => r.Always().SkipOutput());
            act.Should().Throw<DmnBuilderException>().WithMessage("Rule * already exists");

            def.Build();

            act = () => tableDecision.WithInput(variableRef, out _);
            act.Should().Throw<DmnBuilderException>().WithMessage("Decision is already built");
            act = () => tableDecision.WithInput(variableRef, out _, "a", "b");
            act.Should().Throw<DmnBuilderException>().WithMessage("Decision is already built");
            act = () => tableDecision.WithInput("Input", out _);
            act.Should().Throw<DmnBuilderException>().WithMessage("Decision is already built");
            act = () => tableDecision.WithInput("Input", out _, "a", "b");
            act.Should().Throw<DmnBuilderException>().WithMessage("Decision is already built");

            act = () => tableDecision.WithOutput(variableRef, out _);
            act.Should().Throw<DmnBuilderException>().WithMessage("Decision is already built");
            act = () => tableDecision.WithOutput(variableRef, out _, "a", "b");
            act.Should().Throw<DmnBuilderException>().WithMessage("Decision is already built");

            act = () => tableDecision.WithRule("r", r => r.Always().SkipOutput());
            act.Should().Throw<DmnBuilderException>().WithMessage("Decision is already built");
            act = () => tableDecision.WithRule("r", "desc", r => r.Always().SkipOutput());
            act.Should().Throw<DmnBuilderException>().WithMessage("Decision is already built");

            act = () => tableDecision.WithHitPolicy(HitPolicyEnum.Any);
            act.Should().Throw<DmnBuilderException>().WithMessage("Decision is already built");
            act = () => tableDecision.WithAggregation(CollectHitPolicyAggregationEnum.List);
            act.Should().Throw<DmnBuilderException>().WithMessage("Decision is already built");


            var def2 = new DmnDefinitionBuilder()
                .WithInput<string>("Input")
                .WithVariable<string>("Variable", out var variable2Ref)
                .WithTableDecision("Table", t => t
                    .WithOutput(variable2Ref, out _)
                    .WithRule("r", r => r.Always().SkipOutput()));
            act = () => def2.Build();
            act.Should().Throw<DmnBuilderException>().WithMessage("At least one input must be defined for decision table *");

            var def3 = new DmnDefinitionBuilder()
                .WithInput<string>("Input")
                .WithVariable<string>("Variable", out var variable3Ref)
                .WithTableDecision("Table", t => t
                    .WithInput(variable3Ref, out _)
                    .WithRule("r", r => r.Always().SkipOutput()));
            act = () => def3.Build();
            act.Should().Throw<DmnBuilderException>().WithMessage("At least one output must be defined for decision table *");

            var def4 = new DmnDefinitionBuilder()
                .WithInput<string>("Input")
                .WithVariable<string>("Variable", out var variable4Ref)
                .WithTableDecision("Table", t => t
                    .WithInput(variable4Ref, out _)
                    .WithOutput(variable4Ref, out _));
            act = () => def4.Build();
            act.Should().Throw<DmnBuilderException>().WithMessage("At least one rule must be defined for decision table *");

        }

        [TestMethod]
        public void TableInputOutputErr()
        {
            // ReSharper disable once JoinDeclarationAndInitializer
            Action act;
            TableDecision tableDecision = null;
            // ReSharper disable once NotAccessedVariable
            object o;

            // ReSharper disable once UnusedVariable
            var defDummy = new DmnDefinitionBuilder()
                .WithInput<string>("Input", out _)
                .WithVariable<string>("Variable", out var defDummyVariableRef)
                .WithExpressionDecision("Decision", "Input", defDummyVariableRef, out _);

            var def = new DmnDefinitionBuilder()
                .WithInput<string>("Input")
                .WithVariable<string>("Variable", out var variableRef)
                .WithTableDecision("Table", t => DummyTable(t, variableRef, out tableDecision));
            var input = tableDecision.Inputs[0];
            var output = tableDecision.Outputs[0];

            act = () => o = input.Result;
            act.Should().Throw<DmnBuilderException>().WithMessage("* is not built yet");
            act = () => o = output.Result;
            act.Should().Throw<DmnBuilderException>().WithMessage("* is not built yet");

            act = () => input.WithVariable(null);
            act.Should().Throw<ArgumentNullException>();
            act = () => input.WithVariable(defDummyVariableRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Can't get the variable from reference*");
            act = () => input.WithExpression(null);
            act.Should().Throw<ArgumentNullException>();
            act = () => input.WithExpression(" ");
            act.Should().Throw<ArgumentException>().WithMessage("Missing expression*");

            act = () => output.WithVariable(null);
            act.Should().Throw<ArgumentNullException>();
            act = () => output.WithVariable(defDummyVariableRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Can't get the variable from reference*");

            def.Build();

            act = () => input.WithVariable(variableRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Table input is already built");
            act = () => input.WithExpression("Input");
            act.Should().Throw<DmnBuilderException>().WithMessage("Table input is already built");
            act = () => input.WithAllowedValues(new[] { "q", "s" });
            act.Should().Throw<DmnBuilderException>().WithMessage("Table input is already built");
            act = () => input.WithoutAllowedValuesConstraint();
            act.Should().Throw<DmnBuilderException>().WithMessage("Table input is already built");

            act = () => output.WithVariable(variableRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Table output is already built");
            act = () => output.WithAllowedValues(new[] { "q", "s" });
            act.Should().Throw<DmnBuilderException>().WithMessage("Table output is already built");
            act = () => output.WithoutAllowedValuesConstraint();
            act.Should().Throw<DmnBuilderException>().WithMessage("Table output is already built");
        }

        [TestMethod]
        public void TableRuleErr()
        {
            // ReSharper disable once JoinDeclarationAndInitializer
            Action act;
            TableDecision tableDecision = null;
            // ReSharper disable once NotAccessedVariable
            object o;

            TableRule.TableRuleInputBuilder ruleInputBuilder = null;
            TableRule.TableRuleThenOrAndBuilder ruleThenOrAndBuilder = null;
            TableRule.TableRuleThenOnlyBuilder ruleThenOnlyBuilder = null;
            // ReSharper disable once NotAccessedVariable
            TableRule.TableRuleOutputBuilder ruleOutputBuilder = null;
            TableRule.TableRuleAndOutputBuilder ruleAndOutputBuilder = null;

            TableInput.Ref tableInputRef = null;
            TableOutput.Ref tableOutputRef = null;
            TableInput.Ref dummyTableInputRef = null;
            TableOutput.Ref dummyTableOutputRef = null;

            TableRule.TableRuleOutputBuilder BuilderDelegate(TableRule.TableRuleInputBuilder builderArg)
            {
                ruleInputBuilder = builderArg;
                ruleThenOnlyBuilder = builderArg.Always();
                ruleThenOrAndBuilder = builderArg.When(tableInputRef, "");

                ruleOutputBuilder = ruleThenOrAndBuilder?.SkipOutput();
                ruleAndOutputBuilder = ruleThenOrAndBuilder?.Then(tableOutputRef, "");

                return ruleAndOutputBuilder;
            }

            // ReSharper disable once UnusedVariable
            var defDummy = new DmnDefinitionBuilder()
                .WithInput<string>("Input")
                .WithVariable<string>("Variable", out var dummyVariableRef)
                .WithTableDecision("Table", t =>
                {
                    tableDecision = t;
                    t
                        .WithInput(dummyVariableRef, out dummyTableInputRef)
                        .WithOutput(dummyVariableRef, out dummyTableOutputRef)
                        .WithRule("r", r => r.Always().SkipOutput());
                    return t;
                });

            var def = new DmnDefinitionBuilder()
                .WithInput<string>("Input")
                .WithVariable<string>("Variable", out var variableRef)
                .WithTableDecision("Table", t =>
                {
                    tableDecision = t;
                    t
                        .WithInput(variableRef, out tableInputRef)
                        .WithOutput(variableRef, out tableOutputRef)
                        .WithRule("r", BuilderDelegate);
                    return t;
                });

            var rule = tableDecision.Rules[0];

            act = () => o = rule.Result;
            act.Should().Throw<DmnBuilderException>().WithMessage("* is not built yet");

            act = () => ruleInputBuilder?.When(null, "input");
            act.Should().Throw<ArgumentNullException>();
            act = () => ruleInputBuilder?.When(dummyTableInputRef, "input");
            act.Should().Throw<DmnBuilderException>().WithMessage("Input reference is not valid for current table");

            act = () => ruleThenOrAndBuilder?.And(null, "input");
            act.Should().Throw<ArgumentNullException>();
            act = () => ruleThenOrAndBuilder?.And(dummyTableInputRef, "input");
            act.Should().Throw<DmnBuilderException>().WithMessage("Input reference is not valid for current table");
            act = () => ruleThenOrAndBuilder?.Then(null, "output");
            act.Should().Throw<ArgumentNullException>();
            act = () => ruleThenOrAndBuilder?.Then(dummyTableOutputRef, "output");
            act.Should().Throw<DmnBuilderException>().WithMessage("Output reference is not valid for current table");

            act = () => ruleThenOnlyBuilder?.Then(null, "output");
            act.Should().Throw<ArgumentNullException>();
            act = () => ruleThenOnlyBuilder?.Then(dummyTableOutputRef, "output");
            act.Should().Throw<DmnBuilderException>().WithMessage("Output reference is not valid for current table");

            act = () => ruleAndOutputBuilder?.And(null, "output");
            act.Should().Throw<ArgumentNullException>();
            act = () => ruleAndOutputBuilder?.And(dummyTableOutputRef, "output");
            act.Should().Throw<DmnBuilderException>().WithMessage("Output reference is not valid for current table");

            def.Build();

            act = () => o = ruleInputBuilder?.Always();
            act.Should().Throw<DmnBuilderException>().WithMessage("Table rule is already built");
            act = () => o = ruleInputBuilder?.When(tableInputRef, "");
            act.Should().Throw<DmnBuilderException>().WithMessage("Table rule is already built");

            act = () => o = ruleThenOrAndBuilder?.SkipOutput();
            act.Should().Throw<DmnBuilderException>().WithMessage("Table rule is already built");
            act = () => o = ruleThenOrAndBuilder?.Then(tableOutputRef, "");
            act.Should().Throw<DmnBuilderException>().WithMessage("Table rule is already built");
            act = () => o = ruleThenOrAndBuilder?.And(tableInputRef, "");
            act.Should().Throw<DmnBuilderException>().WithMessage("Table rule is already built");

            act = () => o = ruleThenOnlyBuilder?.SkipOutput();
            act.Should().Throw<DmnBuilderException>().WithMessage("Table rule is already built");
            act = () => o = ruleThenOnlyBuilder?.Then(tableOutputRef, "");
            act.Should().Throw<DmnBuilderException>().WithMessage("Table rule is already built");

            act = () => o = ruleAndOutputBuilder?.And(tableOutputRef, "");
            act.Should().Throw<DmnBuilderException>().WithMessage("Table rule is already built");

        }

        private static TableDecision DummyTable(TableDecision t, Variable.Ref variableRef, out TableDecision tableDecision)
        {
            tableDecision = DummyTable(t, variableRef);
            return tableDecision;
        }
        private static TableDecision DummyTable(TableDecision t, Variable.Ref variableRef)
        {
            var tableDecision = t.WithInput(variableRef, out _).WithOutput(variableRef, out _)
                .WithRule("r", r => r.Always().SkipOutput());
            return tableDecision;
        }
    }
}
