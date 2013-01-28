using System;
using System.IO;
using System.Text;

namespace task8_WordReplacerMod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Modify the solution of the previous problem to replace only whole words (not substrings).

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
            line = line.Replace(" start ", " finish ");
            line = line.Replace("start ", "finish ");
            line = line.Replace(" start", " finish");
            return line;
        }
    }
}
