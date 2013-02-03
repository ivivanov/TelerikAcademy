using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. Sample input:
            string word = "Hi!";
            Console.WriteLine(Encode(word));
        }
        static string Encode(string input)
        {
            ushort charInp = 0;
            string result = "";
            string tempRes = "";
            for (int i = 0; i < input.Length; i++)
            {
                charInp = input[i];
                tempRes = charInp.ToString("X").PadLeft(4, '0');
                result += "\\u" + tempRes;
            }
            return result;
        }
    }
}
