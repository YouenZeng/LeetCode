using LeetCode.Leets;
using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    internal class MinDiffInBSTSln : ISolution
    {
        private int result = int.MaxValue;
        private int preNode = -1;
        public int MinDiffInBST(TreeNode root)
        {
            if (root.left != null) MinDiffInBST(root.left);
            if (preNode >= 0) result = Math.Min(result, root.val - preNode);

            preNode = root.val;

            if (root.right != null) MinDiffInBST(root.right);
            return result;
        }

        public int MinDiffBSTIterative(TreeNode root)
        {
            int res = int.MaxValue;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode pNode = null;

            while (stack.Count > 0 || root != null)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }

                TreeNode pop = stack.Pop();

                if (pNode != null)
                {
                    res = Math.Min(res, pop.val - pNode.val);
                }

                pNode = pop;
                root = pop.right;

            }
            return res;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
