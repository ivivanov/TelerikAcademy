using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that applies bonus scores to given scores in the range [1..9]. 
            //The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10;
            //if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000. 
            //If it is zero or if the value is not a digit, the program must report an error.
	    	//Use a switch statement and at the end print the calculated new value in the console.

            Console.WriteLine("Enter score: ");
            int score = int.Parse(Console.ReadLine());
            int newScore =1;
            switch (score)
            {
                case 1:
                    newScore = score * 10;
                    break;
                case 2:
                    newScore = score * 10;
                    break;
                case 3:
                    newScore = score * 10;
                    break;
                case 4:
                    newScore = score * 100;
                    break;
                case 5:
                    newScore = score * 100;
                    break;
                case 6:
                    newScore = score * 100;
                    break;
                case 7:
                    newScore = score * 1000;
                    break;
                case 8:
                    newScore = score * 1000;
                    break;
                case 9:
                    newScore = score * 1000;
                    break;
                default:
                    Console.WriteLine("Invalid score input");
                    break;
            }
            Console.WriteLine(newScore);
        }
    }
}
