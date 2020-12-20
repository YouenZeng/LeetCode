using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Leets;

namespace LeetCode.Challenge
{
    class IncreasingBSTSln : ISolution
    {
        public TreeNode IncreasingBST(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            TreeNode result = new TreeNode(-1);
            TreeNode r = result;
            Stack<TreeNode> stack = new Stack<TreeNode>();

            while (stack.Count > 0 || root != null)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }

                root = stack.Pop();
                result.right = new TreeNode(root.val);
                result = result.right;
                root = root.right;
            }

            return r.right;
        }

        public void Execute()
        {
            var node = TreeNode.FromArray(new int?[] { 5, 3, 6, 2, 4, null, 8, 1, null, null, null, 7, 9 });
            IncreasingBST(node);
        }
    }
}