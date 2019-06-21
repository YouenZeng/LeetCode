using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    class ThreeSumSln : ISolution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            Array.Sort(nums);

            int start = 0;

            while (start < nums.Length - 2)
            {
                int end = nums.Length - 1;
                int tStart = start;
                while (tStart < end)
                {
                    int target = nums[tStart] + nums[end];
                    target = target * -1;

                    for (int i = tStart + 1; i < end - 1; i++)
                    {
                        if (nums[i] == target)
                        {
                            var r = new List<int> {nums[tStart], target, nums[end]};
                            result.Add(r);
                            break;
                        }
                    }

                    end--;
                }

                start++;
            }

            return result;
        }

        public void Execute()
        {
            ThreeSum(new int[] {-1, 0, 1, 2, -1, -4});
        }
    }
}