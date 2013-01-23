using System;

namespace task3_LongestSeqMatrix
{
    class Program
    {
        //We are given a matrix of strings of size N x M. 
        //Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. 
        //Write a program that finds the longest sequence of equal strings in the matrix. 
        static string[,] matrix;
        static int maxRow;
        static int maxCol;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter test in BGcoder style: (check for sample test under my code)");
            maxRow = 0;
            maxCol = 0;
            maxRow = int.Parse(Console.ReadLine());
            maxCol = int.Parse(Console.ReadLine());
            matrix = new string[maxRow, maxCol];
            string element = "";

            for (int i = 0; i < maxRow; i++)
            {
                for (int j = 0; j < maxCol; j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }

            int currentLen = 0;
            int maxLen = 0;
            for (int i = 0; i < maxRow; i++)
            {
                for (int j = 0; j < maxCol; j++)
                {
                    currentLen = CheckForSeq(i, j);
                    if (currentLen > maxLen)
                    {
                        maxLen = currentLen;
                        element = matrix[i, j];
                    }
                }
            }
            PrintMatrix(matrix, maxRow, maxCol);
            Console.WriteLine();
            PrintSeq(element, maxLen);
        }

        static int CheckForSeq(int i, int j)
        {
            int currentMax = 0;
            int maxSeq = 0;
            int row = i;
            int col = j;

            while (matrix[i, j] == matrix[row, col])
            {
                row++;
                currentMax++;
                if (row >= maxRow || col >= maxCol)
                {
                    break;
                }
            }
            if (currentMax > maxSeq)
            {
                maxSeq = currentMax; ;
            }
            currentMax = 0;
            row = i;
            col = j;
            while (matrix[i, j] == matrix[row, col])
            {
                col++;
                currentMax++;
                if (row >= maxRow || col >= maxCol)
                {
                    break;
                }
            }
            if (currentMax > maxSeq)
            {
                maxSeq = currentMax; ;
            }
            currentMax = 0;
            row = i;
            col = j;
            while (matrix[i, j] == matrix[row, col])
            {
                col++;
                row++;
                currentMax++;
                if (row >= maxRow || col >= maxCol)
                {
                    break;
                }
            }
            if (currentMax > maxSeq)
            {
                maxSeq = currentMax; ;
            }
            return maxSeq;
        }

        static void PrintMatrix(string[,] matrix, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < col; j++)
                {
                    Console.Write("{0,5}", matrix[i, j]);
                }
            }
            Console.WriteLine();
        }

        static void PrintSeq(string maxSeqItem, int maxSeq)
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
/*test1         test2
 *  3           3
 *  4           3
 *  haaa        ss
 *  fifi        qq 
 *  hooo        ss
 *  hiii        pp
 *  fooo        pp 
 *  haaa        ss
 *  hiii        pp
 *  xxyy        qq
 *  xxxx        ss
 *  hooo
 *  haaa
 *  xxyy
 */