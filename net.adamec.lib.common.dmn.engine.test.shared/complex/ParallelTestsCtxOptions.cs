using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.engine.execution.context;

namespace net.adamec.lib.common.dmn.engine.test.complex
{
    [TestClass]
    [TestCategory("Complex tests - non parallel rules evaluation")]
    public class ParallelTestsOptNonParallelRules : ParallelTests
    {
        protected override Action<DmnExecutionContextOptions> ConfigureCtx => (options => options.EvaluateTableRulesInParallel = false);

        private static DmnDefinition defFileOpts1;
        protected override DmnDefinition DefStatic => defFileOpts1;
        [ClassInitialize]
        public static void InitCtxFileOpts2(TestContext testContext)
        {
            defFileOpts1 = DEF("parallel.dmn", SourceEnum.File);
        }
    }

    [TestClass]
    [TestCategory("Complex tests - parallel rule outputs evaluation")]
    public class ParallelTestsOptParallelOutputs : ParallelTests
    {
        protected override Action<DmnExecutionContextOptions> ConfigureCtx => (options => options.EvaluateTableOutputsInParallel = true);

        private static DmnDefinition defFileOpts2;
        protected override DmnDefinition DefStatic => defFileOpts2;
        [ClassInitialize]
        public static void InitCtxFileOpts2(TestContext testContext)
        {
            defFileOpts2 = DEF("parallel.dmn", SourceEnum.File);
        }
    }
}
