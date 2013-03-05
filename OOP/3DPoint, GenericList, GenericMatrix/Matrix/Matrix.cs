/*
* Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
* Implement an indexer this[row, col] to access the inner matrix cells.
* Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication. 
* Throw an exception when the operation cannot be performed. Implement the true operator (check for non-zero elements).
*/

using System;
using System.Text;

namespace MatrixClass
{
    public class Matrix<T> where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>, new()
    {
        #region Fields
        
        private readonly int rows;
        private readonly int cols;
        private T[,] matrix;
        
        #endregion
        
        #region Constructors
        
        public Matrix() : this(0, 0, new T[0, 0])
        {
        }
        
        public Matrix(int rows, int cols) : this(rows, cols, new T[rows, cols])
        {
        }
        
        public Matrix(int rows, int cols, T[,] matr)
        {
            this.rows = rows;
            this.cols = cols;
            this.matrix = matr;
        }
        
        #endregion
        
        #region Properties
        
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
        
        public T this[int i, int j]
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
        
        #endregion
        
        #region Methods
        
        public void Print()
        {
            Console.WriteLine(new string('-', 20));
            for (int i = 0; i < GetRows; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < GetCols; j++)
                {
                    Console.Write("{0,8}", this.matrix[i, j]);
                }
            }
            Console.WriteLine();
        }
        
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            
            for (int i = 0; i < this.GetRows; i++)
            {
                builder.Append('\n');
                for (int j = 0; j < this.GetCols; j++)
                {
                    builder.Append(this.matrix[i, j]).Append("  ");
                }
            }
            return builder.ToString();
        }
        
        public void Duplicate(Matrix<T> matr)
        {
            if ((this.GetCols != matr.GetCols) || (this.GetRows != matr.GetRows))
            {
                throw new FormatException("Matricses are not with same dimensions");
            }
            else
            {
                for (int i = 0; i < matr.GetRows; i++)
                {
                    for (int j = 0; j < matr.GetCols; j++)
                    {
                        matr[i, j] = this.matrix[i, j];
                    }
                }
            }
        }
        
        //Operators overloading
        public static Matrix<T> operator +(Matrix<T> leftMatrix, Matrix<T> rightMatrix)
        {
            if ((leftMatrix.GetRows != rightMatrix.GetRows) || (leftMatrix.GetCols != rightMatrix.GetCols))
            {
                throw new FormatException("Adding (+) can't be used on matrixes with diferent dimensions");
            }
            else
            {
                Matrix<T> result = new Matrix<T>(leftMatrix.GetRows, leftMatrix.GetCols);
                for (int i = 0; i < leftMatrix.GetRows; i++)
                {
                    for (int j = 0; j < leftMatrix.GetCols; j++)
                    {
                        result.matrix[i, j] = (dynamic)leftMatrix.matrix[i, j] + (dynamic)rightMatrix.matrix[i, j];
                    }
                }
                return result;
            }
        }
        
        public static Matrix<T> operator -(Matrix<T> leftMatrix, Matrix<T> rightMatrix)
        {
            if ((leftMatrix.GetRows != rightMatrix.GetRows) || (leftMatrix.GetCols != rightMatrix.GetCols))
            {
                throw new FormatException("Substracting (-) can't be used on matrixes with diferent dimensions");
            }
            else
            {
                Matrix<T> result = new Matrix<T>(leftMatrix.GetRows, leftMatrix.GetCols);
                for (int i = 0; i < leftMatrix.GetRows; i++)
                {
                    for (int j = 0; j < leftMatrix.GetCols; j++)
                    {
                        result.matrix[i, j] = (dynamic)leftMatrix.matrix[i, j] - (dynamic)rightMatrix.matrix[i, j];
                    }
                }
                return result;
            }
        }
        
        public static Matrix<T> operator *(Matrix<T> leftMatrix, Matrix<T> rightMatrix)
        {
            if (leftMatrix.GetCols != rightMatrix.GetRows)
            {
                throw new FormatException("Multiplying  (*) can be used on matrixes with dimensions like: Matrix one dim: ???xA matrix two dim: Ax??? ");
            }
            else
            {
                int rows = leftMatrix.GetRows;
                int cols = rightMatrix.GetCols;
                Matrix<T> result = new Matrix<T>(rows, cols);
                
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        dynamic sum = 0;
                        for (int x = 0; x < cols; x++)
                        {
                            sum = sum + (dynamic)leftMatrix.matrix[i, x] * (dynamic)rightMatrix.matrix[x, j];
                        }
                        result.matrix[i, j] = sum;
                    }
                }
                
                return result;
            }
        }
        
        //Implement the true operator (check for non-zero elements).
        public static bool operator true(Matrix<T> matr)
        {
            for (int i = 0; i < matr.GetRows; i++)
            {
                for (int j = 0; j < matr.GetCols; j++)
                {
                    //matr[i, j] == 0
                    int zero = 0;
                    if (matr[i, j].CompareTo((T)Convert.ChangeType(zero, typeof(T))) == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        
        public static bool operator false(Matrix<T> matr)
        {
            for (int i = 0; i < matr.GetRows; i++)
            {
                for (int j = 0; j < matr.GetCols; j++)
                {
                    //matr[i, j] == 0
                    int zero = 0;
                    if (matr[i, j].CompareTo(new T()) == 0)
                    //if (matr[i, j].CompareTo(default(T)) == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    
        #endregion
    }
}

