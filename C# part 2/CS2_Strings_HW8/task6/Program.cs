using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with '*'. Print the result string into the console.
            string input = Console.ReadLine();
            int length = input.Length;
            while (length < 20)
            {
                input += "*";
                length++;
            }
            Console.WriteLine(input);
        }
    }
}
