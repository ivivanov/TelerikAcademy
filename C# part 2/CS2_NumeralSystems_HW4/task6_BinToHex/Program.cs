using System;
using System.Collections.Generic;
using System.Text;

namespace task6_BinToHex
{
    class Program
    {
        static Dictionary<string, char> bin = new Dictionary<string, char>();

        static void Main(string[] args)
        {
            //Write a program to convert binary numbers to hexadecimal numbers (directly).
            bin.Add("0000",'0');
            bin.Add("0001",'1');
            bin.Add("0010",'2');
            bin.Add("0011",'3');
            bin.Add("0100",'4');
            bin.Add("0101",'5');
            bin.Add("0110",'6');
            bin.Add("0111",'7');
            bin.Add("1000",'8');
            bin.Add("1001",'9');
            bin.Add("1010",'A');
            bin.Add("1011",'B');
            bin.Add("1100",'C');
            bin.Add("1101",'D');
            bin.Add("1110",'E');
            bin.Add("1111",'F');
            Console.WriteLine(BinToHex("111100011010"));
        }

        static string BinToHex(string bin)
        {
            StringBuilder hex = new StringBuilder();
            for (int i = 0; i < bin.Length; i+=4)
            {
                hex.Append(GetHex(bin.Substring(i, 4)));
            }
            return hex.ToString();
        }

        static char GetHex(string str)
        {
            return bin[str];
        }
    }
}
