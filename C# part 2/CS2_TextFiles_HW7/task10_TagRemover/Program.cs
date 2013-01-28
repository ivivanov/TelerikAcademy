using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace task10_TagRemover
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that extracts from given XML file all the text without the tags. Example:
            string path1 = @"C:\Users\Ivan\Desktop\Large document.txt";
            string path2 = @"C:\Users\Ivan\Desktop\tempfile.txt";
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");
            Regex regex = new Regex(@">(?<data>[\s\w\d#]+)<");
            string line = null;
            string extractedData = null;
            try
            {
                StreamReader reader = new StreamReader(path1, win1251);
                StreamWriter writer = new StreamWriter(path2, false, win1251);
                using (reader)
                {
                    using (writer)
                    {
                        line = reader.ReadLine();
                        Match data;
                        while (line != null)
                        {
                            data = regex.Match(line);
                            while (data.Success)
                            {
                                extractedData = data.Groups["data"].Value;
                                extractedData = extractedData.Trim();
                                writer.WriteLine(extractedData);
                                data = data.NextMatch();
                            }
                            line = reader.ReadLine(); 
                        }
                    }
                }
                Console.WriteLine("Successesful extraction of text outside a tag!");
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
