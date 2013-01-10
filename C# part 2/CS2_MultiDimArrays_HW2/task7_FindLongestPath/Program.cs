using System;
using task6_ClassMatrix;

namespace task7_FindLongestPath
{
    class Program
    {
        static Matrix matrix;
        static void Main(string[] args)
        {
            matrix = new Matrix(5, 6);
            int[] values = {
                               1, 3, 2, 2, 2, 4,
                               3, 3, 3, 2, 4, 4,
                               4, 3, 1, 2, 3, 3,
                               4, 3, 1, 3, 3, 1,
                               4, 3, 3, 3, 1, 1
                           };
            int counter =0;
            int longestPath = 0;
            int currentPath=0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    matrix[i, j] = values[counter++];
                }
            }
            //matrix.Print();
        }
    }
}
