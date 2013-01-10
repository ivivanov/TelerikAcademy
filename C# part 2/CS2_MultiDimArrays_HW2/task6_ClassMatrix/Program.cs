using System;

namespace task6_ClassMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a class Matrix, to holds a matrix of integers. Overload the operators for adding, 
            //subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().


            Matrix matr = new Matrix(3, 3);
            Matrix matr2 = new Matrix(3, 3);
            matr.FillMatrix();
            matr2.FillMatrix();

            Console.WriteLine("1st matrix");
            matr.Print();
            Console.WriteLine("2nd matrix");
            matr2.Print();

            Matrix matr3 = new Matrix(3, 3);

            Console.WriteLine("Operator + in action");
            matr3 = matr + matr2;
            matr3.Print();

            Console.WriteLine("Operator - in action");
            matr3 = matr - matr2;
            matr3.Print();

            Console.WriteLine("Operator * in action");
            matr3 = matr * matr2;
            matr3.Print();

            Console.WriteLine(matr.ToString());

            //Console.WriteLine(matr3[0, 0]);


            //Matrix matr = new Matrix(3, 2);
            //Matrix matr2 = new Matrix(2, 1);
            //Matrix matr3 = new Matrix(3, 1);
            //matr.FillMatrix();
            //matr2.FillMatrix();

            //Console.WriteLine("Operator * in action");
            //matr3 = matr * matr2;
            //matr3.Print();

        }
    }
}
// two simple matrixes
// 1 1 1    0 1 0
// 2 2 2    1 0 0
// 3 3 3    0 0 1
/*   ^        ^       
 *   1        0
 *   1        1
 *   1        0
 *   2        1
 *   2        0
 *   2        0
 *   3        0
 *   3        0
 *   3        1
 */

/*3x3 matrixes
   1        
   1        
   1        
   2        
   2        
   2        
   3        
   3        
   3    
 * 0
   1
   0
   1
   0
   0
   0
   0
   1
 * 
 * 3x2 * 2x1 = 3x1 matrix
 * 1
 * 1
 * 2
 * 2
 * 3
 * 3
 * 10
 * 10
*/