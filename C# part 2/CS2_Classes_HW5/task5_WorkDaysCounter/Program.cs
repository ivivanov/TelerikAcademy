using System;

namespace task5_WorkDaysCounter
{
    class Program
    {
        static DateTime[] publicHolydays = { new DateTime(9999, 1, 1), new DateTime(9999, 3, 3), new DateTime(9999, 5, 24), new DateTime(9999, 11, 1), new DateTime(9999, 12, 24), new DateTime(9999, 12, 25), new DateTime(9999, 12, 26) };
        static void Main(string[] args)
        {
            DateTime futureDate;
            Console.Write("Enter future date: ");
            if (!(DateTime.TryParse(Console.ReadLine(), out futureDate)))
            {
                Console.WriteLine("Not a valid date format. Correct format month.day.year or month/day/year");
            }
            else
            {
                Console.WriteLine(WorkDaysCounter(futureDate));
            }
        }

        static int WorkDaysCounter(DateTime futureDate)
        {
            DateTime now = DateTime.Now;
            int counter = 0;
            while (now.Year != futureDate.Year || now.Month != futureDate.Month || now.Day != futureDate.Day)
            {
                if (IsHolyday(now))
                {
                    now = now.AddDays(1);
                }
                else
                {
                    if (IsPublicHolyday(now))
                    {
                        now = now.AddDays(1);
                    }
                    else
                    {
                        counter++;
                        now = now.AddDays(1);
                    }
                }
            }
            return counter;
        }

        static bool IsPublicHolyday(DateTime now)
        {
            foreach (var item in publicHolydays)
            {
                if (item.Month == now.Month && item.Day == now.Day)
                {
                    return true;
                }
            }
            return false;
        }

        static bool IsHolyday(DateTime now)
        {
            if (now.DayOfWeek == DayOfWeek.Saturday || now.DayOfWeek == DayOfWeek.Sunday)
            {
                return true;
            }
            return false;
        }
    }
}
