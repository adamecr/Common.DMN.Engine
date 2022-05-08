using System;
using System.Collections.Generic;
using System.Linq;
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
            OpenCacheExecutionContext.ResetStaticCache(); //cleanup between runs!!!

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
            //--------------------------
            //within execution
            //--------------------------
            ctx1.ExecuteDecision("decision2");
            ctx1.RetrievedFromCache.Should().Be(cachedExecution);
            ctx1.AddedToCache.Should().Be(addedToCache);

            ctx1.ExecutionCacheCount.Should().Be(0); //auto purged 
            ctx1.ContextCacheCount.Should().Be(cacheType == ParsedExpressionCacheScopeEnum.Context ? 1 : 0);
            OpenCacheExecutionContext.AllDefinitionCacheCount.Should().Be(cacheType == ParsedExpressionCacheScopeEnum.Definition || cacheType == null ? 1 : 0);
            OpenCacheExecutionContext.DefinitionCacheCount(def1.Id).Should().Be(cacheType == ParsedExpressionCacheScopeEnum.Definition || cacheType == null ? 1 : 0);
            OpenCacheExecutionContext.GlobalCacheCount.Should().Be(cacheType == ParsedExpressionCacheScopeEnum.Global ? 1 : 0);

            //--------------------------
            //within context
            //--------------------------
            ctx1.ExecuteDecision("decision1");
            ctx1.RetrievedFromCache.Should().Be(cachedContext);

            ctx1.ExecutionCacheCount.Should().Be(0); //auto purged 
            //already cached and no record should be added - unless it's Execution cache that is auto purged
            ctx1.ContextCacheCount.Should().Be(cacheType == ParsedExpressionCacheScopeEnum.Context ? 1 : 0);
            OpenCacheExecutionContext.AllDefinitionCacheCount.Should().Be(cacheType == ParsedExpressionCacheScopeEnum.Definition || cacheType == null ? 1 : 0);
            OpenCacheExecutionContext.DefinitionCacheCount(def1.Id).Should().Be(cacheType == ParsedExpressionCacheScopeEnum.Definition || cacheType == null ? 1 : 0);
            OpenCacheExecutionContext.GlobalCacheCount.Should().Be(cacheType == ParsedExpressionCacheScopeEnum.Global ? 1 : 0);
            ctx1.AddedToCache.Should().Be(cacheType == ParsedExpressionCacheScopeEnum.Execution);
            //TODO - another cached expression to check it is not adding only the single/last one! also check purge by id
            //--------------------------
            //within definition
            //--------------------------
            var ctx2 = Ctx(def1, cacheType);
            ctx2.ExecuteDecision("decision1");
            ctx2.RetrievedFromCache.Should().Be(cachedDefinition);

            //--------------------------
            //outside definition (global)
            //--------------------------
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
        [TestMethod]
        // Added as a part of fix of Issue 15 - Memory leak detected within DmnExecutionContext class
        public void SeparationAndPurgeCacheTest()
        {
            OpenCacheExecutionContext.ResetStaticCache(); //cleanup between runs!!!

            var def1 = new DmnDefinitionBuilder()
                .WithInput<int>("input", out var inputRef)
                .WithVariable<int>("output", out var output1Ref)
                .WithExpressionDecision("decision1", "input+2", output1Ref, out var decision1Ref)
                 .Build();

            var def2 = new DmnDefinitionBuilder()
                .WithInput<int>("input")
                .WithVariable<int>("output", out var output2Ref)
                .WithExpressionDecision("decision1", "input+2", output2Ref)
                .Build();


            //--------------------------
            //within execution
            //--------------------------
            var ctxE1 = Ctx(def1, ParsedExpressionCacheScopeEnum.Execution);
            ctxE1.ExecuteDecision("decision1");
            ctxE1.RetrievedFromCache.Should().Be(false);
            ctxE1.AddedToCache.Should().Be(true); //added during processing
            ctxE1.ExecutionCacheCount.Should().Be(0);//purged after processing

            ctxE1.ExecuteDecision("decision1");
            ctxE1.RetrievedFromCache.Should().Be(false); //was auto purged - executions are separated

            //--------------------------
            //within context
            //--------------------------
            var ctxC1 = Ctx(def1, ParsedExpressionCacheScopeEnum.Context);
            ctxC1.ExecuteDecision("decision1");
            ctxC1.RetrievedFromCache.Should().Be(false);
            ctxC1.AddedToCache.Should().Be(true); //added during processing
            ctxC1.ContextCacheCount.Should().Be(1);//kept in context

            ctxC1.ExecuteDecision("decision1");
            ctxC1.RetrievedFromCache.Should().Be(true);//already in there
            ctxC1.AddedToCache.Should().Be(false); //already in there
            ctxC1.ContextCacheCount.Should().Be(1);//kept in context

            ctxE1.ExecuteDecision("decision1");
            ctxE1.RetrievedFromCache.Should().Be(false);//not in execution cache 

            var ctxC2 = Ctx(def1, ParsedExpressionCacheScopeEnum.Context);
            ctxC2.ExecuteDecision("decision1");
            ctxC2.RetrievedFromCache.Should().Be(false); //not in context yet
            ctxC2.AddedToCache.Should().Be(true); //added during processing


            ctxC1.ExecuteDecision("decision1");
            ctxC1.RetrievedFromCache.Should().Be(true);//already in there
            ctxC1.AddedToCache.Should().Be(false); //already in there
            ctxC1.ContextCacheCount.Should().Be(1);//kept in context

            ctxC2.ContextCacheCount.Should().Be(1);//kept in context 2
            ctxC1.ContextCacheCount.Should().Be(1);//kept in context 1
            ctxE1.ContextCacheCount.Should().Be(0);//nothing in execution cache
            OpenCacheExecutionContext.AllDefinitionCacheCount.Should().Be(0); // not added to definition cache
            OpenCacheExecutionContext.GlobalCacheCount.Should().Be(0); //not added to global cache

            //--------------------------
            //within definition
            //--------------------------
            var ctxD11 = Ctx(def1, ParsedExpressionCacheScopeEnum.Definition); //Definition cache, instance 1, definition 1
            ctxD11.ExecuteDecision("decision1");
            ctxD11.RetrievedFromCache.Should().Be(false);
            ctxD11.AddedToCache.Should().Be(true); //added during processing
            OpenCacheExecutionContext.DefinitionCacheCount(def1.Id).Should().Be(1);//kept in definition cache

            var ctxD21 = Ctx(def1, ParsedExpressionCacheScopeEnum.Definition); //Definition cache, instance 2, definition 1
            ctxD21.ExecuteDecision("decision1");
            ctxD21.RetrievedFromCache.Should().Be(true); //retrieved from cache
            ctxD21.AddedToCache.Should().Be(false); //already in there
            OpenCacheExecutionContext.DefinitionCacheCount(def1.Id).Should().Be(1);//kept in definition cache

            var ctxD32 = Ctx(def2, ParsedExpressionCacheScopeEnum.Definition); //Definition cache, instance 3, definition 2
            OpenCacheExecutionContext.DefinitionCacheCount(def2.Id).Should().Be(0);//not there yet
            OpenCacheExecutionContext.DefinitionCacheCount(def1.Id).Should().Be(1);//existing in definition cache for definition 1
            ctxD32.ExecuteDecision("decision1");
            ctxD32.RetrievedFromCache.Should().Be(false);
            ctxD32.AddedToCache.Should().Be(true); //added during processing
            OpenCacheExecutionContext.DefinitionCacheCount(def2.Id).Should().Be(1);//kept in definition cache for definition 2
            OpenCacheExecutionContext.DefinitionCacheCount(def1.Id).Should().Be(1);//existing also in definition cache for definition 1
            OpenCacheExecutionContext.AllDefinitionCacheCount.Should().Be(2);//definition cache for definition 1 and 2

            var ctxD42 = Ctx(def2, ParsedExpressionCacheScopeEnum.Definition); //Definition cache, instance 4, definition 2
            OpenCacheExecutionContext.DefinitionCacheCount(def2.Id).Should().Be(1);//kept in definition cache for definition 2
            OpenCacheExecutionContext.DefinitionCacheCount(def1.Id).Should().Be(1);//existing also in definition cache for definition 1
            ctxD42.ExecuteDecision("decision1");
            ctxD42.RetrievedFromCache.Should().Be(true);//already there
            ctxD42.AddedToCache.Should().Be(false); //already there
            OpenCacheExecutionContext.AllDefinitionCacheCount.Should().Be(2);//definition cache for definition 1 and 2

            var ctxC3 = Ctx(def1, ParsedExpressionCacheScopeEnum.Context);
            OpenCacheExecutionContext.AllDefinitionCacheCount.Should().Be(2);//existing in definition cache for definition 1 
            ctxC3.ContextCacheCount.Should().Be(0);//empty context cache
            ctxC3.ExecuteDecision("decision1");
            ctxC3.RetrievedFromCache.Should().Be(false); //not in context cache (even if in definition cache)
            ctxC3.AddedToCache.Should().Be(true); //added during processing
            ctxC3.ContextCacheCount.Should().Be(1);//kept in context

            ctxC3.ExecuteDecision("decision1");
            ctxC3.RetrievedFromCache.Should().Be(true);//already in there
            ctxC3.AddedToCache.Should().Be(false); //already in there
            ctxC3.ContextCacheCount.Should().Be(1);//kept in context

            OpenCacheExecutionContext.AllDefinitionCacheCount.Should().Be(2);//definition cache for definition 1 and 2 
            ctxE1.ExecuteDecision("decision1");
            ctxE1.RetrievedFromCache.Should().Be(false);//not in execution cache

            var ctxE2 = Ctx(def1, ParsedExpressionCacheScopeEnum.Execution);
            OpenCacheExecutionContext.AllDefinitionCacheCount.Should().Be(2);//existing in definition cache for definition 1 and 2
            ctxE2.ContextCacheCount.Should().Be(0);//empty context cache
            ctxE2.ExecutionCacheCount.Should().Be(0);//empty execution cache
            ctxE2.ExecuteDecision("decision1");
            ctxE2.RetrievedFromCache.Should().Be(false);
            ctxE2.AddedToCache.Should().Be(true); //added during processing
            ctxE2.ExecutionCacheCount.Should().Be(0);//purged after processing

            OpenCacheExecutionContext.GlobalCacheCount.Should().Be(0); //nothing added to global cache so far

            //remove Definition 2 from cache
            DmnExecutionContext.PurgeExpressionCacheDefinitionScope(def2.Id);

            OpenCacheExecutionContext.DefinitionCacheCount(def2.Id).Should().Be(0);//purged
            OpenCacheExecutionContext.DefinitionCacheCount(def1.Id).Should().Be(1);//kept
            ctxD32.ExecuteDecision("decision1");
            ctxD32.RetrievedFromCache.Should().Be(false); //was purged
            ctxD32.AddedToCache.Should().Be(true); //added
            OpenCacheExecutionContext.DefinitionCacheCount(def2.Id).Should().Be(1);//added
            OpenCacheExecutionContext.DefinitionCacheCount(def1.Id).Should().Be(1);//kept

            ctxD32.ExecuteDecision("decision1");
            ctxD32.RetrievedFromCache.Should().Be(true); //in there now
            OpenCacheExecutionContext.DefinitionCacheCount(def2.Id).Should().Be(1);//kept
            OpenCacheExecutionContext.DefinitionCacheCount(def1.Id).Should().Be(1);//kept

            ctxD21.ExecuteDecision("decision1");
            ctxD21.RetrievedFromCache.Should().Be(true); //retrieved from cache - still in there
            ctxD21.AddedToCache.Should().Be(false); //already in there
            OpenCacheExecutionContext.DefinitionCacheCount(def2.Id).Should().Be(1);//kept
            OpenCacheExecutionContext.DefinitionCacheCount(def1.Id).Should().Be(1);//kept


            //purge Definition  cache
            DmnExecutionContext.PurgeExpressionCacheDefinitionScopeAll();

            OpenCacheExecutionContext.DefinitionCacheCount(def2.Id).Should().Be(0);//purged
            OpenCacheExecutionContext.DefinitionCacheCount(def1.Id).Should().Be(0);//purged
            OpenCacheExecutionContext.AllDefinitionCacheCount.Should().Be(0);//purged

            ctxD21.ExecuteDecision("decision1");
            ctxD21.RetrievedFromCache.Should().Be(false); //was purged
            ctxD21.AddedToCache.Should().Be(true); //added
            OpenCacheExecutionContext.DefinitionCacheCount(def2.Id).Should().Be(0);//was purged
            OpenCacheExecutionContext.DefinitionCacheCount(def1.Id).Should().Be(1);//was added

            //--------------------------
            //global cache
            //--------------------------
            var ctxG11 = Ctx(def1, ParsedExpressionCacheScopeEnum.Global); //Global cache, instance 1, definition 1
            ctxG11.ExecuteDecision("decision1");
            ctxG11.RetrievedFromCache.Should().Be(false);
            ctxG11.AddedToCache.Should().Be(true); //added during processing
            OpenCacheExecutionContext.GlobalCacheCount.Should().Be(1);//kept in global cache

            var ctxG21 = Ctx(def1, ParsedExpressionCacheScopeEnum.Global); //Global cache, instance 2, definition 1
            ctxG21.ExecuteDecision("decision1");
            ctxG21.RetrievedFromCache.Should().Be(true); //retrieved from cache
            ctxG21.AddedToCache.Should().Be(false); //already in there
            OpenCacheExecutionContext.GlobalCacheCount.Should().Be(1);//no change in global cache

            var ctxG32 = Ctx(def2, ParsedExpressionCacheScopeEnum.Global); //Global cache, instance 3, definition 2
            OpenCacheExecutionContext.DefinitionCacheCount(def2.Id).Should().Be(0);//not there yet
            OpenCacheExecutionContext.DefinitionCacheCount(def1.Id).Should().Be(1);//existing in definition cache for definition 1
            ctxG32.ExecuteDecision("decision1");
            ctxG32.RetrievedFromCache.Should().Be(true); //retrieved from cache
            ctxG32.AddedToCache.Should().Be(false); //already in there
            OpenCacheExecutionContext.GlobalCacheCount.Should().Be(1);//no change in global cache

            var ctxD52 = Ctx(def2, ParsedExpressionCacheScopeEnum.Definition); //Definition cache, instance 5, definition 2
            OpenCacheExecutionContext.GlobalCacheCount.Should().Be(1);//existing in global cache 
            OpenCacheExecutionContext.DefinitionCacheCount(def2.Id).Should().Be(0);//definition cache for definition 2 is empty (purged before)
            ctxD52.ExecuteDecision("decision1");
            ctxD52.RetrievedFromCache.Should().Be(false); //not in definition cache for def2 (even if in global cache and in definition cache for def1)
            ctxD52.AddedToCache.Should().Be(true); //added during processing
            OpenCacheExecutionContext.DefinitionCacheCount(def2.Id).Should().Be(1);//kept in definition cache

            var ctxC4 = Ctx(def1, ParsedExpressionCacheScopeEnum.Context);
            OpenCacheExecutionContext.GlobalCacheCount.Should().Be(1);//existing in global cache 
            ctxC4.ContextCacheCount.Should().Be(0);//empty context cache
            ctxC4.ExecuteDecision("decision1");
            ctxC4.RetrievedFromCache.Should().Be(false); //not in context cache (even if in global cache)
            ctxC4.AddedToCache.Should().Be(true); //added during processing
            ctxC4.ContextCacheCount.Should().Be(1);//kept in context

            ctxC4.ExecuteDecision("decision1");
            ctxC4.RetrievedFromCache.Should().Be(true);//already in there
            ctxC4.AddedToCache.Should().Be(false); //already in there
            ctxC4.ContextCacheCount.Should().Be(1);//kept in context
            OpenCacheExecutionContext.GlobalCacheCount.Should().Be(1);//no change in global cache

            ctxE1.ExecuteDecision("decision1");
            ctxE1.RetrievedFromCache.Should().Be(false);//not in execution cache

            var ctxE3 = Ctx(def1, ParsedExpressionCacheScopeEnum.Execution);
            OpenCacheExecutionContext.GlobalCacheCount.Should().Be(1); //existing in global cache
            OpenCacheExecutionContext.AllDefinitionCacheCount.Should().Be(2);//existing in definition cache for definition 1 and 2
            ctxE3.ContextCacheCount.Should().Be(0);//empty context cache
            ctxE3.ExecutionCacheCount.Should().Be(0);//empty execution cache
            ctxE3.ExecuteDecision("decision1");
            ctxE3.RetrievedFromCache.Should().Be(false);
            ctxE3.AddedToCache.Should().Be(true); //added during processing
            ctxE3.ExecutionCacheCount.Should().Be(0);//purged after processing

            //purge Global  cache
            DmnExecutionContext.PurgeExpressionCacheGlobalScope();

            OpenCacheExecutionContext.GlobalCacheCount.Should().Be(0); //purged
            OpenCacheExecutionContext.AllDefinitionCacheCount.Should().Be(2);//kept definition cache for definition 1 and 2
            ctxC4.ContextCacheCount.Should().Be(1);//kept in context cache

            ctxG21.ExecuteDecision("decision1");
            ctxG21.RetrievedFromCache.Should().Be(false); //was purged
            ctxG21.AddedToCache.Should().Be(true); //added
            OpenCacheExecutionContext.GlobalCacheCount.Should().Be(1); //was added
        }
        [TestMethod]
        public void CacheAndTablesTest()
        {
            OpenCacheExecutionContext.ResetStaticCache(); //cleanup between runs!!!

            var def1 = new DmnDefinitionBuilder()
                .WithInput<int>("input", out var inputRef)
                .WithVariable<int>("output", out var output1Ref)
                .WithExpressionDecision("decision1", "input+2", output1Ref, out var decision1Ref)
                .WithExpressionDecision("decision2", ed => ed.Put("input+2").To(output1Ref).Requires(decision1Ref))

                .WithTableDecision("decision3", table =>
                     table
                         .WithInput(inputRef, out var tblInput1Ref)
                         .WithInput("input+3", out var tblInput2Ref)
                         .WithOutput(output1Ref, out var tblOutput1Ref)

                         .WithRule("r1", r => r.When(tblInput1Ref, "1").Then(tblOutput1Ref, "2"))
                         .WithRule("r2", r => r.When(tblInput1Ref, ">1").And(tblInput2Ref, "[3..10]").Then(tblOutput1Ref, "input*2")))
                 .Build();

            //--------------------------
            //within execution
            //--------------------------
            var ctxE = Ctx(def1, ParsedExpressionCacheScopeEnum.Execution);
            ctxE.ExecuteDecision("decision2");
            ctxE.ExecutionCacheCountBeforePurge.Should().Be(1); //"input+2"
            ctxE.ExecutionCacheCountAfterPurge.Should().Be(0); //execution cache purged
            ctxE.ExecutionCacheExpressions.Should().BeEquivalentTo("input+2");

            ctxE.WithInputParameter("input", 1);
            ctxE.ExecuteDecision("decision3");
            //rule 1 (use just the first tbl input): "input==1" (tbl input 1 evaluation expr.), "2" (output expression)
            //rule 2:"input>1" (tbl input 1 evaluation expr. -> false, don't continue with further eval)
            ctxE.ExecutionCacheCountBeforePurge.Should().Be(3);
            ctxE.ExecutionCacheCountAfterPurge.Should().Be(0); //execution cache purged
            ctxE.ExecutionCacheExpressions.Should().BeEquivalentTo("input==1", "2", "input>1");

            ctxE.WithInputParameter("input", 2);
            ctxE.ExecuteDecision("decision3");
            //rule 1 (use just the first tbl input): "input==1" (tbl input 1 evaluation expr. -> false, don't continue with further eval)
            //rule 2: "input>1" (tbl input 1 evaluation expr.), "(input+3>=3 && input+3<=10)" (tbl input 2 evaluation expr.),  "input1*2" (output expression)
            ctxE.ExecutionCacheCountBeforePurge.Should().Be(4);
            ctxE.ExecutionCacheCountAfterPurge.Should().Be(0); //execution cache purged
            ctxE.ExecutionCacheExpressions.Should().BeEquivalentTo("input==1", "input>1", "(input+3>=3 && input+3<=10)", "input*2");

            //all caches are empty here
            ctxE.ExecutionCacheCount.Should().Be(0);
            ctxE.ContextCacheCount.Should().Be(0);
            OpenCacheExecutionContext.AllDefinitionCacheCount.Should().Be(0);
            OpenCacheExecutionContext.GlobalCacheCount.Should().Be(0);

            //--------------------------
            //within context
            //--------------------------
            var ctxC = Ctx(def1, ParsedExpressionCacheScopeEnum.Context);
            ctxC.ExecuteDecision("decision2");
            ctxC.ContextCacheCount.Should().Be(1); //"input+2"
            ctxC.ContextCacheExpressions.Should().BeEquivalentTo("input+2");

            ctxC.WithInputParameter("input", 1);
            ctxC.ExecuteDecision("decision3");
            //rule 1 (use just the first tbl input): "input==1" (tbl input 1 evaluation expr.), "2" (output expression)
            //rule 2:"input>1" (tbl input 1 evaluation expr. -> false, don't continue with further eval)
            ctxC.ContextCacheCount.Should().Be(1 + 3); //1 "old", 3 "new"
            ctxC.ContextCacheExpressions.Should().BeEquivalentTo("input+2", "input==1", "2", "input>1");

            ctxC.WithInputParameter("input", 2);
            ctxC.ExecuteDecision("decision3");
            //rule 1 (use just the first tbl input): "input==1" (tbl input 1 evaluation expr. -> false, don't continue with further eval)
            //rule 2: "input>1" (tbl input 1 evaluation expr.), "(input+3>=3 && input+3<=10)" (tbl input 2 evaluation expr.),  "input*2" (output expression)
            ctxC.ContextCacheCount.Should().Be(4 + 2); //4 "old", 2 "new"
            ctxC.ContextCacheExpressions.Should().BeEquivalentTo("input+2", "input==1", "2", "input>1", "(input+3>=3 && input+3<=10)", "input*2");

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

            public int ExecutionCacheCount => ParsedExpressionsInstanceCache.Keys.Count(k => !k.StartsWith($"{Id}||"));
            public int ContextCacheCount => ParsedExpressionsInstanceCache.Keys.Count(k => k.StartsWith($"{Id}||"));
            public static int AllDefinitionCacheCount => ParsedExpressionsCache.Keys.Count(k => !k.StartsWith("||"));
            public static int DefinitionCacheCount(string definitionId) => ParsedExpressionsCache.Keys.Count(k => k.StartsWith($"{definitionId}||"));
            public static int GlobalCacheCount => ParsedExpressionsCache.Keys.Count(k => k.StartsWith("||"));

            public string[] ContextCacheExpressions => ParsedExpressionsInstanceCache.Where(i => i.Key.StartsWith($"{Id}||")).Select(i => i.Value.ExpressionText).ToArray();

            public int ExecutionCacheCountBeforePurge { get; private set; }
            public int ExecutionCacheCountAfterPurge { get; private set; }
            public string[] ExecutionCacheExpressions { get; private set; }

            public OpenCacheExecutionContext(DmnDefinition definition,
                IReadOnlyDictionary<string, DmnExecutionVariable> variables,
                IReadOnlyDictionary<string, IDmnDecision> decisions,
                Action<DmnExecutionContextOptions> configure = null)
                : base(definition, variables, decisions, configure)
            {
            }

            public static void ResetStaticCache()
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

            public override void PurgeExpressionCacheExecutionScope(string executionId)
            {
                ExecutionCacheCountBeforePurge = ExecutionCacheCount;
                ExecutionCacheExpressions = ParsedExpressionsInstanceCache.Where(i => !i.Key.StartsWith($"{Id}||")).Select(i => i.Value.ExpressionText).ToArray();

                base.PurgeExpressionCacheExecutionScope(executionId);
                ExecutionCacheCountAfterPurge = ExecutionCacheCount;
            }
        }
    }
}
