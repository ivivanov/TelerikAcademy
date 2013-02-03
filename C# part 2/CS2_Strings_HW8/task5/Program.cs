using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //  You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. Example:
            //We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
            //We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
            string input = "  //We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            int start = 0;
            int end = 0;
            int length = input.Length;
            string substr = null;
            while (start < length)
            {
                start = input.IndexOf("<upcase>", start);
                end = input.IndexOf("</upcase>", end);
                if (start == -1 || end == -1)
                {
                    break;
                }
                substr = input.Substring(start + 8, end - start-8);
                input = input.Replace(substr, substr.ToUpper());
                start++;
                end++;
            }
            start=0;
            input = input.Replace("<upcase>", "");
            input = input.Replace("</upcase>", "");
            Console.WriteLine(input);
        }
    }
}
