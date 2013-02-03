using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
             //        Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
             //    Example: The target substring is "in". The text is as follows:
             //We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
             //The result is: 9.
            string input = Console.ReadLine();
            int counter = 0;
            int index = 0;
            input = input.ToLower();
            int length = input.Length;
            while (index < length)
            {
                index = input.IndexOf("in", index);
                if (index == -1)
                {
                    break;
                }
                index++;
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
