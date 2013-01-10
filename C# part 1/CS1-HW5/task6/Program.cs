using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that enters the coefficients a, b and c of a quadratic equation
            //a*x2 + b*x + c = 0 , and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double D = (b * b) - 4.0 * a * c;
            if (D < 0)
            {
                Console.WriteLine("Niama realni koreni");
            }
            else
            {
                if (D == 0)
                {
                    double x = -b / 2 * a;
                    Console.WriteLine("Uravnenieto ima edin dvukraten koren = {0}", x);
                }
                else
                {
                    double x1 = ((-b) + Math.Sqrt(D)) / 2 * a;
                    double x2 = ((-b) - Math.Sqrt(D)) / 2 * a;
                    Console.WriteLine("korenite na uravnenieto sa x1={0} i x2={1}", x1, x2);
                }
            }

        }
    }
}
