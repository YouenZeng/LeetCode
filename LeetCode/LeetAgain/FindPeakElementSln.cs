using System;

namespace LeetCode.LeetAgain
{
    public class FindPeakElementSln : ISolution
    {
        public int FindPeakElement(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;

            if (end == 0)
                return 0;

            if (end > 0 && nums[start] > nums[1])
                return 0;

            if (end > 0 && nums[end] > nums[end - 1])
                return 0;

            var e = FindPeakElement(nums, start, end);
            if (e == -1)
                return 0;
            return e; 
        }

        private int FindPeakElement(int[] nums, int start, int end)
        {
            if (end - start == 2)
            {
                if (nums[start + 1] > nums[start] && nums[start + 1] > nums[end])
                {
                    return start + 1;
                }

                return -1;
            }

            int mid = start + (end - start) / 2;
            return Math.Max(FindPeakElement(nums, start, mid + 1), FindPeakElement(nums, mid, end));
        }

        public void Execute()
        {
            Console.WriteLine(FindPeakElement(new[] {1, 2, 3, 1}));
            Console.WriteLine(FindPeakElement(new[] {1, 2, 1, 5, 3, 6, 4}));
        }
    }
}