using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace net.adamec.lib.common.dmn.engine.test.complex
{
    [TestClass]
    [TestCategory("Complex tests - hit policy")]
    public class HitPolicyMultiOutTests13Ext : HitPolicyMultiOutTests13
    {
        protected override SourceEnum Source => SourceEnum.File13ext;
    }
}
