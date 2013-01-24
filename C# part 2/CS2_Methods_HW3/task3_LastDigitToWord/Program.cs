using System;

namespace task3_LastDigitToWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(LastDigitToWord(number));
        }

        public static string LastDigitToWord(int number)
        {
            string result = null;
            switch (number % 10)
            { 
                case 0:
                    return "Zero";
                case 1:
                    return "One";
                case 2:
                    return "Two";
                case 3:
                    return "Three";
                case 4:
                    return "Four";
                case 5:
                    return "Five";
                case 6:
                    return "Six";
                case 7:
                    return "Seven";
                case 8:
                    return "Eight";
                case 9:
                    return "Nine";
                default:
                    return "Not a number";
            }
        }
    }
}
