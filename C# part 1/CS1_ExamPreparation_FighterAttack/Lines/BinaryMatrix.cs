using System;

namespace Lines
{
    class BinaryMatrix
    {
        static void Main(string[] args)
        {
            int [,] matrix = new int[8, 8];
            int longestLineLen = 0;
            int longestLineCount = 0;
            int length = 0;

            for (int row = 0; row < 8; row++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                for (int col = 0; col < 8; col++)
                {
                    if ((inputNumber & (1 << col)) == 1 << col)
                    {
                        matrix[row, col] = 1;
                    }
                }
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    int col = j;
                    while (col<8)
                    {
                        if (matrix[i, col] == 1)
                        {
                            length++;
                            col++;
                        }
                        else 
                        {
                            break;
                        }
                    }
                    if (length > longestLineLen)
                    {
                        longestLineLen = length;
                        longestLineCount = 0;
                    }
                    if (length == longestLineLen)
                    {
                        longestLineCount++;
                    }
                    length = 0;
                }
            }
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    int row = i;
                    while (row < 8)
                    {
                        if (matrix[row,j] == 1)
                        {
                            length++;
                            row++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (length > longestLineLen)
                    {
                        longestLineLen = length;
                        longestLineCount = 0;
                    }
                    if (length == longestLineLen)
                    {
                        longestLineCount++;
                    }
                    length = 0;
                }
            }

            if (longestLineLen == 1)
            {
                longestLineCount /= 2;
            }
            Console.WriteLine(longestLineLen);
            Console.WriteLine(longestLineCount);

            //print matrix
            //for (int i = 0; i < 8; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write(matrix[i, j]);
            //    }
            //}

        }
    }
}
