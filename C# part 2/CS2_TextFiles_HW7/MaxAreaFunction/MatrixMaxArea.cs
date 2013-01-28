using System;

namespace MaxAreaFunction
{
    public class MatrixMaxArea
    {
        static int[,] matrix;

        public int MatrixMaxAreaSum(string matrixInArr)
        {
            string[] splitedMatrix = matrixInArr.Split();
            int row = int.Parse(splitedMatrix[0]);
            int col = row;
            matrix = new int[row, col];
            int counter = 1;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = int.Parse(splitedMatrix[counter++]);
                }
            }
        
            int currentSum = 0;
            int maxSum = int.MinValue;

            for (int i = 0; i <= row - 2; i++)
            {
                for (int j = 0; j <= col - 2; j++)
                {
                    currentSum = SumInSquare(i, j);
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }
            return maxSum;
        }

        public  int SumInSquare(int rowIndex, int colIndex)
        {
            int result = 0;

            for (int i = rowIndex; i < 2 + rowIndex; i++)
            {
                for (int j = colIndex; j < 2 + colIndex; j++)
                {
                    result += matrix[i, j];
                }
            }

            return result;
        }
    }
}
