using System;

namespace LeetCode.LeetAgain
{
    public class PalindromePartitioningSln : ISolution
    {
        public int MinCut(string s)
        {
            int[] minDp = new int[s.Length + 1];
            bool[,] checkDp = new bool[s.Length + 1, s.Length + 1];

            for (int i = 0; i < s.Length; i++)
            {
                minDp[i] = i;
                for (int j = 0; j <= i; j++)
                {
                    //if (IsPalindrome(s, j, i))
                    //{
                    //    minDp[i] = j == 0 ? 0 : Math.Min(minDp[i], minDp[j - 1] + 1);
                    //}

                    if (s[j] == s[i] && (j + 1 > i - 1 || checkDp[j + 1, i - 1]))
                    {
                        checkDp[j, i] = true;
                        minDp[i] = j == 0 ? 0 : Math.Min(minDp[i], minDp[j - 1] + 1);
                    }
                }
            }

            return minDp[s.Length - 1];
        }

        private bool IsPalindrome(string s, int start, int end)
        {
            while (start < end)
            {
                if (s[start++] != s[end--])
                {
                    return false;
                }
            }

            return true;
        }

        public void Execute()
        {
            MinCut("aabfssd");
        }
    }
}