using System;

namespace task14_QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 40, 20, 10, 80, 60, 50, 7, 30, 100 };

            QuickSort(numbers, numbers.Length);
            
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        static void QuickSort(int[] numbers, int size)
        {
            q_sort(numbers, 0, size - 1);
        }

        static void q_sort(int[] numbers, int left, int right)
        {
            int lHold = left;
            int rHold = right;
            int pivot = numbers[left];
            while (left < right)
            {
                while ((numbers[right] >= pivot) && (left < right))
                {
                    right--;
                }
                if (left != right)
                {
                    numbers[left] = numbers[right];
                    left++;
                }
                while ((numbers[left] <= pivot) && (left < right))
                {
                    left++;
                }
                if (left != right)
                {
                    numbers[right] = numbers[left];
                    right--;
                }
            }
            numbers[left] = pivot;
            pivot = left;
            left = lHold;
            right = rHold;
            if (left < pivot)
                q_sort(numbers, left, pivot - 1);
            if (right > pivot)
                q_sort(numbers, pivot + 1, right);
        }
    }
}