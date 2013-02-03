using System;

namespace task2_RandomGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that generates and prints to the console 10 random values in the range [100, 200].

            Random number = new Random();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Random number {0} = {1}", i, number.Next(100, 201));
            }
        }
    }
}
