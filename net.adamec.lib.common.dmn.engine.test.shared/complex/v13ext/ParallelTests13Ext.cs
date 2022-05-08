using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.definition;

namespace net.adamec.lib.common.dmn.engine.test.complex
{
    [TestClass]
    [TestCategory("Complex tests")]
    public class ParallelTests13 : ParallelTests
    {
        protected override SourceEnum Source => SourceEnum.File13;

        private static DmnDefinition defFile13;
        protected override DmnDefinition DefStatic => defFile13;

        [ClassInitialize]
        public static void InitCtxFile13(TestContext testContext)
        {
            defFile13 = DEF("parallel.dmn", SourceEnum.File13);
        }
    }
}
