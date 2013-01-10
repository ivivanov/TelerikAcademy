using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort 3 real values in descending order using nested if statements.
            int a = 1;
            int b = 2;
            int c = 3;
            //int[] unSorted = { 1, 5, 123, 5, -1, 4, 67, 0, 1, 4, -5 };
            int[] unSorted = { a, b, c };
            Sort(unSorted);
            Print(unSorted);

        }

        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        Swap(j, arr);
                    }
                }
            }
        }

        static void Swap(int j, int[] arr)
        {
            int temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;
        }


    }
}
