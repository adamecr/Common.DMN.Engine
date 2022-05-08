using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace net.adamec.lib.common.dmn.engine.test.complex
{
    [TestClass]
    [TestCategory("Complex tests")]
    public class ComplexInputsTests13Ext : ComplexInputsTests13
    {
        protected override SourceEnum Source => SourceEnum.File13ext;
    }
}
