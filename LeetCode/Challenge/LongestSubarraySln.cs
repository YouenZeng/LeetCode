using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LeetCode.Challenge
{
    class LongestSubarraySln : ISolution
    {
        public int LongestSubarray(int[] nums, int limit)
        {

            LinkedList<int> min = new LinkedList<int>();
            LinkedList<int> max = new LinkedList<int>();
            int start = 0, end = 0;
            int res = 0;
            for (; end < nums.Length; ++end)
            {
                while (min.Count > 0 && nums[end] < min.Last.Value) min.RemoveLast();
                while (max.Count > 0 && nums[end] > max.Last.Value) max.RemoveLast();
                min.AddLast(nums[end]);
                max.AddLast(nums[end]);
                while (max.First.Value - min.First.Value > limit)
                {
                    if (nums[start] == min.First.Value) min.RemoveFirst();
                    if (nums[start] == max.First.Value) max.RemoveFirst();
                    start++;
                }
                res = Math.Max(res, end - start + 1);
            }
            return res;

            //int left = 0;
            //int right = 0;
            //int res = 0;
            ////记录当前窗口的最大值和最小值
            //int curMax = nums[0];
            //int curMin = nums[0];
            //while (right < nums.Length)
            //{
            //    curMax = Math.Max(curMax, nums[right]);
            //    curMin = Math.Min(curMin, nums[right]);
            //    //如果满足条件那么窗口右边界扩张
            //    if (curMax - curMin <= limit)
            //    {
            //        right++;
            //    }
            //    else
            //    {
            //        //当不满足条件时窗口左边界收缩
            //        res = Math.Max(right - left, res);
            //        left = right;
            //        curMax = nums[left];
            //        curMin = nums[left];
            //        //重新找到当前窗口的最大最小值
            //        while (Math.Abs(nums[right] - nums[--left]) <= limit)
            //        {
            //            curMin = Math.Min(nums[left], curMin);
            //            curMax = Math.Max(nums[left], curMax);
            //        }

            //        left++;
            //        right++;
            //    }
            //}

            //return Math.Max(right - left, res);

        }

        public void Execute()
        {
            LongestSubarray(new int[] { 10, 1, 2, 4, 7, 2 }, 5);
        }
    }
}