using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class LongestPrefixSln : ISolution
    {
        public string LongestPrefix(string s)
        {
            //For the string of i size, the hash is: s[0] * 26 ^ (i - 1) + s[1] * 26 ^ (i -2) + ... + s[i - 2] * 26 + s[i - 1].


            long h1 = 0, h2 = 0, mul = 1, len = 0, mod = 1000000007;
            for (int i = 0, j = s.Length - 1; j > 0; ++i, --j)
            {
                int first = s[i] - 'a', last = s[j] - 'a';
                h1 = (h1 * 26 + first) % mod;
                h2 = (h2 + mul * last) % mod;
                mul = mul * 26 % mod;
                if (h1 == h2)
                    len = i + 1;
            }
            return s.Substring(0, (int)len);
        }

        public String LongestPrefix2(string s)
        {
            int[] dp = new int[s.Length];
            int j = 0;
            for (int i = 1; i < s.Length; ++i)
            {
                if (s[i] == s[j])
                    dp[i] = ++j;
                else if (j > 0)
                {
                    j = dp[j - 1];
                    --i;
                }
            }
            return s.Substring(0, j);
        }

        public int Kmp(string text, string pattern)
        {
            int n = text.Length;
            int m = pattern.Length;
            int[] pi = KmpProcess(pattern);

            int q = 0;
            for (int i = 0; i < n; i++)
            {
                while (q > 0 && pattern[q] != text[i])
                {
                    q = pi[q - 1]; //next char does not match, step back pi*[]
                }

                if (pattern[q] == text[i])
                {
                    q = q + 1; //next char matches
                }

                if (q == m) //all matched
                {
                    Console.WriteLine("matched " + i);
                    q = pi[q - 1]; //next match
                }
            }

            return -1;
        }

        private int[] KmpProcess(string pattern)
        {
            int len = pattern.Length;
            int[] pi = new int[len];
            pi[0] = 0;
            int k = 0;

            for (int i = 1; i < len; i++)
            {
                while (k > 0 && pattern[k] != pattern[i])
                {
                    k = pi[k];
                }
                if (pattern[k] == pattern[i])
                {
                    k = k + 1;
                }

                pi[i] = k;
            }

            return pi;

        }

        public void Execute()
        {
            KmpProcess("uababace");
            Kmp("fuababace uababace uababace uababace uababace uababace uababace uababace g", "uababace");
        }
    }
}
