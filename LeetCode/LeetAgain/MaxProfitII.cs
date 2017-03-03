using System;

namespace LeetCode.LeetAgain
{
    public class MaxProfitII : ISolution
    {
        public int MaxProfit(int[] prices)
        {
            int minBuyPrice = int.MaxValue;
            int maxSellPrice = int.MaxValue;
            int maxProfit = 0;
            int currentProfix = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                //find sell chance
                if (prices[i] < maxSellPrice)
                {
                    minBuyPrice = prices[i];
                    maxSellPrice = int.MinValue;
                    maxProfit += currentProfix;
                    currentProfix = 0;
                }

                maxSellPrice = Math.Max(prices[i], maxSellPrice);
                currentProfix = Math.Max((prices[i] - minBuyPrice), currentProfix);
            }
            return maxProfit + currentProfix;
        }
        void ISolution.Execute()
        {
            MaxProfit(new[] { 7, 1, 2, 4 });
        }
    }
}