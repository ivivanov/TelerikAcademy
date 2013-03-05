/*
 * Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
 */
using System;
using System.Linq;

namespace task6_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 21, 33, 5, 3, 12, 323, 777, 5, 147, 6, 67, 7, 78, 433, 2, 48 };

            //////////////////////////////with LINQ///////////////////////////////////////
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("LINQ \n");

            var filter = from number in arr
                         where (number % 7 == 0) && (number % 3 == 0)
                         select number;
            foreach (var number in filter)
            {
                Console.WriteLine(number);
            }

            //////////////////////////////with Lambda///////////////////////////////////////
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Lambda \n");

            var filter2 = arr.ToList<int>().FindAll(number => (number % 7 == 0) && (number % 3 == 0));
            foreach (var number in filter2)
            {
                Console.WriteLine(number);
            }
        }
    }
}
