using System;

namespace task2_StringCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads two arrays from the console and compares them element by element.
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            string[] input1Arr = input1.Split(' ');
            string[] input2Arr = input2.Split(' ');

            int len1 = input1Arr.Length;
            int len2 = input2Arr.Length;
            bool identical = true;

            if (len1 != len2)
            {
                Console.WriteLine("Different arrays!");
                identical = false;
            }
            else
            {
                for (int i = 0; i < len1; i++)
                {
                    if (string.Compare(input1Arr[i], input2Arr[i]) != 0)
                    {
                        Console.WriteLine("Different arrays!");
                        identical = false;
                        break;
                    }
                }

            }
            if (identical)
            {
                Console.WriteLine("Arrays are identical!");
            }
        }
    }
}
