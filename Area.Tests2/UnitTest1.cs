using NUnit.Framework;
using AreaOfFigures;
using System;

namespace Area.Tests2
{
    [TestFixture]
    public class Tests
    {
        

        [Test]
        public void SingleTest()
        {
            Assert.AreEqual(4, Circle.Area(2));
        }
        public void TestIsTriangle()
        {
            Assert.AreEqual(true, Triangle.IsTriangle(10,10,1));
        }
        public void TestTriangle()
        {
            Assert.AreEqual(false, Triangle.RightTriangle(10,10,1));
        }

        [TestCase(3,4, 5, 6)]  // не нужно помечать атрибутом [Test]
        [TestCase(5, 4, 5, 9.16)]  // не нужно помечать атрибутом [Test]


        public void TestCases(double a, double b, double c, double expectedResult)
        {
            Assert.AreEqual(Math.Round(expectedResult, 2), Math.Round(Triangle.Area(a, b, c), 2));
        }
 
            
    }
}