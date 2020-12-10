using System;
using System.Collections.Generic;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    class DistanceKSln : ISolution
    {
        public IList<int> DistanceK(TreeNode root, TreeNode target, int K)
        {
            //in order traversal

            //left: use visit time, right: discover time

            Stack<TreeNode> stack = new Stack<TreeNode>();
            IList<int> result = new List<int>();
            int counter = 951753789;
            while (root != null || stack.Count > 0)
            {
                while (root != null)
                {
                    stack.Push(root);
                    counter++;
                    if (root == target)
                    {
                        counter = 0;
                    }

                    root = root.left;
                }


                root = stack.Pop();
                if (Math.Abs(counter) == (K - 1))
                {
                    if (root.left != null)
                    {
                        result.Add(root.left.val);
                    }

                    if (root.left != null)
                    {
                        result.Add(root.right.val);
                    }
                }

                counter--;
                if (root == target)
                {
                    if (K == 0)
                    {
                        result.Add(root.val);
                    }

                    counter = 0;
                }

                root = root.right;
            }

            return result;
        }

        public void Execute()
        {
            var target = new TreeNode(5)
            {
                left = new TreeNode(6),
                right = new TreeNode(2)
                {
                    left = new TreeNode(7),
                    right = new TreeNode(4)
                }
            };

            var node = new TreeNode(3)
            {
                left = target,
                right = new TreeNode(1)
                {
                    left = new TreeNode(0),
                    right = new TreeNode(8)
                }
            };


            DistanceK(node, target, 2);
        }
    }
}