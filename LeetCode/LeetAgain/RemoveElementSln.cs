﻿using System;

namespace LeetCode.LeetAgain
{
    class RemoveElementSln : ISolution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int N = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    N++;
                    nums[i] = int.MaxValue;
                }
            }

            Array.Sort(nums);

            return nums.Length - N;
        }


        public void Execute()
        {
            RemoveElement(new int[] {3, 2, 2, 3}, 3);
        }
    }
}