using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task11_ReplaceRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that deletes from a text file all words that start with the prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.

            string path1 = @"C:\Users\Ivan\Desktop\sortedNames.txt";
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");
            Regex regex = new Regex(@"\bstart[\w\d]*");
            string line = null;
            try
            {
                StreamReader reader = new StreamReader(path1, win1251);
                using (reader)
                {
                    line = reader.ReadToEnd();
                    line = regex.Replace(line, "");
                }
                StreamWriter writer = new StreamWriter(path1, false, win1251);
                using (writer)
                {
                    writer.WriteLine(line);
                }
                Console.WriteLine("Successesful replacing!");
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
