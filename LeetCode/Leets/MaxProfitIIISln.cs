using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    public class MaxProfitIIISln : ISolution
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 2)
            {
                if (prices[0] < prices[1])
                    return prices[1] - prices[0];
                return 0;
            }

            int currentMin = prices[1];
            int currentMin2 = prices[0];
            int maxProfit = 0;
            int maxProfit2 = 0;
            int totalProfit = 0;

            for (int i = 2; i < prices.Length; i++)
            {
                
            }

            //            int currentMin;
            //            int currentMin2;
            //            if (prices[0] > prices[1])
            //            {
            //                currentMin = prices[1];
            //                currentMin2 = prices[0];
            //            }
            //            else
            //            {
            //                currentMin = prices[0];
            //                currentMin2 = prices[1];
            //            }
            //
            //            int maxProfit = 0;
            //            int maxProfit2 = 0;
            //            int totalProfit = 0;
            //            for (int i = 2; i < prices.Length; i++)
            //            {
            //
            //                if (prices[i] < currentMin2 && prices[i]> currentMin)
            //                {
            //                    currentMin2 = prices[i];
            //                }
            //                else if (prices[i] < currentMin)
            //                {
            //                    currentMin2 = currentMin;
            //                    currentMin = prices[i];
            //                }
            //
            //
            //                if ((prices[i] - currentMin2) > maxProfit)
            //                {
            //                    maxProfit = (prices[i] - currentMin);
            //                }
            //                else
            //                {
            //                    //开始新的购买
            //                    currentMin = prices[i];
            //                    totalProfit += maxProfit;
            //                    maxProfit = 0;
            //                }
            //            }
            //            return totalProfit + maxProfit;

            throw  new NotImplementedException();
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
