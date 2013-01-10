using System;

class Program
{
    static void Main()
    {
        //Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
        decimal sum = 1;
        decimal previousSum = 1;
        decimal divider = 2;
        int sign = 1;

        do
        {
            previousSum = sum;
            sum = sum + sign * (1 / divider++);
            sign *= -1;
        }
        while (Math.Abs(sum - previousSum) > (decimal)0.0001);

        Console.WriteLine("The sum (with accuracy of 0.001) of 1 + 1/2 - 1/3 + 1/4 - 1/5 + ... = {0:F4}", previousSum);
        //Console.WriteLine(2 - Math.Log(2));
    }
}