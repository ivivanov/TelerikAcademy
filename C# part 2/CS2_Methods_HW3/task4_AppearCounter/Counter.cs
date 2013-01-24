using System;

namespace task4_AppearCounter
{
    public class Counter
    {
        //Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.

        public int AppearCounter(int[] arr, int number)
        {
            int occurencies = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    occurencies++;
                }
            }
            return occurencies;
        }
    }
}
