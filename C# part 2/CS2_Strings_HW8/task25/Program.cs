using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task25
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. Example:
            //<html>
            //  <head><title>News</title></head>
            //  <body><p><a href="http://academy.telerik.com">Telerik
            //    Academy</a>aims to provide free real-world practical
            //    training for young people who want to turn into
            //    skillful .NET software engineers.</p></body>
            // </html>
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");
            Regex regex = new Regex(@">(?<data>(.|\n)*?)<");
            string line = Console.ReadLine();
            string extractedData = "";

            Match data = regex.Match(line);
            while (data.Success)
            {
                extractedData = data.Groups["data"].Value;
                extractedData = extractedData.Trim();
                Console.WriteLine((extractedData));
                data = data.NextMatch();

            }
        }
    }
}
