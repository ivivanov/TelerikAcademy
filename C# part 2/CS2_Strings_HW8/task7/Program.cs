using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that encodes and decodes a string using given encryption key (cipher).
            //The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) 
            //operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first
            string input = "Nakov";
            string chipher = "ab";
            string coded = Encode(input, chipher);
            string decoded = Decode(coded, chipher);

            Console.WriteLine("coded: {0}",coded);
            Console.WriteLine("decoded: {0}",decoded);
        }

        static string Decode(string coded, string chipher)
        {
            string result = "";
            int length = coded.Length;
            int positionInChipher = 0;
            ushort chiperChar = 0;
            ushort msgChar = 0;
            ushort xorResult = 0;
            for (int i = 0; i < length; i++)
            {
                if (positionInChipher == chipher.Length)
                {
                    positionInChipher = 0;
                }
                chiperChar = chipher[positionInChipher++];
                msgChar = coded[i];
                xorResult =(ushort)(msgChar ^ chiperChar);
                result += Convert.ToChar(xorResult);
            }
            return result;
        }

        static string Encode(string input, string chipher)
        {
            int chipherLen = chipher.Length;
            int chipherPosition = 0;
            ushort charInp = 0;
            ushort charChip = 0;
            ushort xorResult = 0;
            string result = "";
            //string tempRes = "";
            //string zeros = "";
            char c = ' ';
            for (int i = 0; i < input.Length; i++)
            {
                if (chipherPosition == chipherLen)
                {
                    chipherPosition = 0;
                }
                charInp = input[i];
                charChip = chipher[chipherPosition++];
                xorResult = (ushort)(charInp ^ charChip);
                //tempRes = xorResult.ToString("x").PadLeft(4, '0');
                c = Convert.ToChar(xorResult);
                result += c;

                //result += "\\u" + tempRes;
            }
            return result;
        }
    }
}
