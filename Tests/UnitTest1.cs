using ShapesLib.Models;

namespace Tests
{
    [TestClass]
    public class UnitTestTriangle
    {
        private const double EPSYLON = 1e-3;

        [TestMethod]
        public void RightAngledTriangleTest()
        {
            var rightAngledTriangle = new TriangleModel(3, 4, 5);
            var actualPerimeter = 12;
            var actualArea = 6;

            var testPerimeter = rightAngledTriangle.GetPerimeter();
            var testArea = rightAngledTriangle.GetArea();

            Assert.AreEqual(testPerimeter, actualPerimeter, EPSYLON);
            Assert.AreEqual(testArea, actualArea, EPSYLON);
        }

        [TestMethod]
        public void EquilateralTriangleTest()
        {
            var equilateralTriangle = new TriangleModel(6, 6, 6);
            var actualPerimeter = 18;
            var actualArea = 15.588;

            var testPerimeter = equilateralTriangle.GetPerimeter();
            var testArea = equilateralTriangle.GetArea();

            Assert.AreEqual(testPerimeter, actualPerimeter, EPSYLON);
            Assert.AreEqual(testArea, actualArea, EPSYLON);
        }

        [TestMethod]
        public void RightTriangleTest()
        {
            var rightTriangle = new TriangleModel(3, 4, 5);
            var actualPerimeter = 12;
            var actualArea = 6;

            var testPerimeter = rightTriangle.GetPerimeter();
            var testArea = rightTriangle.GetArea();
            var testIsRight = rightTriangle.IsRight();

            Assert.AreEqual(testPerimeter, actualPerimeter, EPSYLON);
            Assert.AreEqual(testArea, actualArea, EPSYLON);
            Assert.IsTrue(testIsRight);
        }
    }

    [TestClass]
    public class UnitTestCircle
    {
        private const double EPSYLON = 1e-3;

        [TestMethod]
        public void CircleTest()
        {
            var circle = new CircleModel(5);
            var actualCircumference = 31.415;
            var actualArea = 78.539;

            var testCircumference = circle.GetPerimeter();
            var testArea = circle.GetArea();

            Assert.AreEqual(testArea, actualArea, EPSYLON);
            Assert.AreEqual(testCircumference, actualCircumference, EPSYLON);
        }
    }
}