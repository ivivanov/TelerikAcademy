using System;

namespace task3_MinMaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them
            //int n = 0;
            //int min = int.MaxValue;
            //int max = int.MinValue;
            //while (int.TryParse(Console.ReadLine(), out n))
            //{
            //    if (min > n)
            //    {
            //        min = n;
            //    }
            //    if (max < n)
            //    {
            //        max = n;
            //    }
            //}
            int n = int.Parse(Console.ReadLine());
            int inputValue = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                inputValue = int.Parse(Console.ReadLine());
                if (min > inputValue)
                {
                    min = inputValue;
                }
                if (max < inputValue)
                {
                    max = inputValue;
                }
            }

            Console.WriteLine("Min = {0}, Max = {1}", min, max);
        }
    }
}
