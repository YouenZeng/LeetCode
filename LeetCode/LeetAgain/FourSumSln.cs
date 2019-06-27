using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.LeetAgain
{
    class FourSumSln : ISolution
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            len = nums.Length;
            Array.Sort(nums);
            var result = kSum(nums, target, 4, 0);
            return result;
        }

        int len = 0;
        private IList<IList<int>> kSum(int[] nums, int target, int k, int index)
        {
            IList<IList<int>> res = new List<IList<int>>();
            if (index >= len)
            {
                return res;
            }
            if (k == 2)
            {
                int i = index, j = len - 1;
                while (i < j)
                {
                    //find a pair
                    if (target - nums[i] == nums[j])
                    {
                        List<int> temp = new List<int>();
                        temp.Add(nums[i]);
                        temp.Add(target - nums[i]);
                        res.Add(temp);
                        //skip duplication
                        while (i < j && nums[i] == nums[i + 1]) i++;
                        while (i < j && nums[j - 1] == nums[j]) j--;
                        i++;
                        j--;
                        //move left bound
                    }
                    else if (target - nums[i] > nums[j])
                    {
                        i++;
                        //move right bound
                    }
                    else
                    {
                        j--;
                    }
                }
            }
            else
            {
                for (int i = index; i < len - k + 1; i++)
                {
                    //use current number to reduce ksum into k-1sum
                    IList<IList<int>> temp = kSum(nums, target - nums[i], k - 1, i + 1);
                    if (temp != null)
                    {
                        //add previous results
                        foreach (List<int> t in temp)
                        {
                            t.Add(nums[i]);
                        }
                        res = res.Union(temp).ToList();
                    }
                    while (i < len - 1 && nums[i] == nums[i + 1])
                    {
                        //skip duplicated numbers
                        i++;
                    }
                }
            }
            return res;
        }

        public void Execute()
        {
            FourSum(new int[] { 1, 0, -1, 0, -2, 2 }, 0);
        }
    }
}