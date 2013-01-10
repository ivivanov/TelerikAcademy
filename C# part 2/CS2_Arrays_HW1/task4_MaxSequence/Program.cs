using System;

namespace task4_MaxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the maximal sequence of equal elements in an array.
            //Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.
            int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            //tests...
            //char[] array = { '1', '2', '1', '1', '3', 'A', 'A', 'A', 'A', '1', '1', '1', '4', '1', '1', '1', '1','1'};
            //char[] array = {  'A', 'A', 'A', '1', '1', '1', '4', '1', '1', '1', '1', '1' };
            //char[] array = { '3', '3', '3' ,'1'};

            int maxSeq = 0;
            int currentSeq = 1;
            int length = array.Length;
            int maxSeqItem = -1;

            for (int i = 0; i < length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    currentSeq++;
                }
                else
                {
                    if (currentSeq > maxSeq)
                    {
                        maxSeq = currentSeq;
                       
                        maxSeqItem = array[i];
                    }
                    currentSeq = 1;
                }
                if (i == length - 2)
                {
                    if (currentSeq > maxSeq)
                    {
                        maxSeq = currentSeq;
                        maxSeqItem = array[i];
                    }
                }
            }

            Print(maxSeqItem, maxSeq);
        }

        static void Print(int maxSeqItem, int maxSeq)
        {
            Console.Write("{");
            for (int i = 0; i < maxSeq; i++)
            {
                Console.Write(maxSeqItem);

                if (i == maxSeq - 1)
                {
                    Console.Write("}");
                    break;
                }
                Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
