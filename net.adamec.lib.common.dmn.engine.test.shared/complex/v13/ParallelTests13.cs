using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.definition;

namespace net.adamec.lib.common.dmn.engine.test.complex
{
    [TestClass]
    [TestCategory("Complex tests")]
    public class ParallelTests13Ext : ParallelTests13
    {
        protected override SourceEnum Source => SourceEnum.File13ext;

        private static DmnDefinition defFile13Ext;
        protected override DmnDefinition DefStatic => defFile13Ext;

        [ClassInitialize]
        public static void InitCtxFile13Ext(TestContext testContext)
        {
            defFile13Ext = DEF("parallel.dmn", SourceEnum.File13ext);
        }
    }
}
