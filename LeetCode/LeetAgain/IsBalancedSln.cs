using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    class IsBalancedSln : ISolution
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;
            if (Math.Abs(MaxHeight(root.left) - MaxHeight(root.right)) > 1)
            {
                return false;
            }

            return IsBalanced(root.left) && IsBalanced(root.right);
        }

        int MaxHeight(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return 1 + Math.Max(MaxHeight(root.left), MaxHeight(root.right));
        }

        public void Execute()
        {
            TreeNode node = new TreeNode(3)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(4)
                    {
                        left = new TreeNode(2),
                        right = new TreeNode(2)
                    },
                    right = new TreeNode(2)
                },
                right = new TreeNode(2)
                {
                    right = new TreeNode(31)
                    {
                        // right = new TreeNode(123)
                    }
                }
            };

            Console.WriteLine(IsBalanced(node));
        }
    }
}