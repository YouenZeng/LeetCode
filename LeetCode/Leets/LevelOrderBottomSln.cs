using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Leets
{
    class LevelOrderBottomSln : ISolution
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (root == null) return result;

            int level = 0;
            Dfs(root, level, ref result);

            return result.Reverse().ToList();
        }

        public void Dfs(TreeNode root, int level, ref IList<IList<int>> result)
        {
            if (root == null) return;

            if (result.Count == level)
            {
                result.Add(new List<int>());
            }
            result[level].Add(root.val);

            Dfs(root.left, level+1, ref result);
            Dfs(root.right, level+1, ref result);
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

            LevelOrderBottom(root);
            Console.WriteLine("Hell!");
        }
    }
}
