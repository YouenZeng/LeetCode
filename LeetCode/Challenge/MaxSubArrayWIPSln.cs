using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class MaxSubArrayWIPSln : ISolution
    {
        public int MaxSubArray(int[] nums)
        {
            return Math.Max(int.MinValue, MaxSubArray(nums, 0, nums.Length - 1));
        }

        private int MaxSubArray(int[] nums, int start, int end)
        {
            if (start == end)
            {
                return nums[start];
            }

            if (start == end - 1)
            {
                return Math.Max(nums[start], nums[end]);
            }


            int mid = start + (end - start) / 2;
            int leftMax = MaxSubArray(nums, start, mid);
            int rightMax = MaxSubArray(nums, mid + 1, end);

            return Math.Max(Math.Max(leftMax, leftMax + rightMax), rightMax);


        }
        public void Execute()
        {
            int[] a = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

            Console.WriteLine(MaxSubArray(a));
        }
    }
}
