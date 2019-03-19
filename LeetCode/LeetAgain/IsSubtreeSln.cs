using LeetCode.Leets;
using System;

namespace LeetCode.LeetAgain
{
    class IsSubtreeSln : ISolution
    {
        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            //dfs t
            return Dfs(s, t);
        }

        private bool Dfs(TreeNode s, TreeNode t)
        {
            if (s == null)
                return false;

            if (IsTreeSame(s, t))
                return true;

            return Dfs(s.left, t) || Dfs(s.right, t);
        }

        private bool IsTreeSame(TreeNode a, TreeNode b)
        {
            if (a == null && b == null)
            {
                return true;
            }
            if (a == null || b == null)
            {
                return false;
            }

            return (a.val == b.val && IsTreeSame(a.left, b.left) && IsTreeSame(a.right, b.right));
        }

        public void Execute()
        {
            TreeNode n1 = new TreeNode(3)
            {
                left =  new TreeNode(4)
                {
                    left = new TreeNode(1),
                    right =  new TreeNode(2)
                },
                right =  new TreeNode(5)
            };

            TreeNode n2 = new TreeNode(4)
            {
                left = new TreeNode(1),
                right = new TreeNode(2)
            };
            Console.WriteLine(IsSubtree(n1, n2));
        }
    }
}
