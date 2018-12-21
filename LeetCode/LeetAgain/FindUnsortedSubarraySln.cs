using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class FindUnsortedSubarraySln : ISolution
    {
        public int FindUnsortedSubarray(int[] nums)
        {
            int[] numsClone = new int[nums.Length];
            Array.Copy(nums, numsClone, nums.Length);
            Array.Sort(nums);

            int lo = 0;
            int hi = 0;



            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != numsClone[i])
                {
                    lo = i; break;
                }
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] != numsClone[i])
                {
                    hi = i; break;
                }
            }

            if (hi == lo) return 0;
            return hi - lo + 1;
        }

        public void Execute()
        {
            FindUnsortedSubarray(new int[] { 2, 2, 2, 2, 1, 1, 1 });
            FindUnsortedSubarray(new int[] { 2, 6, 4, 8, 10, 9, 15 });
            FindUnsortedSubarray(new int[] { 1, 2 });
            FindUnsortedSubarray(new int[] { 2, 1 });
        }
    }
}
