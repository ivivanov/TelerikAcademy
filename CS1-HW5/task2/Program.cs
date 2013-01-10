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
            //Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.
            int a = -1;
            int b = -2;
            int c = -4;
            int counter = 0;
            if (a < 0)
            {
                counter++;
            }
            if (b < 0)
            {
                counter++;
            }
            if (c < 0)
            {
                counter++;
            }
            if (counter % 2 == 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}
