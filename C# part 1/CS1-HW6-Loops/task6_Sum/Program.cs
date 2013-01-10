using System;

namespace task6_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            double result = 0;
            
            for (int i = 0; i <= n; i++)
            {
                result = result + Factorial(i) / Math.Pow(x, i);
            }
            Console.WriteLine("Sum result = {0}", result);
        }
        static ulong Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return (ulong)n * Factorial(--n);
            }
        }
    }
}
