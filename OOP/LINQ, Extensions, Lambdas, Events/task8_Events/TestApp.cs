/*
* Using delegates write a class Timer that can execute certain method at each t seconds.
* Re-implement the above using .NET events and following the best practices.
*/
using System;

namespace task8_Events
{
    public class TestApp
    {
        public static void Main()
        {
            CountDownTimer timer = new CountDownTimer(seconds: 4, interval: 1);
            timer.TimeChanged += timerTimeChanged;
            timer.StartCountDownTimer();
        }

        //Event Handler
        public static void timerTimeChanged(object sender, TimeChangedEventArgs e)
        {
            Console.WriteLine("Seconds left: " + e.SecondsChanged);
        }

    }
}
