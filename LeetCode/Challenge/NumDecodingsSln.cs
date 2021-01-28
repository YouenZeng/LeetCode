using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class NumDecodingsSln : ISolution
    {
        public int NumDecodings(string s)
        {
            if (s.Length == 1)
            {
                return s == "0" ? 0 : 1;
            }

            int[] dp = new int[s.Length + 1];
            char[] c = s.ToCharArray();

            dp[0] = 1;
            dp[1] = c[0] == '0' ? 0 : 1;


            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] != '0')
                {
                    dp[i + 1] = dp[i];
                }

                if (IsAlpha(c[i - 1], c[i]))
                {
                    dp[i + 1] += dp[i - 1];
                }
            }

            return dp[s.Length];
        }

        private bool IsAlpha(char c1, char c2)
        {
            return c1 == '2' && c2 <= '6' || c1 == '1' && c2 <= '9';
        }


        public void Execute()
        {
            Console.WriteLine(NumDecodings("01"));
            Console.WriteLine(NumDecodings("100"));
            Console.WriteLine(NumDecodings("226"));
            Console.WriteLine(NumDecodings("1"));
            Console.WriteLine(NumDecodings("11111"));
            Console.WriteLine(NumDecodings("66666"));
        }
    }
}