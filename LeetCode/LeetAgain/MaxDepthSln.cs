using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    class MaxDepthSln : ISolution
    {
        private int _maxCount = 0;
        private int count = 0;

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }

        private void Dfs(TreeNode root)
        {
            if (root == null)
            {
                _maxCount = Math.Max(count, _maxCount);
                return;
            }

            count++;
            Dfs(root.left);
            Dfs(root.right);
            count--;
        }

        public void Execute()
        {
            TreeNode node = new TreeNode(3)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(4)
                },
                right = new TreeNode(2)
                {
                    left = new TreeNode(4)
                    {
                        right = new TreeNode(123)
                    }
                }
            };
            Console.WriteLine(MaxDepth(node));
        }
    }
}