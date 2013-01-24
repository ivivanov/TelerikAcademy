using System;
using System.Collections.Generic;

namespace taks11_Polynomial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
		    //x2 + 5 = 1x2 + 0x + 5 -> |5|0|1|
            decimal[] poly1 = { -1, 1, 1 };
            decimal[] poly2 = { 6, 3, 2 };
            decimal[] poly3 = { -3, -2 };
            decimal[] poly4 = { -6, 3, 2, -5 };
            PrintPoly(Sum(poly1, poly2));
            PrintPoly(Multiplying(poly1, poly3));
            PrintPoly(Substract(poly1, poly2));
        }

        static decimal[] Substract(decimal[] poly1, decimal[] poly2)
        {
            for (int i = 0; i < poly2.Length; i++)
            {
                poly2[i] *= -1;
            }
            return Sum(poly1, poly2);
        }

        static decimal[] Multiplying(decimal[] poly1, decimal[] poly2)
        {
            decimal[] result = new decimal[poly1.Length * poly2.Length];
            for (int i = 0; i < poly1.Length; i++)
            {
                for (int j = 0; j < poly2.Length; j++)
                {
                    result[i + j] += poly1[i] * poly2[j];
                }
            }
            return result;
        }

        static decimal[] Sum(decimal[] poly1, decimal[] poly2)
        {
            List<decimal> result = new List<decimal>();
            int size = poly1.Length > poly2.Length ? poly1.Length : poly2.Length;

            for (int i = 0; i < size; i++)
            {
               if (LegitIndex(poly1, i) && LegitIndex(poly2, i))
               {
                   result.Add(poly1[i] + poly2[i]);
               }
               else
               {
                   if (LegitIndex(poly1, i))
                   {
                       result.Add(poly1[i]);
                   }
                   else
                   {
                       result.Add(poly2[i]);
                   }
               }
            }
            return result.ToArray();
        }

        static bool LegitIndex(decimal[] arr, int i)
        {
            if (i < 0 || i > arr.Length - 1)
            {
                return false;
            }
            return true;
        }

        static void PrintPoly(decimal[] poly)
        {
            for (int i = poly.Length - 1; i >= 0; i--)
            {
                if (poly[i] != 0 && i != 0)
                {
                    if (i == 1)
                    {
                        if (poly[i - 1] >= 0)
                        {
                            Console.Write("{0}x +", poly[i]);
                        }
                        else
                        {
                            Console.Write("{0}x ", poly[i]);
                        }
                    }
                    else
                    {
                        if (poly[i - 1] >= 0)
                        {
                            Console.Write("{1}x^{0} +", i, poly[i]);
                        }
                        else
                        {
                            Console.Write("{1}x^{0} ", i, poly[i]);
                        }
                    }
                }
                else
                {
                    if (i == 0)
                    {
                        Console.Write("{0}", poly[i]);
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
