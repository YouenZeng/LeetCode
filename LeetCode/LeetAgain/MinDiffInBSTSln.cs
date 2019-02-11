using LeetCode.Leets;
using System;

namespace LeetCode.LeetAgain
{
    internal class MinDiffInBSTSln : ISolution
    {
        private int result = int.MaxValue;
        private int preNode = -1;
        public int MinDiffInBST(TreeNode root)
        {
            if (root.left != null) MinDiffInBST(root.left);
            if (preNode >= 0) result = Math.Min(result, root.val - preNode);

            preNode = root.val;

            if (root.right != null) MinDiffInBST(root.right);
            return result;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
