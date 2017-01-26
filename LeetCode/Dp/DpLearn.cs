using System;
using System.Collections.Generic;
using System.Linq;
using LeetCode.Leets;

namespace LeetCode.Dp
{
    class DpLearn : ISolution
    {
        public int CoinMin(int ammount)
        {
            int[] coins = { 7, 3, 5 };
            List<int> list = new List<int>();
            Enumerable.Range(0, ammount + 1).ToList().ForEach(i => list.Add(i));
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < coins.Length; j++)
                {
                    if (coins[j] <= i && (list[i - coins[j]] + 1) < list[i])
                    {
                        list[i] = list[i - coins[j]] + 1;
                        Console.WriteLine("Setting value " + i);
                    }
                }
            }
            return list[list.Count - 1];
        }

        public int LongestIncreasingSubsequence(int[] nums)
        {
            int[] d = new int[nums.Length];
            int len = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                d[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] <= nums[i] && d[j] + 1 > d[i])
                    {
                        d[i] = d[j] + 1;
                    }
                    if (d[i] > len)
                    {
                        len = d[i];
                    }
                }
            }
            return len;
        }

        public void Execute()
        {
            Console.WriteLine(LongestIncreasingSubsequence(new []{5,3,4,8,6,7}));
        }
    }
}
