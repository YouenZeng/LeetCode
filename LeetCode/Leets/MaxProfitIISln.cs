using System;

namespace LeetCode.Leets
{
    public class MaxProfitIISln : ISolution
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0)
                return 0;
            int currentMin = prices[0];
            int maxProfit = 0;
            int totalProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < currentMin)
                {
                    currentMin = prices[i];
                }
                if ((prices[i] - currentMin) > maxProfit)
                {
                    maxProfit = (prices[i] - currentMin);
                }
                else
                {
                    //开始新的购买
                    currentMin = prices[i];
                    totalProfit += maxProfit;
                    maxProfit = 0;
                }
            }
            return totalProfit + maxProfit;

        }
        public void Execute()
        {
            int[] arr = new[] { 2,1,2,0,1 };
            Console.WriteLine(MaxProfit(arr));
        }
    }
}
