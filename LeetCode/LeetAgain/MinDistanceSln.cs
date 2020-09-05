using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class MinDistanceSln : ISolution
    {
        public int MinDistance(string word1, string word2)
        {
            int w1 = word1.Length;
            int w2 = word2.Length;

            int[,] dp = new int[w1 + 1, w2 + 1];
            for (int i = 0; i <= w1; i++)
            {
                dp[i, 0] = i;
            }

            for (int i = 0; i <= w2; i++)
            {
                dp[0, i] = i;
            }


            for (int i = 1; i <= w1; i++)
            {
                for (int j = 1; j <= w2; j++)
                {
                    if (word1[i - 1] == word2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = Math.Min(dp[i - 1, j - 1], Math.Min(dp[i, j - 1], dp[i - 1, j])) + 1;
                    }
                }
            }

            return dp[w1, w2];
        }

        public void Execute()
        {
            MinDistance("horse", "ros");
        }
    }
}