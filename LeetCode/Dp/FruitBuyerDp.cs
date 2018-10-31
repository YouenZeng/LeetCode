using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Dp
{
    class FruitBuyerDp
    {
        public void FruitBuyer(Dictionary<string, int> fruitPrices, int totalMoney)
        {
            //print result
            FruitBuyerInternal(fruitPrices, totalMoney, new Dictionary<string, int>());
        }

        private void FruitBuyerInternal(Dictionary<string, int> fruitPrices, int totalMoney, Dictionary<string, int> result)
        {

        }
    }
}
