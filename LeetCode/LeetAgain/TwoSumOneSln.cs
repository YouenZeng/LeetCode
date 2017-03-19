using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class TwoSumOneSln : ISolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    result[0] = i;
                    result[1] = dict[target - nums[i]];
                    break;
                }

                if(dict.ContainsKey(nums[i]) == false)
                    dict.Add(nums[i], i);
            }

            return result;
        }

        public void Execute()
        {
            TwoSum(new[] { 3, 2, 4 }, 6);
        }
    }
}
