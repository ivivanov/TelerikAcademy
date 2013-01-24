using System;
using System.Collections.Generic;

namespace task8_BigIntegers
{
    public class BigInts
    {
        static void Main()
        {
            //Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; 
            //the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.
            char[] numAarr = "321".ToCharArray();
            char[] numBarr = "0168".ToCharArray();
            BigInts instance = new BigInts();
            char[] sum = instance.AddTwoNumbers(numAarr, numBarr);
            string suma = string.Join("", sum);
            Console.WriteLine(sum);
        }

        public char[] AddTwoNumbers(char[] numAarr, char[] numBarr)
        {
            Array.Reverse(numAarr);
            Array.Reverse(numBarr);
            int size = numAarr.Length > numBarr.Length ? numAarr.Length : numBarr.Length;
            bool oneOnMind = false;
            int tempSum = 0;
            List<int> sum = new List<int>();
            for (int i = 0; i < size; i++)
            {
                tempSum = 0;
                if (LegitIndex(numAarr, i) && LegitIndex(numBarr, i))
                {
                    tempSum = CalculateTempSum(numAarr[i], numBarr[i], ref oneOnMind);
                    sum.Add(tempSum);
                }
                else
                {
                    if (LegitIndex(numAarr, i))
                    {
                        tempSum = CalculateTempSum(numAarr[i], '0', ref oneOnMind);
                        sum.Add(tempSum);
                    }
                    else
                    {
                        tempSum = CalculateTempSum('0', numBarr[i], ref oneOnMind);
                        sum.Add(tempSum);
                    }
                }
            }
            if (oneOnMind)
            {
                sum.Add(1);
            }

            sum.Reverse();
            string suma = string.Join("", sum.ToArray());
            return suma.ToCharArray();
        }

        static int CalculateTempSum(char p1, char p2,ref bool oneOnMind)
        {
            int tempSum = GetNumberFromChar(p1) + GetNumberFromChar(p2);
            if (oneOnMind)
            {
                tempSum++;
                oneOnMind = false;
            }
            if (tempSum > 9)
            {
                tempSum = tempSum % 10;
                oneOnMind = true;
            }
            return tempSum;
        }

        static int GetNumberFromChar(char p)
        {
            return p - '0';
        }

        static bool LegitIndex(char[] arr, int i)
        {
            if (i < 0 || i > arr.Length - 1)
            {
                return false;
            }
            return true;
        }
    }
}
