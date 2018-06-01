using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class FindLengthOfLCISSln : ISolution
    {
        public int FindLengthOfLCIS(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int prevMax = 1;
            int endWithCurrentMax = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    endWithCurrentMax++;
                    prevMax = Math.Max(prevMax, endWithCurrentMax);
                }
                else
                {
                    endWithCurrentMax = 1;
                }
            }
            return prevMax;
        }

        public int FindLengthOfLCIS2(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int[] dp = new int[nums.Length];
            int[] dpCount = new int[nums.Length];

            int result = 0;
            int maxLength = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                dp[i] = 1;
                dpCount[i] = 1;

                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        if (dp[i] == dp[j] + 1)
                        {
                            dpCount[i] += dpCount[j];
                        }
                        if (dp[i] < dp[j] + 1)
                        {
                            dp[i] = dp[j] + 1;
                            dpCount[i] = dpCount[j];
                        }
                    }
                }

                if (maxLength == dp[i]) result += dpCount[i];

                if (maxLength < dp[i])
                {
                    maxLength = dp[i];
                    result = dpCount[i];
                }

            }
            return result;
        }


        public void Execute()
        {
            FindLengthOfLCIS2(new int[] { 1, 2, 4, 3, 23, 32, 4, 3, 5 });
            FindLengthOfLCIS2(new int[] { 1, 3, 5, 4, 7 });
        }
    }
}
