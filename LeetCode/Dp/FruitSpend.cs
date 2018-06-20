using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Dp
{
    class FruitSpend
    {
        public void FruitBuyer(Dictionary<string, int> fruitPrices, int totalMoney)
        {
            Dfs(fruitPrices, totalMoney, fruitPrices.ToDictionary(f => f.Key, f => 0));
        }

        private readonly List<string> _resultCache = new List<string>();

        private void Dfs(Dictionary<string, int> fruitPrices, int totalMoney, Dictionary<string, int> fruitCount)
        {
            if (totalMoney < 0)
            {
                return;
            }
            if (totalMoney == 0)
            {
                var hash = fruitCount.OrderBy(f => f.Key).Select(fr => fr.Key + fr.Value);
                var stringHash = string.Join("", hash);

                if (_resultCache.Contains(stringHash) == false)
                {
                    _resultCache.Add(stringHash);
                    Console.WriteLine("Cococo, you found one.");
                    //print it
                    foreach (var item in fruitCount)
                    {
                        if (item.Value > 0)
                        {
                            Console.WriteLine($"{item.Key}:{item.Value}");
                        }
                    }
                }
                return;
            }

            foreach (KeyValuePair<string, int> item in fruitPrices)
            {
                fruitCount[item.Key]++;
                Dfs(fruitPrices, totalMoney - item.Value, fruitCount);
                fruitCount[item.Key]--;
            }
        }

        public void Test()
        {

            var fruitList = new Dictionary<string, int>() {
                { "A",32},
                { "B",41},
                { "C",97},
                { "D",254},
                { "E",399}
            };

            FruitBuyer(fruitList, 500);

        }
    }
}
