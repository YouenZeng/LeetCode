using LeetCode.Leets;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    //https://leetcode.com/articles/binary-tree-inorder-traversal/
    class InorderTraversalSln : ISolution
    {
        List<int> result = new List<int>();
        public IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null) return result;
            if (root.left == null && root.right == null)
            {
                result.Add(root.val);
                return result;
            };
            InorderTraversal(root.left);
            result.Add(root.val);
            InorderTraversal(root.right);
            return result;
        }

        public IList<int> InorderTraversalBetter(TreeNode root)
        {
            List<int> resultList = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode currentNode = root;

            while (stack.Count > 0 || currentNode != null)
            {
                while (currentNode != null)
                {
                    stack.Push(currentNode);
                    currentNode = currentNode.left;
                }
                currentNode = stack.Pop();
                resultList.Add(currentNode.val);
                currentNode = currentNode.right;

            }
            return resultList;
        }


        public IList<int> InorderTraversalInterative(TreeNode root)
        {
            if (root == null) return result;
            if (root.left == null && root.right == null)
            {
                result.Add(root.val);
                return result;
            };

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            TreeNode currentNode = root;
            TreeNode prevNode = null;
            while (stack.Count > 0)
            {
                if (currentNode.left != null && prevNode != currentNode)
                {
                    stack.Push(currentNode.left);
                    currentNode = currentNode.left;
                    continue;
                }

                currentNode = stack.Pop();
                prevNode = currentNode;
                result.Add(currentNode.val);

                if (currentNode.right != null)
                {
                    stack.Push(currentNode.right);
                    currentNode = currentNode.right;
                }

            }

            return result;
        }

        public void Execute()
        {
            TreeNode node = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(3)
                    {
                        right = new TreeNode(4)
                        {
                            right = new TreeNode(5)
                        }
                    }

                },

            };

            InorderTraversalBetter(node);
        }
    }
}
