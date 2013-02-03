using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".
            Regex pattern = new Regex(@"(?<v>[\w])\1+");
            string text = Console.ReadLine();
            MatchCollection matches = pattern.Matches(text);
            foreach (Match item in matches)
            {
                text = text.Replace(item.Value, item.Groups["v"].Value);
            }
            Console.WriteLine(text);
        }
    }
}
