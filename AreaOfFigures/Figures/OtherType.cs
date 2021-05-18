using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfFigures
{
    public class OtherType : IFigure
    {
        public OtherType()
        {

        }
        public OtherType(IFigure figure)
        {
            shape = figure;
        }
        private IFigure shape;
        public double Area() => shape.Area();
       

      
    }
}
