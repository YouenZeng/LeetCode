using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class TriangleNumberSln : ISolution
    {
        public int TriangleNumber(int[] nums)
        {
            int result = 0;
            if (nums.Length < 3) return result;

            Array.Sort(nums);

            for (int i = 2; i < nums.Length; i++)
            {
                int left = 0, right = i - 1;
                while (left < right)
                {
                    if (nums[left] + nums[right] > nums[i])
                    {
                        result += (right - left);
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }

            return result;
        }
        public void Execute()
        {
            TriangleNumber(new int[] { 2, 2, 3,4 });
        }
    }
}
