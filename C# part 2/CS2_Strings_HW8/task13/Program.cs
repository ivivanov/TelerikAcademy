using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reverses the words in given sentence.
	        //Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".
            //Можете да решите задачата на две стъпки: обръщане на входния низ на обратно; обръщане на всяка от думите от резултата на обратно.
            //Друг, интересен подход е да разделете входния текст по препина­телните знаци между думите, за да получите само думите от текста и след това да разделите по буквите, 
            //за да получите препинателните знаци от текста. Така, имайки списък от думи и списък от препина­телни знаци между тях, 
            //лесно можете да обърнете думите на обратно, запазвайки препинателните знаци.
            string text = "C# is not C++, not PHP and not Delphi!";
            List<char> spliters = new List<char>();
            string[] onlyWords = text.Split('!', '?', ',', '.', ' ');
            for (int i = (int)'A'; i <= (int)'z'; i++)
            {
                spliters.Add((char)i);
            }
            char[] letters = spliters.ToArray();
            string[] onlySigns = text.Split(letters);
        }
    }
}
