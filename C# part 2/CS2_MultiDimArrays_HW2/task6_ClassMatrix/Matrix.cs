using System;
using System.Text;

namespace task6_ClassMatrix
{
    public class Matrix
    {
        //Fields
        private readonly int rows;
        private readonly int cols;
        private int[,] matrix;

        //Constructors
        public Matrix()
        {
            rows = 0;
            cols = 0;
            matrix = new int[0, 0];
        }

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.matrix = new int[rows, cols];
        }

        //Properties
        public int GetRows
        {
            get
            {
                return this.rows;
            }
        }

        public int GetCols
        {
            get
            {
                return this.cols;
            }
        }

        public int this[int i, int j]
        {
            get
            {
                if (i < 0 || j < 0 || i > this.rows || j > this.cols)
                {
                    throw new IndexOutOfRangeException("Trying to access not existing element!");
                }
                return matrix[i, j];
            }
            set
            {
                matrix[i, j] = value;
            }
        }


        //Methods
        public void FillMatrix()
        {
            for (int i = 0; i < GetRows; i++)
            {
                for (int j = 0; j < GetCols; j++)
                {
                    this.matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Print()
        {
            Console.WriteLine(new string('-', 20));
            for (int i = 0; i < GetRows; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < GetCols; j++)
                {
                    Console.Write("{0,3}", this.matrix[i, j]);
                }
            }
            Console.WriteLine();
        }

        public string ToString()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < this.GetRows; i++)
            {
                for (int j = 0; j < this.GetCols; j++)
                {
                    builder.Append(this.matrix[i,j]).Append(" ");
                }
            }
            return builder.ToString();
        }

        //Operators overloading

        public static Matrix operator +(Matrix leftMatrix, Matrix rightMatrix)
        {
            if ((leftMatrix.GetRows != rightMatrix.GetRows) || (leftMatrix.GetCols != rightMatrix.GetCols))
            {
                throw new FormatException("Adding (+) can't be used on matrixes with diferent dimensions");
            }
            else
            {
                Matrix result = new Matrix(leftMatrix.GetRows, leftMatrix.GetCols);
                for (int i = 0; i < leftMatrix.GetRows; i++)
                {
                    for (int j = 0; j < leftMatrix.GetCols; j++)
                    {
                        result.matrix[i, j] = leftMatrix.matrix[i, j] + rightMatrix.matrix[i, j];
                    }
                }
                return result;
            }
        }

        public static Matrix operator -(Matrix leftMatrix, Matrix rightMatrix)
        {
            if ((leftMatrix.GetRows != rightMatrix.GetRows) || (leftMatrix.GetCols != rightMatrix.GetCols))
            {
                throw new FormatException("Substracting (-) can't be used on matrixes with diferent dimensions");
            }
            else
            {
                Matrix result = new Matrix(leftMatrix.GetRows, leftMatrix.GetCols);
                for (int i = 0; i < leftMatrix.GetRows; i++)
                {
                    for (int j = 0; j < leftMatrix.GetCols; j++)
                    {
                        result.matrix[i, j] = leftMatrix.matrix[i, j] - rightMatrix.matrix[i, j];
                    }
                }
                return result;
            }
        }

        public static Matrix operator *(Matrix leftMatrix, Matrix rightMatrix)
        {
            if (leftMatrix.GetCols != rightMatrix.GetRows)
            {
                throw new FormatException("Multiplying  (*) can be used on matrixes with dimensions like: Matrix one dim: ???xA matrix two dim: Ax??? ");
            }
            else
            {
                int rows = leftMatrix.GetRows;
                int cols = rightMatrix.GetCols;
                Matrix result = new Matrix(rows, cols);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        int sum = 0;
                        for (int x = 0; x < cols; x++)
                        {
                            sum = sum + leftMatrix.matrix[i, x] * rightMatrix.matrix[x, j];
                        }
                        result.matrix[i, j] = sum;
                    }
                }

                return result;
            }
        }
    }
}
