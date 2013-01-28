using System;
using System.IO;
using System.Text;


namespace task7_WordReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).
            string path1 = @"C:\Users\Ivan\Desktop\Large document(fixed).txt";
            string path2 = @"C:\Users\Ivan\Desktop\Large document.txt";
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");
            string line = null;
            string fixedLine = null;
            try
            {
                StreamWriter writer = new StreamWriter(path1, false, win1251);
                StreamReader reader = new StreamReader(path2, win1251);
                using (reader)
                {
                    line = reader.ReadLine();
                    using (writer)
                    {
                        while (line != null)
                        {
                            fixedLine = FixLine(line);
                            writer.WriteLine(fixedLine);
                            line = reader.ReadLine();
                        }
                    }
                }
                Console.WriteLine("Successesful replacing!");
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        static string FixLine(string line)
        {
            line = line.Replace("start", "finish");
            return line;
        }
    }
}
