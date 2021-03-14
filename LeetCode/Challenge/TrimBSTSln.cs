using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Leets;

namespace LeetCode.Challenge
{
    class TrimBSTSln : ISolution
    {
        public TreeNode TrimBST(TreeNode root, int low, int high)
        {
            if (root == null)
            {
                return null;
            }

            if (root.val < low)
            {
                root = TrimBST(root.right, low, high);
            }
            else if (root.val > high)
            {
                root = TrimBST(root.left, low, high);
            }
            else
            {
                root.left = TrimBST(root.left, low, high);
                root.right = TrimBST(root.right, low, high);
            }

            return root;
        }

        public void Execute()
        {
            var r =TrimBST(TreeNode.FromArray(new int?[] { 3, 0, 4, null, 2, null, null, 1 }), 1, 3);
        }
    }
}