using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class ThreeSumClosestSln : ISolution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);

            int result = int.MaxValue;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    int start = i + 1;
                    int end = nums.Length - 1;

                    while (start < end)
                    {
                        int diff = target - nums[start] - nums[end] - nums[i];

                        if (Math.Abs(diff) < Math.Abs(result))
                        {
                            result = diff;
                        }

                        if (diff > 0)
                        {
                            start++;
                        }
                        else
                        {
                            end--;
                        }
                    }
                }
            }

            return target - result;
        }

        public void Execute()
        {
            ThreeSumClosest(new int[] {2, 2, 2, 2, 2, 2, 3, 3, 3}, 6);
        }
    }
}