using System;
using System.IO;
using System.Text;

namespace task9_OddLineRemover
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that deletes from given text file all odd lines. The result should be in the same file.
            string path1 = @"C:\Users\Ivan\Desktop\document(fixed).txt";
            string path2 = @"C:\Users\Ivan\Desktop\tempfile.txt";
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");
            int lineNum = 0;
            string line = null;
            try
            {
                StreamReader reader = new StreamReader(path1, win1251);
                StreamWriter writer = new StreamWriter(path2, false, win1251);
                line = reader.ReadLine();
                using (reader)
                {
                    using (writer)
                    {
                        line = reader.ReadLine();
                        while (line != null)
                        {
                            lineNum++;
                            if (lineNum % 2 != 0)
                            {
                                writer.WriteLine(line);
                            }
                            line = reader.ReadLine();
                        }
                    }
                }

                StreamWriter writer2 = new StreamWriter(path1, false, win1251);
                StreamReader reader2 = new StreamReader(path2, win1251);

                using (reader2)
                {
                    using (writer2)
                    {
                        line = reader2.ReadLine();
                        while (line != null)
                        {
                            writer2.WriteLine(line);
                            line = reader2.ReadLine();
                        }
                    }
                }
              
                File.Delete(path2);
       
                Console.WriteLine("Successesful deleting!");
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
    }
}