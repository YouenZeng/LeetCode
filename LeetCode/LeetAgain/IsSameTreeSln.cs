using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    class IsSameTreeSln : ISolution
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null) return false;
            if (q == null) return false;
            if (p.val == q.val) return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
            return false;
        }

        public void Execute()
        {
            TreeNode node1 = new TreeNode(1)
            {
                left = new TreeNode(2),
                right = new TreeNode(3)
            };
            TreeNode node2 = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(2)
                },
                right = new TreeNode(3)
            };

            Console.WriteLine(IsSameTree(node1, node2));
            ;
        }
    }
}