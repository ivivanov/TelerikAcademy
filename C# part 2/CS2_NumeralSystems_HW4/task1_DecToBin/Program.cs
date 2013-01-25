using System;
using System.Text;

namespace task1_DecToBin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to convert binary numbers to their decimal representation.
            int dec = 255;
            Console.WriteLine(DecToBin(dec));
            //Console.WriteLine(Convert.ToString(dec, 2));
        }

        static string DecToBin(int p)
        {
            StringBuilder reversedResult = new StringBuilder();
            while (p != 0)
            {
                reversedResult.Append(p % 2);
                p /= 2;
            }
            StringBuilder result = new StringBuilder();
            for (int i = reversedResult.Length - 1; i >= 0; i--)
            {
                result.Append(reversedResult[i]);
            }
            return result.ToString();
        }
    }
}
