using System;

namespace task3_LexicographicCmp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that compares two char arrays lexicographically (letter by letter).
            char[] arrA = { 'a', 'a', 'b', 'c', 'd', 'e', 'f' };
            char[] arrB = { 'a', 'a', 'b', 'c', 'd', 'e' };
            int smallerLength = arrA.Length < arrB.Length ? arrA.Length : arrB.Length;
            bool theSame = true;

            for (int i = 0; i < smallerLength; i++)
            {
                if (arrA[i] < arrB[i])
                {
                    Console.WriteLine("Array A is earlier!");
                    theSame = false;
                    break;
                }
                else
                {
                    if (arrA[i] > arrB[i])
                    {
                        Console.WriteLine("Array B is earlier!");
                        theSame = false;
                        break;
                    }
                }
            }
            if (theSame)
            {
                if (arrA.Length == arrB.Length)
                {
                    Console.WriteLine("Identical Arrays!");
                }
                else
                {
                    if (arrA.Length < arrB.Length)
                    {
                        Console.WriteLine("Array A is earlier!");
                    }
                    else
                    {
                        Console.WriteLine("Array B is earlier!");
                    }
                }
            }
        }
    }
}