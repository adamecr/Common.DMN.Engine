using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.test.complex;

namespace net.adamec.lib.common.dmn.engine.test.builder
{
    [TestClass]
    [TestCategory("Complex tests - builder")]
    public class ParallelTestsBuilder : ParallelTests
    {
        protected override SourceEnum Source => SourceEnum.Builder;

        private static DmnDefinition defBuilder;
        protected override DmnDefinition DefStatic => defBuilder;

        [ClassInitialize]
        public static void InitCtxBuilder(TestContext testContext)
        {
            defBuilder = DEF("parallel.dmn", DmnTestBase.SourceEnum.Builder);
        }
    }
}
