using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Leets;

namespace LeetCode.Challenge
{
    class BSTIterator : ISolution
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode head;
        public BSTIterator(TreeNode root)
        {
            head = root;
            TryDfs();
        }

        private void TryDfs()
        {
            while (head != null)
            {
                stack.Push(head);
                head = head.left;
            }
        }

        public int Next()
        {
            TreeNode node = stack.Pop();
            head = node.right;
            TryDfs();
            return node.val;
        }

        public bool HasNext()
        {
            return stack.Count > 0;
        }
        public void Execute()
        {
            var treeNode = TreeNode.FromArray(new int?[] { 7, 3, 15, null, null, 9, 20 });
            Console.WriteLine(Next());
            Console.WriteLine(Next());
            Console.WriteLine(HasNext());
            Console.WriteLine(Next());
            Console.WriteLine(HasNext());
            Console.WriteLine(Next());
            Console.WriteLine(HasNext());
            Console.WriteLine(Next());
        }
    }
}
