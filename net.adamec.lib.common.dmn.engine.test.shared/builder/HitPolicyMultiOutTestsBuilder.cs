using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.test.complex;

namespace net.adamec.lib.common.dmn.engine.test.builder
{
    [TestClass]
    [TestCategory("Complex tests - hit policy")]
    public class HitPolicyMultiOutTestsBuilder : HitPolicyMultiOutTests
    {
        protected override SourceEnum Source => SourceEnum.Builder;
    }
}
