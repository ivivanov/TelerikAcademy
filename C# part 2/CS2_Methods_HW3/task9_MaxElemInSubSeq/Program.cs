using System;

namespace task9_MaxElemInSubSeq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that return the maximal element in a portion of array of integers starting at given index. Using it write another method that sorts an array in ascending / descending order.
            int[] arr = {2, 100,6, 4,-1,-1,-1, 43, 3, 6, 5, 2 };
            Print(ref arr);
            SortDesc(ref arr);
            Print(ref arr);
            SortAsc(ref arr);
            Print(ref arr);

        }

        static void Print(ref int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private static void SortAsc(ref int[] arr)
        {
            SortDesc(ref arr);
            Array.Reverse(arr);
        }

        static void SortDesc(ref int[] arr)
        {
            int length = arr.Length;
            int maxIndex = 0;
            for (int i = 0; i < length; i++)
            {
                maxIndex = FindMax(arr, i);
                Swap(ref arr, i, maxIndex);
            }
        }

        static void Swap(ref int[] arr, int i, int index)
        {
            int temp = arr[i];
            arr[i] = arr[index];
            arr[index] = temp;
        }

        //static int FindIndexOfMax(int[] arr, int max)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] == max)
        //        {
        //            return i;
        //        }
        //    }
        //    return 0;
        //}

        static int FindMax(int[] arr, int index)
        {
            int max = index;
            int length = arr.Length;
            for (int i = index; i < length; i++)
            {
                if (arr[i] > arr[max])
                {
                    max = i;
                }
            }
            return max;
        }
    }
}
