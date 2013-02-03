using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
            string[] text = Console.ReadLine().Split();
            Dictionary<string, int> words = new Dictionary<string, int>();
            foreach (var item in text)
            {
                if (words.ContainsKey(item))
                {
                    words[item]++;
                }
                else
                {
                    words.Add(item, 1);
                }
            }
            foreach (var item in words)
            {
                Console.WriteLine("{0}  {1}",item.Key,item.Value);
            }
        }
    }
}
