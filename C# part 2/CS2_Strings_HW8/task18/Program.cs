using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program for extracting all email addresses from given text. All substrings that match the format 
            //<identifier>@<host>…<domain> should be recognized as emails.
            Regex email = new Regex(@"[A-Za-z0-9]+[\._A-Za-z0-9-]+@([A-Za-z0-9]+[-\.]?[A-Za-z0-9]+)+(\.[A-Za-z0-9]+[-\.]?[A-Za-z0-9]+)*(\.[A-Za-z]{2,})");
            string text = 
@" sd fds f sd fme@asd.vom s df sd f dsf sd f s
bla@aaaaa.co @@@////.....@.... aaaaa.....!
a34234sdfsdf@dasd33d3d3.com";
            foreach (var item in email.Matches(text))
            {
                Console.WriteLine(item);
            }



        }
    }
}
