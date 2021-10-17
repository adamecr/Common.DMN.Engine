using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.execution.context;

namespace net.adamec.lib.common.dmn.engine.test.complex
{
    [TestClass]
    [TestCategory("Complex tests - non parallel rules evaluation")]
    public class EndToEndTestsOptNonParallelRules : EndToEndTests
    {
        protected override Action<DmnExecutionContextOptions> ConfigureCtx => (options => options.EvaluateTableRulesInParallel = false); 
    }

    [TestClass]
    [TestCategory("Complex tests - parallel rule outputs evaluation")]
    public class EndToEndTestsOptParallelOutputs : EndToEndTests
    {
        protected override Action<DmnExecutionContextOptions> ConfigureCtx => (options => options.EvaluateTableOutputsInParallel = true);
    }
}
