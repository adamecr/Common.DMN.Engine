using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace net.adamec.lib.common.dmn.engine.test.complex
{
    [TestClass]
    [TestCategory("Complex tests - hit policy")]
    public class HitPolicyMultiOutTests13 : HitPolicyMultiOutTests
    {
        protected override SourceEnum Source => SourceEnum.File13;
    }
}
