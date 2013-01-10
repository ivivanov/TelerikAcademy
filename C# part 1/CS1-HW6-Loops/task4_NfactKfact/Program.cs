using System;
using System.Numerics;

namespace task4_NfactKfact
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that calculates N!/K! for given N and K (1<K<N).
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            //This method is not good !
            //long nFact = Factorial(n);
            //long kFact = Factorial(k);
            //Console.WriteLine("{0}!/{1}! = {2}", n, k, nFact / kFact);

            //1.2.3...k.(k+1)...n / 1.2.3....k = (k+1)(k+2)...n
            BigInteger result = 1;
            for (int i = k + 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine("{0}!/{1}! = {2}", n, k, result);
        }

        //static long Factorial(long n)
        //{
        //    if (n == 0)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        return n * Factorial(--n);
        //    }
        //}
    }
}
