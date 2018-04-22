using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    class BinaryTreePathsSln : ISolution
    {
        private const string Combine = "->";
        private readonly IList<string> _result = new List<string>();
        private readonly Stack<int> _stack = new Stack<int>();

        public IList<string> BinaryTreePaths(TreeNode root)
        {
            DfsInternal(root);
            return _result;
        }

        private void DfsInternal(TreeNode root)
        {
            if (root == null) return;
            if (root.left == null && root.right == null)
            {
                _stack.Push(root.val);
                _result.Add(string.Join(Combine, _stack.Reverse()));
                _stack.Pop();
                return;
            }

            _stack.Push(root.val);

            DfsInternal(root.left);
            DfsInternal(root.right);

            _stack.Pop();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}