using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class MaxProfit2Sln : ISolution
    {
        public int MaxProfit(int[] prices, int fee)
        {
            int currentMin = int.MaxValue;
            int currentProfit = 0;
            int totalProfit = 0;
            int currentMax = int.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] + fee < currentMax)
                {
                    currentMin = prices[i];
                    totalProfit += currentProfit;
                    currentMax = int.MinValue;
                    currentProfit = 0;
                }

                if (currentProfit == 0 && prices[i] < currentMin)
                {
                    currentMin = prices[i];
                }

                currentMax = Math.Max(prices[i], currentMax);
                currentProfit = Math.Max(prices[i] - currentMin - fee, currentProfit);
            }

            return totalProfit + currentProfit;
        }

        /// <summary>
        /// 123
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfitIII(int[] prices)
        {
            //dp[k, i] = max(dp[k, i-1], prices[i] - prices[j] + dp[k-1, j-1]), j=[0..i-1]


            int[][] dp = new int[3][];
            dp[0] = new int[prices.Length];
            for (int i = 1; i < 3; i++)
            {
                dp[i] = new int[prices.Length];
                int min = prices[0];

                for (int j = 1; j < prices.Length; j++)
                {
                    min = Math.Min(min, prices[j] - dp[i - 1][j - 1]);
                    dp[i][j] = Math.Max(dp[i][j - 1], prices[j] - min);
                }
            }

            return dp[2][prices.Length - 1];
        }


        /// <summary>
        /// 123
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfitIIIT(int[] prices)
        {
            //dp[k, i] = max(dp[k, i-1], prices[i] - prices[j] + dp[k-1, j-1]), j=[0..i-1]

            if (prices.Length == 0) return 0;

            int[] dp = new int[3];
            int[] min = new int[3];
            for (int i = 0; i < 3; i++)
            {
                min[i] = prices[0];
            }

            for (int j = 1; j < prices.Length; j++)
            {
                for (int i = 1; i < 3; i++)
                {
                    min[i] = Math.Min(min[i], prices[j] - dp[i - 1]);
                    dp[i] = Math.Max(dp[i], prices[j] - min[i]);
                }
            }

            return dp[2];
        }

        public void Execute()
        {
            var a = MaxProfitIIIT(new int[] {2, 1, 4, 4, 2, 3, 2, 5, 1, 12});
            MaxProfit(new int[] {2, 1, 4, 4, 2, 3, 2, 5, 1, 2}, 1);
        }
    }
}