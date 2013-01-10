using System;

class BinSequenceCounter
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int inputNumber = 0;
        string conCatNumber = "";
        int seqLen = 1;
        int dancingBitsCounter = 0;

        for (int i = 0; i < n; i++)
        {
            inputNumber = int.Parse(Console.ReadLine());
            conCatNumber += Convert.ToString(inputNumber, 2);
        }

        int conCatNumberLen = conCatNumber.Length;

        for (int i = 1; i < conCatNumberLen; i++)
        {
            if (conCatNumber[i] == conCatNumber[i-1])
            {
                seqLen++;
            }
            else 
            {
                if (seqLen == k)
                {
                    dancingBitsCounter++;
                }
                seqLen = 1;
            }
        }
        if (seqLen == k)
        {
            dancingBitsCounter++;
        }

        Console.WriteLine(dancingBitsCounter);
    }
}