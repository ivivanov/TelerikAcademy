using System;
using System.Collections.Generic;

namespace task11_BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).
            int[] array = { 1, 5, 1, 4, 6 , 33, 45, 32, 123, 543, 123, 1, 3, 43, 6, 8, 88, 943, 323, -2, -23, -132, 23, 44 };
            // sorted: -132 -23 -2 1 1 1 3 4 5 6 6 8 23 32 33 43 44 45 88 123 123 323 543 943
            int itemNeeded= 8;
            array = SelectionSort(array);
           
            int index = BinarySearch(itemNeeded, array, 0, array.Length - 1);

            if (index == -1)
            {
                Console.WriteLine("Not Found!");
            }
            else
            {
                Console.WriteLine("{0} found on index: {1}", itemNeeded, index);
            }
        }

        static int BinarySearch(int itemNeeded, int[] array, int begIndex, int endIndex)
        {
            int middle = (begIndex + endIndex) / 2;

            if (begIndex > endIndex)
            {
                return -1;
            }
            else
            {
                if (itemNeeded == array[middle])
                {
                    return middle;
                }
                if (itemNeeded < array[middle])
                {
                    return BinarySearch(itemNeeded, array, begIndex, middle - 1);
                }
                else
                {
                    if (itemNeeded > array[middle])
                    {
                        return BinarySearch(itemNeeded, array, middle + 1, endIndex);
                    }
                }
            }
            return -1;
           
        }


        static T[] SelectionSort<T>(T[] array)
        {
            T itemForCompare;
            int itemForSwapIndex;

            for (int i = 0; i < array.Length - 1; i++)
            {
                itemForCompare = array[i];
                itemForSwapIndex = -1;

                for (int j = i + 1; j < array.Length; j++)
                {
                    var cmpResult = Comparer<T>.Default.Compare(itemForCompare, array[j]);
                    if (cmpResult > 0)
                    //if (itemForCompare > array[j])
                    {
                        itemForCompare = array[j];
                        itemForSwapIndex = j;
                    }
                }

                if (itemForSwapIndex > 0)
                {
                    T temp = array[i];
                    array[i] = array[itemForSwapIndex];
                    array[itemForSwapIndex] = temp;
                }
            }

            return array;
        }
    }
}
