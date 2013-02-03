using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…[/URL]. Sample HTML fragment:
            //<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
            //<p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
            string text = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
            Regex aTag = new Regex(@"<a href=""(?<link>.*?)"">");
            string closingTag = "</a>";
            text = text.Replace(closingTag, "[/URL]");
            MatchCollection matches = aTag.Matches(text);
            string forReplace = "";
            string pureLink = "";
            foreach (Match item in matches)
            {
                pureLink = item.Groups["link"].ToString();
                forReplace = "[URL=" + pureLink + "]";
                text = text.Replace(item.ToString(), forReplace);
            }
            Console.WriteLine(text);
        }
    }
}
