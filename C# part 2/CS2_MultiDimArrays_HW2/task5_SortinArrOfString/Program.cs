using System;
using System.Collections.Generic;

namespace task5_SortinArrOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
            string[] array = { "aaa", "bb", "c", "ccccc", "dddd", "aaaaaa" };
            array = SelectionSort(array);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        static string[] SelectionSort(string[] array)
        {
            string itemForCompare;
            int itemForSwapIndex;

            for (int i = 0; i < array.Length - 1; i++)
            {
                itemForCompare = array[i];
                itemForSwapIndex = -1;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (itemForCompare.Length > array[j].Length)
                    {
                        itemForCompare = array[j];
                        itemForSwapIndex = j;
                    }
                }

                if (itemForSwapIndex > 0)
                {
                    string temp = array[i];
                    array[i] = array[itemForSwapIndex];
                    array[itemForSwapIndex] = temp;
                }
            }

            return array;
        }
    }
}
