using System;

namespace task4_TriangeleSurface
{
    class Program
    {
        static public double Area(double a, double h)
        {
            return a * h / 2;
        }

        static public double Area(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        static public double Area(double a, double b, int angle)
        {
            double radians = angle * Math.PI / 180;
            return (a * b * Math.Sin(radians)) / 2;

        }

        static void Main(string[] args)
        {
            //Write methods that calculate the surface of a triangle by given:
            //Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.
            Console.WriteLine(Area(a: 5, b: 3, angle: 90));
            Console.WriteLine(Area(a: 3, b: 4, c: 5));
            Console.WriteLine(Area(a: 5, h: 2));
        }
    }
}
