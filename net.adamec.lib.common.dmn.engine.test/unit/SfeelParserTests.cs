using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.parser;

namespace net.adamec.lib.common.dmn.engine.test.unit
{
    [TestClass]
    [TestCategory("Code tests - parser")]
    public class SfeelParserTests
    {
        [TestMethod]
        [DataRow("5","o==5")]
        [DataRow("<5", "o<5")]
        [DataRow(">5", "o>5")]
        [DataRow("<=5", "o<=5")]
        [DataRow(">=5", "o>=5")]

        [DataRow("\"a\"", "o==\"a\"")]
        [DataRow("var", "o==var")]

        [DataRow("[1..3]","(o>=1 && o<=3)")]
        [DataRow("[1 .. 3]", "(o>=1 && o<=3)")]
        [DataRow("(1..3)", "(o>1 && o<3)")]
        [DataRow("]1..3[", "(o>1 && o<3)")]
        [DataRow("]1..3)", "(o>1 && o<3)")]
        [DataRow("(1..3[", "(o>1 && o<3)")]
        [DataRow("[1..3[", "(o>=1 && o<3)")]
        [DataRow("[1..3)", "(o>=1 && o<3)")]
        [DataRow("(1..3]", "(o>1 && o<=3)")]
        [DataRow("]1 .. 3]", "(o>1 && o<=3)")]

        [DataRow("5,6,7","o==5 || o==6 || o==7")]
        [DataRow("5, b , 7", "o==5 || o==b || o==7")]
        [DataRow("\"a\",\"b\",c", "o==\"a\" || o==\"b\" || o==c")]

        [DataRow("5, [1..3] , 7", "o==5 || (o>=1 && o<=3) || o==7")]
        [DataRow("5, [1..3] , (7..9), c", "o==5 || (o>=1 && o<=3) || (o>7 && o<9) || o==c")]

        [DataRow("not(5)","!(o==5)")]
        [DataRow("not(>=5)", "!(o>=5)")]
        [DataRow("not(\"a\")", "!(o==\"a\")")]
        [DataRow("not(\"a\",\"b\")", "!(o==\"a\" || o==\"b\")")]
        [DataRow("not( 5, [1..3] , (7..9), c )", "!(o==5 || (o>=1 && o<=3) || (o>7 && o<9) || o==c)")]
        public void SfeelExpressionTest(string expression, string result)
        {
            var res=SfeelParser.ParseInput(expression, "o");

            res.Should().NotBeNull().And.Be(result);

        }

        [TestMethod]
        [DataRow("[]")]
        [DataRow("[1]")]
        [DataRow("[1..2..3]")]
        public void SfeelExpressionWrongRangeTest(string expression)
        {
            Action act=()=> SfeelParser.ParseInput(expression, "o");

            act.Should().Throw<DmnParserException>().WithMessage("Wrong S-FEEL range *");

        }
    }
}
