using System;
using System.Collections.Generic;
using System.Linq;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    class FindSecondMinimumValueSln : ISolution
    {
        private int min = -1;
        public int FindSecondMinimumValue(TreeNode root)
        {
            if (root.left == null) return -1;
            min = root.val;
            int max = Math.Max(Dfs(root.left), Dfs(root.right));
            if (min == max) return -1;
            return max;
        }

        private int Dfs(TreeNode root)
        {
            if (root.left == null) return root.val;
            if (root.left.val < root.right.val)
            {
                return Dfs(root.left);
            }

            return Dfs(root.right);
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}

