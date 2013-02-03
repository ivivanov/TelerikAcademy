using System;

namespace task6_StringOfNumsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers in one line separated by Space and pres Enter:");
            string numbers = Console.ReadLine();

            Console.WriteLine(SumNumbers(numbers));

        }

        static double SumNumbers(string numbers)
        {
            numbers = numbers.Trim();
            string[] nums = numbers.Split();
            double sum = 0;
            foreach (var item in nums)
            {
                sum += double.Parse(item);
            }
            return sum;
        }
    }
}
