/*
 * Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ.
 */
using ClassStudent;
using System;
using System.Linq;

namespace task5_OrderByThanBy
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = { 
                                     
                new Student { FName = "AAA", LName = "BBB",Age=3 }, 
                new Student { FName = "AAA", LName = "ZZZ",Age=54 }, 
                new Student { FName = "BBB", LName = "CCC",Age=18 }, 
                new Student { FName = "BBB", LName = "AAA",Age=14 }, 
                new Student { FName = "AAA", LName = "AAA",Age=22 } 
                                 };

            //////////////////////////////with LINQ///////////////////////////////////////
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("LINQ sorting\n");
            var query = from student in students
                        orderby student.FName descending, student.LName descending
                        select new { FName = student.FName, LName = student.LName };

            foreach (var item in query)
            {
                Console.WriteLine(item.FName + " " + item.LName);
            }

            //////////////////////////////with Lambda///////////////////////////////////////
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Lambda sorting\n");
            //var sorted = students.OrderByDescending(x => x.LName).OrderByDescending(x => x.FName);
            var sorted = students.OrderByDescending(x => x.FName).ThenByDescending(x => x.LName);

            foreach (var item in sorted)
            {
                Console.WriteLine(item.FName + " " + item.LName);
            }
        }
    }
}
