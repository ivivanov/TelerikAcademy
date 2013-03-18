/*
* Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range.
* It should hold error message and a range definition [start … end].
* Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> 
* by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
*/

using System;
using System.Globalization;

namespace task3_ClassExeption
{
    class TestApp
    {
        static void Main(string[] args)
        {
            DateTime startDate = new DateTime(year: 1980, month: 1, day: 1);
            DateTime endDate = new DateTime(year: 2013, month: 12, day: 31);

            try
            {
                ReadNumber(1, 100);
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine("{0} Range:[{1},{2}]", e.Message, e.Start, e.End);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                ReadDate(startDate, endDate);
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine("{0} Range:[{1},{2}]", e.Message, e.Start, e.End);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void ReadNumber(int start, int end)
        {
            while (true)
            {
                int input;
                Console.WriteLine("Enter number between [{0}; {1}]", start, end);
                if (!int.TryParse(Console.ReadLine(), out input))
                {
                    throw new ArgumentException("Not valid input");
                }
                if (input < start || input > end)
                {
                    throw new InvalidRangeException<int>(start,end);
                }
            }
        }

        private static void ReadDate(DateTime startDate, DateTime endDate)
        {
            while (true)
            {
                DateTime input;
                Console.WriteLine("Enter date between: {0} - {1}", startDate, endDate);
                string pattern = "dd.MM.yyyy";
                if (!DateTime.TryParseExact(Console.ReadLine(), pattern, CultureInfo.InvariantCulture, DateTimeStyles.None, out input))
                {
                    throw new ArgumentException("Not valid input");
                }
                if (input.CompareTo(startDate) < 0 || input.CompareTo(endDate) > 0)
                {
                    throw new InvalidRangeException<DateTime>("Input is outside required range", startDate, endDate);
                }
            }
        }
    }
}
