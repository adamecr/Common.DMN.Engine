using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.definition.builder;
using net.adamec.lib.common.dmn.engine.engine.execution;
using net.adamec.lib.common.dmn.engine.engine.execution.context;
using net.adamec.lib.common.dmn.engine.engine.execution.result;
using net.adamec.lib.common.dmn.engine.parser.dto;

namespace net.adamec.lib.common.dmn.engine.test.unit
{
    [TestClass]
    public class HitRulesTests
    {
        [TestMethod]
        [DataRow(2, 1, "r1", 1)]
        [DataRow(2, 2, "r2", 1)]
        [DataRow(5, 1, "r3", 1)]
        [DataRow(5, 2, "r4", -1)] //exception non unique 
        [DataRow(6, 1, "r5", 1)]
        [DataRow(6, 3, "r5", -1)] //exception non unique 
        [DataRow(6, null, "r5", 1)]
        [DataRow(7, 2, "r6", 1)]
        [DataRow(7, 1, null, 1)] //hit, empty out
        [DataRow(1, 3, "r8", 1)]
        [DataRow(null, 3, "r8", 1)]
        [DataRow(null, null, null, 0)] //no hit
        [DataRow(9, 9, null, 0)] //no hit
        public void UniqueHitPolicyTest(int? a, int? b, string hit, int hitsCount)
        {
            var def = new DmnDefinitionBuilder()
              .WithInput<int>("a", out var aRef)
              .WithInput<int>("b", out var bRef)
              .WithVariable<string>("o", out var oRef)

              .WithTableDecision("Unique", table =>
                  table
                      .WithInput(aRef, out var inputARef)
                      .WithInput(bRef, out var inputBRef)
                      .WithOutput(oRef, out var outputRef)
                      .WithHitPolicy(HitPolicyEnum.Unique)
                      .WithRule("r1", r => r
                          .When(inputARef, "< 5").And(inputBRef, "1").Then(outputRef, "\"r1\""))
                      .WithRule("r2", "err not unique for 5 - 2", r => r
                          .When(inputARef, "<= 5").And(inputBRef, "2").Then(outputRef, "\"r2\""))
                      .WithRule("r3", r => r
                          .When(inputARef, "5").And(inputBRef, "1").Then(outputRef, "\"r3\""))
                      .WithRule("r4", "err not unique for 5 - 2", r => r
                          .When(inputARef, "5").And(inputBRef, "2").Then(outputRef, "\"r4\""))
                      .WithRule("r5", "err not unique for 6-3", r => r
                          .When(inputARef, "6").Then(outputRef, "\"r5\""))
                      .WithRule("r6", r => r
                          .When(inputARef, "> 6").And(inputBRef, "2").Then(outputRef, "\"r6\""))
                      .WithRule("rEmpty", "empty out", r => r
                          .When(inputARef, "> 6").And(inputBRef, "1").Then(outputRef, ""))
                      .WithRule("r8", "err not unique for 6-3", r => r
                          .When(inputBRef, "3").Then(outputRef, "\"r8\""))
                      .Requires(aRef).Requires(bRef))
              .Build();

            var ctx = DmnExecutionContextFactory
                .CreateExecutionContext(def)
                .WithInputParameter("a", a)
                .WithInputParameter("b", b);

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
            result.Results.Should().HaveCount(hitsCount);

            if (hitsCount == 0) return;
            result.Results[0].HitRules.Should().HaveCount(1);
            result.Results[0].HitRules[0].Name.Should().Be(hit ?? "rEmpty");
        }

