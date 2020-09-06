using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    internal class MinDepthSln : ISolution
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            if (root.left == null) return MinDepth(root.right) + 1;
            if (root.right == null) return MinDepth(root.left) + 1;
            return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
        }

        public int MinDepthBfs(TreeNode root)
        {
            if (root == null) return 0;
            int count = 1;
            Queue<TreeNode> visited = new Queue<TreeNode>();

            visited.Enqueue(root);
            int layerCount = 1;
            while (visited.Count > 0)
            {
                if (layerCount == 0)
                {
                    count++;
                    layerCount = visited.Count;
                }

                var node = visited.Dequeue();
                layerCount--;

                if (node.left == null && node.right == null)
                {
                    break;
                }

                if (node.left != null)
                {
                    visited.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    visited.Enqueue(node.right);
                }
            }


            return count;
        }

        public void Execute()
        {
            var node = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(12)
                {
                    left = new TreeNode(123)
                }
            };

            Console.WriteLine(MinDepthBfs(node));
        }
    }
}