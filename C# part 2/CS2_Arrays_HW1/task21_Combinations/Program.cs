using System;

namespace task21_Combinations
{
    class Program
    {
        static int[] combination;
        static int n;
        static int k;
        static void Main(string[] args)
        {
            //Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example:
            //N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            combination = new int[k];
            Combination(0);
        }

        static void Combination(int index)
        {
            if (index == k)
            {
                PrintCombinations();
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                combination[index] = i;
                Combination(index + 1);
            }
        }

        static void PrintCombinations()
        {
            Console.WriteLine();
            Console.Write("{");
            for (int i = 0; i < combination.Length; i++)
            {
                if (i == combination.Length - 1)
                {
                    Console.Write(combination[i]);
                }
                else
                {
                    Console.Write(combination[i] + ", ");
                }
            }
            Console.Write("}");
        }
    }
}
