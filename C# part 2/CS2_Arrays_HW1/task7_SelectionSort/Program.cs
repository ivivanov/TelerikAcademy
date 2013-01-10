using System;
using System.Collections.Generic;

namespace task7_SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
            //Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

            //Example Arrays
            int[] ints = { -9 ,9, -1, 6, 2, -7, 4, -1, 6, 5, 8, -8 };
            char[] chars = { 'z','c','e', 'b', 'd', 'a' };
            string[] names = { "Ivan", "Blagoi", "Blaga", "Anton" };
            string[] city = { "Sofia", "Dupnica", "Varna", "Burgas", "Teteven", "Aitos", "AitosZ" };

            //sorting
            ints = SelectionSort(ints);
            chars = SelectionSort(chars);
            names = SelectionSort(names);
            city = SelectionSort(city);

            //printing
            Print(names);
            Print(chars);
            Print(city);
            Print(ints);
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
                    if(cmpResult > 0)
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

        static void Print<T>(IEnumerable<T> g)
        {
            var enumerator = g.GetEnumerator();

            var item = enumerator.MoveNext();
            while (item)
            {
                Console.Write(enumerator.Current);
                item = enumerator.MoveNext();
                if (item)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();


        }
    }
}
