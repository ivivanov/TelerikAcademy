using System;

class Program
{
    static void Main()
    {
        //Write a program that reads the radius r of a circle and prints its perimeter and area.
        int r = int.Parse(Console.ReadLine());
        Console.WriteLine("S = {0} and P = {1}", (Math.PI) * r * r, 2 * (Math.PI) * r);
    }
}

