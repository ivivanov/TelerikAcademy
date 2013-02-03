using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
            string text = @"//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.";
            Regex palindrome = new Regex(@"\b(?<N>.)+.?(?<-N>\k<N>)+(?(N)(?!))\b");
            foreach (var item in palindrome.Matches(text))
            {
                Console.WriteLine(item);
            }
        }
    }
}
