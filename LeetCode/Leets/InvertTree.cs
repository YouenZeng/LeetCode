using System;

namespace LeetCode.Leets
{
    public class InvertTreeExe : ISolution
    {
        // Definition for a binary tree node.

        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;
            TreeNode node = root.left;
            root.left = root.right;
            root.right = node;
            InvertTree(root.left);
            InvertTree(root.right);
            return root;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}