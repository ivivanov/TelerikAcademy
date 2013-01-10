using System;

namespace task10_SeqSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds in given array of integers a sequence of given sum S (if present). 
            //Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

            int sum = -15;
            int[] array = { -4, -3, -1, -4, -10, -5, -8 };
            int[] indexes = new int[2];

            indexes = SearchForSum(sum, array);
            Print(array, array.Length, 0);
            Console.Write(", S= {0} -> ",sum);
            Print(array, indexes[1] - indexes[0] + 1, indexes[0]);
        }

        private static int[] SearchForSum(int sum, int[] array)
        {
            int len = array.Length;
            int currentSum = 0;
            int[] result = new int[2]; // result[0]- start index and resul[1]- end index

            for (int i = 0; i < len; i++)
            {
                currentSum = array[i];
                for (int j = i + 1; j < len; j++)
                {
                    if (currentSum == sum)
                    {
                        result[0] = i;
                        result[1] = j - 1;
                        return result;
                    }
                    else
                    {
                        currentSum += array[j];
                    }
                }
            }
            return result;
        }

        static void Print(int[] array, int maxSeq, int maxSeqIndex)
        {
            Console.Write("{");
            for (int i = maxSeqIndex; i < maxSeqIndex + maxSeq; i++)
            {
                Console.Write(array[i]);

                if (i == maxSeq + maxSeqIndex - 1)
                {
                    Console.Write("}");
                    break;
                }
                Console.Write(", ");
            }
        }
    }
}
