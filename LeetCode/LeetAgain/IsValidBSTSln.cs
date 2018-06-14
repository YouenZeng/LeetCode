using LeetCode.Leets;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class IsValidBSTSln : ISolution
    {
        public bool IsValidBST(TreeNode root)
        {
            if (root == null) return true;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode currentNode = root;
            int? prevValue = null;
            while (stack.Count > 0 || currentNode != null)
            {
                while (currentNode != null)
                {
                    stack.Push(currentNode);
                    currentNode = currentNode.left;
                }
                currentNode = stack.Pop();
                if (prevValue.HasValue && currentNode.val <= prevValue.Value)
                {
                    return false;
                }
                prevValue = currentNode.val;
                currentNode = currentNode.right;
            }
            return true;
        }

        public void Execute()
        {
            TreeNode node = new TreeNode(2)
            {
                left = new TreeNode(1),
                right = new TreeNode(3)
            };

            IsValidBST(node);
        }
    }
}
