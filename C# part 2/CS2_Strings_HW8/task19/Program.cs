using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
            //Display them in the standard date format for Canada.
            Regex date = new Regex(@"[\d]{2}\.[\d]{2}\.[\d]{4}");
            string text =
@" sd fds f sd fme@asd.vom s df sd f dsf sd f s
bla@aaaaa.co sdfsdfsdf15.12.2012 sdfsdfsdfsd00.00.0000fsdfsdfsdf 5.1sdfsdfsdf15.12.2012 sdfsdfsdfsd00.00.0000fsdfsdfsdf 5.12.2012f15.2sd15.12.02sdsdfsdfsdf15.12.2012 sdfsdfsdfsd00.00.0000fsdfsdfsdf 5.12.2012f15.2sd15.12.02sdfsdfsfsdfsdfsdf15.12.2012 sdfsdfsdfsd00.00.0000fsdfsdfsdf 5.12.2012f15.2sd15.12.02sdfsdfsfsdfsdfsdf15.12.2012 sdfsdfsdfsd00.00.0000fsdfsdfsdf 5.12.2012f15.2sd15.12.02sdfsdfsffsdfsfsdfsdfsdf15.12sdfsdfsdf15.12.2012 sdfsdfsdfsd00.00.0000fsdfsdfsdf 5.12.2012f15.2sd15.12.02sdfsdfsf2 sdfsdfsdfsdf15.12.2012 sdfsdfsdfsd00.00.0000fsdfsdfsdf 5.12.2012f15.2sd15.12.02sdfsdfsfdfsdfsd00.00.0000fsdfsdfsdf 5.12.2012f15.2sd15.12.02sdfsdfsfsdfsdfsdf15.12.2012 sdfsdfsdfsd00.00.0000fsdfsdfsdf 5.12.2012f15.2sd15.12.02sdfsdfsf2.2012f15.2sd15.12.02sdfsdfsf@@@////.....@.... aaaaa.....!
a34234sdfsdf@dasd33d3d3.com";
            foreach (var item in date.Matches(text))
            {
                Console.WriteLine(item);
            }
        }
    }
}
