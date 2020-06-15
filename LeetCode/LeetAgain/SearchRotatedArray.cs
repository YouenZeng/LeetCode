using System;

namespace LeetCode.LeetAgain
{
    public class SearchRotatedArray : ISolution
    {
        public bool Search(int[] nums, int target)
        {
            return Search(nums, 0, nums.Length - 1, target);
        }

        private bool Search(int[] nums, int start, int end, int target)
        {
            if (start > end)
                return false;
            if (start == end)
            {
                if (nums[start] == target)
                    return true;
                return false;
            }

            int mid = start + (end - start) / 2;

            //ensure we are going to correct part
            if (nums[mid] < target)
            {
                if (nums[start] < nums[end])
                {
                    return Search(nums, mid + 1, end, target);
                }

                return Search(nums, mid + 1, end, target) || Search(nums, start, mid, target);
            }

            if (nums[start] < nums[end])
            {
                return Search(nums, start, mid, target);
            }

            return Search(nums, mid + 1, end, target) || Search(nums, start, mid, target);
        }

        public void Execute()
        {
            Console.WriteLine(Search(new int[] {2, 3, 5, 1, 2, 2, 2}, 2));
            Console.WriteLine(Search(new int[] {1, 1, 1, 2, 2, 2, 3, 3, 3, 3}, 3));
            Console.WriteLine(Search(new int[] {4, 5, 6, 7, 0, 1, 2}, 0));
            Console.WriteLine(Search(new int[] {4, 5, 6, 7, 0, 1, 2}, 3));
        }
    }
}