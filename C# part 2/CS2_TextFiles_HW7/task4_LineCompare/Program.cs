using System;
using System.IO;
using System.Text;


namespace task4_LineCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different. 
            //Assume the files have equal number of lines.
            string file3 = @"C:\Users\Ivan\Desktop\ConcatTest.txt";
            string file4 = @"C:\Users\Ivan\Desktop\NumberedLines.txt";
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");
            StringBuilder equal = new StringBuilder();
            StringBuilder notEqual = new StringBuilder();
            equal.Append("Same lines: ");
            notEqual.Append("Different lines: ");
            string lineX = null;
            string lineY = null;
            int lineNum=0;
            try
            {
                StreamReader reader1 = new StreamReader(file3, win1251);
                StreamReader reader2 = new StreamReader(file4, win1251);
                using (reader1)
                {
                    lineX = reader1.ReadLine();
                    using (reader2)
                    {
                        lineY = reader2.ReadLine();
                        while (lineY != null && lineX != null)
                        {
                            lineNum++;
                            if (lineX == lineY)
                            {
                                equal.Append(lineNum + " ");
                            }
                            else
                            {
                                notEqual.Append(lineNum + " ");
                            }
                            lineX = reader1.ReadLine();
                            lineY = reader2.ReadLine();
                        }
                    }
                }
                Console.WriteLine(equal.ToString());
                Console.WriteLine(notEqual.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
               
        }
    }
}
