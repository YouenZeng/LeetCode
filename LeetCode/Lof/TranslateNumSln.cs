using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lof
{
    class TranslateNumSln : ISolution
    {
        public int TranslateNum(int num)
        {
            string input = num.ToString();
            int[] dp = new int[input.Length + 1];

            dp[0] = 1;
            dp[1] = 1;
            for (int i = 1; i < input.Length; i++)
            {
                int twoDigit = Convert.ToInt32(input.Substring(i - 1, 2));
                if (twoDigit <= 25 && twoDigit >= 10)
                {
                    dp[i + 1] = dp[i] + dp[i - 1];
                }
                else
                {
                    dp[i + 1] = dp[i];
                }
            }

            return dp[input.Length];
        }

        public void Execute()
        {
            TranslateNum(99999);
        }
    }
}