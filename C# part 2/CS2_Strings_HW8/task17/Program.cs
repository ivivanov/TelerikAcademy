using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the 
            //date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
            string date = "13.1.2000 10:00:00";
            string[] formats = { "d.M.yyyy H:mm:ss" };
            DateTime date1 = DateTime.ParseExact(date, formats, CultureInfo.InvariantCulture, DateTimeStyles.None);
            //TimeSpan add = new TimeSpan(0, 6, 30, 0);
            date1= date1.AddHours(6.5);
            CultureInfo bg = new CultureInfo("bg-BG");
            Console.WriteLine("{0} {1}",date1.ToString(formats[0]), date1.ToString("dddd",bg));
        }
    }
}
