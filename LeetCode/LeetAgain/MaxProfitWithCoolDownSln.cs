using System;

namespace LeetCode.LeetAgain
{
    public class MaxProfitWithCoolDownSln : ISolution
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0) return 0;
            //0 buy, 1 sell, 2 cooldown
            int[,] dp = new int[prices.Length, 3];

            for (int i = 1; i < prices.Length; i++)
            {
                int maxSell = 0;
                for (int j = 0; j < i; j++)
                {
                    maxSell = Math.Max(dp[j, 0] + prices[i] - prices[j], maxSell);
                }

                dp[i, 1] = maxSell;
                dp[i, 0] = dp[i - 1, 2];
                dp[i, 2] = Math.Max(Math.Max(dp[i - 1, 0], dp[i - 1, 1]), dp[i - 1, 2]);
            }

            return Math.Max(Math.Max(dp[prices.Length - 1, 0], dp[prices.Length - 1, 1]), dp[prices.Length - 1, 2]);
        }

        void ISolution.Execute()
        {
            Console.WriteLine(MaxProfit(new[] { 1111}));
        }
    }
}