using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.engine.execution.context;
using net.adamec.lib.common.dmn.engine.parser;
using net.adamec.lib.common.dmn.engine.parser.dto;

namespace net.adamec.lib.common.dmn.engine.test.unit
{
    [TestClass]
    [TestCategory("Code tests - parser")]
    public class DmnParserDataTypesTests : DmnTestBase
    {
        [TestMethod]
        public void CheckAndUpdateVariableType_NullType_Test()
        {
            var v = new DmnVariableDefinition("TEST");
            Action act = () => InvokeCheckAndUpdateVariableType(v, null);
            act.Should().NotThrow();
        }

        [TestMethod]
        public void CheckAndUpdateVariableType_EmptyType_Test()
        {
            var v = new DmnVariableDefinition("TEST");
            Action act = () => InvokeCheckAndUpdateVariableType(v, "");
            act.Should().NotThrow();
        }

        [TestMethod]
        public void CheckAndUpdateVariableType_NullVariable_Test()
        {
            Action act = () => InvokeCheckAndUpdateVariableType(null, "string");
            act.Should().NotThrow();
        }

        [TestMethod]
        public void CheckAndUpdateVariableType_Match_Test()
        {
            var v = new DmnVariableDefinition("TEST", typeof(int));
            Action act = () => InvokeCheckAndUpdateVariableType(v, "integer");
            act.Should().NotThrow();
        }

        [TestMethod]
        public void CheckAndUpdateVariableType_NotMatch_Test()
        {
            var v = new DmnVariableDefinition("TEST", typeof(long));
            Action act = () => InvokeCheckAndUpdateVariableType(v, "integer");
            act.Should().Throw<DmnParserException>().WithMessage("Types for variable TEST don't match*");
        }

        private static void InvokeCheckAndUpdateVariableType(DmnVariableDefinition var, string typeStr)
        {
            var dummyModel = new DmnModel();
            var definitionFactory = TestTools.InvokeNonPublicCtor<DmnDefinitionFactory>(dummyModel) as DmnDefinitionFactory;
            TestTools.InvokeNonPublicMethod(definitionFactory,"CheckAndUpdateVariableType", var, typeStr);
        }

        [TestMethod]
        public void ParseTypesTest()
        {
            var ctx = CTX("datatypes.dmn");
            ctx.Should().NotBeNull();

            ctx.Variables["string"].Type.Should().Be(typeof(string));
            ctx.Variables["int"].Type.Should().Be(typeof(int));
            ctx.Variables["bool"].Type.Should().Be(typeof(bool));
            ctx.Variables["long"].Type.Should().Be(typeof(long));
            ctx.Variables["double"].Type.Should().Be(typeof(double));
            ctx.Variables["date"].Type.Should().Be(typeof(DateTime));
        }

        [TestMethod]
        public void ParseTypesErrTest()
        {
            Action act = () => DmnExecutionContextFactory.CreateExecutionContext(MODEL("datatypes_err.dmn"));
            act.Should().Throw<DmnParserException>().WithMessage("Unsupported type name datetime");
        }
    }
}
