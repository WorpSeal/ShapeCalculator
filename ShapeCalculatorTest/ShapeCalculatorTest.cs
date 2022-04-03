using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeCalculator;
using System;
using ShapeCalc = ShapeCalculator.ShapeCalculator;

namespace ShapeCalculatorTest
{
    [TestClass]
    public class ShapeCalculatorTest
    {
        [TestMethod]
        public void TriangleArea()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, ShapeCalc.ComputeArea(triangle));
        }

        [TestMethod]
        public void CircleArea()
        {
            double r = 2;
            Circle circle = new Circle(r);
            Assert.AreEqual( System.Math.PI * 2 * r, ShapeCalc.ComputeArea(circle));
        }

        [TestMethod]
        public void ShapeCreatorArea()
        {
            double squareSide = 3;
            SquareCreatorTest squareCreator = new SquareCreatorTest(squareSide);
            Assert.AreEqual(squareSide * squareSide, ShapeCalc.ComputeArea(squareCreator.Create()));
        }

        [TestMethod]
        public void IsRightTriangle()
        {
            Assert.IsTrue(ShapeCalc.IsRightTriangle(new Triangle(3, 4, 5)));
        }
    }
}
