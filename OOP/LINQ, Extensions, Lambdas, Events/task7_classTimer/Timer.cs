/*
* Using delegates write a class Timer that can execute certain method at each t seconds.
*/

using System;
using System.Linq;

namespace task7_classTimer
{
    public delegate void FunctionDelegate(int param);

    public class Timer
    {
        public static void Method(int seconds)
        {
            while (true)
            { 
                Console.Clear();
                Console.WriteLine(DateTime.Now);
                System.Threading.Thread.Sleep(seconds * 1000);
            }
        }

        static void Main(string[] args)
        {
            FunctionDelegate d = new FunctionDelegate(Method);
            Console.WriteLine("Enter interval in seconds: ");
            d(int.Parse(Console.ReadLine()));
        }
    }
}
