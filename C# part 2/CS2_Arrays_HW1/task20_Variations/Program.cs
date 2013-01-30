using System;

namespace task20_Variations
{
    class Program
    {
        static int[] variation;
        static void Main(string[] args)
        {
            //Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
	        //N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int index=0;
            variation = new int[k];
            Variation(0, n, k);
        }

        static void Variation(int index, int n,int k)
        {
            if (index == k)
            {
                PrintVariation();
                return;
            }
            for (int i = 1; i <=n ; i++)
            {
                variation[index] = i;
                Variation(index + 1, n, k);
            }
        }

        static void PrintVariation()
        {
            Console.WriteLine();
            Console.Write("{");
            for (int i = 0; i < variation.Length; i++)
            {
                if (i == variation.Length - 1)
                {
                    Console.Write(variation[i]);
                }
                else
                {
                    Console.Write(variation[i] + ", ");
                }
            }
            Console.Write("}");
        }
    }
}
