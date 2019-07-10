using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class FirstMissingPositiveSln : ISolution
    {
        public int FirstMissingPositive(int[] nums)
        {
            if (nums.Length == 0) return 1;
            for (int i = 0; i < nums.Length; i++)
            {
                while (nums[i] > 0 && nums[i] <= nums.Length && nums[i] != nums[nums[i] - 1])
                {
                    Swap(nums, i, nums[i] - 1);
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != (i + 1))
                    return i + 1;
            }

            return nums.Length + 1;
        }

        private void Swap(int[] nums, int from, int to)
        {
            int t = nums[from];
            nums[from] = nums[to];
            nums[to] = t;
        }

        public void Execute()
        {
            FirstMissingPositive(new int[] { 1 });
            FirstMissingPositive(new int[] { 7, 8, 9, 11, 12 });
            FirstMissingPositive(new int[] { 1, 0, 0, -11, 3 });
            FirstMissingPositive(new int[] { 1 });
            
        }
    }
}
