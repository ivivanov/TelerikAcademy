using System;
using System.IO;
using System.Text;

namespace task12_SpesificWordsRemover
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that removes from a text file all words listed in given another text file. Handle all possible exceptions in your methods.
            string path1 = @"C:\Users\Ivan\Desktop\sortedNames.txt";
            string path2 = @"C:\Users\Ivan\Desktop\forbiddenWords.txt";
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");
            string line = null;
            string[] forbiddenWords;
            try
            {
                StreamReader reader1 = new StreamReader(path1, win1251);
                StreamReader reader2 = new StreamReader(path2, win1251);
                using (reader2)
                {
                    line = reader2.ReadToEnd();
                    forbiddenWords = line.Split('\n',' ');
                    for (int i = 0; i < forbiddenWords.Length; i++)
                    {
                        forbiddenWords[i] = forbiddenWords[i].Trim('\r', '\n');
                    }
                }
                using (reader1)
                {
                    line = reader1.ReadToEnd();
                    for (int i = 0; i < forbiddenWords.Length; i++)
                    {
                        line = line.Replace(forbiddenWords[i], "");
                    }
                }
                StreamWriter writer = new StreamWriter(path1,false,win1251);
                using (writer)
                {
                    writer.WriteLine(line);
                }
                Console.WriteLine("Successesful removeing of words!");
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
