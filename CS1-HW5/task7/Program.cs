using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the greatest of given 5 variables.
            int a = 11;
            int b = 2;
            int c = 3;
            int d = 9;
            int e = 10;
            int max = a;
            int[] arr = { a, b, c, d, e };
            for (int i = 1; i < 5; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("The greatest number is {0}", max);
        }
    }
}
