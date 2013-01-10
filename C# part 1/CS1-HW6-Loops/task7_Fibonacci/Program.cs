using System;

namespace task7_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
            //Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.

            int n = int.Parse(Console.ReadLine());
            int fibN_2 = 0;// n-2 fib member
            int fibN_1 = 1;// n-1 fib member
            int fibN = 0;
            ulong result = 1;
            if (n > 2)
            {
                for (int i = 2; i < n; i++)
                {
                    fibN = fibN_2 + fibN_1;
                    fibN_2 = fibN_1;
                    fibN_1 = fibN;
                    //Console.WriteLine(fibN);
                    result += (ulong)fibN;
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("input number must be greater than 2");
            }
        }
    }
}
