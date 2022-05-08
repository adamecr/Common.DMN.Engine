using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace net.adamec.lib.common.dmn.engine.test.complex
{
    [TestClass]
    [TestCategory("Not regular test")]
    public class CircularReferenceTests13Ext: CircularReferenceTests13
    {
        protected override SourceEnum Source => SourceEnum.File13ext;
    }
}
