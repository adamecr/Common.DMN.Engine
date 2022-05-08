using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace net.adamec.lib.common.dmn.engine.test.unit
{

    [TestClass]
    [TestCategory("Code tests - parser")]
    public class DmnInformationRequirementsTests : DmnTestBase
    {
        [TestMethod]
        public void DirectAndAllRequirementTest()
        {
            var def = DEF("test.dmn");
            def.Should().NotBeNull();
            
            var age10 = def.Decisions["Age +10"];
            age10.Should().NotBeNull();
            age10.RequiredInputs.Select(i => i.Name).Should().BeEquivalentTo(new string[] { "Age" });
            age10.RequiredDecisions.Should().BeEmpty();
            age10.GetAllRequiredInputs().Select(i => i.Name).Should().BeEquivalentTo(new string[] { "Age" });
            age10.GetAllRequiredDecisions().Should().BeEmpty();

            var doubleAge10 = def.Decisions["Double (Age+10)"];
            doubleAge10.Should().NotBeNull();
            doubleAge10.RequiredInputs.Should().BeEmpty();
            doubleAge10.RequiredDecisions.Select(d => d.Name).Should().BeEquivalentTo(new string[] { "Age +10" });
            doubleAge10.GetAllRequiredInputs().Select(i => i.Name).Should().BeEquivalentTo(new string[] { "Age" });
            doubleAge10.GetAllRequiredDecisions().Select(d => d.Name).Should().BeEquivalentTo(new string[] { "Age +10" });

            var mainDt = def.Decisions["MainDT"];
            mainDt.Should().NotBeNull();
            mainDt.RequiredInputs.Select(d => d.Name).Should().BeEquivalentTo(new string[] { "Pocet","Rano","Test","Greeting","Age" });
            mainDt.RequiredDecisions.Select(d => d.Name).Should().BeEquivalentTo(new string[] { "Double (Age+10)" });
            mainDt.GetAllRequiredInputs().Select(i => i.Name).Should().BeEquivalentTo(new string[] { "Pocet", "Rano", "Test", "Greeting", "Age" });
            mainDt.GetAllRequiredDecisions().Select(d => d.Name).Should().BeEquivalentTo(new string[] { "Double (Age+10)","Age +10" });

            var ensureEligible = def.Decisions["Ensure Eligible"];
            ensureEligible.Should().NotBeNull();
            ensureEligible.RequiredInputs.Should().BeEmpty();
            ensureEligible.RequiredDecisions.Select(d => d.Name).Should().BeEquivalentTo(new string[] { "MainDT" });
            ensureEligible.GetAllRequiredInputs().Select(i => i.Name).Should().BeEquivalentTo(new string[] { "Pocet", "Rano", "Test", "Greeting", "Age" });
            ensureEligible.GetAllRequiredDecisions().Select(d => d.Name).Should().BeEquivalentTo(new string[] { "MainDT", "Double (Age+10)", "Age +10" });

            var secondaryDt = def.Decisions["Secondary DT"];
            secondaryDt.Should().NotBeNull();
            secondaryDt.RequiredInputs.Should().BeEmpty();
            secondaryDt.RequiredDecisions.Select(d => d.Name).Should().BeEquivalentTo(new string[] { "Ensure Eligible" });
            secondaryDt.GetAllRequiredInputs().Select(i => i.Name).Should().BeEquivalentTo(new string[] { "Pocet", "Rano", "Test", "Greeting", "Age" });
            secondaryDt.GetAllRequiredDecisions().Select(d => d.Name).Should().BeEquivalentTo(new string[] {"Ensure Eligible", "MainDT", "Double (Age+10)", "Age +10" });

            var categorySuffix = def.Decisions["Category + suffix"];
            categorySuffix.Should().NotBeNull();
            categorySuffix.RequiredInputs.Select(d => d.Name).Should().BeEquivalentTo(new string[] { "Suffix"});
            categorySuffix.RequiredDecisions.Select(d => d.Name).Should().BeEquivalentTo(new string[] { "MainDT" });
            categorySuffix.GetAllRequiredInputs().Select(i => i.Name).Should().BeEquivalentTo(new string[] { "Pocet", "Rano", "Test", "Greeting", "Age" ,"Suffix"});
            categorySuffix.GetAllRequiredDecisions().Select(d => d.Name).Should().BeEquivalentTo(new string[] {  "MainDT", "Double (Age+10)", "Age +10" });
            
        }
    }
}
