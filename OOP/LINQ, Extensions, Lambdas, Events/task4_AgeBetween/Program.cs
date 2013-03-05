
/*
 * Write a LINQ query that finds the first name and last name of all students with age between 18 and 24
 */
using ClassStudent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace task4_AgeBetween
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = Student.students;

            var query = from student in students
                        where student.Age >= 18 && student.Age <= 24
                        select new { FName = student.FName, LName = student.LName };

            Console.WriteLine("All all students with age between 18 and 24: ");
            foreach (var item in query)
            {
                Console.WriteLine(item.FName + " " + item.LName);
            }
        }
    }
}
