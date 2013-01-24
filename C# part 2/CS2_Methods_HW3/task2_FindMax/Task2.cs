using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_FindMax
{
    public class Task2
    {
        static void Main(string[] args)
        {
            //Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().
            int a = 0, b = 0, c = 0;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            Task2 inst = new Task2();
            Console.WriteLine(inst.GetMaxNumber(a, b, c));
        }

        public int GetMaxNumber(params int[] listOfNums)
        {
            int max = GetMax(listOfNums[0], listOfNums[1]);

            for (int i = 2; i < listOfNums.Length; i++)
            {
                max = GetMax(max, listOfNums[i]);
            }
            return max;
        }

        public int GetMax(int p1, int p2)
        {
            int bigger = p1 > p2 ? p1 : p2;
            return bigger;
        }
    }
}
