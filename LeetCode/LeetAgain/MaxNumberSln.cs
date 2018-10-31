using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    class MaxNumberSln : ISolution
    {
        public int[] MaxNumber(int[] nums1, int[] nums2, int k)
        {
            List<int> result = new List<int>();

            int[] dp = new int[k + 1];

            for (int i = 1; i <= k; i++)
            {
                for (int j = 0; j < nums1.Length; j++)
                {
                    for (int l = 0; l < nums2.Length; l++)
                    {
                        //dp[i] = Math.Max(dp[i-1])
                    }
                }
            }


            return result.ToArray();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}