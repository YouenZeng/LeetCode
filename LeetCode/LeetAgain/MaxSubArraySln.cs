using System;

namespace LeetCode.LeetAgain
{
    public class MaxSubArraySln : ISolution
    {

        public int MaxSubArray(int[] nums)
        {

            int prevMax = nums[0];
            int currentMax = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (currentMax < 0)
                    currentMax = nums[i];
                else
                    currentMax += nums[i];

                prevMax = Math.Max(currentMax, prevMax);
            }
            return prevMax;
        }
        void ISolution.Execute()
        {
            MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
        }
    }
}