using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class CoinChangeSln : ISolution
    {
        public int CoinChange(int[] coins, int amount)
        {
            int[] dp = new int[amount + 1];

            for (int i = 0; i <= amount; i++)
            {
                dp[i] = amount + 1;
            }
            dp[0] = 0;

            

            for (int j = 0; j < coins.Length; j++)
            {
                for (int i = coins[j]; i <= amount; i++)
                {
                    dp[i] = Math.Min(dp[i - coins[j]] + 1, dp[i]);
                }
            }


            return dp[amount] > amount ? -1 : dp[amount];
        }
        public void Execute()
        {
            CoinChange(new int[] { 1, 2, 55 }, 11);
        }
    }
}
