using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Lof
{
    public class FindRepeatNumberSln : ISolution
    {
        public int FindRepeatNumber(int[] nums)
        {
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (hs.Add(nums[i]) == false)
                {
                    return nums[i];
                }
            }
            return -1;
        }

        public int FindRepeatNumber2(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i)
                {
                    Swap(nums, i, nums[i]);
                }
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] != i)
                    return nums[i];
            }
            return -1;
        }

        private void Swap(int[] nums, int from, int to)
        {
            int t = nums[from];
            nums[from] = nums[to];
            nums[to] = t;
        }

        public void Execute()
        {
            FindRepeatNumber2(new int[] { 5, 4, 7, 6, 2, 2, 1, 1 });
        }
    }
}
