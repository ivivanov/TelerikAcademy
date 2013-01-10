using System;

class Program
{
    static void Main()
    {
        //Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).
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