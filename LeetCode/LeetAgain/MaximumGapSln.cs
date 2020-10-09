using System;

namespace LeetCode.LeetAgain
{
    public class MaximumGapSln : ISolution
    {
        public int MaximumGap(int[] nums)
        {
            Array.Sort(nums);

            int minGap = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] - nums[i - 1] > minGap)
                    minGap = nums[i] - nums[i - 1];
            }

            return minGap;
        }

        public void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}