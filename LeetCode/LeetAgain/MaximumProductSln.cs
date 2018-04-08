using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class MaximumProductSln : ISolution
    {
        public int MaximumProduct(int[] nums)
        {
            Array.Sort(nums);

            int length = nums.Length;

            int low = nums[0] * nums[1];
            int hight = nums[length - 3] * nums[length - 2];

            return Math.Max(nums[length - 1] * low, nums[length - 1] * hight);
        }

        public void Execute()
        {
            Console.WriteLine(MaximumProduct(new[] { -123, 33, -2, 1 }));
            Console.WriteLine(MaximumProduct(new[] { -1, -2, -3 }));
            Console.WriteLine(MaximumProduct(new[] { 1, 0, 0, 0 }));
        }
    }
}