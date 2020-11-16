using LeetCode.Leets;

namespace LeetCode.Challenge
{
    class RangeSumBSTSln : ISolution
    {
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.val < low)
            {
                return RangeSumBST(root.right, low, high);
            }

            if (root.val > high)
            {
                return RangeSumBST(root.left, low, high);
            }

            return root.val + RangeSumBST(root.left, low, high) + RangeSumBST(root.right, low, high);
        }

        public void Execute()
        {
            var node = TreeNode.FromArray(new int?[] { 10, 5, 15, 3, 7, 13, 18, 1, null, 6 });
            var r = RangeSumBST(node, 6, 10);
        }
    }
}