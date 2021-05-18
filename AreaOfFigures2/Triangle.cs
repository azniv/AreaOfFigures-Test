using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfFigures2
{
    public class Triangle
    {
        public static double Area( double a, double b, double c)
        {
            double p = (a + b + c) / 2;  // полупериметр треугольника
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        // существует ли треугольник
        public bool IsTriangle(double a, double b, double c)
        {
            return (a + b > c) || (b + c > a) || (a + c > b);
        }
    }
}
