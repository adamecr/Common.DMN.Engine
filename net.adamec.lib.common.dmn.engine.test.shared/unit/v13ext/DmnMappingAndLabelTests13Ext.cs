using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.decisions.expression;
using net.adamec.lib.common.dmn.engine.engine.decisions.table;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.engine.execution.context;
using net.adamec.lib.common.dmn.engine.parser;

namespace net.adamec.lib.common.dmn.engine.test.unit
{

    [TestClass]
    public class DmnMappingAndLabelTests13Ext : DmnTestBase
    {
        protected override SourceEnum Source => SourceEnum.File13ext;
        // DMN 1_3 and 1_3ext mappingAndLabel.dmn XML models are created as close as possible,
        // so the DmnMappingAndLabelTests13 and DmnMappingAndLabelTests13Ext can illustrate
        // the differences how the definition is built from same source using the different setting.
        // Keep such differences in mind when migrating as it can lead to non-parseable models or
        // unexpected behavior!!!


        // However, the 1_3 version of XML model had to be adjusted in some cases related to the 
        // table input mapping, otherwise it will throw the DMNParserException. 
        // This is mainly related to:
        //  - Using camunda:inputVariable attribute without label (in 1_3 the label is used for mapping to variable and camunda:inputVariable is not used at all)
        //  - Definition of input expression in label only (valid in 1_3ext, but v1_3 will try to map it to variable and it will throw invalid character exception in variable name in most cases 

        [TestMethod]
        public virtual void InputMappingAndLabelTest()
        {
            var def = DEF("mappingAndLabel.dmn");
            def.Should().NotBeNull();

            //The following provide same results in DMN 1_3 and 1_3ext:

            var a = def.InputData["a"]; //"standard" Name from name, label from name
            a.Should().NotBeNull();
            a.Label.Should().Be("a");

            var i1 = def.InputData["i_1"]; //Name from name; normalized
            i1.Should().NotBeNull();
            i1.Label.Should().Be("i 1"); //label from name

            var i2 = def.InputData["InputData_I2"]; //Name from ID
            i2.Should().NotBeNull();
            i2.Label.Should().Be("InputData_I2"); //label from ID

        }

        [TestMethod]
        public virtual void DecisionMappingAndLabelTest()
        {
            var def = DEF("mappingAndLabel.dmn");
            def.Should().NotBeNull();

            //The following provide same results in DMN 1_3 and 1_3ext:

            var d1 = def.Decisions["Decision 1"]; //Name from name, no normalization
            d1.Should().NotBeNull();
            d1.Label.Should().Be("Decision 1");//label from name

            var d2 = def.Decisions["Decision_ID2"]; //Name from ID
            d2.Should().NotBeNull();
            d2.Label.Should().Be("Decision_ID2"); //label from ID
        }

        [TestMethod]
        public virtual void ExpressionDecisionMappingAndLabelTest()
        {
            var def = DEF("mappingAndLabel.dmn");
            def.Should().NotBeNull();
            var ctx = DmnExecutionContextFactory.CreateExecutionContext(def);
            ctx.WithInputParameter("a", "val a");
            ctx.WithInputParameter("i_1", "val i1");
            ctx.WithInputParameter("InputData_I2", "val i2");

            //The following provide same results in DMN 1_3 and 1_3ext:

            var d1 = def.Decisions["Decision 1"] as DmnExpressionDecision;
            d1.Should().NotBeNull();
            // ReSharper disable once PossibleNullReferenceException
            d1.Output.Name.Should().Be("b_1"); //from name, normalized
            d1.Output.Label.Should().Be("b 1"); //from name, not normalized
            var rd1 = ctx.ExecuteDecision(d1);
            rd1.First["b_1"].Value.Should().Be("val i1");

            var d2 = def.Decisions["Decision_ID2"] as DmnExpressionDecision;
            d2.Should().NotBeNull();
            // ReSharper disable once PossibleNullReferenceException
            d2.Output.Name.Should().Be("b2"); //from name, no normalization
            d2.Output.Name.Should().Be("b2"); //from name, no normalization
            var rd2 = ctx.ExecuteDecision(d2);
            rd2.First["b2"].Value.Should().Be("val i2");

            var d3 = def.Decisions["Decision 3"] as DmnExpressionDecision;
            d3.Should().NotBeNull();
            // ReSharper disable once PossibleNullReferenceException
            d3.Output.Name.Should().Be("b3"); //from id, no normalization
            d3.Output.Label.Should().Be("b3"); //from id, no normalization
            var rd3 = ctx.ExecuteDecision(d3);
            rd3.First["b3"].Value.Should().Be("val a");
        }

