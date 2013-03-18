using System;

namespace Person
{
    class TestApp
    {
        static void Main(string[] args)
        {
            Person x = new Person("Ivna");
            Console.WriteLine(x);
            Person y = new Person("Divna", 13);
            Console.WriteLine(y);
        }
    }
}
