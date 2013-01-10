using System;
using System.Numerics;

namespace ExcelColumnsAAZB
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] columnLeteres = new char[n];
            BigInteger sum = 0;
            int letterIndex = 0;
            int power=0;
            BigInteger pow = 1;
            for (int i = 0; i < n; i++)
            {
                columnLeteres[i] = char.Parse(Console.ReadLine());
            }

            for (int i = n-1; i >= 0; i--)
            {
                letterIndex = GetLeterIndex(columnLeteres[i]);
                //pow = (BigInteger)Math.Pow(26, power);
                
                sum += letterIndex * pow;
                pow = pow * 26;
                power++;
            }
            Console.WriteLine(sum);
        }

        static int GetLeterIndex(char letter)
        {
            char previousA='@';
            return letter - previousA;
        }
    }
}
