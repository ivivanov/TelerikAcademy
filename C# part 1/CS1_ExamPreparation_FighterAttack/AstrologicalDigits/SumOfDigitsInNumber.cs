using System;

namespace AstrologicalDigits
{
    class SumOfDigitsInNumber
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int result = AstrologicalDigits(SumDigits(n));
            Console.WriteLine(result);
        }

        static int AstrologicalDigits(int n)
        {
            if (n > 9)
            {
                return AstrologicalDigits(SumDigits(Convert.ToString(n)));
            }
            else
            {
                return Convert.ToInt16(n);
            }
        }

        static int SumDigits(string number)
        {
            int sum = 0;
            foreach (char c in number)
            {
                if (c != '.' && c != '-')
                {
                    sum += (c - '0');
                }
            }
            return sum;
        }
    }
}