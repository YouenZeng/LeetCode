using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class JumpGameSln : ISolution
    {
        public int Jump(int[] nums)
        {
            //try to use largest step reachable
            //2, 3, 1 ,1 ,4

            int count = 0;
            int idx = 0;

            while (nums[idx] > 0 && idx < nums.Length - 1)
            {
                int currentMaxStep = nums[idx];

                if(idx+currentMaxStep >=nums.Length-1)
                {
                    count++;
                    break;
                }

                int stepToGo = 0;
                int stepIndex = idx;
                for (int j = idx; j <= idx + currentMaxStep && j < nums.Length; j++)
                {
                    if (stepToGo < nums[j] + j - idx)
                    {
                        stepIndex = j;
                        stepToGo = nums[j] + j - idx;
                    }
                }

                idx = stepIndex;
                count++;
            }


            return count;
        }
        public void Execute()
        {
            var nums = new[] { 0};
            Jump(nums);
        }
    }
}
