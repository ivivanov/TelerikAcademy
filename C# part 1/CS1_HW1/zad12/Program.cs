using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad12
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Write a program to read your age from the console and print how old you will be after 10 years.
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("After 10 years you will be {0} years old.", age + 10);
        }
    }
}
