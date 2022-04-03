using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShapeCalculator;

namespace ShapeCalculatorTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void WrongSides()
        {
            //Any side is negative or 0
            Assert.ThrowsException<ArgumentException>(() => { var a = new Triangle(-1,3,5); });
            Assert.ThrowsException<ArgumentException>(() => { var a = new Triangle(1,0,5); });
            Assert.ThrowsException<ArgumentException>(() => { var a = new Triangle(1,3,-5); });

            //Impossible triangle
            Assert.ThrowsException<ArgumentException>(() => { var a = new Triangle(1, 3, 0.5); });
        }
    }
}
