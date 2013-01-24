using System;
using System.Collections.Generic;
using task8_BigIntegers;

namespace task10_BigNumFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

            char[] factNum = "1".ToCharArray();
            char[] nextNum = new char[0];
            for (int i = 1; i < 101; i++)
            {
                nextNum = i.ToString().ToCharArray();
                factNum = MultTwoNumbers("1231".ToCharArray(), "10".ToCharArray());
                factNum = MultTwoNumbers(factNum, nextNum);
                Console.Write("{0}! ---> ", i);
                foreach (var item in factNum)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }

        }

        static char[] MultTwoNumbers(char[] numA, char[] numB)
        {
            if (numA.Length > numB.Length)
            {
                char[] temp = numA;
                numA = numB;
                numB = temp;
            }
            List<char[]> addends = new List<char[]>();
            int lengthA = numA.Length;
            int zeros = 0;
            char[] addend = new char[0];
            char[] totalSum = new char[0];
            BigInts instance = new BigInts();
            Array.Reverse(numA);
            Array.Reverse(numB);
            for (int i = 0; i < lengthA; i++)
            {
                addend = CreateAddend(numA[i],numB,zeros);
                zeros++;
                addends.Add(addend);
            }
            for (int i = 0; i < addends.Count; i++)
            {
                Array.Reverse(addends[i]);
                totalSum = instance.AddTwoNumbers(totalSum, addends[i]);
            }
            return totalSum;
        }

        static char[] CreateAddend(char p, char[] numB, int zeros)
        {
            List<int> addend = new List<int>();
            for (int i = 0; i < zeros; i++)
            {
                addend.Add(0);
            }
            char[] trailingNum = MultDigitWithNum(p, numB);
            for (int i = 0; i < trailingNum.Length; i++)
            {
                addend.Add(trailingNum[i]-'0');
            }
            string str = string.Join("", addend.ToArray());

            return str.ToCharArray();
        }

        static char[] MultDigitWithNum(char p, char[] numB)
        {
            int num = p - '0';
            int onMind = 0;
            int length = numB.Length;
            int temp = 0;
            string number ="";
            for (int i = 0; i < length; i++)
            {
                int mult = numB[i] - '0';
                temp = num * mult + onMind;
                onMind = 0;
                if (i == length - 1)
                {
                    if (temp > 9)
                    {
                        string reversedTemp="";
                        reversedTemp+=(temp%10).ToString();
                        temp/=10;
                        reversedTemp+=temp.ToString();
                        number+=reversedTemp;
                    }
                    else
                    {
                        number+=temp;
                    }
                }
                else
                {
                    if (temp > 9)
                    {
                        onMind = temp / 10;
                        temp = temp % 10;
                    }
                    number+=temp;
                }
            }
            return number.ToCharArray();
        }
    }
}
