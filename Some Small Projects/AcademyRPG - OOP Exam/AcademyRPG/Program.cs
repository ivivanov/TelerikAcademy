using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    class Program
    {
        static Engine GetEngineInstance()
        {
            return new CustomEngine();
        }

        static void Main(string[] args)
        {
            #if DEBUG
            Console.SetIn(new System.IO.StreamReader(@"../../sample.in.txt"));
            #endif 
            Engine engine = GetEngineInstance();

            string command = Console.ReadLine();
            while (command != "end")
            {
                engine.ExecuteCommand(command);
                command = Console.ReadLine();
            }
        }
    }
}