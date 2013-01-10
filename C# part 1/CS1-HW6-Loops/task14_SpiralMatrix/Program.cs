using System;

namespace task14_SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixDim = int.Parse(Console.ReadLine());
            int[,] arr = new int[matrixDim, matrixDim];
            int count = 1;
            int i = 0, j = 0, k = 0, m = 0, n = 0;

            for (i = 0; i < matrixDim; i++)
            {
                // na dqsno
                for (j = i; j < matrixDim - i; j++)
                {
                    arr[i, j] = count++;
                }
                j--;
                // na dolo
                for (k = i; k < matrixDim - i - 1; k++)
                {
                    arr[k + 1, j] = count++;
                }

                //na lqvo
                for (m = k; m > i; m--)
                {
                    arr[k, m - 1] = count++;
                }
                //na gore
                for (n = k; n > i + 1; n--)
                {
                    arr[n - 1, m] = count++;
                }
            }


            for (int p = 0; p < matrixDim; p++)
            {
                for (int l = 0; l < matrixDim; l++)
                {
                    Console.Write("{0,4}", arr[p, l]);
                }
                Console.WriteLine();
            }
        }
    }
}
