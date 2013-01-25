using System;
using System.Collections.Generic;

namespace task13_MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).
            //int[] list = { 15, 2, 8, 4, 13, 3, 9 };
            int[] list = { 6, 9, 1, 10, 34, 12, 15, 8 };
            //char[] list = { 'M', 'E', 'R', 'G', 'E', 'S', 'O', 'R', 'T', 'E', 'X', 'A', 'M', 'P', 'L', 'E' };
            foreach (var item in MergeSort(list))
            {
                Console.WriteLine(item);
            }
        }

        static T[] MergeSort<T>(T[] arr)
        {
            int length = arr.Length;
            if (length == 1 || length == 0)
            {
                return arr;
            }
            int middle = length / 2;
            T[] left = new T[length - middle];
            T[] right = new T[middle];
            for (int i = 0; i < length - middle; i++)
            {
                left[i] = arr[i];
            }
            for (int i = 0; i < middle; i++)
            {
                right[i] = arr[i + length - middle];
            }
            left = MergeSort(left);
            right = MergeSort(right);

            T[] sortedArr = new T[length];
            int leftIndex = 0;
            int rightIndex = 0;
            for (int i = 0; i < length; i++)
            { 
                if (leftIndex == left.Length)
                {
                    sortedArr[i] = right[rightIndex++];
                }
                else
                {
                    if (rightIndex == right.Length)
                    {
                        sortedArr[i] = left[leftIndex++];
                    }
                }
                if (leftIndex < left.Length && 
                    rightIndex < right.Length &&
                    (Comparer<T>.Default.Compare(right[rightIndex], left[leftIndex]) >= 0))
                {
                    sortedArr[i] = left[leftIndex++];
                }
                else
                {
                    if (rightIndex < right.Length &&
                        leftIndex < left.Length &&
                        (Comparer<T>.Default.Compare(left[leftIndex], right[rightIndex]) >= 0))
                    {
                        sortedArr[i] = right[rightIndex++];
                    }
                }
            }
            return sortedArr;
        }
    }
}
/*
* if (a.Length == 1)
return a;
int middle = a.Length / 2;
int[] left = new int[middle];
for (int i = 0; i < middle; i++)
{
left[i] = a[i];
}
int[] right = new int[a.Length - middle];
for (int i = 0; i < a.Length - middle; i++)
{
right[i] = a[i + middle];
}
left = MergeSort(left);
right = MergeSort(right);

int leftptr = 0;
int rightptr = 0;

int[] sorted = new int[a.Length];
for (int k = 0; k < a.Length; k++)
{
if (rightptr == right.Length || ((leftptr < left.Length) && (left[leftptr] <= right[rightptr])))
{
sorted[k] = left[leftptr];
leftptr++;
}
else if (leftptr == left.Length || ((rightptr < right.Length) && (right[rightptr] <= left[leftptr])))
{
sorted[k] = right[rightptr];
rightptr++;
}
}
return sorted;
*/