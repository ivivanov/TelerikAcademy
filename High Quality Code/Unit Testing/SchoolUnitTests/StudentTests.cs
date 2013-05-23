using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task1School;

namespace task1SchoolUnitTests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestStudentCtor()
        {
            Student newStudent = new Student("Ivan", 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNameArgumentException()
        {
            Student newStudent = new Student(null, 1);
        }

        [TestMethod]
        public void TestGetName()
        {
            Student newStudent = new Student("Ivan", 1);
            string getName = newStudent.Name;
            Assert.AreEqual("Ivan", getName);
        }

        [TestMethod]
        public void TestGetId()
        {
            Student newStudent = new Student("Ivan", 1);
            int getId = newStudent.Id;
            Assert.AreEqual(1, getId);
        }
    }
}