        [TestMethod]
        [DataRow(2, 1, "r1", 1)]
        [DataRow(2, 2, "r2", 1)]
        [DataRow(5, 1, "r3", 1)]
        [DataRow(5, 2, "r2", 1)]
        [DataRow(6, 1, "r5", 1)]
        [DataRow(6, null, "r5", 1)]
        [DataRow(7, 2, "r6", 1)]
        [DataRow(7, 1, null, 1)] //hit empty output
        [DataRow(null, 1, "r1", 1)]
        [DataRow(1, 3, "fallback", 1)]
        [DataRow(null, 3, "fallback", 1)]
        [DataRow(null, null, "fallback", 1)]
        public void FirstHitPolicyTest(int? a, int? b, string hit, int hitsCount)
        {
            var def = new DmnDefinitionBuilder()
                .WithInput<int>("a", out var aRef)
                .WithInput<int>("b", out var bRef)
                .WithVariable<string>("o", out var oRef)

                .WithTableDecision("First", table =>
                    table
                        .WithInput(aRef, out var inputARef)
                        .WithInput(bRef, out var inputBRef)
                        .WithOutput(oRef, out var outputRef)
                        .WithHitPolicy(HitPolicyEnum.First)

                        .WithRule("r1", r => r
                            .When(inputARef, "< 5").And(inputBRef, "1").Then(outputRef, "\"r1\""))
                        .WithRule("r2", r => r
                            .When(inputARef, "<= 5").And(inputBRef, "2").Then(outputRef, "\"r2\""))
                        .WithRule("r3", r => r
                            .When(inputARef, "5").And(inputBRef, "1").Then(outputRef, "\"r3\""))
                        .WithRule("r4", r => r
                            .When(inputARef, "5").And(inputBRef, "2").Then(outputRef, "\"r4\"")) //should never hit (r2 hits first)
                        .WithRule("r5", r => r
                            .When(inputARef, "6").Then(outputRef, "\"r5\""))
                        .WithRule("r6", r => r
                            .When(inputBRef, "2").Then(outputRef, "\"r6\""))
                        .WithRule("rEmpty", "empty out", r => r
                            .When(inputBRef, "1").Then(outputRef, ""))
                        .WithRule("fallback", r => r
                            .Always().Then(outputRef, "\"fallback\""))
                        .Requires(aRef).Requires(bRef))
                .Build();

            var ctx = DmnExecutionContextFactory
                .CreateExecutionContext(def)
                .WithInputParameter("a", a)
                .WithInputParameter("b", b);

            ctx.WithInputParameter("a", a);
            ctx.WithInputParameter("b", b);

            var result = ctx.ExecuteDecision("First");

            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();
            result.Results.Should().HaveCount(hitsCount);

            if (hitsCount == 0) return;
            result.Results[0].HitRules.Should().HaveCount(1);
            result.Results[0].HitRules[0].Name.Should().Be(hit ?? "rEmpty");
        }

        [TestMethod]
        [DataRow(2, 2, "r1", 1)] //single match
        [DataRow(5, 1, "r2", 1)]
        [DataRow(5, 2, "r1", 1)] //"any" (multi) match
        [DataRow(6, 1, "r4", 1)]
        [DataRow(6, 3, "r4", -1)] //exception not same matches
        [DataRow(6, 4, "r4", 1)]
        [DataRow(6, null, "r4", 1)]
        [DataRow(7, 2, "r5", 1)]
        [DataRow(7, 1, null, 1)] //hit, empty out
        [DataRow(1, 3, "r6", 1)]
        [DataRow(null, 3, "r6", 1)]
        [DataRow(null, null, null, 0)]//no hit
        [DataRow(8, 8, null, 0)] //no hit
        public void AnyHitPolicyTest(int? a, int? b, string hit, int hitsCount)
        {
            var def = new DmnDefinitionBuilder()
                .WithInput<int>("a", out var aRef)
                .WithInput<int>("b", out var bRef)
                .WithVariable<string>("o", out var oRef)

                .WithTableDecision("Unique", table =>
                    table
                        .WithInput(aRef, out var inputARef)
                        .WithInput(bRef, out var inputBRef)
                        .WithOutput(oRef, out var outputRef)
                        .WithHitPolicy(HitPolicyEnum.Any)

                        .WithRule("r1", "any for 5 - 2", r => r
                            .When(inputARef, "<= 5").And(inputBRef, "2").Then(outputRef, "\"r1\""))
                        .WithRule("r2", r => r
                            .When(inputARef, "5").And(inputBRef, "1").Then(outputRef, "\"r2\""))
                        .WithRule("r3", "any for 5 - 2", r => r
                            .When(inputARef, "5").And(inputBRef, "2").Then(outputRef, "\"r1\"")) //for "any" hit, needs to be same output as r1 that will be taken first from the "any positive matches"
                        .WithRule("r4", "err not same for 6-3", r => r
                            .When(inputARef, "6").Then(outputRef, "\"r4\""))
                        .WithRule("r5", r => r
                            .When(inputARef, "> 6").And(inputBRef, "2").Then(outputRef, "\"r5\""))
                        .WithRule("rEmpty", "empty out", r => r
                            .When(inputARef, "> 6").And(inputBRef, "1").Then(outputRef, ""))
                        .WithRule("r6", "err not same for 6-3", r => r
                            .When(inputBRef, "3").Then(outputRef, "\"r6\""))
                        .Requires(aRef).Requires(bRef))
              .Build();

            var ctx = DmnExecutionContextFactory
                .CreateExecutionContext(def)
                .WithInputParameter("a", a)
                .WithInputParameter("b", b);

            DmnDecisionResult result = null;
            Action act = () => { result = ctx.ExecuteDecision("Unique"); };

            if (hitsCount < 0)
            {
                act.Should().Throw<DmnExecutorException>().WithMessage("ANY hit policy violation - the outputs don't match");
                return;
            }

            act.Invoke();

            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();
            result.Results.Should().HaveCount(hitsCount);

            if (hitsCount == 0) return;
            result.Results[0].HitRules.Should().HaveCount(1);
            result.Results[0].HitRules[0].Name.Should().Be(hit ?? "rEmpty");
        }

