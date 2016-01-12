using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    class HasPathSumSln : ISolution
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null) return false;

            return (Dfs(root, sum));
        }

        public bool Dfs(TreeNode root, int sum)
        {
            if (root == null) return false;
            if (root.left == null && root.right == null)
            {
                return root.val == sum;
            }
            return Dfs(root.left, sum - root.val) || Dfs(root.right, sum - root.val);
        }

        public void Execute()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2)
            {
                left = new TreeNode(4),
                right = new TreeNode(5)
            };

            root.right = new TreeNode(3)
            {

            };

            bool result = HasPathSum(root, 18);
            Console.WriteLine(result);
        }
    }
}
