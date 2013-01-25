using System;
using System.Text;

namespace task8_ShortToBin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
            //Console.WriteLine(Convert.ToString((short)-5, 2));
            Console.WriteLine(ShortToBin(-5));
        }

        static string ShortToBin(short x)
        {
            int mask = 1;
            int bit = 0;
            StringBuilder bin = new StringBuilder();
            for (int i = 0; i < 16; i++)
            {
                bin.Append((x >> i) & mask);
            }
            StringBuilder reversed = new StringBuilder();
            for (int i = bin.Length - 1; i >= 0; i--)
            {
                reversed.Append(bin[i]);   
            }
            return reversed.ToString();
        }
    }
}