        [TestMethod]
        public virtual void TableInputMappingAndLabelTest()
        {
            var def = DEF("mappingAndLabel.dmn");
            def.Should().NotBeNull();


            var d = def.Decisions["Decision 4"] as DmnDecisionTable;
            d.Should().NotBeNull();

            //----------------------------
            // camunda:inputVariable
            //----------------------------

            /* This would fail in v1_3 - missing Input/Variable "In1"as it will try to get variable name from label (camunda:inputVariable is ignored there)
               <input id="InputClause_1rse01f" label="In1" camunda:inputVariable="a">
                 <inputExpression id="LiteralExpression_08gpjl1" typeRef="string" />
               </input>             
             */

            // ReSharper disable once PossibleNullReferenceException
            d.Inputs[0].Variable.Name.Should().Be("a"); //camunda:inputVariable
            d.Inputs[0].Expression.Should().BeNull();
            d.Inputs[0].Label.Should().Be("In1"); //label set

            /* This would fail in v1_3 - missing Input/Variable "InputClause_050h3zz" as it will try to get variable name from id (camunda:inputVariable is ignored there)
              <input id="InputClause_050h3zz" camunda:inputVariable="c_c">
                <inputExpression id="LiteralExpression_118rvrs" typeRef="string">
                  <text></text>
                </inputExpression>
              </input>
             */

            d.Inputs[1].Variable.Name.Should().Be("c_c"); //camunda:inputVariable
            d.Inputs[1].Expression.Should().BeNull();
            d.Inputs[1].Label.Should().Be("c_c"); //label not set, from variable

            /* This would fail in v1_3 - missing Input/Variable "In3" as it will try to get variable name from label (camunda:inputVariable is ignored there)
              <input id="InputClause_1eu2ctl" label="In3" camunda:inputVariable="c c">
                 <inputExpression id="LiteralExpression_0yw1eod" typeRef="string">
                   <text></text>
                 </inputExpression>
              </input>
             */

            d.Inputs[2].Variable.Name.Should().Be("c_c"); //camunda:inputVariable, normalized ("c c" in DMN)
            d.Inputs[2].Expression.Should().BeNull();
            d.Inputs[2].Label.Should().Be("In3"); //label set

            //----------------------------
            // expression
            //----------------------------

            d.Inputs[3].Variable.Name.Should().Be("a");//expression that is variable; it will be null in v1_3 - expression set, so no variable
            d.Inputs[3].Expression.Should().BeNull(); //expression that is variable, so variable is set, expression is null; it will be "a" in v1_3 as the expression has priority over variable
            d.Inputs[3].Label.Should().Be("In 4"); //label set

            d.Inputs[4].Variable.Name.Should().Be("c_c");//expression that is variable, normalized ("c c" in DMN); it will be null in v1_3 - expression set, so no variable
            d.Inputs[4].Expression.Should().BeNull();//expression that is variable (after normalization), so variable is set, expression is null; it will be "c c" in v1_3 as the expression has priority over variable
            d.Inputs[4].Label.Should().Be("c c"); //label not set, from variable as in expression xml  (non normalized); in v1_3 label not set, variable not set, defaults to Input#5


            d.Inputs[5].Variable.Name.Should().Be("c_c");//expression that is variable; it will be null in v1_3 - expression set, so no variable
            d.Inputs[5].Expression.Should().BeNull();//expression that is variable, so variable is set, expression is null; it will be "c_c" in v1_3 as the expression has priority over variable
            d.Inputs[5].Label.Should().Be("c_c"); //label not set, from variable; in v1_3 label not set, variable not set, defaults to Input#6

            //The following provide same results in DMN 1_3 and 1_3ext:

            d.Inputs[6].Variable.Should().BeNull();//expression that is not variable
            d.Inputs[6].Expression.Should().Be("a+\">\"");
            d.Inputs[6].Label.Should().Be("Input#7"); //label not set, no variable -> default

            //----------------------------
            // label
            //----------------------------

            //The following provide same results in DMN 1_3 and 1_3ext:
            d.Inputs[7].Variable.Name.Should().Be("a");//label that is variable
            d.Inputs[7].Expression.Should().BeNull();
            d.Inputs[7].Label.Should().Be("a"); //label set

            d.Inputs[8].Variable.Name.Should().Be("c_c");//label that is variable, normalized ("c c" in DMN)
            d.Inputs[8].Expression.Should().BeNull();
            d.Inputs[8].Label.Should().Be("c c"); //label set


            d.Inputs[9].Variable.Name.Should().Be("c_c");//label that is variable
            d.Inputs[9].Expression.Should().BeNull();
            d.Inputs[9].Label.Should().Be("c_c"); //label set


            /* This would fail in v1_3 -  Variable name 'a+">"' contains invalid character
             <input id="InputClause_1uhtnoj" label="a+&#34;&#62;&#34;">
                <inputExpression id="LiteralExpression_1cwx9xs" typeRef="string">
                  <text></text>
                </inputExpression>
             </input>
            */
            d.Inputs[10].Variable.Should().BeNull();//label that is not variable
            d.Inputs[10].Expression.Should().Be("a+\">\"");
            d.Inputs[10].Label.Should().Be("a+\">\""); //label set

            //----------------------------
            // id
            //----------------------------
            
            //The following provide same results in DMN 1_3 and 1_3ext:
            d.Inputs[11].Variable.Name.Should().Be("a");//id that is variable
            d.Inputs[11].Expression.Should().BeNull();
            d.Inputs[11].Label.Should().Be("a"); //label not set, from variable

            d.Inputs[12].Variable.Name.Should().Be("c_c");//id that is variable
            d.Inputs[12].Expression.Should().BeNull();
            d.Inputs[12].Label.Should().Be("c_c"); //label not set, from variable


        }

