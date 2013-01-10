using System;

namespace FallDown
{
    class FallDown
    {
        static byte[,] matrix = new byte[8, 8];

        static void Main(string[] args)
        {
            byte line1 = byte.Parse(Console.ReadLine());
            byte line2 = byte.Parse(Console.ReadLine());
            byte line3 = byte.Parse(Console.ReadLine());
            byte line4 = byte.Parse(Console.ReadLine());
            byte line5 = byte.Parse(Console.ReadLine());
            byte line6 = byte.Parse(Console.ReadLine());
            byte line7 = byte.Parse(Console.ReadLine());
            byte line8 = byte.Parse(Console.ReadLine());


            byte[] numbers = { line1, line2, line3, line4, line5, line6, line7, line8 };

            for (int i = 0; i < 8; i++)
            {
                FillMatrixLine((byte)i, numbers[i]);
            }

            //PrintMatrix();

            TetrisMove();
            //PrintMatrix();
            CreateNumbers();
        }

        static void CreateNumbers()
        {
            string numberStr = "";
            
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    numberStr = numberStr + (Convert.ToString(matrix[i, j]));
                }
                Console.WriteLine(ConverBinToDecimal(numberStr));
                numberStr = "";
            }
        }

        static byte ConverBinToDecimal(string numberStr)
        {
            byte result = 0;
            byte exponent=7;
            for (int i = 0; i < 8; i++)
            {
                if (numberStr[i] == '1')
                {
                    result += (byte)Math.Pow(2, exponent);
                }
                exponent--;
            }

            return result;
        }

        static void TetrisMove()
        {
            byte columnOnesCount = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (matrix[j,i] == 1)
                    {
                        columnOnesCount++;
                    }
                }
                FillMatrixColumn(i, columnOnesCount);
                columnOnesCount = 0;
            }
        }

        static void FillMatrixColumn(int column, byte columnOnesConut)
        {
            for (int i = 0; i < 8; i++)
            {
                matrix[i, column] = 0;
            }

            for (int i = 7; i > 7 - columnOnesConut; i--)
            {
                matrix[i, column] = 1;
            }
        }

        static void PrintMatrix()
        {
            for (int i = 0; i < 8; i++)
            {
                
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void FillMatrixLine(byte line, byte decimalNumber)
        {
            string binaryNumberStr = Convert.ToString(decimalNumber, 2);
            int binaryNumberNum = int.Parse(binaryNumberStr);

            for (int col = 7; col >= 0; col--)
            {
                matrix[line, col] = (byte)(binaryNumberNum % 10);
                binaryNumberNum /= 10;
            }
        }
    }
}
