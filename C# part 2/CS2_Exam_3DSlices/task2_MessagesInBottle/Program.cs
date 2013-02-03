using System;
using System.IO;

namespace task2_MessagesInBottle
{
    class Program
    {
        static void Main(string[] args)
        {
        #if DEBUG
            Console.SetIn(new StreamReader(@"../../test.txt"));    
        #endif
            string message = Console.ReadLine();
            string chipher = Console.ReadLine();
        }
    }
}
