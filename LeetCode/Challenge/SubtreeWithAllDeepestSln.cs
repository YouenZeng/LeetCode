using System;
using LeetCode.Leets;

namespace LeetCode.Challenge
{
    class SubtreeWithAllDeepestSln : ISolution
    {
        TreeNode result = new TreeNode(-1);
        int maxDepth = -1;

        public TreeNode SubtreeWithAllDeepest(TreeNode root)
        {
            result = new TreeNode(-1);
            maxDepth = -1;
            Dfs(root, 0);

            return result;
        }
        private int Dfs(TreeNode node, int depth)
        {
            if (node == null)
            {
                return depth;
            }

            int leftDepth = Dfs(node.left, depth + 1);
            int rightDepth = Dfs(node.right, depth + 1);

            if (leftDepth == rightDepth && leftDepth >= maxDepth)
            {
                //
                maxDepth = leftDepth;
                result = node;

            }
            else if (leftDepth > maxDepth)
            {
                //
                maxDepth = leftDepth;
                result = node.left;
            }
            else if (rightDepth > maxDepth)
            {
                //
                maxDepth = leftDepth;
                result = node.right;
            }


            return Math.Max(leftDepth, rightDepth);
        }

        public void Execute()
        {
            SubtreeWithAllDeepest(TreeNode.FromArray(new int?[] { 1 }));
            SubtreeWithAllDeepest(TreeNode.FromArray(new int?[] { 3, 5, 1, 6, 2, 0, 8, 699, 698, 7, 4, 111, 222, 333, 444,555 }));
            SubtreeWithAllDeepest(TreeNode.FromArray(new int?[] { 0, 1, 3, null, 2 }));
        }
    }
}
