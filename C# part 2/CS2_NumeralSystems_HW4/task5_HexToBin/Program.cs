using System;
using System.Collections.Generic;
using System.Text;

namespace task5_HexToBin
{
    class Program
    {
        static Dictionary<char, string> hex = new Dictionary<char, string>();

        static void Main(string[] args)
        {
            //Write a program to convert hexadecimal numbers to binary numbers (directly).
            hex.Add('0', "0000");
            hex.Add('1', "0001");
            hex.Add('2', "0010");
            hex.Add('3', "0011");
            hex.Add('4', "0100");
            hex.Add('5', "0101");
            hex.Add('6', "0110");
            hex.Add('7', "0111");
            hex.Add('8', "1000");
            hex.Add('9', "1001");
            hex.Add('A', "1010");
            hex.Add('B', "1011");
            hex.Add('C', "1100");
            hex.Add('D', "1101");
            hex.Add('E', "1110");
            hex.Add('F', "1111");
            Console.WriteLine(HexToBin("AF1C2"));
            //Console.WriteLine(Convert.ToString(0xAF1C2,2));
        }

        static string HexToBin(string hex)
        {
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < hex.Length; i++)
            {
                res.Append(GetBin(hex[i]));
            }
            return res.ToString();
        }
        static string GetBin(char c)
        {
            return hex[c];
        }
    }
}
