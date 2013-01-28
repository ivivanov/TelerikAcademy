using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace task13_WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a list of words from a file words.txt and finds how many times each of the words is contained in another file test.txt. 
            //The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
            //Handle all possible exceptions in your methods.
            string path1 = @"C:\Users\Ivan\Desktop\words.txt";
            string path2 = @"C:\Users\Ivan\Desktop\test.txt";
            string path3 = @"C:\Users\Ivan\Desktop\result.txt";
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");
            Dictionary<string,int> wordDictionary = new Dictionary<string,int>();
            string line = null;
            string[] wordsToCount;
            Regex regex;
            int count = 0;

            try
            {
                StreamReader reader1 = new StreamReader(path1, win1251);
                StreamReader reader2 = new StreamReader(path2, win1251);
                StreamWriter writer = new StreamWriter(path3, false, win1251);
                using (reader2)
                {
                    line = reader2.ReadToEnd();
                    wordsToCount = line.Split('\n', ' ');
                    for (int i = 0; i < wordsToCount.Length; i++)
                    {
                        wordsToCount[i] = wordsToCount[i].Trim('\r', '\n');
                    }
                }
                using (reader1)
                {
                    line = reader1.ReadToEnd();
                    for (int i = 0; i < wordsToCount.Length; i++)
                    {
                        regex = new Regex(wordsToCount[i]);
                        MatchCollection matches = Regex.Matches(line, wordsToCount[i], RegexOptions.Multiline);
                        wordDictionary.Add(wordsToCount[i], matches.Count);
                    }
                }

                var sortedDict = (from entry in wordDictionary orderby entry.Value descending select entry).ToDictionary(pair => pair.Key, pair => pair.Value);
                using (writer)
                {
                    foreach (var item in sortedDict)
                    {
                        writer.WriteLine(item.Key + " - " + item.Value);
                    }
                }
                Console.WriteLine("Successesful counting! Check file result for information.");
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
