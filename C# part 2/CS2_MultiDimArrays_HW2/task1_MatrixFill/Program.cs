using System;

namespace task1_MatrixFill
{
    class Program
    {
        static int[,] matrix;
        static int n;
        static void Main(string[] args)
        {
            n = 5;
            matrix = new int[n, n];

            FillMatrixTypeA(n);
            Print(matrix, n);

            FillMatrixTypeB(n);
            Print(matrix, n);

            FillMatrixTypeC(n);
            Print(matrix, n);

            FillMatrixTypeD(n);
            Print(matrix, n);
        }

        static void FillMatrixTypeD(int n)
        {
            int value = 1,
                a = 0,
                b = 0,
                c = 0,
                d = 0;
            for (int i = 0; i < n; i++)
            {
                for (a=i; a < n-i; a++)
                {
                    matrix[a,i] = value++;
                }
                a--;
                for (b=i+1; b < n-i; b++)
                {
                    matrix[a, b] = value++;
                }
                b--;
                for (a=a-1; a>=i; a--)
                {
                    matrix[a, b] = value++;
                }
                a++;
                for (b=b-1; b>=i+1; b--)
                {
                    matrix[a, b] = value++;
                }
            }
        }

        static void FillMatrixTypeC(int n)
        {
            int k = 0;
            int m = 0;
            int value=1;

            //this loop fills under the main diagonal including
            for (int i = n-1; i >=0; i--)
            {
                k=i;
                m=0;
                while (k < n && m < n)
                {
                    matrix[k++, m++] = value++;
                }
            }

            //this loop fills over the main diagonal
            for (int j = 1; j < n; j++)
            {
                k = j;
                m = 0;
                while (k < n && m < n)
                {
                    matrix[m++,k++] = value++;
                }
            }
        }

        static void FillMatrixTypeB(int n)
        {
            int value = 1;
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (j == 0)
                {
                    for (; j < n; j++)
                    {
                        matrix[j, i] = value++;
                    }
                    j--;
                }
                else
                {
                    for (; j >= 0; j--)
                    {
                        matrix[j, i] = value++;
                    }
                    j++;
                }
            }
        }

        static void FillMatrixTypeA(int n)
        {
            int value = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[j, i] = value++;
                }
            }
        }

        static void Print(int[,] matrix, int len)
        {
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < len; j++)
                {
                    Console.Write("{0,5}",matrix[i, j]);
                }
            }
            Console.WriteLine();
        }
    }
}
