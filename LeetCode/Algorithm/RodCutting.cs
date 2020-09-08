using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithm
{
    public class RodCutting:ISolution
    {
        public void TryCut(int totalLength)
        {
            Dictionary<int, int> prices = new Dictionary<int, int>()
            {
                {1, 1},
                {2, 5},
                {3, 8},
                {4, 9},
                {5, 10},
                {6, 17},
                {7, 17},
                {8, 20},
                {9, 24},
                {10, 30},
            };

            int[] cache = new int[totalLength + 1];
            int[] steps = new int[totalLength + 1];
            //i, 当前棍子长度
            for (int i = 1; i <= totalLength; i++)
            {
                //遍历可用的切割方案, j<=i 避免数组cache[i - j]越界,
                //j <= prices.Count控制循环次数, 最多循环prices.Count次
                for (int j = 1; j <= i && j <= prices.Count; j++)
                {
                    if (cache[i - j] + prices[j] > cache[i])
                    {
                        cache[i] = cache[i - j] + prices[j];
                        steps[i] = j;
                    }
                }
            }

        }

        public void Execute()
        {
            TryCut(3300);
        }
    }
}