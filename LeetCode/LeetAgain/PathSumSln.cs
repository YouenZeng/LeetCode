using System;
using System.Collections.Generic;
using System.Linq;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    public class PathSumSln : ISolution
    {
        private IList<IList<int>> result = new List<IList<int>>();

        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            List<int> l = new List<int>();

            Dfs(root, sum, l);
            return result;
        }

        private void Dfs(TreeNode root, int sum, List<int> l)
        {
            if (root == null)
                return;
            if (root.left == null && root.right == null)
            {
                if (root.val == sum)
                {
                    var l2 = new List<int>(l) {root.val};
                    result.Add(l2);
                    return;
                }
            }

            l.Add(root.val);
            Dfs(root.left, sum - root.val, l);
            Dfs(root.right, sum - root.val, l);
            l.RemoveAt(l.Count - 1);
        }

        public void Execute()
        {
            var node = new TreeNode(5)
            {
                left = new TreeNode(4)
                {
                    left = new TreeNode(11)
                    {
                        left = new TreeNode(7),
                        right = new TreeNode(2)
                    }
                },
                right = new TreeNode(8)
                {
                    left = new TreeNode(13),
                    right = new TreeNode(4)
                    {
                        left = new TreeNode(5),
                        right = new TreeNode(1)
                    }
                }
            };

            var aa = PathSum(node, 22);
        }
    }
}