        [TestMethod]
        public virtual void TableOutputMappingAndLabelTest()
        {
            var def = DEF("mappingAndLabel.dmn");
            def.Should().NotBeNull();


            var d = def.Decisions["Decision 5"] as DmnDecisionTable;
            d.Should().NotBeNull();

            // ReSharper disable once PossibleNullReferenceException
            d.Outputs[0].Variable.Name.Should().Be("to1"); //has output name. Output name has priority over label  (Note: in 1_3, the variable name will be "To1" as the label has priority there)
            d.Outputs[0].Label.Should().Be("To1"); //has label

            //The following provide same results in DMN 1_3 and 1_3ext:

            d.Outputs[1].Variable.Name.Should().Be("To_2"); //has no output name, use normalized label
            d.Outputs[1].Label.Should().Be("To 2"); //has label

            d.Outputs[2].Variable.Name.Should().Be("to3"); //has output name
            d.Outputs[2].Label.Should().Be("to3"); //has no label, use output name

            d.Outputs[3].Variable.Name.Should().Be("to_4"); //has output name, needs to be normalized
            d.Outputs[3].Label.Should().Be("to 4"); //has no label, use output name

            d.Outputs[4].Variable.Name.Should().Be("to5"); //has no output name, no label, use ID
            d.Outputs[4].Label.Should().Be("Output#5"); //has no label, no output name, use default (Output#5)

        }

        [TestMethod]
        public virtual void TableInputWrongInputVariableTest()
        {
            var model = MODEL("mappingAndLabel_wrong_tblInputInputVarName.dmn");

            Action act = () => DmnDefinitionFactory.CreateDmnDefinition(model);
            act.Should().Throw<DmnParserException>().WithMessage("Input variable * for decision table * not found");
        }

        [TestMethod]
        public virtual void TableInputWrongInputIdTest()
        {
            var model = MODEL("mappingAndLabel_wrong_tblInputId.dmn");

            Action act = () => DmnDefinitionFactory.CreateDmnDefinition(model);
            act.Should().Throw<DmnParserException>().WithMessage("Input#* for decision table * has no source");
        }
    }
}
