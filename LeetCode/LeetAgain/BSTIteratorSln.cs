using LeetCode.Leets;
using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    /// <summary>
    /// https://leetcode.com/problems/binary-search-tree-iterator/description/
    /// 
    /// </summary>
    public class BSTIterator : ISolution
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();

        public BSTIterator(TreeNode root)
        {
            TraverseNode(root);
        }

        /** @return the next smallest number */
        public int Next()
        {
            var n = stack.Pop();
            TraverseNode(n.right);
            return n.val;
        }

        /** @return whether we have a next smallest number */
        public bool HasNext()
        {
            return stack.Count > 0;
        }

        private void TraverseNode(TreeNode node)
        {
            while (node != null)
            {
                stack.Push(node);
                node = node.left;
            }
        }


        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}