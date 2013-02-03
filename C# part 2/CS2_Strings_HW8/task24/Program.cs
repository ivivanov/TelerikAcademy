using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task24
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
            string[] text = Console.ReadLine().Split();
            List<string> words = new List<string>();
            foreach (var item in text)
            {

                words.Add(item);

            }
            string[] arr = words.ToArray();
            words.Sort();
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
