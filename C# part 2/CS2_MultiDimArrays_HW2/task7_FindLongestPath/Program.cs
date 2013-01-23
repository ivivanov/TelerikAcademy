using System;
using task6_ClassMatrix;

namespace task7_FindLongestPath
{
    class Program
    {
        static bool[,] walked;
        static int BFScounter;
        
        static void Main(string[] args)
        {
            int longestPath = 0;
            int[] longestPathEntryPosition = new int[2];
            BFScounter = 0;

            Console.WriteLine("Enter matrix row,col,values in BGcoder style: (check for a sample test under my code)");

            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            walked = new bool[row,col];
            Matrix matrix = new Matrix(row, col);

            //fill matrix with values
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (walked[i, j] == false)
                    {
                        BFScounter = 0;
                        BFS(matrix, i,j);
                        if (BFScounter > longestPath)
                        {
                            longestPath = BFScounter;
                            longestPathEntryPosition[0] = i;
                            longestPathEntryPosition[1] = j;
                        }
                    }
                }
            }
            
            Console.WriteLine("longest path length = {0}",longestPath);
            walked = new bool[row, col];
            BFS(matrix, longestPathEntryPosition[0], longestPathEntryPosition[1]);
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < col; j++)
                {
                    if (walked[i, j] == false)
                    {
                        Console.Write("{0,3}",matrix[i, j]);
                    }
                    else
                    {
                        Console.Write("{0,3}","#");
                    }
                }
            }
            Console.WriteLine();

        }

        static void BFS(Matrix matrix, int i, int j)
        {
            BFScounter++;
            walked[i, j] = true;
            int addend = -1;
            do
            {
                if (IsValidCell(matrix, i + addend, j) && walked[i + addend, j] == false && matrix[i + addend, j] == matrix[i, j])
                {
                    BFS(matrix, i + addend, j);
                }
                if (IsValidCell(matrix, i, j + addend) && walked[i, j + addend] == false && matrix[i, j + addend] == matrix[i, j])
                {
                    BFS(matrix, i, j + addend);
                }
                addend += 2;
            }
            while (addend <= 1);          
        }

        static bool IsValidCell(Matrix matrix, int i, int j)
        {
            if (i < 0 || i >= matrix.GetRows || j < 0 || j >= matrix.GetCols)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
/*test*
 * 5
 * 6
 * 1
 * 3
 * 2
 * 2
 * 2
 * 4
   3
 * 3
 * 3
 * 2
 * 4
 * 4
   4
 * 3
 * 1
 * 2
 * 3
 * 3
   4
 * 3
 * 1
 * 3
 * 3
 * 1
   4
 * 3
 * 3
 * 3
 * 1
 * 1
 
 */