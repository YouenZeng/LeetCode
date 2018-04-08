using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{

    class ToHexSln : ISolution
    {
        const string HEX = "0123456789abcdef";

        public string ToHex(int num)
        {
            if (num == 0) return "0";
            string result = string.Empty;
            int count = 0;

            while (num != 0 && count < 8)
            {
                result = HEX[num & 0xf] + result;
                num = num >> 4;
                count++;
            }
            return result;
        }
        //public string ToHex(int num)
        //{
        //    if (num == int.MinValue) return "80000000";
        //    if (num == 0) return "0";
        //    if (num < 0)
        //    {
        //        return HandleFirstChar(ToHex(int.MaxValue + num + 1));
        //    }

        //    string result = string.Empty;
        //    while (num != 0)
        //    {
        //        var mod = num % 16;
        //        result = NumToHex(mod)+result;
        //        num = num / 16;
        //    }

        //    return result;
        //}

        //private string HandleFirstChar(string s)
        //{
        //    int n = Convert.ToInt32(s[0]-'0') + 8;
        //    char[] arr = s.ToCharArray();
        //    arr[0] = NumToHex(n);
        //    return string.Join("",arr);
        //}
        //private char NumToHex(int n)
        //{
        //    if (n < 9) return (char)(n+48);
        //    return (char)(n - 10 + 97);
        //}


        public void Execute()
        {
            Console.WriteLine(ToHex(int.MinValue));
        }
    }
}