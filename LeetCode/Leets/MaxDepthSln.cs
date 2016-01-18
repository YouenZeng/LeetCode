using System;

namespace LeetCode.Leets
{
    class MaxDepthSln : ISolution
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return 1+ Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
