using System;
using System.Text;

namespace LeetCode.Leets
{
    class IsPalindromeSln : ISolution
    {
        public bool IsPalindrome(int x)
        {
            int input = x;
            int newNum = 0;
            while (x > 0)
            {
                int yu = x % 10;
                x = x / 10;
                newNum = newNum * 10 + yu;
            }

            return newNum == input;
        }

        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;

            StringBuilder sb = new StringBuilder();

            foreach (char c in s)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')|| (c>='0' && c<='9')) sb.Append(c);
            }
            string pureString = sb.ToString();

            pureString = pureString.ToLower();

            char[] cArray = pureString.ToCharArray();

            int start = 0;
            int end = cArray.Length - 1;

            while (start < end)
            {
                if (cArray[start] == cArray[end])
                {
                    start++;
                    end--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public void Execute()
        {
            Console.WriteLine(IsPalindrome("0p"));
        }
    }
}
