using System;

namespace task3_DateTimeWeekDay
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints to the console which day of the week is today. Use System.DateTime.

            DateTime weekDay = new DateTime();
            weekDay = DateTime.Now;
            Console.WriteLine("Today is {0}",weekDay.DayOfWeek);
        }
    }
}
