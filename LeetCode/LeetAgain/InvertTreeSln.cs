using LeetCode.Leets;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class InvertTreeSln : ISolution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return root;

            TreeNode t = root.left;
            root.left = root.right;
            root.right = t;

            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
