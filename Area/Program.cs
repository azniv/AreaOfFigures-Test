using System;
using System.Collections.Generic;
using System.Linq;
using AreaOfFigures;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Circle circle = new Circle(2);
            //Console.WriteLine(Circle.Area(2));
            //Triangle t = new Triangle(10, 5, 1);
            //Console.WriteLine(Triangle.Area(10,5,1));
            foreach (var point in ParsePoints(new[] { "1 -2", "-3 4", "0 2" }))
                Console.WriteLine(point.X + " " + point.Y);
            foreach (var point in ParsePoints(new List<string> { "+01 -0042" }))
                Console.WriteLine(point.X + " " + point.Y);
        }
        public static List<Point> ParsePoints(IEnumerable<string> lines)
        {
            return lines
                .Select(x => new Point(int.Parse(x.Split(' ')[0]), int.Parse(x.Split(' ')[1])))
                .ToList();
               
                
            }
    }
    public class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X, Y;
    }
}
