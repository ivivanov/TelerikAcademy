using System;
using System.IO;
using System.Text;

namespace task2_TextFileCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that concatenates two text files into another text file.

            string file1 = @"C:\Users\Ivan\Desktop\test.txt";
            string file2 = @"C:\Users\Ivan\Desktop\test.txt";
            string file3 = @"C:\Users\Ivan\Desktop\ConcatTest.txt";
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");

            try
            {
                StreamReader reader1 = new StreamReader(file1, win1251);
                StreamReader reader2 = new StreamReader(file2, win1251);
                StreamWriter write = new StreamWriter(file3, false, win1251);
                using (write)
                {
                    string f1;
                    string f2;
                    using (reader1)
                    {
                        f1 = reader1.ReadToEnd();
                    }
                    using (reader2)
                    {
                        f2 = reader2.ReadToEnd();
                    }
                    write.WriteLine(f1);
                    write.WriteLine(f2);
                    Console.WriteLine("Successesful concatenation!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
