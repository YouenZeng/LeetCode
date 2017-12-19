using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    class LevelOrderBottomSln : ISolution
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (root == null) return result;

            Queue<TreeNode> Q = new Queue<TreeNode>();

            TreeNode fakeNode = new TreeNode(0);
            Q.Enqueue(root);
            Q.Enqueue(fakeNode);

            IList<int> lst = new List<int>() { root.val };

            Stack<IList<int>> resultStack = new Stack<IList<int>>();
            resultStack.Push(lst);

            lst = new List<int>();

            while (Q.Count > 1)
            {
                TreeNode u = Q.Dequeue();
                if (u.left != null)
                {
                    Q.Enqueue(u.left);
                    lst.Add(u.left.val);
                }

                if (u.right != null)
                {
                    Q.Enqueue(u.right);
                    lst.Add(u.right.val);
                }

                if (Q.Peek() == fakeNode && Q.Count > 1)
                {
                    resultStack.Push(lst);
                    lst = new List<int>();
                    Q.Dequeue();
                    Q.Enqueue(fakeNode);
                }
            }

            while (resultStack.Count > 0)
            {
                result.Add(resultStack.Pop());
            }

            return result;

        }

        private TreeNode BuildTree()
        {
            TreeNode top = new TreeNode(1);
            top.left = new TreeNode(2);
            top.right = new TreeNode(3);

            top.left.left = new TreeNode(4);
            top.left.right = new TreeNode(5);
            top.left.left.left = new TreeNode(45);


            top.right.left = new TreeNode(6);
            top.right.right = new TreeNode(7);


            top.right.left.left = new TreeNode(8);
            top.right.left.right = new TreeNode(9);

            top.right.right.left = new TreeNode(10);
            top.right.right.right = new TreeNode(11);
            return top;
        }

        public void Execute()
        {
            TreeNode top = BuildTree();

            LevelOrderBottom(top);
        }
    }
}
