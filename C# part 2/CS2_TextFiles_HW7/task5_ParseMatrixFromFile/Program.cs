using System;
using System.IO;
using System.Text;
using MaxAreaFunction;
namespace task5_ParseMatrixFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements.
            //The first line in the input file contains the size of matrix N. Each of the next N lines contain N numbers separated by space. 
            //The output should be a single number in a separate text file.

            string path = @"C:\Users\Ivan\Desktop\matrix.txt";
            string path2 = @"C:\Users\Ivan\Desktop\result.txt";
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");
            string matrix = null;
            try
            {
                StreamReader matrixFile = new StreamReader(path, win1251);
                using (matrixFile)
                {
                    matrix = matrixFile.ReadToEnd();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
            matrix = matrix.Trim();
            matrix = matrix.Replace("\r\n", " ");
            MatrixMaxArea inst = new MatrixMaxArea();
            int maxSum = inst.MatrixMaxAreaSum(matrix);
            try
            {
                StreamWriter writer = new StreamWriter(path2, false, win1251);
                using (writer)
                {
                    writer.WriteLine(maxSum);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
            Console.WriteLine("Successesful calculation!");
        }
    }
}
