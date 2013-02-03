using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14
{
    class Program
    {
        static void Main(string[] args)
        {
            //A dictionary is stored as a sequence of text lines containing words and their explanations. Write a program that enters a word and translates it by using the dictionary. Sample dictionary:
            //.NET – platform for applications from Microsoft
            //CLR – managed execution environment for .NET
            //namespace – hierarchical organization of classes
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add(".NET", "– platform for applications from Microsoft");
            dict.Add("CLR", "– managed execution environment for .NET");
            dict.Add("namespace", "– hierarchical organization of classes");
            Console.WriteLine("Enter word");
            string input = Console.ReadLine();
            Console.WriteLine("{0} {1}",input,dict[input]);
        }
    }
}
