using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task1_Hello;
using task2_FindMax;
using task4_AppearCounter;
using task5_Neighbours;
using task6_ElementSearch;
using task7_ReverseNumber;
using task8_BigIntegers;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Task1Test()
        {
            Task1 instance = new Task1();
            Assert.AreEqual("Hello,  !", instance.SayHello(" "));
            Assert.AreEqual("Hello, !", instance.SayHello(""));
            Assert.AreEqual("Hello, Ivan!", instance.SayHello("Ivan"));
            Assert.AreEqual("Hello, K.V. Petrov!", instance.SayHello("K.V. Petrov"));
        }

        [TestMethod]
        public void Task2Test()
        {
            Task2 instance = new Task2();
            Assert.AreEqual(80, instance.GetMax(80, -1231231223));
            Assert.AreEqual(int.MaxValue, instance.GetMax(80, int.MaxValue));
            Assert.AreEqual(80, instance.GetMax(80, int.MinValue));
            Assert.AreEqual(5, instance.GetMaxNumber(1, 0, 5, 0, -1));
        }

        [TestMethod]
        public void Task4Test()
        {
            Counter instance = new Counter();
            int[] arr = {1,1,1,4,5,6,7,88,88};
            Assert.AreEqual(1, instance.AppearCounter(arr, 5));
            Assert.AreEqual(3, instance.AppearCounter(arr, 1));
            Assert.AreEqual(0, instance.AppearCounter(arr,-1));
            Assert.AreEqual(2, instance.AppearCounter(arr, 88));
        }

        [TestMethod]
        public void Task5Test()
        {
            Neighbours instance = new Neighbours();
            int[] arr = { 1, 1, 1, 4, 3, 6, 7, 88, 88 };
            Assert.IsTrue(instance.BiggerThanNeighbours(arr, 3));
            Assert.IsFalse(instance.BiggerThanNeighbours(arr, 2));
            Assert.IsFalse( instance.BiggerThanNeighbours(arr, -1));
        }

        [TestMethod]
        public void Task6Test()
        {
            ElementSearch instance = new ElementSearch();
            int[] arr = { 1, 1, 1, 4, 3, 6, 7, 88, 88 };
            int[] arrr = { 1, 1, 1, 1, 1, 1 };
            Assert.AreEqual(3, instance.IndexFinder(arr));
            Assert.AreEqual(-1, instance.IndexFinder(arrr));
        }

        [TestMethod]
        public void Task7Test()
        {
            NumReverse instance = new NumReverse();
            Assert.AreEqual(625, instance.Reverser(526));
            Assert.AreEqual(0, instance.Reverser(0));
            Assert.AreEqual(1, instance.Reverser(1));
            Assert.AreEqual(13, instance.Reverser(31));

        }

        [TestMethod]
        public void Task8Test()
        {
            BigInts instance = new BigInts();
            char[] numA = ("4234345345").ToCharArray();
            char[] numB = ("3489734968").ToCharArray();
            string suma = string.Join("", instance.AddTwoNumbers(numA, numB));
            Assert.AreEqual("7724080313",suma);
            numA = ("3").ToCharArray();
            numB = ("11").ToCharArray();
            suma = string.Join("", string.Join("", instance.AddTwoNumbers(numA, numB)));
            Assert.AreEqual("14", suma);
            numA = ("0").ToCharArray();
            numB = ("1").ToCharArray(); 
            suma = string.Join("", string.Join("", instance.AddTwoNumbers(numA, numB)));
            Assert.AreEqual("1", suma);
            numA = ("99").ToCharArray();
            numB = ("1").ToCharArray();
            suma = string.Join("", string.Join("", instance.AddTwoNumbers(numA, numB)));
            Assert.AreEqual("100", suma);
            numA = ("1").ToCharArray();
            numB = ("99").ToCharArray();
            suma = string.Join("", string.Join("", instance.AddTwoNumbers(numA, numB)));
            Assert.AreEqual("100", suma);
        }
    }
}
