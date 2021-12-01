using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.execution.context;

namespace net.adamec.lib.common.dmn.engine.test.complex
{
    [TestClass]
    [TestCategory("Complex tests")]
    public class SfeelExpressionsTests13 : SfeelExpressionsTests
    {
        protected override SourceEnum Source => SourceEnum.File13;

        private static DmnExecutionContext ctxFile13;
        protected override DmnExecutionContext Ctx => ctxFile13;

        [ClassInitialize]
        public static void InitCtxFile13(TestContext testContext)
        {
            ctxFile13 = CTX("sfeel.dmn", SourceEnum.File13);
        }
    }
}
