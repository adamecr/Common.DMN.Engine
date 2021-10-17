using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.engine.execution.context;
using net.adamec.lib.common.dmn.engine.parser;
using net.adamec.lib.common.dmn.engine.parser.dto;
using net.adamec.lib.common.dmn.engine.test.builder;

namespace net.adamec.lib.common.dmn.engine.test
{
    [TestClass]
    public abstract class DmnTestBase
    {
        public TestContext TestContext { get; set; }

        public enum SourceEnum
        {
            File,
            File13,
            Builder
        }

        protected virtual SourceEnum Source => SourceEnum.File;

        protected virtual Action<DmnExecutionContextOptions> ConfigureCtx => null;
    
        // ReSharper disable once InconsistentNaming
        protected DmnExecutionContext CTX(string dmnFile, Action<DmnExecutionContextOptions> configure = null)
        {
            
            var ctx=
                Source != SourceEnum.Builder ?
                    DmnExecutionContextFactory.CreateExecutionContext(MODEL(dmnFile), configure??ConfigureCtx) :
                    DmnExecutionContextFactory.CreateExecutionContext(DmnBuilderSamples.Files[dmnFile], configure??ConfigureCtx);

            TestContext.WriteLine($"CTX: Source={Source}, Opts:{CtxOptionsStr(ctx.Options)}; DMN: {dmnFile}");
            return ctx;
        }

        protected static string CtxOptionsStr(IDmnExecutionContextOptions options)
        {
            return
                $"EvaluateTableRulesInParallel:{options.EvaluateTableRulesInParallel}, EvaluateTableOutputsInParallel:{options.EvaluateTableOutputsInParallel}, RecordSnapshots:{options.RecordSnapshots}";
        }

        // ReSharper disable once InconsistentNaming
        protected static DmnExecutionContext CTX(string dmnFile, SourceEnum source, Action<DmnExecutionContextOptions> configure = null)
        {
            var ctx=
                source != SourceEnum.Builder ?
                    DmnExecutionContextFactory.CreateExecutionContext(MODEL(dmnFile, source), configure) :
                    DmnExecutionContextFactory.CreateExecutionContext(DmnBuilderSamples.Files[dmnFile], configure);

           return ctx;
        }

        // ReSharper disable once InconsistentNaming
        protected DmnDefinition DEF(string dmnFile)
        {
            return
                Source != SourceEnum.Builder ?
                    DmnDefinitionFactory.CreateDmnDefinition(MODEL(dmnFile)) :
                    DmnBuilderSamples.Files[dmnFile];
        }

        // ReSharper disable once InconsistentNaming
        protected static DmnDefinition DEF(string dmnFile, SourceEnum source)
        {
            return
                source != SourceEnum.Builder ?
                    DmnDefinitionFactory.CreateDmnDefinition(MODEL(dmnFile, source)) :
                    DmnBuilderSamples.Files[dmnFile];
        }

        // ReSharper disable once InconsistentNaming
        protected string FILE(string dmnFile)
        {
            if (Source == SourceEnum.File) return File11(dmnFile);
            if (Source == SourceEnum.File13) return File13(dmnFile);

            throw new NotImplementedException();
        }

        // ReSharper disable once InconsistentNaming
        protected static string FILE(string dmnFile, SourceEnum source)
        {
            if (source == SourceEnum.File) return File11(dmnFile);
            if (source == SourceEnum.File13) return File13(dmnFile);

            throw new NotImplementedException();
        }
        private static string File11(string dmnFile)
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir ?? string.Empty, $"dmn/{dmnFile}");
            return file;
        }
        private static string File13(string dmnFile)
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir ?? string.Empty, $"dmn/dmn1.3/{dmnFile}");
            return file;
        }
        // ReSharper disable once InconsistentNaming
        protected DmnModel MODEL(string dmnFile)
        {
            var file = FILE(dmnFile);
            if (Source == SourceEnum.File) return DmnParser.Parse(file);
            if (Source == SourceEnum.File13) return DmnParser.Parse13(file);

            throw new NotImplementedException();
        }

        // ReSharper disable once InconsistentNaming
        protected static DmnModel MODEL(string dmnFile, SourceEnum source)
        {
            var file = FILE(dmnFile, source);
            if (source == SourceEnum.File) return DmnParser.Parse(file);
            if (source == SourceEnum.File13) return DmnParser.Parse13(file);

            throw new NotImplementedException();
        }
    }
}
