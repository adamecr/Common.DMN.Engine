using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace net.adamec.lib.common.dmn.engine.test.complex
{
    [TestClass]
    [TestCategory("Complex tests - hit policy")]
    public class HitPolicyTest13Ext : HitPolicyTest13
    {
        protected override SourceEnum Source => SourceEnum.File13ext;
    }
}
