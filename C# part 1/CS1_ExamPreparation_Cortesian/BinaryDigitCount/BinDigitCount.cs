using System;

namespace BinaryDigitCount
{
    class BinDigitCount
    {
        static void Main(string[] args)
        {
            byte b = byte.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] digitCount = new int[n];
            for (int i = 0; i < n; i++)
            {
                digitCount[i] = CountDigits(b, uint.Parse(Console.ReadLine()));
            }
            foreach (int item in digitCount)
            {
                Console.WriteLine(item);
            }
        }

        static int CountDigits(byte b, uint number)
        {
            string binaryNumber = Convert.ToString(number, 2);
            int count = 0;
            foreach (char x in binaryNumber)
            {
                if (x.ToString() == b.ToString())
                {
                    count++;
                }
            }
            return count;
        }
    }
}
