using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class MissingNumberSln : ISolution
    {
        public int MissingNumber(int[] nums)
        {
            int max = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                while (nums[i] != i && nums[i] != max)
                {
                    int t = nums[nums[i]];
                    nums[nums[i]] = nums[i];
                    nums[i] = t;
                }
            }

            //Console.WriteLine(string.Join("", nums));
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == max)
                {
                    return i;
                }
            }

            return max;
        }

        public void Execute()
        {
            MissingNumber(new int[] {9, 6, 4, 2, 3, 5, 7, 0, 1});
        }
    }
}