using System;

namespace LeetCode.LeetAgain
{
    public class MaxProfitSln : ISolution
    {
        public int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                    continue;
                }

                maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
            }

            return maxProfit;
        }


        /// <summary>
        /// 122. Best Time to Buy and Sell Stock II
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit2(int[] prices)
        {


            throw new NotImplementedException();
        }
        void ISolution.Execute()
        {
            MaxProfit(new[] {7, 16, 12, 35, 1, 12});
        }
    }
}