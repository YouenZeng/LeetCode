using System;
using LeetCode;
public class AddBinarySln : ISolution
{
    public string AddBinary(string a, string b)
    {
        int binaryLength = Math.Max(a.Length, b.Length);

        if (a.Length > b.Length)
        {
            int lengthDiff = a.Length - b.Length;
            for (int i = 0; i < lengthDiff; i++)
            {
                b = "0" + b;
            }
        }

        if (b.Length > a.Length)
        {
            int lengthDiff = b.Length - a.Length;
            for (int i = 0; i < lengthDiff; i++)
            {
                a = "0" + a;
            }
        }

        string result = string.Empty;
        char overflowChar = '0';
        for (int i = binaryLength - 1; i >= 0; i--)
        {
            char charA = '0';
            char charB = '0';
            char tempResult = '0';
            char tempOverflow = '0';

            charA = a[i];
            charB = b[i];

            if (charA == '0' && charB == '0')
            {
                tempResult = '0';
            }
            if ((charA == '0' && charB == '1') || (charA == '1' && charB == '0'))
            {
                tempResult = '1';
            }

            if (charA == '1' && charB == '1')
            {
                tempResult = '0';
                tempOverflow = '1';
            }

            if (overflowChar == '0')
                result = tempResult + result;

            if (overflowChar == '1')
            {
                if (tempResult == '1')
                {
                    result = '0' + result;
                    tempOverflow = '1';
                }
                else
                {
                    result = '1' + result;
                }
            }

            if (tempOverflow == '1')
                overflowChar = '1';
            else
                overflowChar = '0';

        }
        if (overflowChar == '1')
        {
            result = overflowChar + result;
        }
        return result;
    }
    void ISolution.Execute()
    {
        Console.WriteLine(AddBinary("11", "1"));
    }
}