using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using net.adamec.lib.common.dmn.engine.engine.definition;
using net.adamec.lib.common.dmn.engine.engine.definition.extensions;
using net.adamec.lib.common.dmn.engine.engine.definition.extensions.diagram;

namespace net.adamec.lib.common.dmn.engine.test.unit
{

    [TestClass]
    public class DmnDiagramExtensionTests13 : DmnTestBase
    {
        protected override SourceEnum Source => SourceEnum.File13;

        [TestMethod]
        public void BasicDiagramTest()
        {
            // ReSharper disable once JoinDeclarationAndInitializer
            IDmnElement element;
            // ReSharper disable once JoinDeclarationAndInitializer
            DiDiagramShapeExtension shape;

            var def = DEF("diagram.dmn");
            def.Should().NotBeNull();
            def.Extensions.Count.Should().Be(1);
            shape = def.GetExtension<DiDiagramShapeExtension>();
            shape.Should().BeNull(); //not there
            var diagram = def.GetExtension<DiDiagramExtension>();
            diagram.Should().NotBeNull();
            diagram.ShapesByElement.Should().HaveCount(12); //12 =6x Input + 6x Decision


            element = def.Decisions["Double (Age+10)"];
            element.Should().NotBeNull();
            element.Extensions.Count.Should().Be(1);
            shape = element.GetExtension<DiDiagramShapeExtension>();
            shape.Should().NotBeNull();
            shape.X.Should().Be(795);
            shape.Y.Should().Be(398);
            shape.Width.Should().Be(180);
            shape.Height.Should().Be(80);

            var shape2 = diagram.ShapesByElement[element];
            shape2.Should().NotBeNull();
            shape2.X.Should().Be(shape.X);
            shape2.Y.Should().Be(shape.Y);
            shape2.Width.Should().Be(shape.Width);
            shape2.Height.Should().Be(shape.Height);

            var shapes = element.GetExtensions<DiDiagramShapeExtension>();
            shapes.Should().NotBeNull();
            shapes.Length.Should().Be(1);
            shapes[0].Should().Be(shape);

            var ext1 = element.GetExtension<object>();
            ext1.Should().NotBeNull(); //DiDiagramShapeExtension is object
            var ext2 = element.GetExtension<string>();
            ext2.Should().BeNull(); //not there
            var ext3 = element.GetExtension<int>();
            ext3.Should().Be(0); //not there
            var ext4 = element.GetExtension<DiDiagramExtension>();
            ext4.Should().BeNull(); //not there
            var ext5 = element.GetExtensions<double>();
            ext5.Should().NotBeNull();
            ext5.Length.Should().Be(0);

            element = def.Decisions["MainDT"];
            element.Should().NotBeNull();
            element.Extensions.Count.Should().Be(1);
            shape = element.GetExtension<DiDiagramShapeExtension>();
            shape.Should().NotBeNull();
            shape.X.Should().Be(436);
            shape.Y.Should().Be(473);
            shape.Width.Should().Be(180);
            shape.Height.Should().Be(80);

            element = def.Decisions["Secondary DT"];
            element.Should().NotBeNull();
            element.Extensions.Count.Should().Be(1);
            shape = element.GetExtension<DiDiagramShapeExtension>();
            shape.Should().NotBeNull();
            shape.X.Should().Be(435);
            shape.Y.Should().Be(625);
            shape.Width.Should().Be(180);
            shape.Height.Should().Be(80);

            element = def.InputData["Age"]; //rsh
            element.Should().NotBeNull();
            element.Extensions.Count.Should().Be(1);
            shape = element.GetExtension<DiDiagramShapeExtension>();
            shape.Should().NotBeNull();
            shape.X.Should().Be(822);
            shape.Y.Should().Be(105);
            shape.Width.Should().Be(125);
            shape.Height.Should().Be(45);

            shape2 = diagram.ShapesByElement[element];
            shape2.Should().NotBeNull();
            shape2.X.Should().Be(shape.X);
            shape2.Y.Should().Be(shape.Y);
            shape2.Width.Should().Be(shape.Width);
            shape2.Height.Should().Be(shape.Height);

            element = def.InputData["Rano"]; //kn0p
            element.Should().NotBeNull();
            element.Extensions.Count.Should().Be(1);
            shape = element.GetExtension<DiDiagramShapeExtension>();
            shape.Should().NotBeNull();
            shape.X.Should().Be(376);
            shape.Y.Should().Be(81);
            shape.Width.Should().Be(125);
            shape.Height.Should().Be(45);

            element = def.InputData["Test"]; //3e0
            element.Should().NotBeNull();
            element.Extensions.Count.Should().Be(1);
            shape = element.GetExtension<DiDiagramShapeExtension>();
            shape.Should().NotBeNull();
            shape.X.Should().Be(520);
            shape.Y.Should().Be(100);
            shape.Width.Should().Be(125);
            shape.Height.Should().Be(45);


        }