        [TestMethod]
        [DataRow(2, 1, "r1")]
        [DataRow(5, 1, "r4")] // r3(->"c") and r4(->"a") match, "a" has higher priority
        [DataRow(5, 2, "r2")] // r2(->"b") and r4(->"a") match, "b" has higher priority
        [DataRow(6, 1, "r5")] // r5(->"d") and rEmpty(->N/A) match, "d" has higher priority (over no output)
        [DataRow(6, 2, "r6")] // r5(->"d") and r6(->"a") match, "a" has higher priority
        [DataRow(6, 3, "r7")] // r5(->"d") and r7(->"c") match, "c" has higher priority
        [DataRow(6, 4, "r5")]
        [DataRow(6, null, "r5")]
        [DataRow(7, 2, "r6")]
        [DataRow(7, 1, "rEmpty")]//hit, empty output
        [DataRow(1, 3, "r7")]
        [DataRow(null, 3, "r7")]
        [DataRow(null, null, null)] //no hit
        [DataRow(8, 8, null)] //no hit
        public void PriorityHitPolicyTest(int? a, int? b, string hit)
        {
            var def = new DmnDefinitionBuilder()
                .WithInput<int>("a", out var aRef)
                .WithInput<int>("b", out var bRef)
                .WithVariable<string>("o", out var oRef)

                .WithTableDecision("Priority", table =>
                    table
                        .WithInput(aRef, out var inputARef)
                        .WithInput(bRef, out var inputBRef)
                        .WithOutput(oRef, out var outputRef, "b", "a", "c", "d")
                        .WithHitPolicy(HitPolicyEnum.Priority)

                        .WithRule("r1", r => r
                            .When(inputARef, "< 5").And(inputBRef, "1").Then(outputRef, "\"a\""))
                        .WithRule("r2", r => r
                            .When(inputARef, "<= 5").And(inputBRef, "2").Then(outputRef, "\"b\""))
                        .WithRule("r3", r => r
                            .When(inputARef, "5").And(inputBRef, "1").Then(outputRef, "\"c\""))
                        .WithRule("r4", r => r
                            .When(inputARef, "5").Then(outputRef, "\"a\""))
                        .WithRule("r5", r => r
                            .When(inputARef, "6").Then(outputRef, "\"d\""))
                        .WithRule("r6", r => r
                            .When(inputARef, ">= 6").And(inputBRef, "2").Then(outputRef, "\"a\""))
                        .WithRule("rEmpty", r => r
                            .When(inputARef, ">= 6").And(inputBRef, "1").Then(outputRef, ""))
                        .WithRule("r7", r => r
                            .When(inputBRef, "3").Then(outputRef, "\"c\""))
                        .Requires(aRef).Requires(bRef))
                .Build();

            var ctx = DmnExecutionContextFactory
                .CreateExecutionContext(def)
                .WithInputParameter("a", a)
                .WithInputParameter("b", b);

            var result = ctx.ExecuteDecision("Priority");

            var hitsCount = hit != null ? 1 : 0;
            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();
            result.Results.Should().HaveCount(hitsCount);

            if (hitsCount == 0) return;
            result.Results[0].HitRules.Should().HaveCount(1);
            result.Results[0].HitRules[0].Name.Should().Be(hit);
        }

