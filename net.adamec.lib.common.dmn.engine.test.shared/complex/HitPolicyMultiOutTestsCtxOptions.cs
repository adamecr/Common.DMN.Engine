using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.execution.context;

namespace net.adamec.lib.common.dmn.engine.test.complex
{
    [TestClass]
    [TestCategory("Complex tests - hit policy - non parallel rules evaluation")]
    public class HitPolicyMultiOutTestsOptNonParallelRules : HitPolicyMultiOutTests
    {
        protected override Action<DmnExecutionContextOptions> ConfigureCtx => (options => options.EvaluateTableRulesInParallel = false);
    }

    [TestClass]
    [TestCategory("Complex tests - hit policy - parallel rule outputs evaluation")]
    public class HitPolicyMultiOutTestsOptParallelOutputs : HitPolicyMultiOutTests
    {
        protected override Action<DmnExecutionContextOptions> ConfigureCtx => (options => options.EvaluateTableOutputsInParallel = true);
    }
}
