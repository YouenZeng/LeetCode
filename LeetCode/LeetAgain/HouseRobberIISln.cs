using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class HouseRobberIISln : ISolution
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            return Math.Max(RobInternal(nums, 0, nums.Length - 2), RobInternal(nums, 1, nums.Length - 1));

        }

        private int RobInternal(int[] nums, int lo, int hi)
        {
            //rob 1st
            int include = 0, exclude = 0;
            for (int j = lo; j <= hi; j++)
            {
                int i = include, e = exclude;
                include = e + nums[j];
                exclude = Math.Max(e, i);
            }
            return Math.Max(include, exclude);
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
