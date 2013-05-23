using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task1School;
using System.IO;
using System.Text;

namespace task1SchoolUnitTests
{
    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSchoolCtor()
        {
            School newSchool = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetNameArgumentException()
        {
            School newSchool = new School("smg");
            string name = newSchool.Name;
            newSchool.Name = null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAddStudentArgumentExeption()
        {
            School newSchool = new School("smg");
            newSchool.AddStudent(null);
        }

        [TestMethod]
        public void TestAddStudent()
        {
            School newSchool = new School("smg");
            newSchool.AddStudent("Petkan");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAddCourseArgumentExeption()
        {
            School newSchool = new School("smg");
            newSchool.AddCourse(null);
        }

        [TestMethod]
        public void TestAddCourse()
        {
            School newSchool = new School("smg");
            newSchool.AddCourse("Math");
        }

        [TestMethod]
        public void TestStudentsListDefaultMsg()
        {
            School newSchool = new School("smg");
            Assert.AreEqual("Sorry, there are no students in this school", newSchool.StudentsList());
        }

        [TestMethod]
        public void TestCoursesListDefaultMsg()
        {
            School newSchool = new School("smg");
            Assert.AreEqual("Sorry, there are no courses in this school", newSchool.CoursesList());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEnrollStudentToCourseArgumentExeption()
        {
            School newSchool = new School("smg");
            newSchool.EnrollStudentToCourse(null, 1);                
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestEnrollStudentToCourseArgumentOutOfRangeException()
        {
            School newSchool = new School("smg");
            newSchool.EnrollStudentToCourse("Ivan Ivanov", 1);
        }

        [TestMethod]
        public void TestEnrollStudentToCourse()
        {
            School newSchool = new School("smg");
            newSchool.AddStudent("Ivan");
            newSchool.AddCourse("Math");
            newSchool.EnrollStudentToCourse("Math", 10000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DismissStudentFromCourseArgumentExeption()
        {
            School newSchool = new School("smg");
            newSchool.DismissStudentFromCourse(null, 1);                
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DismissStudentFromCourseArgumentOutOfRangeException()
        {
            School newSchool = new School("smg");
            newSchool.DismissStudentFromCourse("Ivan Ivanov", 1);
        }

        [TestMethod]
        public void DismissStudentFromCourse()
        {
            School newSchool = new School("smg");
            newSchool.AddStudent("Ivan");
            newSchool.AddCourse("Math");
            newSchool.EnrollStudentToCourse("Math", 10000);
            newSchool.DismissStudentFromCourse("Math", 10000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetNextFreeIdArgumentOutOfRangeException()
        {
            School newSchool = new School("smg");
            for (int i = 0; i < 1000001; i++)
            {
                newSchool.AddStudent(i.ToString());
            }
        }

        [TestMethod]
        public void TestToStringEmpty()
        { 
            School newSchool = new School("smg");
            StringBuilder result = new StringBuilder();
            result.AppendLine(newSchool.CoursesList());
            result.AppendLine(newSchool.StudentsList());
            Assert.AreEqual(result.ToString(), newSchool.ToString());
        }

        [TestMethod]
        public void TestToString()
        {
            School SMG = new School("Sofia Math Gymnasium");

            SMG.AddStudent("Ivan Ivanov");
            SMG.AddStudent("Georgi Georgiev");
            SMG.AddStudent("Ivan Georgiev");
            SMG.AddStudent("Georgi Ivanov");

            SMG.AddCourse("Biology");
            SMG.AddCourse("Mathematics");

            SMG.EnrollStudentToCourse("Biology", 10001);
            SMG.EnrollStudentToCourse("Biology", 10002);
            SMG.EnrollStudentToCourse("Biology", 10000);

            string expected =
                @"Course Name: Biology Enrolled Students: 3
Course Name: Mathematics Enrolled Students: 0

Id: 10000  Name: Ivan Ivanov
Id: 10001  Name: Georgi Georgiev
Id: 10002  Name: Ivan Georgiev
Id: 10003  Name: Georgi Ivanov

";

            Assert.AreEqual(expected, SMG.ToString());
        }
    }
}