        [TestMethod]
        [DataRow(2, 1, new[] { "r1" })]
        [DataRow(5, 1, new[] { "r3", "r4" })]
        [DataRow(5, 2, new[] { "r2", "r4" })]
        [DataRow(6, 1, new[] { "r5", "rEmpty" })]
        [DataRow(6, 2, new[] { "r5", "r6" })]
        [DataRow(6, 3, new[] { "r5", "r7" })]
        [DataRow(6, 4, new[] { "r5" })]
        [DataRow(6, null, new[] { "r5" })]
        [DataRow(7, 2, new[] { "r6" })]
        [DataRow(7, 1, new[] { "rEmpty" })]//hit, empty output
        [DataRow(9, 1, new[] { "rEmpty", "r8" })]
        [DataRow(1, 3, new[] { "r7" })]
        [DataRow(null, 3, new[] { "r7" })]
        [DataRow(null, null, null)] //no hit
        [DataRow(8, 8, null)] //no hit
        public void RuleOrderHitPolicyTest(int? a, int? b, string[] hits)
        {
            var def = new DmnDefinitionBuilder()
                .WithInput<int>("a", out var aRef)
                .WithInput<int>("b", out var bRef)
                .WithVariable<string>("o", out var oRef)

                .WithTableDecision("RuleOrder", table =>
                    table
                        .WithInput(aRef, out var inputARef)
                        .WithInput(bRef, out var inputBRef)
                        .WithOutput(oRef, out var outputRef, "b", "a", "c", "d")
                        .WithHitPolicy(HitPolicyEnum.RuleOrder)

                        .WithRule("r1", r => r
                            .When(inputARef, "< 5").And(inputBRef, "1").Then(outputRef, "\"a\""))
                        .WithRule("r2", r => r
                            .When(inputARef, "<= 5").And(inputBRef, "2").Then(outputRef, "\"b\""))
                        .WithRule("r3", r => r
                            .When(inputARef, "5").And(inputBRef, "1").Then(outputRef, "\"c\""))
                        .WithRule("r4", r => r
                            .When(inputARef, "5").Then(outputRef, "\"a\""))
                        .WithRule("r5", r => r
                            .When(inputARef, "6").Then(outputRef, "\"d\""))
                        .WithRule("r6", r => r
                            .When(inputARef, ">= 6").And(inputBRef, "2").Then(outputRef, "\"a\""))
                        .WithRule("rEmpty", r => r
                            .When(inputARef, ">= 6").And(inputBRef, "1").Then(outputRef, ""))
                        .WithRule("r7", r => r
                            .When(inputBRef, "3").Then(outputRef, "\"c\""))
                        .WithRule("r8", r => r
                            .When(inputARef, "9").And(inputBRef, "1").Then(outputRef, "\"a\""))
                        .Requires(aRef).Requires(bRef))
                .Build();

            var ctx = DmnExecutionContextFactory
                .CreateExecutionContext(def)
                .WithInputParameter("a", a)
                .WithInputParameter("b", b);

            var result = ctx.ExecuteDecision("RuleOrder");

            var hitsCount = hits?.Length ?? 0;
            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();
            result.Results.Should().HaveCount(hitsCount);

            if (hitsCount == 0) return;
            for (var i = 0; i < hitsCount; i++)
            {
                result.Results[i].HitRules.Should().HaveCount(1);
                // ReSharper disable once PossibleNullReferenceException
                result.Results[i].HitRules[0].Name.Should().Be(hits[i]);
            }
        }

