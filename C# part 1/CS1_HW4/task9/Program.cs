using System;
using System.Numerics;

class Program
{

    static void Main()
    {
        //Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 

        BigInteger fn_1 = 0;
        BigInteger fn_2 = 1;
        BigInteger fn = 0;
        Console.WriteLine(fn_1);
        for (int i = 1; i < 100; i++)
        {
            fn = fn_1 + fn_2;
            Console.WriteLine(fn);
            fn_2 = fn_1;
            fn_1 = fn;
        }
    }
}
