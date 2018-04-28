using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class CombinationSum4Sln : ISolution
    {
        public int CombinationSum4(int[] nums, int target)
        {
            Array.Sort(nums);

            int[] cache = new int[target + 1];

            for (int i = 0; i <= target; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i - nums[j] > 0)
                    {
                        cache[i] += cache[i - nums[j]];
                    }

                    if (i == nums[j])
                    {
                        cache[i] += 1;
                    }
                }
            }

            return cache[target];
        }

        public void Execute()
        {
            CombinationSum4(new[] {1, 2, 3}, 4);
        }
    }
}