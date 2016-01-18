using System;

namespace LeetCode.Leets
{
    public class TreeNodeLeet : ISolution
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;
            return IsBalanced(root.left) && IsBalanced(root.right) &&
                   Math.Abs(Height(root.left) - Height(root.right)) <= 1;
        }

        int Height(TreeNode root)
        {
            if (root == null) return 0;
            return Math.Max(Height(root.left), Height(root.right)) + 1;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }

        public  string GenerateSecurityProjectNo(string projectNo)
        {
            Random rd = new Random();
            string mask = rd.Next(1, 9999).ToString("D4");
            return projectNo + mask;
        }
    }


}
