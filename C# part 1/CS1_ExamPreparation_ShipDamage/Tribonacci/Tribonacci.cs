using System;
using System.Numerics;

namespace Tribonacci
{
    class Tribonacci
    {
        static void Main(string[] args)
        {

            BigInteger first = BigInteger.Parse(Console.ReadLine());
            BigInteger second = BigInteger.Parse(Console.ReadLine());
            BigInteger third = BigInteger.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            BigInteger tribN = 0;
            if (n == 1)
            {
                Console.WriteLine(first);
            }
            else
            {
                if (n == 2)
                {
                    Console.WriteLine(second);
                }
                else
                {
                    if (n == 3)
                    {
                        Console.WriteLine(third);
                    }
                    else 
                    {
                        for (int i = 4; i <= n; i++)
                        {
                            tribN = first + second + third;
                            first = second;
                            second = third;
                            third = tribN;
                        }
                        Console.WriteLine(tribN);
                    }
                }
            }
        }
    }
}
