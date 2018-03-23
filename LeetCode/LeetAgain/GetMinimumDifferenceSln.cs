using LeetCode.Leets;
using System;

namespace LeetCode.LeetAgain
{
    class GetMinimumDifferenceSln : ISolution
    {
        int minDiff = int.MaxValue;
        TreeNode prev;
        public int GetMinimumDifference(TreeNode root)
        {
            inorder(root);
            return minDiff;
        }

        public void inorder(TreeNode root)
        {
            if (root == null) return;
            inorder(root.left);
            if (prev != null) minDiff = Math.Min(minDiff, root.val - prev.val);
            prev = root;
            inorder(root.right);
        }

        public void Execute()
        {
            TreeNode node = new TreeNode(1476)
            {
                left = new TreeNode(1054)
                {
                    left = new TreeNode(1)
                    {
                        right = new TreeNode(215)
                        {
                            right = new TreeNode(745)
                        }
                    }

                },

            };
            //TreeNode node = new TreeNode(1)
            //{
            //    right = new TreeNode(5)
            //    {
            //        left = new TreeNode(3)
            //        //right = new TreeNode(16)
            //    }
            //};
            Console.WriteLine(GetMinimumDifference(node));
        }
    }
}
