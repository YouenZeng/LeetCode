using System;

namespace LeetCode.Leets
{
    class IsSymmetricSln : ISolution
    {
        public void Execute()
        {
            throw new NotImplementedException();
        }

        public bool IsSymmetric(TreeNode root)
        {
            return root == null || IsSymmetric(root.left, root.right);
        }

        public bool IsSymmetric(TreeNode root1, TreeNode root2)
        {

//            while (root1 != null && root2 != null)
//            {
//                
//            }

            if (root1 == null && root2 == null)
            {
                return true;
            }

            if (root1 != null && root2 != null)
            {
                if (root1.val == root2.val)
                {
                    return IsSymmetric(root1.left, root2.right) && IsSymmetric(root1.right, root2.left);
                }
            }
            return false;
        }
    }
}
