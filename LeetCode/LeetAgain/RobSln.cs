using System;

namespace LeetCode.LeetAgain
{
    public class RobSln : ISolution
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
            if (nums.Length == 2) return Math.Max(nums[0], nums[1]);
            int prevRob = nums[1];
            int prevNotRob = nums[0];
            for (int i = 2; i < nums.Length; i++)
            {
                int notRTemp = prevNotRob;
                prevNotRob = Math.Max(prevRob, prevNotRob);
                prevRob = Math.Max(prevRob, prevNotRob + nums[i]);
            }

            return Math.Max(prevNotRob, prevRob);
        }
        void ISolution.Execute()
        {
            Rob(new[] { 2, 1, 1, 2 });
        }
    }
}