
/*
 * Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. Use LINQ query operators.
 */
using ClassStudent;
using System;
using System.Collections.Generic;
using System.Linq;

namespace task3_StudentsNames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = Student.students;

            var query = from student in students
                        where student.FName.CompareTo(student.LName) < 0
                        select student;

            Console.WriteLine("All students whose first name is before its last name alphabetically: ");
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
