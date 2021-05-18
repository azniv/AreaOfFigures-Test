using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaOfFigures;
using System;

namespace AreaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AreaEquation()
        {
            Circle circle = new Circle(1);
            Circle circle1 = new Circle(10);
            Triangle triangle = new Triangle(10,10,1); 


            var radius = circle.Area();

            Assert.AreEqual(Math.PI, radius);
            Assert.AreEqual(Math.PI*circle1.Radius*circle1.Radius, circle1.Area());
            Assert.AreEqual(4.993746088859544, triangle.Area());

        }
    }
}
