using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace ClassLibraryShapes.Tests
{
    class CircleTest
    {
        [Test]
        public void CircleNegativeRadiusTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-3));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(0));
        }
        [Test]
        [TestCase(2, ExpectedResult = 12.57)]
        [TestCase(5, ExpectedResult = 78.54)]
        [TestCase(8, ExpectedResult = 201.06)]
        public double FindSquareTest(int r)
        { 
            Circle circle = new Circle(r);
            return circle.FindSquare();
        }
    }
}
