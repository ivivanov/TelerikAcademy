using System;

namespace GenericList
{
    class ListTests
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////Task5 GenericList - TESTS////////////////////////////////////////////////////////////
            GenericList<int> myList = new GenericList<int>();

            //////////////////////////Adding///////////////////////////////
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(-7);
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Test Adding elements");
            Console.WriteLine("This is my list: "+myList);

            //////////////////////////Inserting///////////////////////////////
            myList.InsertAt(2, 333);
            myList.InsertAt(0, 333);
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Test Insert of elements");
            Console.WriteLine(myList);

            /////////////////////////Removeing////////////////////////////////
            myList.Remove(0);
            myList.Remove(2);
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Test Remove of elements");
            Console.WriteLine(myList);

            /////////////////////Min item////////////////////////////////////
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Test finding min item");
            Console.WriteLine(myList.Min<int>());

            /////////////////////Max item////////////////////////////////////
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Test finding max item");
            Console.WriteLine(myList.Max<int>());


        }
    }
}
