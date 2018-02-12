using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    public class TrimBstSln : ISolution
    {
        public TreeNode TrimBST(TreeNode root, int L, int R)
        {
            if (root == null) return root;

            if (root.val < L)
                return TrimBST(root.right, L, R);
            if (root.val > R)
                return TrimBST(root.left, L, R);

            root.left = TrimBST(root.left, L, R);
            root.right = TrimBST(root.right, L, R);
            return root;
        }
        void ISolution.Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}