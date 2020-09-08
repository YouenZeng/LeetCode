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
            int max = 0;

            //greedy

            int current = int.MinValue;
            int minPrice = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                if (minPrice > prices[i])
                {
                    minPrice = prices[i];
                    continue;
                }

                //up raised
                if (current < prices[i])
                {
                    current = prices[i];
                }

                //预知未来
                if (i < prices.Length - 1 && prices[i + 1] < prices[i])
                {
                    max = max + current - minPrice;
                    current = int.MinValue;
                    minPrice = prices[i];
                }
            }

            if (current > minPrice)
                max = max + current - minPrice;
            return max;
        }

        public int MaxProfit3(int[] prices)
        {
            int total = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i + 1] > prices[i]) 
                    total += prices[i + 1] - prices[i];
            }

            return total;
        }

        void ISolution.Execute()
        {
            MaxProfit3(new[] {1,2,1,4,112});
        }
    }
}