using System;
using task1School;

namespace task1SchoolDemo
{
    public class Demo
    {
        public static void Main(string[] args)
        {
            try
            {
                School SMG = new School("Sofia Math Gymnasium");
                Console.WriteLine(SMG.ToString());

                SMG.AddStudent("Ivan Ivanov");
                SMG.AddStudent("Georgi Georgiev");
                SMG.AddStudent("Ivan Georgiev");
                SMG.AddStudent("Georgi Ivanov");

                SMG.AddCourse("Biology");
                SMG.AddCourse("Mathematics");

                // First we get the list of student to find which student id we need!
                SMG.EnrollStudentToCourse("Biology", 10001);
                SMG.EnrollStudentToCourse("Biology", 10002);
                SMG.EnrollStudentToCourse("Biology", 10000);
                // SMG.EnrollStudentToCourse("Biology", 10000); // Exception thrown: "The student you are trying to enroll is allready enrolled in this course"

                SMG.DismissStudentFromCourse("Biology", 10000);
                // SMG.DismissStudentFromCourse("Biology", 10000); // Exception thrown: "There is no such student in this course"

                Console.WriteLine(SMG.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}