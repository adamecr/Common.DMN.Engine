using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.execution.context;

namespace net.adamec.lib.common.dmn.engine.test.complex
{
    [TestClass]
    [TestCategory("Complex tests")]
    public class SfeelExpressionsTests13Ext : SfeelExpressionsTests13
    {
        protected override SourceEnum Source => SourceEnum.File13ext;

        private static DmnExecutionContext ctxFile13Ext;
        protected override DmnExecutionContext Ctx => ctxFile13Ext;

        [ClassInitialize]
        public static void InitCtxFile13Ext(TestContext testContext)
        {
            ctxFile13Ext = CTX("sfeel.dmn", SourceEnum.File13ext);
        }
    }
}
