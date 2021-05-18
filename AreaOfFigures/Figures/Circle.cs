using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfFigures
{
    public class Circle : IFigure
    {
        public Circle()
        {

        }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public int Radius { get; set; }
       
        public  double Area ()=> Math.PI * Radius * Radius;

    }
}
