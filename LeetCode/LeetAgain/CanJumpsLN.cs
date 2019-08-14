using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class CanJumpSln : ISolution
    {
        public bool CanJump(int[] nums)
        {
            if (nums.Length == 0) return false;
            if (nums.Length == 1) return true;
            int maxReachIndex = nums[0];

            for (int j = 1; j < maxReachIndex; j++)
            {
                maxReachIndex = Math.Max(maxReachIndex, j + nums[j]);
                if (maxReachIndex >= nums.Length - 1) return true;
            }

            return false;
        }
        public void Execute()
        {
            Console.WriteLine(CanJump(new int[] { 2, 3, 1, 1, 4 }));
            Console.WriteLine(CanJump(new int[] { 3, 2, 1, 0, 4 }));
        }
    }
}
