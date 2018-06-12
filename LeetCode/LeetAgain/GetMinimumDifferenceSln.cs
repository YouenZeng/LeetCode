using LeetCode.Leets;
using System;

namespace LeetCode.LeetAgain
{
    class GetMinimumDifferenceSln : ISolution
    {
        int minDiff = int.MaxValue;
        TreeNode prevNode;
        public int GetMinimumDifference(TreeNode root)
        {
            if (root == null) return minDiff;

            GetMinimumDifference(root.left);

            if (prevNode != null)
            {
                minDiff = Math.Min(minDiff, root.val - prevNode.val);
            }
            prevNode = root;
            GetMinimumDifference(root.right);

            return minDiff;
        }

        //private int FindMin(TreeNode root)
        //{
        //    if (root == null) return int.MaxValue;
        //    if (root.left == null && root.right == null) return root.val;
        //    return Math.Min(Math.Min(root.val, FindMin(root.left)), FindMin(root.right));
        //}

        //private int FindMax(TreeNode root)
        //{
        //    if (root == null) return int.MinValue;
        //    if (root.left == null && root.right == null) return root.val;
        //    return Math.Max(Math.Max(root.val, FindMax(root.left)), FindMax(root.right));
        //}

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
                            right = new TreeNode(216)
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
