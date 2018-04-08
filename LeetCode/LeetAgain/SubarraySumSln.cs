using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class SubarraySumSln : ISolution
    {
        public int SubarraySum(int[] nums, int k)
        {
            int result = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int sum = 0;
            dict.Add(0, 1);
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (dict.ContainsKey(sum - k))
                {
                    result += dict[sum - k];
                }

                if (dict.ContainsKey(sum)) dict[sum]++;
                else dict.Add(sum, 1);
            }

            return result;
        }
        public void Execute()
        {
            SubarraySum(new int[] { 1, 1, 1, 2, 3, 0, -1, 1 }, 3);
        }
    }
}
