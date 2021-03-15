using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Challenge
{
    class MinimumSizeSln : ISolution
    {
        public int MinimumSize(int[] nums, int maxOperations)
        {
            int min = 1;
            int max = nums.Max();

            while (min < max)
            {
                int mid = min + (max - min) / 2;
                int op = CountOps(nums, mid);
                if (op == maxOperations)
                {
                    return mid;
                }
                else if (op < maxOperations)
                {
                    max = mid - 1;
                   
                }
                else
                {
                    min = mid + 1;
                }
            }

            return max;
        }

        private int CountOps(int[] nums, int slice)
        {
            int count = 0;
            foreach (int num in nums)
            {
                if (num <= slice)
                {
                    continue;
                }

                count += (num - 1) / slice;
            }

            return count;
        }


        public void Execute()
        {
            MinimumSize(new int[] { 2, 4, 8, 2 }, 4);
            MinimumSize(new int[] {9}, 2);
        }
    }
}