using System;
using System.IO;

namespace MatrixClass
{
    class MatrixTests
    {
        static void Main(string[] args)
        {
            //Redirectin console read to file for matrix fill and dim.
            //matrix.txt - On the first line of matrix.txt we get the dimension N (assuming we have NxN matrix) and on the next N^2 lines we have matrix values.
            #if DEBUG
            Console.SetIn(new StreamReader(@"../../matrix.txt"));          
            #endif     
            int n = int.Parse(Console.ReadLine());
            Matrix<decimal> matr = new Matrix<decimal>(n, n);
            matr.FillMatrix<decimal>();
            Matrix<decimal> matr2 = matr;
            //////////////////////PRINT/////////////////////////
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Test matrix Print()");
            matr.Print();
            //Console.WriteLine(matr);

            //////////////////////SUM/////////////////////////
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Test matrix sum: operator +");
            Matrix<decimal> sum = matr + matr2;
            sum.Print();

            //////////////////////SUBSTRACT/////////////////////////
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Test matrix substracion: operator -");
            Matrix<decimal> sub = matr - matr2;
            sub.Print();

            //////////////////////MULTIPLY/////////////////////////
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Test matrix multiplication: operator *");
            Matrix<decimal> mult = matr * matr2;
            mult.Print();

            //////////////////////OPERATOR true and false/////////////////////////
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Check for non-zero elements: operators true and false");
            Console.WriteLine("Testing if(matrix) with this matrix:");
            mult.Print();
            Console.WriteLine();
            if (mult)
            {
                Console.WriteLine("Matrix does not contain zero elements!");
            }
            else
            {
                Console.WriteLine("Matrix contain zero elements!");
            }


        }
    }
}
