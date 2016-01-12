using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    public class MaxSubarrSln : ISolution
    {
        //Find the contiguous subarray within an array (containing at least one number) which has the largest sum.
        //
        //For example, given the array [-2,1,-3,4,-1,2,1,-5,4],
        //the contiguous subarray [4,-1,2,1] has the largest sum = 6.
        public int MaxSubArray(int[] nums)
        {
            int currentMax = nums[0];
            int maxCache = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                currentMax = currentMax + nums[i];
                if (nums[i] > currentMax)
                {
                    currentMax = nums[i];
                }
                if (currentMax > maxCache)
                {
                    maxCache = currentMax;
                }
            }

            return Math.Max(maxCache, currentMax);
        }
        public void Execute()
        {
            int[] arr = new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Console.Write(MaxSubArray(arr));
        }
    }
}
