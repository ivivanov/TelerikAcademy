using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task1School;

namespace task1SchoolUnitTests
{
    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void TestCourseCtor()
        {
            Course newCourse = new Course("Math");
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCourseCtorArgumentException()
        {
            Course newCourse = new Course(null);
        }

        [TestMethod]
        public void TestGetName()
        {
            Course newCourse = new Course("Math");
            string name = newCourse.Name;
            Assert.AreEqual("Math", name);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestEnrollStudentInvalidOperationException1()
        {
            Course newCourse = new Course("Math");

            Student newStudent = new Student("Ivan", 1);
            newCourse.EnrollStudent(newStudent);

            Student newStudent2 = new Student("Ivan", 1);
            newCourse.EnrollStudent(newStudent2);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestEnrollStudentInvalidOperationException2()
        {
            Course newCourse = new Course("Math");

            for (int i = 0; i < 33; i++)
            {
                Student newStudent = new Student("Ivan", i);
                newCourse.EnrollStudent(newStudent);
            }
        }

        [TestMethod]
        public void TestEnrollStudent()
        {
            Course newCourse = new Course("Math");
            Student newStudent = new Student("Ivan", 1);
            newCourse.EnrollStudent(newStudent);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestDismissStudentInvalidOperationException1()
        {
            Course newCourse = new Course("Math");
            newCourse.DismissStudent(new Student("asd", 1));
        }

        [TestMethod]
        public void TestDismissStudent()
        {
            Course newCourse = new Course("Math");
            Student newStudent = new Student("Ivan", 1);
            newCourse.EnrollStudent(newStudent);
            newCourse.DismissStudent(newStudent);
        }
    }
}