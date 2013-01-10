using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            //8.	Write an expression that calculates trapezoid's area by given sides a and b and height h.
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            float area = ((a + b) / (float)2) * h;
            Console.WriteLine("Area = "+area);
        }
    }
}
