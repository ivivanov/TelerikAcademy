using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that extracts from a given text all sentences containing given word.
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string extracted = Extract(text, "in");
            Console.WriteLine(extracted);
        }

        static string Extract(string text, string p)
        {
            int dotPosition = 0;
            int previousDot =0;
            bool contains = false;
            p = " " + p + " ";
            dotPosition = text.IndexOf(".");
            string substr = "";
            string result = "";
            while (dotPosition != -1)
            {
                substr = text.Substring(previousDot, dotPosition - previousDot);
                previousDot = dotPosition++;
                if (substr.Contains(p))
                {
                    result += substr;
                }
                dotPosition = text.IndexOf(".", dotPosition);
            }
            return result;
        }
    }
}
