using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. 
            string text = Console.ReadLine();
            int[] myAsciiTable = new int[256];
            foreach (var item in text)
            {
                myAsciiTable[item]++;
            }
            for (int i = 0; i < 256; i++)
            {
                if (myAsciiTable[i] != 0 && char.IsLetterOrDigit((char)i))
                {
                    Console.WriteLine("char: {0} occurences: {1}", (char)i, myAsciiTable[i]);
                }
            }
        }
    }
}
