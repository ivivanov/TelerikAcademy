using System;

class Program
{
    
    static void Main()
    {
        //Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Number {0} = ", i+1);
            sum += int.Parse(Console.ReadLine());
        }
        Console.WriteLine(sum);
    }
}