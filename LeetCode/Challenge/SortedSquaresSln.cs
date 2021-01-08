using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class SortedSquaresSln : ISolution
    {
        public int[] SortedSquares(int[] nums)
        {
            int[] result = new int[nums.Length];
            int end = nums.Length - 1;
            int start = 0;
            int current = nums.Length - 1;

            while (start <= end)
            {
                if (Math.Abs(nums[end]) > Math.Abs(nums[start]))
                {
                    result[current] = nums[end] * nums[end];
                    end--;
                }
                else
                {
                    result[current] = nums[start] * nums[start];
                    start++;
                }
                current--;
            }

            return result;
        }
        public void Execute()
        {
            SortedSquares(new int[] { 1, 2 });
            SortedSquares(new int[] { -7, -3, 2, 3, 11 });
            SortedSquares(new int[] { -4, -1, 0, 3, 10 });
        }
    }
}
