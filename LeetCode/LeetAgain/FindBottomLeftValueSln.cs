using System;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    public class FindBottomLeftValueSln : ISolution
    {
        private int _currentDepth = 0;
        private int _maxDepth = int.MinValue;
        private int _min;
        public int FindBottomLeftValue(TreeNode root)
        {
            Dfs(root);

            return _min;
        }

        private void Dfs(TreeNode root)
        {
            if (root == null) return;

            if (root.left == null && root.right == null)
            {
                if (_currentDepth <= _maxDepth) return;

                _min = root.val;
                _maxDepth = _currentDepth;
                return;
            }

            _currentDepth++;
            Dfs(root.left);
            Dfs(root.right);
            _currentDepth--;
        }

        public void Execute()
        {
            TreeNode root = new TreeNode(2)
            {
                left = new TreeNode(1),
                right = new TreeNode(3)
            };

            Console.WriteLine(FindBottomLeftValue(root));
        }
    }
}