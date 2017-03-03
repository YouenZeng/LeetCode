using System;

namespace LeetCode.LeetAgain
{
    public class MaxProfitSln : ISolution
    {
        public int MaxProfit(int[] prices)
        {
            int minBuyPrice = int.MaxValue;
            int maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minBuyPrice)
                    minBuyPrice = prices[i];

                maxProfit = Math.Max((prices[i] - minBuyPrice), maxProfit);
            }
            return maxProfit;
        }
        void ISolution.Execute()
        {
            MaxProfit(new[] { 7, 16, 12, 35, 1, 12 });
        }
    }
}