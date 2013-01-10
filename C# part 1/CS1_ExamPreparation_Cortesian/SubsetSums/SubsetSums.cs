using System;

namespace SubsetSums
{
    class SubsetSums
    {
        static void Main(string[] args)
        {
            long s = long.Parse(Console.ReadLine());
            long n = long.Parse(Console.ReadLine());
            long[] numbers = new long[n];
            for (long i = 0; i < n; i++)
            {
                numbers[i] = long.Parse(Console.ReadLine());
            }
            Console.WriteLine(CountSubsets(numbers,s));
        }

        static int CountSubsets(long[] numbers, long sum)
        {
            int count = 0;
            int combinations = (int)Math.Pow(2, numbers.Length) - 1;
            int binary = 1;
            for (int i = 1; i <= combinations; i++)
            {
                if (SumOfNumbersOnPositions(numbers, i) == sum)
                {
                    count++;
                }
            }

            return count;
        }
        static long SumOfNumbersOnPositions(long[] listOfNumbers, int intToBin)
        {
            bool[] arrOfBools = new bool[listOfNumbers.Length];

            long binary = long.Parse(Convert.ToString(intToBin, 2));
            long sum = 0;

            for (int i = arrOfBools.Length - 1; i >= 0; i--)
            {
                if (binary % 10 == 1)
                {
                    sum += listOfNumbers[i];
                    arrOfBools[i] = true;
                }
                binary /= 10;
            }
            return sum;
        }
    }
}
