using System;

namespace task13_NfactTrailingZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
            //N = 10  N! = 3628800  2
            //N = 20  N! = 2432902008176640000  4
            //Does your program work for N = 50 000?
            //Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!

            int n = int.Parse(Console.ReadLine());
            //DateTime start = DateTime.Now;
            int trailingZeros = 0;
            int powersOfFive =5;
            while (n / powersOfFive >= 1)
            {
                trailingZeros += n / powersOfFive;
                powersOfFive *= 5;
            }
            Console.WriteLine(trailingZeros);
            //DateTime end = DateTime.Now;
            //TimeSpan duration = end - start;
            //Console.WriteLine(duration);
        }
    }
}
