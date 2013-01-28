using System;
using System.IO;
using System.Text;

namespace task3_LineNumbering
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.
            string file3 = @"C:\Users\Ivan\Desktop\ConcatTest.txt";
            string file4 = @"C:\Users\Ivan\Desktop\NumberedLines.txt";
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");
            try
            {
                StreamReader reader = new StreamReader(file3, win1251);
                StreamWriter writer = new StreamWriter(file4, false, win1251);
                string line;
                int lineNum = 0;
                using (reader)
                {
                    line = reader.ReadLine();
                    using (writer)
                    {
                        while (line != null)
                        {
                            lineNum++;
                            line = "Line " + lineNum + ": " + line;
                            writer.WriteLine(line);
                            line = reader.ReadLine();
                        }
                    }
                }
                Console.WriteLine("Successesful line numbering!");
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
