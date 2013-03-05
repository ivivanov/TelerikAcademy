/*
* We are given a school. In the school there are classes of students. Each class has a set of teachers. 
* Each teacher teaches a set of disciplines. Students have name and unique class number.
* Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises. 
* Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
* Your task is to identify the classes (in terms of  OOP) and their attributes and operations,
* encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace task1_ClassSchool
{
    class TestApp
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student> { new Student(fname: "Ivan", lname: "Ivanov", number: 44598, comment: "") };
            List<Discipline> disciplines = new List<Discipline>
            {
                new Discipline(name:"Discreet Structures",numberOfLectures:1,numberOfExercises:1,comment:"1st course, 1st semeter"),
                new Discipline(name:"Design and Analysis of Algorithms",numberOfLectures:1,numberOfExercises:2,comment:"2nd course, 2nd semeter")
            };
            List<Teacher> teachers = new List<Teacher> { new Teacher(fname: "K.", lname: "Manev", disciplines:disciplines, comment: "Professor") };
            List<Class> classes = new List<Class> { new Class(students: students, teachers: teachers, disciplines: disciplines, textIdentifier: "Informatics, 2nd course, 1st flow") };
            
            School mySchool = new School("Faculty of Mathematics and Informatics",classes,teachers);    
        }
    }
}
