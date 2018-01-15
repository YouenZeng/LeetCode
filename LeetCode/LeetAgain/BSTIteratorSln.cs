using LeetCode.Leets;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    /// <summary>
    /// https://leetcode.com/problems/binary-search-tree-iterator/description/
    /// 
    /// </summary>
    public class BSTIterator : ISolution
    {
        Stack<TreeNode> treeStack = new Stack<TreeNode>();

        public BSTIterator(TreeNode root)
        {
            FullfillStack(root);
        }

        /** @return whether we have a next smallest number */
        public bool HasNext()
        {
            return treeStack.Count > 0;
        }

        /** @return the next smallest number */
        public int Next()
        {
            TreeNode popNode = treeStack.Pop();
            FullfillStack(popNode.right);
            return popNode.val;
        }

        private void FullfillStack(TreeNode treeNode)
        {
            while (treeNode != null)
            {
                treeStack.Push(treeNode);
                treeNode = treeNode.left;
            }
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
