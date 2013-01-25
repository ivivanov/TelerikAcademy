using System;
namespace zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region initialization of variables

            //int[] array = { 0, 1, 9, 0, 1, 2, 2, 2, 2, 5, 2, 3, 0, 3, 1, 1, 1, 8, 0, 9, 0 };
            int[] array = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
            int[] sequence = new int[array.Length];
            int[] parent = new int[array.Length];
            int maxSequence = 0, index = 0;
            int[] maxIncreasingSubseq;
            int indexProgress = 0;

            #endregion

            #region fill with default values

            for (int i = 0; i < array.Length; i++)
            {
                sequence[i] = 1;
                parent[i] = -1;
            }

            #endregion

            #region loop for finding sequence and parent arrays

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[i] >= array[j - 1] && sequence[j - 1] >= sequence[i])
                    {
                        sequence[i] = sequence[j - 1] + 1;
                        parent[i] = j - 1;
                    }
                }
            }

            #endregion

            #region algorithm for finding longest subsequence of increasing elements

            for (int i = 0; i < array.Length; i++)
            {
                if (sequence[i] >= maxSequence)
                {
                    maxSequence = sequence[i];
                    index = i;
                }
            }

            maxIncreasingSubseq = new int[maxSequence];
            maxIncreasingSubseq[indexProgress] = array[index];
            indexProgress++;

            for (int i = index; i > 0; i--)
            {
                if (sequence[i - 1] == maxSequence - 1)
                {
                    maxSequence--;
                    maxIncreasingSubseq[indexProgress] = array[i - 1];
                    indexProgress++;
                }
            }

            #endregion

            #region print (reverse)

            for (int i = maxIncreasingSubseq.Length - 1; i >= 0; i--)
            {
                Console.Write(" {0} ", maxIncreasingSubseq[i]);
            }

            #endregion
        }
    }
}