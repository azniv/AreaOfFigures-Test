using NUnit.Framework;
using AreaOfFigures2;
using System;

namespace AreaTest2
{
    [TestFixture]
    public class Tests
    {


        [Test]
        public void SingleTest()
        {
            Assert.AreEqual(Math.PI, Circle.Area(1));
        }

        [TestCase(10, 10, 1, 4.993746088859544)]
        [TestCase(5, 10, 14, 17.605041891458253)]
        [TestCase(5, 10, 4, Double.NaN)]
        public void TestCases(double a, double  b, double c, double expectedResult)
        {
            Assert.AreEqual(expectedResult, Triangle.Area(a, b, c));
        }
    }
}