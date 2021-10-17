using System;
using System.Globalization;
using System.Xml;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.execution.context;

namespace net.adamec.lib.common.dmn.engine.test.complex
{
    [TestClass]
    [TestCategory("Complex tests")]
    public class SfeelExpressionsTests:DmnTestBase
    {
        private static DmnExecutionContext ctxFile;
        protected virtual DmnExecutionContext Ctx => ctxFile;

        [ClassInitialize]
        public static void InitCtxFile(TestContext testContext)
        {
             ctxFile = CTX("sfeel.dmn", SourceEnum.File);
        }

        [TestCleanup]
        public void ResetCtx()
        {
            Ctx.Reset();
        }

        [TestMethod]
        [DataRow(6, "a", null, "6")]
        [DataRow(6, "aa", null, "6")]
        [DataRow(6, "aaa", null, "6")]
        [DataRow(66, "a", null, null)]
        [DataRow(6, "aaaa", null, null)]
        [DataRow(null, "a", null, null)]

        [DataRow(4, "b", null, "<5")]
        [DataRow(-1, "b", null, "<5")]
        [DataRow(5, "b", null, null)]
        [DataRow(6, "b", null, null)]
        [DataRow(null, "b", null, "<5")] //null for int is changes to default(int) i.e. 0

        [DataRow(4, "c", null, "<=4")]
        [DataRow(3, "c", null, "<=4")]
        [DataRow(null, "c", null, "<=4")]//null for int is changes to default(int) i.e. 0
        [DataRow(5, "c", null, null)]

        [DataRow(6, "d", null, ">5")]
        [DataRow(5, "d", null, null)]
        [DataRow(3, "d", null, null)]
        [DataRow(null, "d", null, null)]//null for int is changes to default(int) i.e. 0

        [DataRow(7, "e", null, ">=7")]
        [DataRow(8, "e", null, ">=7")]
        [DataRow(-2, "e", null, null)]

        [DataRow(2, "f", null, "[2..5]")]
        [DataRow(3, "f", null, "[2..5]")]
        [DataRow(5, "f", null, "[2..5]")]
        [DataRow(1, "f", null, null)]
        [DataRow(6, "f", null, null)]

        [DataRow(2, "g", null, "[2..5[")]
        [DataRow(3, "g", null, "[2..5[")]
        [DataRow(5, "g", null, null)]
        [DataRow(1, "g", null, null)]
        [DataRow(6, "g", null, null)]

        [DataRow(2, "h", null, "[2..5)")]
        [DataRow(3, "h", null, "[2..5)")]
        [DataRow(5, "h", null, null)]
        [DataRow(1, "h", null, null)]
        [DataRow(6, "h", null, null)]


        [DataRow(2, "i", null, null)]
        [DataRow(3, "i", null, "]2..5]")]
        [DataRow(5, "i", null, "]2..5]")]
        [DataRow(1, "i", null, null)]
        [DataRow(6, "i", null, null)]

        [DataRow(2, "j", null, null)]
        [DataRow(3, "j", null, "]2..5[")]
        [DataRow(5, "j", null, null)]
        [DataRow(1, "j", null, null)]
        [DataRow(6, "j", null, null)]

        [DataRow(2, "k", null, null)]
        [DataRow(3, "k", null, "]2..5)")]
        [DataRow(5, "k", null, null)]
        [DataRow(1, "k", null, null)]
        [DataRow(6, "k", null, null)]

        [DataRow(2, "l", null, null)]
        [DataRow(3, "l", null, "(2..5]")]
        [DataRow(5, "l", null, "(2..5]")]
        [DataRow(1, "l", null, null)]
        [DataRow(6, "l", null, null)]

        [DataRow(2, "m", null, null)]
        [DataRow(3, "m", null, "(2..5[")]
        [DataRow(5, "m", null, null)]
        [DataRow(1, "m", null, null)]
        [DataRow(6, "m", null, null)]

        [DataRow(2, "n", null, null)]
        [DataRow(3, "n", null, "(2..5)")]
        [DataRow(5, "n", null, null)]
        [DataRow(1, "n", null, null)]
        [DataRow(6, "n", null, null)]

        [DataRow(3, "o", null, "not(6)")]
        [DataRow(6, "o", null, null)]

        [DataRow(6, "p", null, "not(<=5)")]
        [DataRow(5, "p", null, null)]
        [DataRow(4, "p", null, null)]

