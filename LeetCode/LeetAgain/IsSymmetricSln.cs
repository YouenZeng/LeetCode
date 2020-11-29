using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    class IsSymmetricSln : ISolution
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;
            return IsSymmetricInternal(root.left, root.right);
        }

        private bool IsSymmetricInternal(TreeNode left, TreeNode right)
        {
            if (left == null || right == null) return left == right;
            if (left.val != right.val) return false;
            return IsSymmetricInternal(left.left, right.right) && IsSymmetricInternal(right.left, left.right);
        }

        public bool IsSymmetric2(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            int layer = 0;
            int layerCount = 1;

            while (q.Count > 0)
            {
                var node = q.Dequeue();
                layerCount--;
                if (node == null)
                {
                    q.Enqueue(null);
                    q.Enqueue(null);
                }
                else
                {
                    q.Enqueue(node.left);
                    q.Enqueue(node.right);
                }
                if (layerCount == 0)
                {
                    int currentLayerNum = (int)Math.Pow(2, layer + 1);
                    while (q.Count < currentLayerNum)
                    {
                        q.Enqueue(null);
                    }

                    //check layer data
                    var arr = q.ToArray();
                    int start = 0; int end = arr.Length - 1;
                    int nullCount = 0;
                    while (start < end)
                    {
                        if (arr[start] == null && arr[end] == null)
                        {
                            nullCount++;
                            start++; end--;
                            continue;
                        }
                        if (arr[start] == null || arr[end] == null)
                        {
                            return false;
                        }
                        if (arr[start].val != arr[end].val)
                        {
                            return false;
                        }
                        start++; end--;
                    }

                    layerCount = q.Count;
                    layer++;
                    if (nullCount == arr.Length / 2)
                    {
                        return true;
                    }
                }

            }
            return true;
        }

        public void Execute()
        {
            TreeNode node = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(3),
                    right = new TreeNode(4)
                },
                right = new TreeNode(2)
                {
                    left = new TreeNode(4),
                    right = new TreeNode(3)
                }
            };
            IsSymmetric2(node);
        }
    }
}