using System;
using System.Collections.Generic;
using System.Linq;

namespace task15_GenericsMinMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //double[] numbers = { 0.1, 0.2, 0.3 };
            decimal[] numbers = { 111.111m, 222.222m, 333.333m };
            dynamic sum = Sum(numbers);
            dynamic mult = Product(numbers);
            dynamic min = Minimum(numbers);
            dynamic max = Maximum(numbers);
            dynamic avg = Avg(numbers);
            Console.WriteLine();
        }

        static T Avg<T>(T[] ints)
        {
            dynamic avg = Sum(ints);
            avg /= ints.Length;
            return avg;
        }

        static T Maximum<T>(T[] ints)
        {
            dynamic max = int.MinValue;
            foreach (var item in ints)
            {
                if (max < item)
                {
                    max = item;
                }
            }
            return max;
        }

        static T Minimum<T>(T[] ints)
        {
            dynamic min = int.MaxValue;
            foreach (var item in ints)
            {
                if (min > item)
                {
                    min = item;
                }
            }
            return min;
        }

        static T Product<T>(T[] ints)
        {
            dynamic result = 1;
            foreach (var item in ints)
            {
                result *= item;
            }
            return result;
        }

        static T Sum<T>(T[] numbers)
        {
            dynamic result = 0;
            foreach (var item in numbers)
            {
                result += item;
            }
            return result;
        }
    }
}
