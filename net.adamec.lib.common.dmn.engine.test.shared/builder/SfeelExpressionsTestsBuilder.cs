using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.execution.context;
using net.adamec.lib.common.dmn.engine.test.complex;

namespace net.adamec.lib.common.dmn.engine.test.builder
{
    [TestClass]
    [TestCategory("Complex tests - builder")]
    public class SfeelExpressionsTestsBuilder : SfeelExpressionsTests
    {
        protected override SourceEnum Source => SourceEnum.Builder;

        private static DmnExecutionContext ctxBuilder;
        protected override DmnExecutionContext Ctx => ctxBuilder;

        [ClassInitialize]
        public static void InitCtxBuilder(TestContext testContext)
        {
            ctxBuilder = CTX("sfeel.dmn", SourceEnum.Builder);
        }
    }
}
