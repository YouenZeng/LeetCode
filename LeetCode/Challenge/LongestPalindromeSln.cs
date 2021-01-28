using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class LongestPalindromeSln : ISolution
    {
        public string LongestPalindrome(string s)
        {
            bool[,] checkDp = new bool[s.Length + 1, s.Length + 1];
            int start = 0;
            int max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (s[j] == s[i] && (j + 1 > i - 1 || checkDp[j + 1, i - 1]))
                    {
                        checkDp[j, i] = true;
                        int l = i - j;
                        if (l > max)
                        {
                            max = l;
                            start = j;
                        }
                    }
                }
            }

            return s.Substring(start, max + 1);
        }

        public void Execute()
        {
            LongestPalindrome("bananas");
            LongestPalindrome("ccc");
            LongestPalindrome("cccc");
            LongestPalindrome("aabbaa");
            LongestPalindrome("aabaa");
        }
    }
}