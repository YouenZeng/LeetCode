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

        TreeNode currentRoot;
        public BSTIterator(TreeNode root)
        {
            currentRoot = root;
        }

        /** @return whether we have a next smallest number */
        public bool HasNext()
        {
            return currentRoot.left != null;
        }

        /** @return the next smallest number */
        public int Next()
        {
            if (HasNext())
            {
                BSTIterator inner = new BSTIterator(currentRoot.left);
                return inner.Next();
            }
            return currentRoot.val;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
