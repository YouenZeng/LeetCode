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

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    int start = i + 1;
                    int end = nums.Length - 1;
                    int target = nums[i] * -1;

                    while (start < end)
                    {
                        if (nums[start] + nums[end] == target)
                        {
                            result.Add(new List<int>()
                            {
                                nums[start],
                                nums[i],
                                nums[end]
                            });

                            while (start < end && nums[start] == nums[start + 1])
                            {
                                start++;
                            }

                            while (start < end && nums[end] == nums[end - 1])
                            {
                                end--;
                            }

                            start++;
                            end--;
                        }
                        else if (nums[start] + nums[end] < target)
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


            return result;
        }

        public void Execute()
        {
            ThreeSum(new int[] {-1, 0, 1, 2, -1, -4});
        }
    }
}