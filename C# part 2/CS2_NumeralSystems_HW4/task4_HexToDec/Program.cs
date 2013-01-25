using System;

namespace task4_HexToDec
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to convert hexadecimal numbers to their decimal representation.
            Console.WriteLine(HexToDec("AF"));
            Console.WriteLine(0xAF12);
        }

        static int HexToDec(string p)
        {
            int result = 0;
            int factor = 1;
            for (int i = p.Length - 1; i >= 0; i--)
            {
                result += ConvertToDec(p[i]) * factor;
                factor *= 16;
            }
            return result;
        }
        static int ConvertToDec(char temp)
        {
            switch (temp - 'A')
            {
                case 0:
                    return 10;
                case 1:
                    return 11;
                case 2:
                    return 12;
                case 3:
                    return 13;
                case 4:
                    return 14;
                case 5:
                    return 15;
                default:
                    return temp - '0';
            }
        }
    }
}
