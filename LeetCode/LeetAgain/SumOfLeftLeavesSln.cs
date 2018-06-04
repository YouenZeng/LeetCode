using LeetCode.Leets;
using System;

namespace LeetCode.LeetAgain
{
    class SumOfLeftLeavesSln : ISolution
    {
        //TODO: challenge using BFS
        //TODO: challenge without external variable
        private int sumResult = 0;
        TreeNode currentParent;
        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null) return 0;
            if (root.left == null && root.right == null)
            {
                if (currentParent == null) return 0;

                if (currentParent.left == root)
                {
                    sumResult += root.val;
                }
                else
                {
                    return 0;
                }
            }

            currentParent = root;
            SumOfLeftLeaves(root.left);
            currentParent = root;
            SumOfLeftLeaves(root.right);

            return sumResult;
        }
        public void Execute()
        {
            var result = SumOfLeftLeaves(new TreeNode(3)
            {
                left = new TreeNode(9)
                {
                    left = new TreeNode(312)
                },
                right = new TreeNode(20)
                {
                    left = new TreeNode(15),
                    right = new TreeNode(7)
                    {
                        left = new TreeNode(123)
                    }
                }
            });
            Console.WriteLine(result);
        }
    }
}
