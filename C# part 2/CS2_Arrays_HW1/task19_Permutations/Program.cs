using System;

namespace task19_Permutations
{
    class Program
    {
        static void Main()
        {
            //* Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. Example:
	        //n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}
                      /*           Knuths
                     1. Find the largest index j such that a[j] < a[j + 1]. If no such index exists, the permutation is the last permutation.
                     2. Find the largest index l such that a[j] < a[l]. Since j + 1 is such an index, l is well defined and satisfies j < l.
                     3. Swap a[j] with a[l].
                     4. Reverse the sequence from a[j + 1] up to and including the final element a[n].
                     */
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = i + 1;
            }
            Print(numbers);
            for ( int i = 0; i < Fact(n); i++)
            {
                Permutations(numbers);
                Print(numbers);
            }
        }

        static void Permutations(int[] numbers)
        {
            int length = numbers.Length;
            int largestI = int.MinValue;
            int largestJ = int.MinValue;

            for (int i = 0; i < length-1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    largestI = i;
                }
            }
            if (largestI < 0)
            {
                return;
            }
            for (int j = 0; j < length; j++)
            {
                if (numbers[largestI] < numbers[j])
                {
                    largestJ = j;
                }
            }
            if(largestJ < 0)
            {
                return;
            }
            Swap(ref numbers, largestI, largestJ);
            PartialReverse(ref numbers, largestI + 1);
            }

        static void PartialReverse(ref int[] numbers, int p)
        {
            int[] temp = new int[numbers.Length - p];
            int iter = 0;
            for (int i = numbers.Length-1; i >= p; i--)
            {
                temp[iter++] = numbers[i];
            }
            iter = 0;
            for (int i = p; i < numbers.Length; i++)
            {
                numbers[i] = temp[iter++];
            }
        }

        static void Swap(ref int[] numbers, int largestI, int largestJ)
        {
            int temp = numbers[largestI];
            numbers[largestI] = numbers[largestJ];
            numbers[largestJ] = temp;
        }

        private static void Print(int[] numbers)
        {
            Console.WriteLine();
            Console.Write("{");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length-1)
                {
                    Console.Write(numbers[i]);
                }
                else
                {
                    Console.Write(numbers[i] + ", ");
                }
            }
            Console.Write("}");
        }

        static long Fact(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Fact(--n);
            }
        }
 
    }
}
