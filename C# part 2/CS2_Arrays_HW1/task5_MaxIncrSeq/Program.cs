using System;

namespace task5_MaxIncrSeq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
            int[] array = { 3, 2, 3, 4, 2, 2, 4 };
            int maxSeq = 0;
            int currentSeq = 1;
            int length = array.Length;
            int maxSeqIndex = -1;
            int currentSeqIndex = -1;

            for (int i = 0; i < length - 1; i++)
            {
                if (currentSeq == 1)
                {
                    currentSeqIndex = i;
                }
                if (array[i] < array[i + 1])
                {
                    currentSeq++;
                }
                else
                {
                    if (currentSeq > maxSeq)
                    {
                        maxSeq = currentSeq;
                        maxSeqIndex = currentSeqIndex;
                    }
                    currentSeq = 1;
                }
                if (i == length - 2)
                {
                    if (currentSeq > maxSeq)
                    {
                        maxSeq = currentSeq;
                    }
                }
            }
            Print(array, array.Length, 0);
            Console.Write(" -> ");
            Print(array, maxSeq, maxSeqIndex);
            Console.WriteLine();

        }

        static void Print(int[] array, int maxSeq, int maxSeqIndex)
        {
            Console.Write("{");
            for (int i = maxSeqIndex; i < maxSeqIndex + maxSeq; i++)
            {
                Console.Write(array[i]);

                if (i == maxSeq+maxSeqIndex - 1)
                {
                    Console.Write("}");
                    break;
                }
                Console.Write(", ");
            }
        }
    }
}
