using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.decisions;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.engine.definition.builder;
using net.adamec.lib.common.dmn.engine.engine.execution.context;
using net.adamec.lib.common.dmn.engine.engine.execution.result;
using net.adamec.lib.common.dmn.engine.test.builder.logicalAndDecisionNs;

namespace net.adamec.lib.common.dmn.engine.test.builder
{

    [TestClass]
    public class CustomDecisionTests
    {
        [TestMethod]
        public void LogicalAndDecisionTest()
        {
            //Logical1: input1 & input2 => output
            //Logical2: output (from logical1) & input2 ; with negate => output
            //meaning output=not(input1 & input2 & input3)
            var builder = new DmnDefinitionBuilderEx();
            builder
                .WithInput<bool>("input1", out var input1Ref)
                .WithInput<bool>("input2", out var input2Ref)
                .WithInput<bool>("input3", out var input3Ref)
                .WithVariable<bool>("output", out var outputRef)
                .As<DmnDefinitionBuilderEx>()
                .WithLogicalAndDecision("Logical1", b => b
                    .WithInputs(input1Ref, input2Ref)
                    .WithOutput(outputRef), out var d1Ref)
                .WithLogicalAndDecision("Logical2", b => b
                    .WithInputs(outputRef, input3Ref)
                    .WithNegate(true)
                    .WithOutput(outputRef)
                    .Requires(d1Ref), out _);

            var def = builder.Build();

            var ctx1 = DmnExecutionContextFactory.CreateExecutionContext(def);
            ctx1.WithInputParameters(new Dictionary<string, object>() {
                { "input1", true },
                { "input2", true },
                { "input3", true }
            });
            var result1 = ctx1.ExecuteDecision("Logical2");
            result1.First["output"].Value.Should().Be(false);

            var ctx2 = DmnExecutionContextFactory.CreateExecutionContext(def);
            ctx2.WithInputParameters(new Dictionary<string, object>() {
                { "input1", true },
                { "input2", false },
                { "input3", true }
            });
            var result2 = ctx2.ExecuteDecision("Logical2");
            result2.First["output"].Value.Should().Be(true);


        }


    }
}

namespace net.adamec.lib.common.dmn.engine.test.builder.logicalAndDecisionNs
{
    //NOTE: These are just quick and dirty PoC samples with no error/exception handling.
    //The sample code is also "encapsulated" in own namespace for separation 
    public class DmnLogicalAndDecision : DmnDecision
    {
        public IDmnVariable InputVar1 { get; }
        public IDmnVariable InputVar2 { get; }
        public bool Negate { get; }
        public IDmnVariable OutputVar { get; }

        public DmnLogicalAndDecision(
            string name,
            IDmnVariable inputVar1,
            IDmnVariable inputVar2,
            bool negate,
            IDmnVariable outputVar,
            IReadOnlyCollection<IDmnVariable> requiredInputs,
            IReadOnlyCollection<IDmnDecision> requiredDecisions)
            : base(name, requiredInputs, requiredDecisions)
        {
            InputVar1 = inputVar1;
            InputVar2 = inputVar2;
            Negate = negate;
            OutputVar = outputVar;
        }

        protected override DmnDecisionResult Evaluate(DmnExecutionContext context, string executionId)
        {

            //Get execution variable value - use it here as sample to get input1 (the input2 will be directly referenced "by name" in the expression)
            var i1Bool = bool.TryParse(context.GetVariable(InputVar1).Value?.ToString() ?? "false", out var tmpOp) &&
                         tmpOp;


            //Build and evaluate an expression
            var expr = $"{(Negate ? "!" : "")}({i1Bool.ToString().ToLower()} && {InputVar2.Name})";
            var result = context.EvalExpression<int>(expr, executionId);

            //Set execution variable value
            context.GetVariable(OutputVar).Value = result;

            //Build the decision result
            return new DmnDecisionResult(new DmnDecisionSingleResult(context.GetVariable(OutputVar)));
        }
    }

    public class LogicalAndDecision : Decision
    {
        public Variable.Ref Input1Var { get; private set; }
        public Variable.Ref Input2Var { get; private set; }
        public bool Negate { get; private set; }
        public Variable.Ref OutputVar { get; private set; }

        public LogicalAndDecision(VariableCatalog variables, DecisionCatalog decisions, string name)
            : base(variables, decisions, name)
        {
        }

        public LogicalAndDecision Requires(Variable.Ref input)
        {
            AddRequiredInput(input);
            return this;
        }

        public LogicalAndDecision Requires(Ref decision)
        {
            AddRequiredDecision(decision);
            return this;
        }

        public LogicalAndDecision WithInputs(Variable.Ref input1Var, Variable.Ref input2Var)
        {
            Input1Var = input1Var;
            Input2Var = input2Var;
            return this;
        }

        public LogicalAndDecision WithOutput(Variable.Ref outputVar)
        {
            OutputVar = outputVar;
            return this;
        }

        public LogicalAndDecision WithNegate(bool negate)
        {
            Negate = negate;
            return this;
        }

        protected override IDmnDecision Build()
        {
            return new DmnLogicalAndDecision(
                Name,
                GetResultOrBuild(Variables[Input1Var]),
                GetResultOrBuild(Variables[Input2Var]),
                Negate,
                GetResultOrBuild(Variables[OutputVar]),
                RequiredInputs.Select(i => GetResultOrBuild(Variables[i])).ToArray(),
                RequiredDecisions.Select(d => GetResultOrBuild(Decisions[d])).ToArray());
        }
    }

    public class DmnDefinitionBuilderEx : DmnDefinitionBuilder
    {

        public DmnDefinitionBuilderEx WithLogicalAndDecision(
            string name,
            Action<LogicalAndDecision> builder,
            out Decision.Ref decisionRef)
        {
            var decision = new LogicalAndDecision(Variables, Decisions, name);
            decisionRef = decision.Reference;
            Decisions.AddDecision(decision);
            builder?.Invoke(decision);
            return this;
        }
    }

    public static class BuilderExtensions
    {
        public static T As<T>(this T builder)
        where T : DmnDefinitionBuilder
        {
            return builder;
        }
    }
}