using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class MinSubArrayLenSln : ISolution
    {
        public int MinSubArrayLen(int s, int[] nums)
        {
            int count = int.MaxValue;
            int slowPointer = 0;
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                while (sum >= s)
                {
                    count = Math.Min(count, i + 1 - slowPointer);
                    sum -= nums[slowPointer++];
                }
            }

            return count == int.MaxValue ? 0 : count;
        }

        public void Execute()
        {
            MinSubArrayLen(7, new[] {2, 3, 1, 2, 4, 3});
            MinSubArrayLen(4, new[] {1, 4, 4});
            MinSubArrayLen(15, new[] {1, 2, 3, 4, 5});
        }
    }
}