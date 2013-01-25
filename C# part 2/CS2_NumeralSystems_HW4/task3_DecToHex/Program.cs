using System;
using System.Text;

namespace task3_DecToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to convert decimal numbers to their hexadecimal representation.
            Console.WriteLine(DecToHex(155));
            //Console.WriteLine(Convert.ToString(155,16));
        }

        static string DecToHex(int p)
        {
            StringBuilder reversedResult = new StringBuilder();
            int temp = 0;
            while (p != 0)
            {
                temp = p % 16;
                reversedResult.Append(ConvertToHex(temp));
                p /= 16;
            }
            StringBuilder result = new StringBuilder();
            for (int i = reversedResult.Length - 1; i >= 0; i--)
            {
                result.Append(reversedResult[i]);
            }
            return result.ToString();
        }

        static string ConvertToHex(int temp)
        {
            switch (temp)
            { 
                case 10:
                    return "A";
                case 11:
                    return "B";
                case 12:
                    return "C";
                case 13:
                    return "D";
                case 14:
                    return "E";
                case 15:
                    return "F";
                default:
                    return temp.ToString();
            }
        }
    }
}
