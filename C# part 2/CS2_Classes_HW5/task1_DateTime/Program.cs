using System;

namespace task1_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
            Console.WriteLine("Enter Date:");
            DateTime input = DateTime.Parse(Console.ReadLine());

            if ((input.Year % 4 == 0) && (input.Year % 100 != 0) || input.Year % 400 == 0)
            {
                Console.WriteLine("{0} is leap year!", input);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year!", input);
            }
        }
    }
}
