using System;

namespace task1_Hello
{
    public class Task1
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Task1 s = new Task1();
            Console.WriteLine(s.SayHello(name));
        }

        public string SayHello(string name)
        {
            return "Hello, " + name + "!";
        }
    }
}