        [TestMethod]
        public void PartialDiagramTest()
        {
            // ReSharper disable once JoinDeclarationAndInitializer
            IDmnElement element;
            // ReSharper disable once JoinDeclarationAndInitializer
            DiDiagramShapeExtension shape;

            var def = DEF("diagram_partial.dmn");
            def.Should().NotBeNull();
            def.Extensions.Count.Should().Be(1);
            shape = def.GetExtension<DiDiagramShapeExtension>();
            shape.Should().BeNull(); //not there
            var diagram = def.GetExtension<DiDiagramExtension>();
            diagram.Should().NotBeNull();
            diagram.ShapesByElement.Should().HaveCount(10); //10 =5x Input + 5x Decision (1 input and 1 decision are w/o shape "record")


            element = def.Decisions["Double (Age+10)"];
            element.Should().NotBeNull();
            element.Extensions.Count.Should().Be(0);
            shape = element.GetExtension<DiDiagramShapeExtension>();
            shape.Should().BeNull();

            var shape2Result = diagram.ShapesByElement.TryGetValue(element,out var shape2);
            shape2Result.Should().BeFalse();
            shape2.Should().BeNull();

            element = def.Decisions["MainDT"];
            element.Should().NotBeNull();
            element.Extensions.Count.Should().Be(1);
            shape = element.GetExtension<DiDiagramShapeExtension>();
            shape.Should().NotBeNull();
            shape.X.Should().Be(436);
            shape.Y.Should().Be(473);
            shape.Width.Should().Be(180);
            shape.Height.Should().Be(80);

            element = def.Decisions["Secondary DT"];
            element.Should().NotBeNull();
            element.Extensions.Count.Should().Be(1);
            shape = element.GetExtension<DiDiagramShapeExtension>();
            shape.Should().NotBeNull();
            shape.X.Should().Be(435);
            shape.Y.Should().Be(625);
            shape.Width.Should().Be(180);
            shape.Height.Should().Be(80);

            element = def.InputData["Age"]; //rsh
            element.Should().NotBeNull();
            element.Extensions.Count.Should().Be(0);
            shape = element.GetExtension<DiDiagramShapeExtension>();
            shape.Should().BeNull();

            shape2Result = diagram.ShapesByElement.TryGetValue(element, out shape2);
            shape2Result.Should().BeFalse();
            shape2.Should().BeNull();

            element = def.InputData["Rano"]; //kn0p
            element.Should().NotBeNull();
            element.Extensions.Count.Should().Be(1);
            shape = element.GetExtension<DiDiagramShapeExtension>();
            shape.Should().NotBeNull();
            shape.X.Should().Be(376);
            shape.Y.Should().Be(81);
            shape.Width.Should().Be(125);
            shape.Height.Should().Be(45);

            shape2 = diagram.ShapesByElement[element];
            shape2.Should().NotBeNull();
            shape2.X.Should().Be(shape.X);
            shape2.Y.Should().Be(shape.Y);
            shape2.Width.Should().Be(shape.Width);
            shape2.Height.Should().Be(shape.Height);

            element = def.InputData["Test"]; //3e0
            element.Should().NotBeNull();
            element.Extensions.Count.Should().Be(1);
            shape = element.GetExtension<DiDiagramShapeExtension>();
            shape.Should().NotBeNull();
            shape.X.Should().Be(520);
            shape.Y.Should().Be(100);
            shape.Width.Should().Be(125);
            shape.Height.Should().Be(45);


        }

        [TestMethod]
        public void EmptyDiagramTest()
        {
            // ReSharper disable once JoinDeclarationAndInitializer
            IDmnElement element;
            // ReSharper disable once JoinDeclarationAndInitializer
            DiDiagramShapeExtension shape;

            var def = DEF("diagram_empty.dmn");
            def.Should().NotBeNull();
            def.Extensions.Count.Should().Be(0);
            shape = def.GetExtension<DiDiagramShapeExtension>();
            shape.Should().BeNull(); //not there
            var diagram = def.GetExtension<DiDiagramExtension>();
            diagram.Should().BeNull(); //not there


            element = def.Decisions["Double (Age+10)"];
            element.Should().NotBeNull();
            element.Extensions.Count.Should().Be(0);
            shape = element.GetExtension<DiDiagramShapeExtension>();
            shape.Should().BeNull();

            var ext1 = element.GetExtension<object>();
            ext1.Should().BeNull(); //not there
            var ext2 = element.GetExtension<string>();
            ext2.Should().BeNull(); //not there
            var ext3 = element.GetExtension<int>();
            ext3.Should().Be(0); //not there
            var ext4 = element.GetExtension<DiDiagramExtension>();
            ext4.Should().BeNull(); //not there


            element = def.Decisions["MainDT"];
            element.Should().NotBeNull();
            element.Extensions.Count.Should().Be(0);
            shape = element.GetExtension<DiDiagramShapeExtension>();
            shape.Should().BeNull();

            element = def.Decisions["Secondary DT"];
            element.Should().NotBeNull();
            element.Extensions.Count.Should().Be(0);
            shape = element.GetExtension<DiDiagramShapeExtension>();
            shape.Should().BeNull();

            element = def.InputData["Age"]; //rsh
            element.Should().NotBeNull();
            element.Extensions.Count.Should().Be(0);
            shape = element.GetExtension<DiDiagramShapeExtension>();
            shape.Should().BeNull();

            element = def.InputData["Rano"]; //kn0p
            element.Should().NotBeNull();
            element.Extensions.Count.Should().Be(0);
            shape = element.GetExtension<DiDiagramShapeExtension>();
            shape.Should().BeNull();

            element = def.InputData["Test"]; //3e0
            element.Should().NotBeNull();
            element.Extensions.Count.Should().Be(0);
            shape = element.GetExtension<DiDiagramShapeExtension>();
            shape.Should().BeNull();


        }
    }
}
