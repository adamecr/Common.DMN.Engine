using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.runtime;
using net.adamec.lib.common.dmn.engine.parser;

namespace net.adamec.lib.common.dmn.engine.test.net.complex
{
    [TestClass]
    [TestCategory("Not regular test")]
    public class CircularReferenceTests13
    {
        //[TestMethod] - uncomment to see the StackOverflowException with circular dependency in model
        public void CircularReferenceTest()
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/dmn1.3/circular_err.dmn");
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse13(file));
            ctx.WithInputParameter("a", 0);
            ctx.ExecuteDecision("Second");
        }
    }
}
