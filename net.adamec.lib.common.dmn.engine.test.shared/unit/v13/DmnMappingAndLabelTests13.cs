using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.decisions.expression;
using net.adamec.lib.common.dmn.engine.engine.decisions.table;
using net.adamec.lib.common.dmn.engine.engine.execution.context;

namespace net.adamec.lib.common.dmn.engine.test.unit
{

    [TestClass]
    public class DmnMappingAndLabelTests13 : DmnTestBase
    {

        protected override SourceEnum Source => SourceEnum.File13;
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
            // camunda:inputVariable not processed in 1_3, so just to keep the similar inputs like in 1_3ext
            //----------------------------

            // ReSharper disable once PossibleNullReferenceException
            d.Inputs[0].Variable.Should().BeNull();
            d.Inputs[0].Expression.Should().Be("a"); //Expression set
            d.Inputs[0].Label.Should().Be("In1"); //label set

            d.Inputs[1].Variable.Should().BeNull();
            d.Inputs[1].Expression.Should().Be("c_c"); //Expression set
            d.Inputs[1].Label.Should().Be("Input#2"); //label not set, variable not set, default Input#2 

            d.Inputs[2].Variable.Should().BeNull();
            d.Inputs[2].Expression.Should().Be("c c"); //Expression set
            d.Inputs[2].Label.Should().Be("In3"); //label set

            //----------------------------
            // expression
            //----------------------------

            d.Inputs[3].Variable.Should().BeNull();//expression set, so no variable; in v1_3ext variable will be "a"
            d.Inputs[3].Expression.Should().Be("a"); //expression set; in v1_3ext it will be null as "a" is know variable
            d.Inputs[3].Label.Should().Be("In 4"); //label set

            d.Inputs[4].Variable.Should().BeNull();//expression set, so no variable; in v1_3ext variable will be "c_c"
            d.Inputs[4].Expression.Should().Be("c c");//expression set; in v1_3ext it will be null as "c c" is "c_c" after normalization and it is know variable
            d.Inputs[4].Label.Should().Be("Input#5"); //label not set, variable not set, default Input#5; in v1_3ext label will be "c c" as "non-normalized" variable name


            d.Inputs[5].Variable.Should().BeNull();//expression set, so no variable; in v1_3ext variable will be "c_c"
            d.Inputs[5].Expression.Should().Be("c_c");//expression set; in v1_3ext it will be null as "c_c" is know variable
            d.Inputs[5].Label.Should().Be("Input#6"); //label not set, variable not set, default Input#6; in v1_3ext label will be "c_c" as variable name

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

            //This is just to keep similar inputs, in 1_3ext test DMN model the expression is in label and it will fail in 1_3
            d.Inputs[10].Variable.Should().BeNull();
            d.Inputs[10].Expression.Should().Be("a+\">\"");
            d.Inputs[10].Label.Should().Be("Input#11"); //label not set, no variable -> default

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
            d.Outputs[0].Variable.Name.Should().Be("To1");//label has priority over output name (Note: in 1_3ext, the variable name will be "to1" as the output name has priority there)
            d.Outputs[0].Label.Should().Be("To1"); //has label

            //The following provide same results in DMN 1_3 and 1_3ext:

            d.Outputs[1].Variable.Name.Should().Be("To_2"); //has no output name, use normalized label
            d.Outputs[1].Label.Should().Be("To 2"); //has label

            d.Outputs[2].Variable.Name.Should().Be("to3"); //has output name, but no label -> use the output name
            d.Outputs[2].Label.Should().Be("to3"); //has no label, use output name

            d.Outputs[3].Variable.Name.Should().Be("to_4"); //has output name, needs to be normalized
            d.Outputs[3].Label.Should().Be("to 4"); //has no label, use output name

            d.Outputs[4].Variable.Name.Should().Be("to5"); //has no output name, no label, use ID
            d.Outputs[4].Label.Should().Be("Output#5"); //has no label, no output name, use default (Output#5)

        }
    }
}
