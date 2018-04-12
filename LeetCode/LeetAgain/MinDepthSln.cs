using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    internal class MinDepthSln : ISolution
    {
        private int _minCount = int.MaxValue;
        private int _count;

        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            return Dfs(root);
        }

        private int Dfs(TreeNode root)
        {
            if (root == null) return int.MaxValue;
            if (root.left == null && root.right == null) return 1;
            return 1 + Math.Min(Dfs(root.left), Dfs(root.right));
        }


        public void Execute()
        {
            var node = new TreeNode(3)
            {
                
            };

            Console.WriteLine(MinDepth(node));
        }
    }
}