using System;

class Program
    {
        static void Main()
        {
            //Write a program that reads 3 integer numbers from the console and prints their sum.

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} + {2} =  {3}", a, b, c, a + b + c);
        }
    }
