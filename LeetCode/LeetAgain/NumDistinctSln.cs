using System;

namespace LeetCode.LeetAgain
{
    public class NumDistinctSln : ISolution
    {
        public int NumDistinct(string s, string t)
        {
            int sLength = s.Length;
            int tLength = t.Length;

            var cache = new int[t.Length + 1, s.Length + 1];
            for (int i = 0; i <= s.Length; i++)
            {
                cache[0, i] = 1;
            }

            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 1; j <= t.Length; j++)
                {
                    cache[j, i] = cache[j, i - 1] + (s[i - 1] == t[j - 1] ? cache[j - 1, i - 1] : 0);
                }
            }

            return cache[tLength, sLength];
        }

        public void Execute()
        {
            NumDistinct("babgbag", "bag");
        }
    }
}