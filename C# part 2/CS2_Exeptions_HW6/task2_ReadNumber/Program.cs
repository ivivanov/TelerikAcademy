using System;


namespace task2_ReadNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. If an invalid number or non-number text is entered, the method should throw an exception. 
            //Using this method write a program that enters 10 numbers:
			//a1, a2, … a10, such that 1 < a1 < … < a10 < 100
            int start = -10;
            int end = 120;
            ReadNumber(start, end);

        }

        static void ReadNumber(int start, int end)
        {
            int temp=0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter Number {0}",i+1);
                try
                {
                    temp = int.Parse(Console.ReadLine());
                    if (temp < start || temp > end)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number or number out of the required range");
                }
            }
        }
    }
}