        [TestMethod]
        [DataRow(2, 1, new[] { "r1" })]
        [DataRow(5, 1, new[] { "r4", "r3" })]
        [DataRow(5, 2, new[] { "r2", "r4" })]
        [DataRow(6, 1, new[] { "r5", "rEmpty" })]
        [DataRow(6, 2, new[] { "r6", "r5" })]
        [DataRow(6, 3, new[] { "r7", "r5" })]
        [DataRow(6, 4, new[] { "r5" })]
        [DataRow(6, null, new[] { "r5" })]
        [DataRow(7, 2, new[] { "r6" })]
        [DataRow(7, 1, new[] { "rEmpty" })]//hit, empty output
        [DataRow(9, 1, new[] { "r8", "rEmpty" })] //null (empty) result at the end of ordered list
        [DataRow(1, 3, new[] { "r7" })]
        [DataRow(null, 3, new[] { "r7" })]
        [DataRow(null, null, null)] //no hit
        [DataRow(8, 8, null)] //no hit
        public void OutputOrderHitPolicyTest(int? a, int? b, string[] hits)
        {
            var def = new DmnDefinitionBuilder()
                .WithInput<int>("a", out var aRef)
                .WithInput<int>("b", out var bRef)
                .WithVariable<string>("o", out var oRef)

                .WithTableDecision("OutputOrder", table =>
                    table
                        .WithInput(aRef, out var inputARef)
                        .WithInput(bRef, out var inputBRef)
                        .WithOutput(oRef, out var outputRef, "b", "a", "c", "d")
                        .WithHitPolicy(HitPolicyEnum.OutputOrder)

                        .WithRule("r1", r => r
                            .When(inputARef, "< 5").And(inputBRef, "1").Then(outputRef, "\"a\""))
                        .WithRule("r2", r => r
                            .When(inputARef, "<= 5").And(inputBRef, "2").Then(outputRef, "\"b\""))
                        .WithRule("r3", r => r
                            .When(inputARef, "5").And(inputBRef, "1").Then(outputRef, "\"c\""))
                        .WithRule("r4", r => r
                            .When(inputARef, "5").Then(outputRef, "\"a\""))
                        .WithRule("r5", r => r
                            .When(inputARef, "6").Then(outputRef, "\"d\""))
                        .WithRule("r6", r => r
                            .When(inputARef, ">= 6").And(inputBRef, "2").Then(outputRef, "\"a\""))
                        .WithRule("rEmpty", r => r
                            .When(inputARef, ">= 6").And(inputBRef, "1").Then(outputRef, ""))
                        .WithRule("r7", r => r
                            .When(inputBRef, "3").Then(outputRef, "\"c\""))
                        .WithRule("r8", r => r
                            .When(inputARef, "9").And(inputBRef, "1").Then(outputRef, "\"a\""))

                        .Requires(aRef).Requires(bRef))
                .Build();


            var ctx = DmnExecutionContextFactory
                .CreateExecutionContext(def)
                .WithInputParameter("a", a)
                .WithInputParameter("b", b);

            var result = ctx.ExecuteDecision("OutputOrder");

            var hitsCount = hits?.Length ?? 0;
            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();
            result.Results.Should().HaveCount(hitsCount);

            if (hitsCount == 0) return;
            for (var i = 0; i < hitsCount; i++)
            {
                result.Results[i].HitRules.Should().HaveCount(1);
                // ReSharper disable once PossibleNullReferenceException
                result.Results[i].HitRules[0].Name.Should().Be(hits[i]);
            }
        }

        [TestMethod]
        [DataRow(2, 1, new[] { "r1" })]
        [DataRow(5, 1, new[] { "r3", "r4" })]
        [DataRow(5, 2, new[] { "r2", "r4" })]
        [DataRow(6, 1, new[] { "r5", "r6" })]
        [DataRow(6, 2, new[] { "r5", "rEmpty" })]
        [DataRow(6, 3, new[] { "r5", "r7" })]
        [DataRow(6, 4, new[] { "r5" })]
        [DataRow(6, null, new[] { "r5" })]
        [DataRow(7, 2, new[] { "rEmpty" })]//hit, empty output
        [DataRow(7, 1, new[] { "r6" })]
        [DataRow(9, 1, new[] { "r6", "r8" })]
        [DataRow(1, 3, new[] { "r7" })]
        [DataRow(null, 3, new[] { "r7" })]
        [DataRow(null, null, null)] //no hit
        [DataRow(8, 8, null)] //no hit
        public void CollectListHitPolicyTest(int? a, int? b, string[] hits)
        {
            var def = new DmnDefinitionBuilder()
                .WithInput<int>("a", out var aRef)
                .WithInput<int>("b", out var bRef)
                .WithVariable<long>("o", out var oRef)

                .WithTableDecision("Collect", table =>
                    table
                        .WithInput(aRef, out var inputARef)
                        .WithInput(bRef, out var inputBRef)
                        .WithOutput(oRef, out var outputRef)
                        .WithHitPolicy(HitPolicyEnum.Collect)
                        .WithAggregation(CollectHitPolicyAggregationEnum.List)

                        .WithRule("r1", r => r
                            .When(inputARef, "< 5").And(inputBRef, "1").Then(outputRef, "5"))
                        .WithRule("r2", r => r
                            .When(inputARef, "<= 5").And(inputBRef, "2").Then(outputRef, "3"))
                        .WithRule("r3", r => r
                            .When(inputARef, "5").And(inputBRef, "1").Then(outputRef, "4"))
                        .WithRule("r4", r => r
                            .When(inputARef, "5").Then(outputRef, "8"))
                        .WithRule("r5", r => r
                            .When(inputARef, "6").Then(outputRef, "2"))
                        .WithRule("r6", r => r
                            .When(inputARef, ">= 6").And(inputBRef, "1").Then(outputRef, "1"))
                        .WithRule("rEmpty", r => r
                            .When(inputARef, ">= 6").And(inputBRef, "2").Then(outputRef, ""))
                        .WithRule("r7", r => r
                            .When(inputBRef, "3").Then(outputRef, "2"))
                        .WithRule("r8", r => r
                            .When(inputARef, "9").And(inputBRef, "1").Then(outputRef, "3"))
                        .Requires(aRef).Requires(bRef))
                .Build();

            var ctx = DmnExecutionContextFactory
                .CreateExecutionContext(def)
                .WithInputParameter("a", a)
                .WithInputParameter("b", b);

            var result = ctx.ExecuteDecision("Collect");

            var hitsCount = hits?.Length ?? 0;
            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();
            result.Results.Should().HaveCount(hitsCount);

            if (hitsCount == 0) return;
            for (var i = 0; i < hitsCount; i++)
            {
                result.Results[i].HitRules.Should().HaveCount(1);
                // ReSharper disable once PossibleNullReferenceException
                result.Results[i].HitRules[0].Name.Should().Be(hits[i]);
            }
        }

