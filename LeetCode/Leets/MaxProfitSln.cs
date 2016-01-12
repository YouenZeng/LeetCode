using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    public class MaxProfitSln : ISolution
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0)
                return 0;
            int currentMin = prices[0];
            int maxProfit = 0;
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
            }
            return maxProfit;
        }
        public void Execute()
        {
            int[] arr = new[] {1};
            Console.WriteLine(MaxProfit(arr));
        }
    }
}
