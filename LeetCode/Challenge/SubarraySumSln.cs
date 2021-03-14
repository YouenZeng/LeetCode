using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class SubarraySumSln : ISolution
    {
        public int SubarraySum(int[] nums, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            int result = 0;
            dict[0] = 1;
            int prev = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                prev += nums[i];
                if (dict.ContainsKey(prev - k))
                {
                    result += dict[prev - k];
                }

                if (dict.ContainsKey(prev))
                {
                    dict[prev]++;
                }
                else
                {
                    dict[prev] = 1;
                }
            }

            return result;
        }

        public void Execute()
        {
            SubarraySum(new int[] {1, 1, 1}, 2);
        }
    }
}