        [TestMethod]
        [DataRow(2, 1, new[] { "r1" })]
        [DataRow(5, 1, new[] { "r3", "r4" })]
        [DataRow(5, 2, new[] { "r2", "r4" })]
        [DataRow(6, 1, new[] { "r5", "r6" })]
        [DataRow(6, 2, new[] { "r5", "rEmpty" })]
        [DataRow(6, 3, new[] { "r5", "r7" })]
        [DataRow(6, 4, new[] { "r5" })]
        [DataRow(6, null, new[] { "r5" })]
        [DataRow(7, 2, new[] { "rEmpty" })]//hit, empty output
        [DataRow(7, 1, new[] { "r6" })]
        [DataRow(9, 1, new[] { "r6", "r8" })]
        [DataRow(1, 3, new[] { "r7" })]
        [DataRow(null, 3, new[] { "r7" })]
        [DataRow(null, null, null)] //no hit
        [DataRow(8, 8, null)] //no hit
        public void CollectSumHitPolicyTest(int? a, int? b, string[] hits)
        {
            CollectAggregateHitPolicyTest(CollectHitPolicyAggregationEnum.Sum, a, b, hits);
        }

        [TestMethod]
        [DataRow(2, 1, new[] { "r1" })]
        [DataRow(5, 1, new[] { "r3", "r4" })]
        [DataRow(5, 2, new[] { "r2", "r4" })]
        [DataRow(6, 1, new[] { "r5", "r6" })]
        [DataRow(6, 2, new[] { "r5", "rEmpty" })]
        [DataRow(6, 3, new[] { "r5", "r7" })]
        [DataRow(6, 4, new[] { "r5" })]
        [DataRow(6, null, new[] { "r5" })]
        [DataRow(7, 2, new[] { "rEmpty" })]//hit, empty output
        [DataRow(7, 1, new[] { "r6" })]
        [DataRow(9, 1, new[] { "r6", "r8" })]
        [DataRow(1, 3, new[] { "r7" })]
        [DataRow(null, 3, new[] { "r7" })]
        [DataRow(null, null, null)] //no hit
        [DataRow(8, 8, null)] //no hit
        public void CollectMinHitPolicyTest(int? a, int? b, string[] hits)
        {
            CollectAggregateHitPolicyTest(CollectHitPolicyAggregationEnum.Min, a, b, hits);
        }

        [TestMethod]
        [DataRow(2, 1, new[] { "r1" })]
        [DataRow(5, 1, new[] { "r3", "r4" })]
        [DataRow(5, 2, new[] { "r2", "r4" })]
        [DataRow(6, 1, new[] { "r5", "r6" })]
        [DataRow(6, 2, new[] { "r5", "rEmpty" })]
        [DataRow(6, 3, new[] { "r5", "r7" })]
        [DataRow(6, 4, new[] { "r5" })]
        [DataRow(6, null, new[] { "r5" })]
        [DataRow(7, 2, new[] { "rEmpty" })]//hit, empty output
        [DataRow(7, 1, new[] { "r6" })]
        [DataRow(9, 1, new[] { "r6", "r8" })]
        [DataRow(1, 3, new[] { "r7" })]
        [DataRow(null, 3, new[] { "r7" })]
        [DataRow(null, null, null)] //no hit
        [DataRow(8, 8, null)] //no hit
        public void CollectMaxHitPolicyTest(int? a, int? b, string[] hits)
        {
            CollectAggregateHitPolicyTest(CollectHitPolicyAggregationEnum.Max, a, b, hits);
        }

