using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints an isosceles triangle of 9 copyright symbols ©.
            //Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.
            char copyright = '\u00A9';
            Console.WriteLine("{0,10}\n{0,9}{0,2}\n{0,8}{0,4}\n{0,7}{0,2}{0,2}{0,2}",copyright);
        }
    }
}
