using System;

namespace Pillars
{
    class BitMatrix
    {
        static void Main(string[] args)
        {
            //read input
            byte[] input = new byte[8];
            for (int i = 0; i < 8; i++)
            {
                input[i] = byte.Parse(Console.ReadLine());
            }

            //Fill matrix with 0s
            char[,] matrix = new char[8, 8];
            
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    matrix[i, j] = '0';
                }
            }
            
            //Fill matrix with input in binary
            string temp = "";
            
            for (int i = 0; i < 8; i++)
            {
                temp = Convert.ToString(input[i], 2);
                //Console.WriteLine("temp:{0}->{1} ", input[i],temp);
                int count = temp.Length - 1;
                for (int j = 7; j >= 8-temp.Length; j--)
                {
                    matrix[i, j] = temp[count--];
                }
            }

            //Finding the mostleft pillar
            byte flag = 0;
            for (int i = 0; i <8; i++)
            {
                if (i == 0)
                {
                    if (CountNonEmpty(i + 1, 7, matrix) == 0)
                    {
                        Console.WriteLine(7 - i);
                        Console.WriteLine(0);
                        flag = 1;
                        break;
                    }
                }
                else
                {
                    if (i == 7)
                    {
                        if (CountNonEmpty(0, i - 1, matrix) == 0)
                        {
                            Console.WriteLine(7 - i);
                            Console.WriteLine(0);
                            flag = 1;
                            break;
                        }
                    }
                    else
                    {
                        if (CountNonEmpty(i + 1, 7, matrix) == CountNonEmpty(0, i - 1, matrix))
                        {
                            Console.WriteLine(7 - i);
                            Console.WriteLine(CountNonEmpty(i + 1, 7, matrix));
                            flag = 1;
                            break;
                        }
                    }
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("No");
            }
        }

        static int CountNonEmpty(int from, int to, char[,] matrix)
        {
            int result = 0;
            for (int rows = 0; rows < 8; rows++)
            {
                for (int cols = from; cols <= to; cols++)
                {
                    if (matrix[rows, cols] == '1')
                    {
                        result++;
                    }
                }
            }
            return result;
        }
    }
}
