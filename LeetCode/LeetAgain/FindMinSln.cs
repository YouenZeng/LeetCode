﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class FindMinSln : ISolution
    {
        public int FindMin(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
            if (nums[0] < nums[nums.Length - 1]) return nums[0];

            return FindMin(nums, 0, nums.Length - 1);
        }

        private int FindMin(int[] nums, int startIndex, int endIndex)
        {
            if (nums[startIndex] < nums[endIndex])
            {
                return int.MinValue;
            }

            if (endIndex - startIndex == 1)
            {
                return Math.Min(nums[startIndex], nums[endIndex]);
            }
            int middle = (endIndex + startIndex) / 2 ;
            return Math.Max(FindMin(nums, startIndex, middle),
                FindMin(nums, middle, endIndex));
        }

        public void Execute()
        {
            Console.WriteLine(FindMin(new int[] { 1, 2, 3 }));
            Console.WriteLine(FindMin(new int[] { 3, 4, 5, 1, 2 }));
            Console.WriteLine(FindMin(new int[] { 4, 5, 6, 7, 0, 1, 2 }));
        }
    }
}
