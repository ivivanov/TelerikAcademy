using System;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            //We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.
            Console.WriteLine("Enter the amount of numbers: ");
            int countNumbers = int.Parse(Console.ReadLine());
            int[] listOfNumbers = new int[countNumbers];
            for (int i = 0; i < countNumbers; i++)
            {
                Console.Write("Enter number {0}: ", i + 1);
                listOfNumbers[i] = int.Parse(Console.ReadLine());
            }
            
            
            int combinations = (int)Math.Pow(2, countNumbers) - 1;

            for (int i = 1; i <= combinations; i++)
            {
                SumOfNumbersOnPositions(listOfNumbers, i);
            }

        }

        static void SumOfNumbersOnPositions(int[] listOfNumbers, int intToBin)
        {
            bool[] arrOfBools = new bool[listOfNumbers.Length];

            int binary = int.Parse(Convert.ToString(intToBin, 2));
            int sum=0;

            for (int i = arrOfBools.Length-1; i >= 0 ; i--)
            {
                if (binary % 10 == 1)
                {
                    sum += listOfNumbers[i];
                    arrOfBools[i] = true;
                }
                binary /= 10;
            }
            if (sum == 0)
            {
                Print(listOfNumbers, arrOfBools);
            }
        }

        static void Print(int[] listOfNumbers, bool[] arrOfBools)
        {
            int length = listOfNumbers.Length;
            int numbercount = 0;
            
            for (int i = 0; i < length; i++)
            {
                if (arrOfBools[i] == true)
                {
                    numbercount++;
                }
            }
            int[] trueNumbers = new int[numbercount];

            for (int i = 0; i < length; i++)
            {
                if (arrOfBools[i] == true)
                {
                    trueNumbers[--numbercount] = listOfNumbers[i];
                }
            }

            if (trueNumbers.Length > 1)
            {
                for (int i = 0; i < trueNumbers.Length; i++)
                {
                    if (i == 0)
                    {
                        Console.Write(trueNumbers[i]);
                    }
                    else
                    {
                        if (trueNumbers[i] >= 0)
                        {
                            Console.Write("+{0}", trueNumbers[i]);
                        }
                        else
                        {
                            Console.Write(trueNumbers[i]);
                        }
                    }
                }
                Console.Write("=0 \n");
            }
        }
    }
}
