using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace net.adamec.lib.common.dmn.engine.test.complex
{
    [TestClass]
    [TestCategory("Complex tests")]
    public class AllowedValuesTests13Ext : AllowedValuesTests13
    {
        protected override SourceEnum Source => SourceEnum.File13ext;
    }
}
