using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AreaOfFigures;
namespace Area.Tests
{
    [TestClass]
    public class AreaTest
    {
        [TestMethod]
        public void AreaFigure()
        {
            //arrange
            var a = 10;
            var b = 10;
            var c = 1;

            //act
            Circle circle = new Circle(1);
            double radius = circle.Area();
            //assert
            Assert.AreEqual(Math.PI, radius);
           // Assert.AreEqual(4.993746088859544, result2);
            
        }
    }
}
