using System;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    public class MaxPathSumSln : ISolution
    {
        private int maxValue = 0;

        public int MaxPathSum(TreeNode root)
        {
            maxValue = int.MinValue;
            MaxPathSum2(root);
            return maxValue;
        }

        public int MaxPathSum2(TreeNode root)
        {
            if (root == null)
                return 0;

            int left = Math.Max(MaxPathSum2(root.left), 0);
            int right = Math.Max(MaxPathSum2(root.right), 0);

            maxValue = Math.Max(root.val + left + right, maxValue);

            return Math.Max(left, right) + root.val;
        }

        public void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}