        [TestMethod]
        [DataRow(2, 1, new[] { "r1" })]
        [DataRow(5, 1, new[] { "r3", "r4" })]
        [DataRow(5, 2, new[] { "r2", "r4" })]
        [DataRow(6, 1, new[] { "r5", "r6" })]
        [DataRow(6, 2, new[] { "r5", "rEmpty" })]
        [DataRow(6, 3, new[] { "r5", "r7" })]
        [DataRow(6, 4, new[] { "r5" })]
        [DataRow(6, null, new[] { "r5" })]
        [DataRow(7, 2, new[] { "rEmpty" })]//hit, empty output
        [DataRow(7, 1, new[] { "r6" })]
        [DataRow(9, 1, new[] { "r6", "r8" })]
        [DataRow(1, 3, new[] { "r7" })]
        [DataRow(null, 3, new[] { "r7" })]
        [DataRow(null, null, null)] //no hit
        [DataRow(8, 8, null)] //no hit
        public void CollectCountHitPolicyTest(int? a, int? b, string[] hits)
        {
            CollectAggregateHitPolicyTest(CollectHitPolicyAggregationEnum.Count, a, b, hits);
        }

        private void CollectAggregateHitPolicyTest(CollectHitPolicyAggregationEnum aggregate,int? a, int? b, string[] hits)
        {
            var def = new DmnDefinitionBuilder()
                .WithInput<int>("a", out var aRef)
                .WithInput<int>("b", out var bRef)
                .WithVariable<long>("o", out var oRef)

                .WithTableDecision("Collect", table =>
                    table
                        .WithInput(aRef, out var inputARef)
                        .WithInput(bRef, out var inputBRef)
                        .WithOutput(oRef, out var outputRef)
                        .WithHitPolicy(HitPolicyEnum.Collect)
                        .WithAggregation(aggregate)

                        .WithRule("r1", r => r
                            .When(inputARef, "< 5").And(inputBRef, "1").Then(outputRef, "5"))
                        .WithRule("r2", r => r
                            .When(inputARef, "<= 5").And(inputBRef, "2").Then(outputRef, "3"))
                        .WithRule("r3", r => r
                            .When(inputARef, "5").And(inputBRef, "1").Then(outputRef, "4"))
                        .WithRule("r4", r => r
                            .When(inputARef, "5").Then(outputRef, "8"))
                        .WithRule("r5", r => r
                            .When(inputARef, "6").Then(outputRef, "2"))
                        .WithRule("r6", r => r
                            .When(inputARef, ">= 6").And(inputBRef, "1").Then(outputRef, "1"))
                        .WithRule("rEmpty", r => r
                            .When(inputARef, ">= 6").And(inputBRef, "2").Then(outputRef, ""))
                        .WithRule("r7", r => r
                            .When(inputBRef, "3").Then(outputRef, "2"))
                        .WithRule("r8", r => r
                            .When(inputARef, "9").And(inputBRef, "1").Then(outputRef, "3"))
                        .Requires(aRef).Requires(bRef))
                .Build();

            var ctx = DmnExecutionContextFactory
                .CreateExecutionContext(def)
                .WithInputParameter("a", a)
                .WithInputParameter("b", b);

            var result = ctx.ExecuteDecision("Collect");

            var hitsCount = hits?.Length ?? 0;
            result.Should().NotBeNull();
            result.Results.Should().NotBeNull();

            if (hitsCount == 0) return;

            result.Results.Should().HaveCount(1);//single result, but might have multiple hits aggregated
            result.IsSingleResult.Should().Be(true);
            result.Results[0].HitRules.Should().HaveCount(hitsCount);

            for (var i = 0; i < hitsCount; i++)
            {
                // ReSharper disable once PossibleNullReferenceException
                result.Results[0].HitRules[i].Name.Should().Be(hits[i]);
            }
        }
    }

}
