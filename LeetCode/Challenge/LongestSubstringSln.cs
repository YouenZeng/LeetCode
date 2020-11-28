using System;

namespace LeetCode.Challenge
{
    class LongestSubstringSln : ISolution
    {
        public int LongestSubstring(string s, int k)
        {
            int[][] dp = new int[s.Length + 1][];
            dp[0] = new int[26];
            for (int i = 1; i <= s.Length; i++)
            {
                dp[i] = new int[26];
                for (int j = 0; j < 26; j++)
                {
                    dp[i][j] = dp[i - 1][j];
                }
                dp[i][s[i - 1] - 'a'] += 1;
            }

            return Math.Max(0, MaxInRange(s, k, 0, s.Length, dp));
        }

        private int MaxInRange(string s, int k, int from, int to, int[][] dp)
        {
            if (from >= to)
            {
                return 0;
            }

            int charIndex = -1;
            for (int i = 0; i < 26; i++)
            {
                if (dp[to][i] > dp[from][i] && (dp[to][i] - dp[from][i]) < k)
                {
                    charIndex = i;
                    break;
                }
            }

            if (charIndex == -1)
            {
                return to - from;
            }

            var charToFind = (char)('a' + charIndex);
            int t = s.IndexOf(charToFind, from);


            return Math.Max(MaxInRange(s, k, from, t, dp), MaxInRange(s, k, t + 1, to, dp));
        }

        public void Execute()
        {
            Console.WriteLine(LongestSubstring("baaabcb", 3));
            Console.WriteLine(LongestSubstring("azauubbzzuybcgcdfdee", 2));
            Console.WriteLine(LongestSubstring("aaaa", 4));
        }
    }
}
