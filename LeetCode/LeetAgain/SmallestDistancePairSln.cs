using System;

namespace LeetCode.LeetAgain
{
    internal class SmallestDistancePairSln : ISolution
    {

        public int SmallestDistancePair(int[] nums, int k)
        {
            int arrayLength = nums.Length;
            Array.Sort(nums);

            int low = 0;
            int high = nums[arrayLength - 1] - nums[0];

            int countMid = 0;
            while (low < high)
            {
                countMid = 0;
                int mid = low + (high - low) / 2;

                for (int i = 0, j = 0; i < arrayLength; i++)
                {
                    while (j < arrayLength && (nums[j] - nums[i]) <= mid) j++;
                    countMid += j - i - 1;
                }

                if (countMid < k)
                    low = mid + 1;
                else
                    high = mid;

            }
            return low;
        }
        public void Execute()
        {
            SmallestDistancePair(new int[] { 1, 6, 1 }, 3);
        }
    }
}
