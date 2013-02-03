using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a string, reverses it and prints the result at the console.
            //Example: "sample"  "elpmas".
            string input = Console.ReadLine();
            StringBuilder reverse = new StringBuilder();
            for (int i = input.Length-1; i >= 0; i--)
            {
                reverse.Append(input[i]);
            }
            Console.WriteLine(reverse.ToString());
        }
    }
}
