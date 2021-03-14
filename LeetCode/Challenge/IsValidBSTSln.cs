using LeetCode.Leets;

namespace LeetCode.Challenge
{
    class IsValidBSTSln : ISolution
    {
        private long prev = (long)int.MinValue - 1;
        private bool result = true;
        public bool IsValidBST(TreeNode root)
        {
            if (result == false || root == null)
            {
                return true;
            }
            else
            {
                IsValidBST(root.left);
                if (root.val <= prev)
                {
                    result = false;
                }

                prev = root.val;
                IsValidBST(root.right);
            }

            return result;
        }



        public void Execute()
        {
            var bb = IsValidBST(TreeNode.FromArray(new int?[] { 5, 1, 4, null, null, 3, 6 }));
        }
    }
}
