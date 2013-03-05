/*
* Define abstract class Human with first name and last name.
* Define new class Student which is derived from Human and has new field – grade. 
* Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and 
* method MoneyPerHour() that returns money earned by hour by the worker. 
* Define the proper constructors and properties for this hierarchy. 
*
* Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method). 
* Initialize a list of 10 workers and sort them by money per hour in descending order. 
* Merge the lists and sort them by first name and last name.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2_AbstractClassHuman
{
    class TestApp
    {
        static Random randNum = new Random();

        static void Main(string[] args)
        {
            Random twoDigitNumber = new Random();
            List<Student> students = new List<Student>();
            List<Worker> workers = new List<Worker>();
            for (int i = 0; i < 10; i++)
            {
                students.Add(new Student(RandomName(), RandomName(), RandomGrade()));
                workers.Add(new Worker(RandomName(), RandomName(), (decimal)randNum.Next(400, 801), (byte)(randNum.Next(5, 10))));
            }

            ////////////////////////////////Sorted grade in ascending order////////////////////////////////
            var sortedStudents = students.OrderBy(x => x.Grade);
            Console.WriteLine(new string('-',80));
            Console.WriteLine("Sorted grade in ascending order");
            foreach (Student student in sortedStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.Grade);
            }

            ////////////////////////////////Sorted by by money per hour in descending order////////////////////////////////
            var sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Sorted by by money per hour in descending order");
            foreach (Worker worker in sortedWorkers)
            {
                Console.WriteLine("{0} {1} {2:f2}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }

            List<Human> humans = new List<Human>(sortedStudents.ToList());
            humans.AddRange(sortedWorkers.ToList());

            ////////////////////////////////Sorted by first name and last name.////////////////////////////////
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Sorted by first name and last name");
            var sortedHumans = humans.OrderBy(x => x.LastName).OrderBy(x => x.FirstName);
            foreach (Human human in sortedHumans)
            {
                Console.WriteLine(human.FirstName + " " + human.LastName);
            }
        }

        private static byte RandomGrade()
        {
            return (byte)(randNum.Next(1, 5));
        }

        private static string RandomName()
        {
            StringBuilder name = new StringBuilder(); 
            byte length = (byte)randNum.Next(3, 10);
            for (int i = 0; i < length; i++)
            {
                name.Append((char)(randNum.Next(97, 123)));
            }
            char[] Name = name.ToString().ToCharArray();
            Name[0] = char.ToUpper(Name[0]);
            return new string(Name);
        }
    }
}