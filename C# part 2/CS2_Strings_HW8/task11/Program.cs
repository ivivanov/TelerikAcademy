using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. Format the output aligned right in 15 symbols.
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number.ToString("D").PadLeft(15));
            Console.WriteLine(number.ToString("X").PadLeft(15));
            Console.WriteLine(number.ToString("P2").PadLeft(15));
            Console.WriteLine(number.ToString("E").PadLeft(15));

        }
    }
}
