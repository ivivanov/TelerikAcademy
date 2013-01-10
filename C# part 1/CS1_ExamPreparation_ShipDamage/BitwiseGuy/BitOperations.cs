using System;

namespace BitwiseGuy
{
    class BitOperations
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];
            for (int i = 0; i < n; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(CreateNewNumber(input[i]));
            }
        }

        static int CreateNewNumber(int number)
        {
            // number =5 , bitnumber = "101" // tilda bit ='010'
            string bitNumber = Convert.ToString(number, 2);
            string tildaBitNumber = BitwiseTildaNumber(bitNumber);
            string dotsBitNumber = BitwiseDotsNumber(bitNumber);
            ///////////////////////////////////////////////////////////
            //Console.WriteLine("1011 -> dots num 1101: "+dotsBitNumber);
            //Console.WriteLine("1011 -> 100: "+tildaBitNumber);
            //return Pnew = (P ^ P̃) & P̈.
            int tilda = BinToDecConverter(tildaBitNumber);
            int dots = BinToDecConverter(dotsBitNumber);

            return (number ^ tilda) & dots;
        }

        static int BinToDecConverter(string tildaBitNumber)
        {
            int result = 0;
            int i = tildaBitNumber.Length - 1;
            foreach (char c in tildaBitNumber)
            {
                if (c == '1')
                {
                    result += (int)Math.Pow(2, i);
                }
                i--;
            }

            return result;
        }

        static string BitwiseDotsNumber(string bitNumber)
        {
            return RemoveZerosInBegining(ReverseString(bitNumber));
        }

        static string BitwiseTildaNumber(string bitNumber)
        {
            string result = "";
            for (int i = 0; i < bitNumber.Length; i++)
            {
                if (bitNumber[i] == '0')
                {
                    result += "1";
                }
                else
                {
                    result += "0";
                }
            }
            //Console.WriteLine("tilda : "+result);
            //Console.WriteLine("remove zeros : " + RemoveZerosInBegining(result));
            return RemoveZerosInBegining(result);
        }

        static string RemoveZerosInBegining(string bitNumber)
        {
            byte iteractions = 0;
            foreach (char c in bitNumber)
            {
                if (!(c == '0'))
                {
                    break;
                }
                iteractions++;
            }
            return bitNumber.Substring(iteractions, bitNumber.Length - iteractions);
        }

        static string ReverseString(string p)
        {
            string result = "";
            
            for (int i = p.Length - 1; i >= 0; i--)
            {
                result += p[i];
            }
            return result;
        }
    }
}
