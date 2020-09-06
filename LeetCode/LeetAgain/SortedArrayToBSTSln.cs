using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    class SortedArrayToBSTSln : ISolution
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0) return null;
            return BuildInternal(nums, 0, nums.Length-1);
        }

        private TreeNode BuildInternal(int[] nums, int start, int end)
        {
            if (start > end) return null;
            if (start == end) return new TreeNode(nums[start]);

            int middle = (end + start) / 2;
            return new TreeNode(nums[middle])
            {
                left = BuildInternal(nums, start, middle - 1),
                right = BuildInternal(nums, middle + 1, end)
            };
        }

        public void Execute()
        {
            int[] arr = {0, 1, 2, 3, 4, 5};
            TreeNode node = SortedArrayToBST(arr);
        }
    }
}