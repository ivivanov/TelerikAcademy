using System;

class Program
{
    static void Main()
    {
        //Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int temp = a >= b ? a : b;
        Console.WriteLine(temp);
    }
}