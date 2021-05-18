using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfFigures
{
    public  class Triangle : IFigure
    {
        public Triangle()
        {

        }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        // стороны треугольника
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

     
        // вычисление площади по трем сторонам 
        public  double Area ()
        {
            double  p = (A + B + C) / 2;  // полупериметр треугольника
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); 
        }

        // существует ли треугольник
        public  bool IsTriangle()
        {
            return (A + B > C) || (B + C > A) || (A + C > B);
        }

        //проверка является ли треугольник прямоугольным
        public  bool RightTriangle()
        {
            return (A == Math.Sqrt(Math.Pow(B, 2) + Math.Pow(C, 2)) || A == Math.Sqrt(Math.Pow(B, 2) + Math.Pow(C, 2))
                || C == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2)));
        }
      
    }
}
