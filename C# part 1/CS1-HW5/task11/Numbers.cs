using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    class Numbers
    {
        static void Main(string[] args)
        {
            string[] digits = { "", "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] teenNumbers = { "", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
           
            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            int serviceNumber = 0;
            if (number < 10)
            {
                Console.WriteLine(digits[number + 1]);
            }
            else
            {
                if (number < 20)
                {
                    Console.WriteLine(teenNumbers[number - 9]);
                }
                else
                {
                    if (number < 100)
                    {
                        if (number % 10 == 0)
                        {
                            Console.WriteLine(tens[number / 10 - 2]);
                        }
                        else
                        {
                            Console.WriteLine("{0} {1}", tens[number / 10 - 2], digits[number % 10 + 1]);
                        }
                    }
                    else
                    {
                        if (number % 100 == 0)
                        {
                            Console.WriteLine("{0} hundred", digits[number / 100 + 1]);
                        }
                        else
                        {
                            serviceNumber = number % 100;
                            if (serviceNumber < 10)
                            {
                                Console.WriteLine("{0} hundred and {1} ", digits[number / 100 + 1], digits[serviceNumber + 1]);
                            }
                            else
                            {
                                if (serviceNumber < 20)
                                {
                                    Console.WriteLine("{0} hundred and {1}", digits[number / 100 + 1], teenNumbers[serviceNumber - 9]);
                                }
                                else
                                {
                                    if (serviceNumber < 100)
                                    {
                                        if (serviceNumber % 10 == 0)
                                        {
                                            Console.WriteLine("{0} hundred and {1}", digits[number / 100 + 1], tens[serviceNumber / 10 - 2]);
                                        }
                                        else
                                        {
                                            Console.WriteLine("{0} hundred and {1} {2} ", digits[number / 100 + 1], tens[serviceNumber / 10 - 2], digits[serviceNumber % 10 + 1]);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
