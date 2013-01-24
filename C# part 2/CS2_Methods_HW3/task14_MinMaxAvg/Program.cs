using System;
using System.Collections.Generic;
using System.Linq;

namespace task14_MinMaxAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.
            int[] ints = { 1, 2, 3, 4, 5 };
            //double[] doubles = { 0.1, 0.2, 0.3 };
            //decimal[] decimals = { 111.111m, 222.222m, 333.333m };
            int sum = Sum(ints);
            int mult = Product(ints);
            int min = Minimum(ints);
            int max = Maximum(ints);
            int avg = Avg(ints);
        }

        static int Avg(int[] ints)
        {
            int avg = Sum(ints);
            avg /= ints.Length;
            return avg;
        }

        static int Maximum(int[] ints)
        {
            int max = int.MinValue;
            foreach (var item in ints)
            {
                if (max < item)
                {
                    max = item;
                }
            }
            return max;
        }

        static int Minimum(int[] ints)
        {
            int min = int.MaxValue;
            foreach (var item in ints)
            {
                if (min > item)
                {
                    min = item;
                }
            }
            return min;
        }

        static int Product(int[] ints)
        {
            int result = 1;
            foreach (int item in ints)
            {
                result *= item;
            }
            return result;
        }

        static int Sum(int[] ints)
        {
            int result = 0;
            foreach (int item in ints)
            {
                result += item;
            }
            return result;
        }
    }
}
