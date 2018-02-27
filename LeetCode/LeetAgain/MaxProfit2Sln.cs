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

                if(currentProfit ==0 && prices[i] < currentMin)
                {
                    currentMin = prices[i];
                }

                currentMax = Math.Max(prices[i], currentMax);
                currentProfit = Math.Max(prices[i] - currentMin - fee, currentProfit);
            }

            return totalProfit + currentProfit;

        }
        public void Execute()
        {
            MaxProfit(new int[] { 2, 1, 4, 4, 2, 3, 2, 5, 1, 2 }, 1);
        }
    }
}
