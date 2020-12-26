using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Leets;

namespace LeetCode.Challenge
{
    class IsBalancedSln : ISolution
    {
        public bool IsBalanced(TreeNode root)
        {
            return Height(root) >= 0;
        }

        public int Height(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftHeight = Height(root.left);
            int rightHeight = Height(root.right);
            if (leftHeight == -1 || rightHeight == -1 || Math.Abs(leftHeight - rightHeight) > 1)
            {
                return -1;
            }
            else
            {
                return Math.Max(leftHeight, rightHeight) + 1;
            }
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
