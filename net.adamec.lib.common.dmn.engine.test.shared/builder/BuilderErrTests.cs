using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.definition.builder;

namespace net.adamec.lib.common.dmn.engine.test.builder
{
    [TestClass]
    [TestCategory("Builder Error Tests")]
    public class BuilderErrTests
    {
        [TestMethod]
        public void DefinitionBuilderErr()
        {
            // ReSharper disable once JoinDeclarationAndInitializer
            Action act;
            // ReSharper disable once NotAccessedVariable
            Variable.Ref varRef;
            // ReSharper disable once NotAccessedVariable
            Decision.Ref decRef;

            var def = new DmnDefinitionBuilder()
                .WithInput<string>("a")
                .WithVariable<string>("aa")
                .WithVariable<string>("b", out var variableRef)
                .WithExpressionDecision("ed", "input+1", variableRef);
            
            //inputs
            act = () => def.WithInputs<string>("i1", "i2", null, "i3");
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithInput(null);
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithInput(" ");
            act.Should().Throw<ArgumentException>();
            act = () => def.WithInput<string>(null);
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithInput<string>(" ");
            act.Should().Throw<ArgumentException>();
            act = () => def.WithInput<string>(null, out varRef);
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithInput<string>(" ", out varRef);
            act.Should().Throw<ArgumentException>();
            act = () => def.WithInput(null, typeof(string));
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithInput(" ", typeof(string));
            act.Should().Throw<ArgumentException>();
            act = () => def.WithInput(null, typeof(string), out varRef);
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithInput(" ", typeof(string), out varRef);
            act.Should().Throw<ArgumentException>();

            act = () => def.WithInput("a");
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate input variable name*");
            act = () => def.WithInput<string>("a");
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate input variable name*");
            act = () => def.WithInput<string>("a", out varRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate input variable name*");
            act = () => def.WithInput("a", typeof(string));
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate input variable name*");
            act = () => def.WithInput("a", typeof(string), out varRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate input variable name*");
            act = () => def.WithInput("aa");
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
            act = () => def.WithInput<string>("aa");
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
            act = () => def.WithInput<string>("aa", out varRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
            act = () => def.WithInput("aa", typeof(string));
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
            act = () => def.WithInput("aa", typeof(string), out varRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");

            //variables
            act = () => def.WithVariables<string>("v1", "v2", null, "v3");
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithVariable<string>(null);
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithVariable<string>(" ");
            act.Should().Throw<ArgumentException>();
            act = () => def.WithVariable<string>(null, out varRef);
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithVariable<string>(" ", out varRef);
            act.Should().Throw<ArgumentException>();
            act = () => def.WithVariable(null, typeof(string));
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithVariable(" ", typeof(string));
            act.Should().Throw<ArgumentException>();
            act = () => def.WithVariable(null, typeof(string), out varRef);
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithVariable(" ", typeof(string), out varRef);
            act.Should().Throw<ArgumentException>();

            act = () => def.WithVariable<string>("a");
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
            act = () => def.WithVariable<string>("b");
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
            act = () => def.WithVariable<string>("a", out varRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
            act = () => def.WithVariable<string>("b", out varRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
            act = () => def.WithVariable("a", typeof(string));
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
            act = () => def.WithVariable("b", typeof(string));
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
            act = () => def.WithVariable("a", typeof(string), out varRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
            act = () => def.WithVariable("b", typeof(string), out varRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");

            //expression decision
            act = () => def.WithExpressionDecision(null, "input+1", variableRef);
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithExpressionDecision(" ", "input+1", variableRef);
            act.Should().Throw<ArgumentException>();
            act = () => def.WithExpressionDecision(null, "input+1", variableRef,out decRef);
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithExpressionDecision(" ", "input+1", variableRef, out decRef);
            act.Should().Throw<ArgumentException>();
            act = () => def.WithExpressionDecision(null, b => b.Put("input+1").To(variableRef));
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithExpressionDecision(" ", b => b.Put("input+1").To(variableRef));
            act.Should().Throw<ArgumentException>();
            act = () => def.WithExpressionDecision(null, b => b.Put("input+1").To(variableRef), out decRef);
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithExpressionDecision(" ", b => b.Put("input+1").To(variableRef), out decRef);
            act.Should().Throw<ArgumentException>();

            act = () => def.WithExpressionDecision("ed", "input+2", variableRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Decision ed already exists");
            act = () => def.WithExpressionDecision("ed", "input+2", variableRef,out decRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Decision ed already exists");
            act = () => def.WithExpressionDecision("ed", b => b.Put("input+1").To(variableRef));
            act.Should().Throw<DmnBuilderException>().WithMessage("Decision ed already exists");
            act = () => def.WithExpressionDecision("ed", b => b.Put("input+1").To(variableRef), out decRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Decision ed already exists");

            act = () => def.WithExpressionDecision("ed2", null);
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithExpressionDecision("ed2", null,out decRef);
            act.Should().Throw<ArgumentNullException>();

            //table decision
            act = () => def.WithTableDecision(null, t => DummyTable(t, variableRef));
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithTableDecision(" ", t => DummyTable(t, variableRef));
            act.Should().Throw<ArgumentException>();
            act = () => def.WithTableDecision(null, t => DummyTable(t, variableRef),out decRef);
            act.Should().Throw<ArgumentNullException>();
            act = () => def.WithTableDecision(" ", t => DummyTable(t, variableRef), out decRef);
            act.Should().Throw<ArgumentException>();

            act = () => def.WithTableDecision("ed", t => DummyTable(t, variableRef));
            act.Should().Throw<DmnBuilderException>().WithMessage("Decision ed already exists");
            act = () => def.WithTableDecision("ed", t => DummyTable(t, variableRef), out decRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Decision ed already exists");

            act = () => def.WithTableDecision("f", null);
            act.Should().Throw<ArgumentException>();
            act = () => def.WithTableDecision("f", null, out decRef);
            act.Should().Throw<ArgumentNullException>();


            // --------------------------
            //  BUILD
            // --------------------------
            def.IsBuilt.Should().Be(false);
            def.Build();
            def.IsBuilt.Should().Be(true);
            // --------------------------
            //  AFTER BUILD
            // --------------------------
            act = () => def.Build();
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");


            act = () => def.WithInputs<string>("a", "b");
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithInput("a");
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithInput<string>("a");
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithInput<string>("a", out varRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithInput("b", typeof(string));
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithInput("c", typeof(string), out varRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");


            act = () => def.WithVariables<string>("a", "b");
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithVariable<string>("c");
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithVariable<string>("c", out varRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithVariable("c", typeof(string));
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithVariable("c", typeof(string), out varRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");

            
            act = () => def.WithExpressionDecision("eded", "input+2", variableRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithExpressionDecision("eded", "input+2", variableRef, out decRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithExpressionDecision("eded", b => b.Put("input+1").To(variableRef));
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithExpressionDecision("eded", b => b.Put("input+1").To(variableRef), out decRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");

            act = () => def.WithTableDecision("td", t => DummyTable(t, variableRef));
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");
            act = () => def.WithTableDecision("td", t => DummyTable(t, variableRef), out decRef);
            act.Should().Throw<DmnBuilderException>().WithMessage("Definition is already built");

        }

        [TestMethod]
        public void VariableErr()
        {
            // ReSharper disable once JoinDeclarationAndInitializer
            Action act;
            var def = new DmnDefinitionBuilder()
                .WithVariable<string>("a_a");

            //normalize name 
            act = () => def.WithVariable<string>("v&v");
            act.Should().Throw<ArgumentException>().WithMessage($"Variable name * contains invalid character*");
            act = () => def.WithVariable<string>("1v");
            act.Should().Throw<ArgumentException>().WithMessage($"Variable name * must start with letter*");
            act = () => def.WithVariable<string>(" 1v");
            act.Should().Throw<ArgumentException>().WithMessage($"Variable name * must start with letter*");

            //normalize name - duplicate
            act = () => def.WithVariable<string>("  a a");
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
            act = () => def.WithVariable<string>("  a_a   ");
            act.Should().Throw<DmnBuilderException>().WithMessage("Duplicate variable name*");
        }

        private static TableDecision DummyTable(TableDecision t, Variable.Ref variableRef)
        {
            var tableDecision = t.WithInput(variableRef, out _).WithOutput(variableRef, out _)
                .WithRule("r", r => r.Always().SkipOutput());
            return tableDecision;
        }
    }
}
