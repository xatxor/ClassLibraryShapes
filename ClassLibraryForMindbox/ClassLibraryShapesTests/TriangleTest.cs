using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace ClassLibraryShapes.Tests
{
    class TriangleTest
    {
        [Test]
        public void TriangleNegativeSidesTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1,-3,2));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-3,4,2));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0,3,2));
        }
        [Test]
        [TestCase(2,4,3, ExpectedResult = 2.90)]
        [TestCase(5,2,4, ExpectedResult = 3.8)]
        [TestCase(8,8,8, ExpectedResult = 27.71)]
        public double FindSquareTest(double a, double b, double c)
        {
            Triangle triangle = new Triangle(a, b, c);
            return triangle.FindSquare();
        }
        [Test]
        [TestCase(4, 5, 3, ExpectedResult = true)]
        [TestCase(12, 7, 3, ExpectedResult = false)]
        [TestCase(8, 4, 17, ExpectedResult = false)]
        public bool IsRightTest(int a, int b, int c)
        {
            Triangle triangle = new Triangle(a, b, c);
            return triangle.IsRight();
        }
    }
}
