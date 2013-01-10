using System;

namespace task8_GCD_Euclid
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
            //Use the Euclidean algorithm (find it in Internet).
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int gcd = GCD(n, m);
            Console.WriteLine("GCD({0},{1}) = {2}", n, m, gcd);
        }

        static int GCD(int n, int m)
        {
            if (n % m == 0)
            {
                return m;
            }
            else
            {
                return GCD(m, n % m);
            }
        }
    }
}
