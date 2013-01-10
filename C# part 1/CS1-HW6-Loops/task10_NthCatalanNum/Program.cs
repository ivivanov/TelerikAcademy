using System;

namespace task10_NthCatalanNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(CatalanNumber(n));
        }

        static int CatalanNumber(int n)
        {
            int num = 2 * n;
            int denom = n;

            int denomResult = 1;
            int numResult = 1;
            int result = 0;

            for (int i = 0; i < n - 1; i++)
            {
                numResult *= num;
                num--;
                denomResult *= denom;
                denom--;
            }
            result = numResult / denomResult;
            return result;
        }
    }
}
