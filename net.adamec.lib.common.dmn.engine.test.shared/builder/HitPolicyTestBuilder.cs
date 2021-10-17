using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.test.complex;

namespace net.adamec.lib.common.dmn.engine.test.builder
{
    [TestClass]
    [TestCategory("Complex tests - hit policy - builder")]
    public class HitPolicyTestBuilder : HitPolicyTest
    {
        protected override SourceEnum Source => SourceEnum.Builder;

        //Not applicable tests
        [Ignore]
        public override void WrongHitPolicyTest()
        {
        }

        [Ignore]
        public override void WrongHitPolicyAggregationTest()
        {
        }

    }
}
