using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    class IsSymmetricSln : ISolution
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;
            return IsSymmetricInternal(root.left, root.right);
        }

        private bool IsSymmetricInternal(TreeNode left, TreeNode right)
        {
            if (left == null || right == null) return left==right;
            if (left.val != right.val) return false;
            return IsSymmetricInternal(left.left, right.right) && IsSymmetricInternal(right.left, left.right);
        }

        public void Execute()
        {
            //TreeNode node = new TreeNode(1)
            //{
            //    left =  new TreeNode(2),
            //    right = new TreeNode(2)
            //    {
            //        left = new TreeNode(3),

            //    }
            //};
        }
    }
}