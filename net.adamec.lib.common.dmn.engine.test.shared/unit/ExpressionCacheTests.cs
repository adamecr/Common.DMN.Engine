using System;
using System.Collections.Generic;
using DynamicExpresso;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.decisions;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.engine.definition.builder;
using net.adamec.lib.common.dmn.engine.engine.execution.context;
using net.adamec.lib.common.dmn.engine.engine.execution.result;

namespace net.adamec.lib.common.dmn.engine.test.unit
{
    [TestClass]
    public class ExpressionCacheTests
    {
        // None - Don't cache parsed expressions
        // Execution - Cache parsed expressions within the single execution run only
        // Context - Cache parsed expressions within execution context only
        // Definition - Cache parsed expressions for definition (cross execution contexts) - default
        // Global - Cache parsed expressions globally (cross definitions and execution contexts)

        [TestMethod]
        [DataRow(ParsedExpressionCacheScopeEnum.None, false, false, false, false, false)]
        [DataRow(ParsedExpressionCacheScopeEnum.Execution, true, false, false, false, true)]
        [DataRow(ParsedExpressionCacheScopeEnum.Context, true, false, false, true, true)]
        [DataRow(ParsedExpressionCacheScopeEnum.Definition, true, false, true, true, true)]
        [DataRow(ParsedExpressionCacheScopeEnum.Global, true, true, true, true, true)]
        [DataRow(null, true, false, true, true, true)]
        public void BasicCacheTest(ParsedExpressionCacheScopeEnum? cacheType, bool addedToCache, bool cachedGlobal, bool cachedDefinition, bool cachedContext, bool cachedExecution)
        {
            OpenCacheExecutionContext.ResetCache(); //cleanup between runs

            var def1 = new DmnDefinitionBuilder()
                .WithInput<int>("input")
                .WithVariable<int>("output", out var output1Ref)
                .WithExpressionDecision("decision1", "input+2", output1Ref, out var decision1Ref)
                .WithExpressionDecision("decision2", ed => ed.Put("input+2").To(output1Ref).Requires(decision1Ref))
                .Build();

            var def2 = new DmnDefinitionBuilder()
                .WithInput<int>("input")
                .WithVariable<int>("output", out var output2Ref)
                .WithExpressionDecision("decision1", "input+2", output2Ref)
                .Build();

            var def3 = new DmnDefinitionBuilder()
                .WithInput<int>("input")
                .WithVariable<int>("output", out var output3Ref)
                .WithExpressionDecision("decision1", "input+2", output3Ref)
                .Build();

            var ctx1 = Ctx(def1, cacheType);
            //within execution
            ctx1.ExecuteDecision("decision2");
            ctx1.RetrievedFromCache.Should().Be(cachedExecution);
            ctx1.AddedToCache.Should().Be(addedToCache);

            //within context
            ctx1.ExecuteDecision("decision1");
            ctx1.RetrievedFromCache.Should().Be(cachedContext);

            //within definition
            var ctx2 = Ctx(def1, cacheType);
            ctx2.ExecuteDecision("decision1");
            ctx2.RetrievedFromCache.Should().Be(cachedDefinition);

            //outside definition (global)
            var ctx3 = Ctx(def2, cacheType);
            ctx3.ExecuteDecision("decision1");
            ctx3.RetrievedFromCache.Should().Be(cachedGlobal);

            //override - always none and have no impact to cache
            var ctx4 = Ctx(def1, ParsedExpressionCacheScopeEnum.None);
            ctx4.ExecuteDecision("decision1");
            ctx4.RetrievedFromCache.Should().BeFalse();
            ctx4.AddedToCache.Should().BeFalse();
            ctx4.ExecuteDecision("decision2");
            ctx4.RetrievedFromCache.Should().BeFalse();
            ctx4.AddedToCache.Should().BeFalse();

            //override global - always cache
            var alreadyCached = cachedGlobal;
            var ctx5 = Ctx(def1, ParsedExpressionCacheScopeEnum.Global);
            ctx5.ExecuteDecision("decision1");
            ctx5.RetrievedFromCache.Should().Be(alreadyCached);
            ctx5.AddedToCache.Should().Be(!alreadyCached);
            var ctx6 = Ctx(def2, ParsedExpressionCacheScopeEnum.Global);
            ctx6.ExecuteDecision("decision1");
            ctx6.RetrievedFromCache.Should().BeTrue();
            ctx6.AddedToCache.Should().BeFalse();
            var ctx7 = Ctx(def3, ParsedExpressionCacheScopeEnum.Global);
            ctx7.ExecuteDecision("decision1");
            ctx7.RetrievedFromCache.Should().BeTrue();
            ctx7.AddedToCache.Should().BeFalse();
        }

        private OpenCacheExecutionContext Ctx(DmnDefinition def, ParsedExpressionCacheScopeEnum? cacheType)
        {
            if (!cacheType.HasValue) //default
            {
                return (OpenCacheExecutionContext)DmnExecutionContextFactory
                    .CreateCustomExecutionContext<OpenCacheExecutionContext>(def);
            }

            return (OpenCacheExecutionContext)DmnExecutionContextFactory
                .CreateCustomExecutionContext<OpenCacheExecutionContext>(
                    def,
                    o => o.ParsedExpressionCacheScope = cacheType.Value);

        }
        public class OpenCacheExecutionContext : DmnExecutionContext
        {
            public bool RetrievedFromCache { get; private set; }
            public bool AddedToCache { get; private set; }
            public OpenCacheExecutionContext(DmnDefinition definition,
                IReadOnlyDictionary<string, DmnExecutionVariable> variables,
                IReadOnlyDictionary<string, IDmnDecision> decisions,
                Action<DmnExecutionContextOptions> configure = null)
                : base(definition, variables, decisions, configure)
            {
            }

            public static void ResetCache()
            {
                ParsedExpressionsCache.Clear();
            }

            public override DmnDecisionResult ExecuteDecision(IDmnDecision decision)
            {
                RetrievedFromCache = false;
                AddedToCache = false;
                return base.ExecuteDecision(decision);
            }

            protected override bool GetParsedExpressionsFromCache(string cacheKey, out Lambda parsedExpression)
            {
                RetrievedFromCache = base.GetParsedExpressionsFromCache(cacheKey, out parsedExpression);
                return RetrievedFromCache;
            }

            protected override void CacheParsedExpression(string cacheKey, Lambda parsedExpression)
            {
                AddedToCache = true;
                base.CacheParsedExpression(cacheKey, parsedExpression);
            }
        }
    }
}
