using System;
using System.Collections.Generic;

namespace LeetCode.Leets
{
    class LevelOrderSln:ISolution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (root == null) return result;

            Dfs(root, 0, ref result);
            return result;
        }

        public void Dfs(TreeNode root, int level, ref IList<IList<int>> result)
        {
            if (root == null) return;
            
            if (result.Count == level) result.Add(new List<int>());

            result[level].Add(root.val);

            Dfs(root.left, level + 1, ref result);
            Dfs(root.right, level + 1, ref result);
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
