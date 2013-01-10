using System;

class Program
{
    static int counter(int a,int b)
    {
        if (a > b)
        {
            return 0;
        }
        else
        {
            if (a % 5 == 0)
            {
                return (1 + counter(a + 5, b));
            }
            else
            {
                return counter(a + 1, b);
            }
        }
    }


    static void Main()
    {
        //Write a program that reads two positive integer numbers and prints how many numbers p exist 
        //between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("p({0},{1}) = {2}", a, b, counter(a, b));
    }
}