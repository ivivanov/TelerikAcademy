using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. Example:
            //Enter the first date: 27.02.2006
            //Enter the second date: 3.03.2006
            //Distance: 4 days
            string[] formats = {@"d.MM.yyyy"};
            DateTime date1 = DateTime.ParseExact(Console.ReadLine(), formats, CultureInfo.InvariantCulture, DateTimeStyles.None);
            DateTime date2 = DateTime.ParseExact(Console.ReadLine(), formats, CultureInfo.InvariantCulture, DateTimeStyles.None);
            TimeSpan timespan = date2 - date1;
            Console.WriteLine("Distance: {0} days", timespan.Days);
        }
    }
}
