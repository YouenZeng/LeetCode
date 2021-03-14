using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class MinSubarraySln : ISolution
    {
        public int MinSubarray(int[] nums, int p)
        {
            Dictionary<int, int> position = new Dictionary<int, int>();
            int sum = 0;
            int min = int.MaxValue;

            int gap = 0;
            foreach (int n in nums)
            {
                gap = (gap + n) % p;
            }

            position[0] = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = (sum + nums[i]) % p;
                if (sum < 0)
                {
                    sum += p;
                }

                position[sum] = i;

                int target = (sum - gap + p) % p;
                if (position.ContainsKey(target))
                {
                    min = Math.Min(min, i - position[target]);
                }
            }

            return min >= nums.Length ? -1 : min;
        }

        public void Execute()
        {
            MinSubarray(new int[] {1, 2, 3}, 7);
        }
    }
}