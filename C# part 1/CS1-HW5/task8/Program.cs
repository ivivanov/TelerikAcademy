using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, 
            //increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement.
            Console.Write("Enter string, double or int: ");
            string input = Console.ReadLine();
            int aInt = 0;
            double aDouble = 0;
            int condition;

            if (int.TryParse(input, out aInt))
            {
                condition = 1;
            }
            else
                if (double.TryParse(input, out aDouble))
                {
                    condition = 2;
                }
                else
                {
                    condition = 3;
                }

            switch (condition)
            {
                case 1:
                    Console.WriteLine(aInt + 1);
                    break;
                case 2:
                    Console.WriteLine(aDouble + 1);
                    break;
                case 3:
                    Console.WriteLine(input + "*");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}
