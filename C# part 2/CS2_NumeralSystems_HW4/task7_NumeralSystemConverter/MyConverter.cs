using System;
using System.Text;

namespace task7_NumeralSystemConverter
{
    class MyConverter
    {
        static void Main(string[] args)
        {
            //Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

            Console.WriteLine(NumeralSystemConverter("1007", 8, 16));
        }
        static string NumeralSystemConverter(string numStr, int numBase, int toBase)
        {
            int decimalNumber = AnyToDec(numStr, numBase);
            return DecToAny(decimalNumber, toBase);
        }

        static string DecToAny(int decimalNumber, int toBase)
        {
            StringBuilder reversedResult = new StringBuilder();
            int temp = 0;
            while (decimalNumber != 0)
            {
                temp = decimalNumber % toBase;
                reversedResult.Append(ConvertToHex(temp));
                decimalNumber /= toBase;
            }
            StringBuilder result = new StringBuilder();
            for (int i = reversedResult.Length - 1; i >= 0; i--)
            {
                result.Append(reversedResult[i]);
            }
            return result.ToString();
        }

        static int AnyToDec(string number,int baseFormat)
        {
            int result = 0;
            int factor = 1;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                result += ConvertToDec(number[i]) * factor;
                factor *= baseFormat;
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
