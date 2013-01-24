using System;

namespace task5_Neighbours
{
    public class Neighbours
    {
        public bool BiggerThanNeighbours(int[] arr, int position)
        {
            if (position <= 0 || position >= arr.Length - 1)
            {
                return false;
            }
            if (arr[position] > arr[position + 1] && arr[position] > arr[position - 1])
            {
                return true;
            }
            return false;
        }
    }
}
