using System;

namespace task2_BinToDec
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to convert binary numbers to their decimal representation.
            Console.WriteLine(BinToDec("1010"));
        }

        static int BinToDec(string p)
        {
            int result = 0;
            int factor = 1;
            for (int i = p.Length-1; i >=0; i--)
            {
                result += int.Parse(p[i].ToString())*factor;
                factor *= 2;
            }
            return result;
        }
    }
}
