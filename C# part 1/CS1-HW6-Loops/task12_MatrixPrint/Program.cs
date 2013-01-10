using System;

namespace task12_MatrixPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n + i; j++)
                {
                    Console.Write("{0,2} ",j);
                }
                Console.WriteLine();
            }
        }
    }
}
