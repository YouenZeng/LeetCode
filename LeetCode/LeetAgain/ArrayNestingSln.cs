using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    class ArrayNestingSln : ISolution
    {
        public int ArrayNesting(int[] nums)
        {
            int max = 0;
            int[] cache = new int[20000];
            int count = 1;
            HashSet<int> circleDetect = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (cache[nums[i]] != 0)
                {
                    continue;
                }
                int currentItem = i;

                while (currentItem < nums.Length && circleDetect.Add(nums[currentItem]))
                {
                    cache[nums[currentItem]] = count;
                    count++;
                    currentItem = nums[currentItem];
                }
                circleDetect.Clear();

                max = Math.Max(count, max);
                count = 1;
            }
            return max - 1;

        }
        public void Execute()
        {
            int[] inputArray = new[] { 1, 2 };
            ArrayNesting(inputArray);
        }
    }
}
