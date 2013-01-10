using System;
using System.Numerics;

namespace task5_Factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = k - n + 1; i <= k; i++)
            {
                result *= i;
            }
            result *= Factorial(n);
            Console.WriteLine("{0}!*{1}! / ({0}-{1})! = {2}", k, n, result);
        }

        static BigInteger Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(--n);
            }
        }
    }
}
