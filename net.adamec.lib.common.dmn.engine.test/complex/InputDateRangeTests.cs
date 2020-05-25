using System;
using System.IO;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.runtime;
using net.adamec.lib.common.dmn.engine.parser;

namespace net.adamec.lib.common.dmn.engine.test.complex
{
    [TestClass]
    [TestCategory("Complex tests")]
    public class InputDateRangeTests
    {
        private DmnExecutionContext ctx;
        [TestInitialize]
        public void InitCtx()
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/date_between_expression.dmn");
            ctx = DmnExecutionContextFactory.CreateExecutionContext(DmnParser.Parse(file));
        }

        [TestCleanup]
        public void ResetCtx()
        {
            ctx.Reset();
        }

        [TestMethod]
        public void DateBetweenInputTest()
        {
            ctx.WithInputParameter("Date", new DateTime(2010,1,1));

            var result = ctx.ExecuteDecision("date_between_decision");

            
        }
    }
}
