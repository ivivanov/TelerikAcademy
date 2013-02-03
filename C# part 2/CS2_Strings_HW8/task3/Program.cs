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
            //Write a program to check if in a given expression the brackets are put correctly.
            //Example of correct expression: ((a+b)/5-d).
            //Example of incorrect expression: )(a+b)).
            string input = Console.ReadLine();
            int open = 0;
            int close = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() == "(")
                {
                    open++;
                }
                if (input[i].ToString() == ")")
                {
                    close++;
                }
                if (close > open)
                {
                    Console.WriteLine("Brackets are not used correctly");
                    return;
                }
            }
            if (open - close == 0)
            {
                Console.WriteLine("brackets are put correctly");
            }
            else
            {
                Console.WriteLine("Brackets are not used correctly");
            }
        }
    }
}
