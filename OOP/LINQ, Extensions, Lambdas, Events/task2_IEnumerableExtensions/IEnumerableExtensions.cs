/*
* Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace task2_IEnumerableExtensions
{
    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            return collection.DefaultIfEmpty().Aggregate((a, b) => (dynamic)a + (dynamic)b);
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            return collection.DefaultIfEmpty().Aggregate((a, b) => (dynamic)a * (dynamic)b);
        }

        public static T Min<T>(this IEnumerable<T> collection)
        {
            return collection.DefaultIfEmpty().Min(x => x);
        }

        public static T Max<T>(this IEnumerable<T> collection)
        {
            return collection.DefaultIfEmpty().Max(x => x);
        }

        public static T Avarage<T>(this IEnumerable<T> collection)
        {
            dynamic sum = 0;
            int counter = 0;
            foreach (var item in collection.DefaultIfEmpty())
            {
                counter++;
                sum += item;
            }
            return sum / counter;
        }

        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 1, 2, 3, 4 };
            Console.WriteLine("Sum = {0}", myList.Sum());
            Console.WriteLine("Product = {0}", myList.Product());
            Console.WriteLine("Min = {0}", myList.Min());
            Console.WriteLine("Max = {0}", myList.Max());
            Console.WriteLine("Average = {0}", myList.Avarage());
        }
    }
}
