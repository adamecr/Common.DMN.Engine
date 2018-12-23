using System;
using System.Globalization;
using System.IO;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.engine.runtime;
using net.adamec.lib.common.dmn.engine.parser;

namespace net.adamec.lib.common.dmn.engine.test.complex
{
    [TestClass]
    [TestCategory("Complex tests")]
    public class ParallelTests
    {
        public TestContext TestContext { get; set; }

        private static DmnDefinition def;

        [ClassInitialize]
        public static void InitCtx(TestContext testContext)
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var file = Path.Combine(dir, "dmn/parallel.dmn");
            def = DmnDefinitionFactory.CreateDmnDefinition(DmnParser.Parse(file));
        }

        [TestMethod]
        public void ParallelTest()
        {
            TestContext.WriteLine("");
            var stopWatch = System.Diagnostics.Stopwatch.StartNew();

            var parallel = Enumerable.Range(10, 17)
                 .AsParallel()
                 .AsOrdered()
                 .Select(n =>
                {
                    var startInner = DateTime.Now;
                    var ctx = DmnExecutionContextFactory.CreateExecutionContext(def);
                    ctx.WithInputParameter("numin", -1 * n);
                    ctx.WithInputParameter("str", "2018-01-" + n);
                    ctx.WithInputParameter("dt", DateTime.ParseExact("2019-01-01 01:01", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture));
                    var result = ctx.Reset().ExecuteDecision("sfeel");
                    var endInner = DateTime.Now;
                    var msInner = (endInner - startInner).Milliseconds;
                    TestContext.WriteLine($"Done for n={n} - execution time: {msInner}ms, start: {startInner:HH:mm:ss.ffff}, end: {endInner:HH:mm:ss.ffff}");
                    return result;
                })
                 .ToArray();

            stopWatch.Stop();
            var ms = stopWatch.ElapsedMilliseconds;
            TestContext.WriteLine($"All done - Total execution time: {ms}ms");

            foreach (var result in parallel)
            {
                result.Should().NotBeNull();
                result.IsSingleResult.Should().Be(true);
                result.SingleResult.Should().NotBeNull();
                result.SingleResult.Should().HaveCount(3);

                var outNumInOut = result.SingleResult[2];
                outNumInOut.Should().NotBeNull();
                outNumInOut.Name.Should().Be("numinout");
                outNumInOut.Type.Should().Be(typeof(int));
                var numInOut = (int)outNumInOut.Value;

                var outO = result.SingleResult[0];
                outO.Should().NotBeNull();
                outO.Name.Should().Be("o");
                outO.Value.Should().Be("2018-01" + numInOut).And.BeOfType<string>();
                outO.Type.Should().Be(typeof(string));

                var outNumOut = result.SingleResult[1];
                outNumOut.Should().NotBeNull();
                outNumOut.Name.Should().Be("numout");
                outNumOut.Value.Should().Be(4 * numInOut).And.BeOfType<int>();
                outNumOut.Type.Should().Be(typeof(int));
            }
        }
    }
}