        [DataRow(3, "q", null, "not(>4)")]
        [DataRow(4, "q", null, "not(>4)")]
        [DataRow(5, "q", null, null)]

        [DataRow(1, "r", null, "not([2..5])")]
        [DataRow(6, "r", null, "not([2..5])")]
        [DataRow(2, "r", null, null)]
        [DataRow(3, "r", null, null)]
        [DataRow(5, "r", null, null)]

        [DataRow(1, "s", null, "not((2..5))")]
        [DataRow(6, "s", null, "not((2..5))")]
        [DataRow(2, "s", null, "not((2..5))")]
        [DataRow(3, "s", null, null)]
        [DataRow(5, "s", null, "not((2..5))")]

        [DataRow(6, "t", null, "6,8,3")]
        [DataRow(8, "t", null, "6,8,3")]
        [DataRow(3, "t", null, "6,8,3")]
        [DataRow(2, "t", null, null)]

        [DataRow(4, "u", null, "4,[6..9),11")]
        [DataRow(6, "u", null, "4,[6..9),11")]
        [DataRow(8, "u", null, "4,[6..9),11")]
        [DataRow(11, "u", null, "4,[6..9),11")]
        [DataRow(9, "u", null, null)]
        [DataRow(10, "u", null, null)]

        [DataRow(4, "v", null, null)]
        [DataRow(6, "v", null, null)]
        [DataRow(8, "v", null, null)]
        [DataRow(11, "v", null, null)]
        [DataRow(9, "v", null, "not(4,[6..9),11)")]
        [DataRow(10, "v", null, "not(4,[6..9),11)")]

        [DataRow(-10, "a", null, "1")]
        [DataRow(-10, "d", null, "1")]
        [DataRow(-10, "b", null, "<5")]

        [DataRow(null, "dt1", "2018-01-22 00:00", "<date(2018-01-23)")]
        [DataRow(null, "dt1", "2018-01-23 00:00", null)]
        [DataRow(null, "dt1", "2018-01-23 00:00", null)]

        [DataRow(null, "dt2", "2018-01-24 00:00", ">=date and time(2018-01-23T15:30)")]
        [DataRow(null, "dt2", "2018-01-23 15:30", ">=date and time(2018-01-23T15:30)")]
        [DataRow(null, "dt2", "2018-01-23 15:29", null)]
        [DataRow(null, "dt2", null, null)]

        [DataRow(null, "dt3", "T13:00", "time(13:00)")]
        [DataRow(null, "dt3", "2018-01-01 13:00", null)]
        [DataRow(null, "dt3", "T12:00", null)]

        [DataRow(null, "dt4", "2021-01-22 00:01", ">(date(2018-01-23)+duration(P3Y))")]
        [DataRow(null, "dt4", "2021-01-22 00:00", null)]

        [DataRow(-20, "2021-01-21", "2021-01-21 00:01", ">date(str)")]
        [DataRow(-20, "2021-01-21", "2021-01-21 00:00", null)]
        [DataRow(-20, "b", null, "<5")]

        public void SfeelExpressionsTest(int? i, string s, string dtStr, string o)
        {
            DateTime? dt = null;
            if (dtStr != null && dtStr.StartsWith("T"))
            {
                dt = XmlConvert.ToDateTime(dtStr.Substring(1), "HH:mm");
            }
            if (dtStr != null && !dtStr.StartsWith("T"))
            {
                dt = DateTime.ParseExact(dtStr, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
            }

            Ctx.WithInputParameter("num", i);
            Ctx.WithInputParameter("str", s);
            Ctx.WithInputParameter("dt", dt);
            var result = Ctx.Reset().ExecuteDecision("sfeel");

            result.Should().NotBeNull();

            if (o == null)
            {
                result.HasResult.Should().BeFalse();
                result.SingleResult.Should().NotBeNull();
                result.SingleResult.Should().HaveCount(0);
                return;
            }

            result.IsSingleResult.Should().Be(true);
            result.SingleResult.Should().NotBeNull();
            result.SingleResult.Should().HaveCount(1);

            var output = result.SingleResult[0];
            output.Should().NotBeNull();
            output.Name.Should().Be("o");
            output.Value.Should().Be(o).And.BeOfType<string>();
            output.Type.Should().Be(typeof(string));
        }
    }
}
