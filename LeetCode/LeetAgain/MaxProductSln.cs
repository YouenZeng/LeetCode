using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class MaxProductSln : ISolution
    {
        public int MaxProduct(int[] nums)
        {
            int currentSum = nums[0];
            int prevMax = nums[0];
            int prevMin = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                var maxCurrent = Math.Max(Math.Max(nums[i]* prevMax, nums[i] * prevMin), nums[i]);
                var minCurrent = Math.Min(Math.Min(nums[i]* prevMax, nums[i] * prevMin), nums[i]);

                currentSum = Math.Max(maxCurrent, currentSum);

                prevMax = maxCurrent;
                prevMin = minCurrent;
            }
            return currentSum;
        }

        public void Execute()
        {
            Console.WriteLine(MaxProduct(new[] { -4,-3,-2 }));
        }
    }
}
