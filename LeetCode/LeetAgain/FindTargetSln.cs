using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    class FindTargetSln : ISolution
    {
        private bool found;
        public bool FindTarget(TreeNode root, int k)
        {
            HashSet<int> target = new HashSet<int>();
            PreOrder(root, k, target);
            return found;
        }

        void PreOrder(TreeNode root, int k, HashSet<int> target)
        {
            if (root == null)
            {
                return;
            }
            if (root.left != null) PreOrder(root.left, k, target);

            
            if (!target.Add(k - root.val))
            {
                found = true;
                return;
            }
            target.Add(root.val);

            PreOrder(root.right, k, target);
        }

        public void Execute()
        {
            TreeNode node = new TreeNode(5)
            {
                left = new TreeNode(3)
                {
                    left = new TreeNode(2),
                    right = new TreeNode(4)
                },
                right = new TreeNode(6)
                {
                    right = new TreeNode(7)
                }
            };

            FindTarget(node, 9);
            FindTarget(node, 93);
        }
    }
}