using System;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    public class FlattenSln : ISolution
    {
        public void Flatten(TreeNode root)
        {
            IterateS(root);
        }


        TreeNode ReversePreOrder(TreeNode root, TreeNode prev)
        {
            if (root == null) return prev;
            prev = ReversePreOrder(root.right, prev);
            prev = ReversePreOrder(root.left, prev);
            root.right = prev;
            root.left = null;
            prev = root;
            return prev;
        }

        void IterateS(TreeNode root)
        {
            var current = root;

            while (current != null)
            {
                if (current.left != null)
                {
                    var prev = current.left;
                    while (prev.right != null)
                    {
                        prev = prev.right;
                    }

                    prev.right = current.right;

                    current.right = current.left;
                    current.left = null;
                }

                current = current.right;
            }
        }

        TreeNode PreOrder(TreeNode root)
        {
            if (root == null)
                return null;
            if (root.left == null && root.right == null)
                return root;

            var leftTail = PreOrder(root.left);
            var rightTail = PreOrder(root.right);

            if (rightTail == null)
            {
                root.right = root.left;
                root.left = null;
                return leftTail;
            }

            if (leftTail == null)
            {
                return rightTail;
            }

            leftTail.right = root.right;
            root.right = root.left;
            root.left = null;
            return rightTail;
        }

        public void Execute()
        {
            //TreeNode n = new TreeNode(1)
            //{
            //    left = new TreeNode(2)
            //    {
            //        left = new TreeNode(3),
            //        right = new TreeNode(4)
            //    },
            //    //right = new TreeNode(5)
            //    //{
            //    //    right = new TreeNode(6)
            //    //}
            //};
            TreeNode n = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(3)
                    {
                        left = new TreeNode(5)
                        {
                            right = new TreeNode(6)
                        }
                    },
                    right = new TreeNode(4)
                    {
                    }
                },
            };

            Flatten(n);
        }
    }
}