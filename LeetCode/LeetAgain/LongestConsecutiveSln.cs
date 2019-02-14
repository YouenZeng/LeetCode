using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    internal class LongestConsecutiveSln : ISolution
    {
        public int LongestConsecutive(int[] nums)
        {
            int result = 0;
            Dictionary<int, int> cache = new Dictionary<int, int>();

            foreach (int item in nums)
            {
                if (!cache.ContainsKey(item))
                {
                    int left = cache.ContainsKey(item - 1) ? cache[item - 1] : 0;
                    int right = cache.ContainsKey(item + 1) ? cache[item + 1] : 0;

                    int sum = left + right + 1;

                    cache.Add(item, sum);
                    result = Math.Max(result, sum);
                    cache[item - left] = sum;
                    cache[item + right] = sum;
                }
                else
                {
                    continue;
                }
            }

            return result;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
