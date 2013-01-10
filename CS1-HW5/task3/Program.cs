using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the biggest of three integers using nested if statements.
            int a = 1;
            int b = 2;
            int c = 3;
            int max = a;

            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }

            Console.WriteLine(max);
        }
    }
}
