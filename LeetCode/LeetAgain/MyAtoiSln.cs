using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class MyAtoiSln : ISolution
    {
        public int MyAtoi(string str)
        {
            if (string.IsNullOrEmpty(str)) return 0;
            str = str.TrimStart();
            int startIndex = 0;
            int strLength = str.Length;

            while (str[startIndex] == ' ') startIndex++;

            if (startIndex == strLength) return 0;
            int sign = 1;
            if (str[startIndex] == '-')
            {
                sign = -1;
            }
            if (str[startIndex] == '-' || str[startIndex] == '+')
            {
                startIndex++;
            }


            int result = 0;
            int prev = 0;

            for (int i = startIndex; i < strLength; i++)
            {
                if (str[i] < '0' || str[i] > '9') return result;
                prev = result;
                result = sign * Convert.ToInt32(str[i] - '0') + result * 10;
                if (result / 10 != prev)
                {
                    if (prev < 0) return int.MinValue;
                    else return int.MaxValue;
                };
            }
            return result;
        }
        public void Execute()
        {
            Console.WriteLine(MyAtoi("+"));
            Console.WriteLine(MyAtoi("4193 with words"));
            Console.WriteLine(MyAtoi("-43"));
            Console.WriteLine(MyAtoi("w43"));
            Console.WriteLine(MyAtoi("2147483648"));
            Console.WriteLine(MyAtoi("-2147483648"));
        }
    }
}
