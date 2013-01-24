using System;
using task5_Neighbours;

namespace task6_ElementSearch
{
    public class ElementSearch
    {
        //Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
        //Use the method from the previous exercise.

        public int IndexFinder(int[] arr)
        {
            Neighbours instance = new Neighbours();
            if (arr.Length >= 3)
            {
                for (int i = 1; i < arr.Length - 2; i++)
                {
                    if (instance.BiggerThanNeighbours(arr, i))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
