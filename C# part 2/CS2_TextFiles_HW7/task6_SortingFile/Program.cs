using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace task6_SortingFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. 
            string path1 = @"C:\Users\Ivan\Desktop\names.txt";
            string path2 = @"C:\Users\Ivan\Desktop\sortedNames.txt";
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");
            string allNames = null;
            string[] names = new string[0];
            try
            {
                StreamReader reader = new StreamReader(path1, win1251);
                StreamWriter writer = new StreamWriter(path2, false, win1251);
                using (reader)
                {
                    allNames = reader.ReadToEnd();
                    allNames = allNames.Replace("\r\n", " ");
                    names = allNames.Split();
                    names = MergeSort<string>(names);
                    using (writer)
                    {
                        for (int i = 0; i < names.Length; i++)
                        {
                            writer.WriteLine(names[i]);
                        }
                    }
                }
                Console.WriteLine("Successesful sorting!");
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
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
