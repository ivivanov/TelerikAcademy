using System;
using System.Collections.Generic;

namespace task9_MostFrequentNum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the most frequent number in an array. Example:
            //{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
            int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

            Dictionary<int, int> collection = new Dictionary<int, int>();
  
            for (int i = 0; i < array.Length; i++)
            {
                if (collection.ContainsKey(array[i]))
                {
                    collection[array[i]]++;
                }
                else
                {
                    collection.Add(array[i], 1);
                }
            }
            int max = int.MinValue;
            int key = 0;
           
            foreach (var item in collection)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    key = item.Key;
                }
            }

            Console.WriteLine("{0} ({1} times)", key, max);
        }
    }
}
