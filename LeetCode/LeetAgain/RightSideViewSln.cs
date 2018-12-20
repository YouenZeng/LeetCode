using LeetCode.Leets;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class RightSideViewSln : ISolution
    {
        public IList<int> RightSideView(TreeNode root)
        {
            IList<int> result = new List<int>();

            Queue<TreeNode> layerQ = new Queue<TreeNode>();
            if (root != null)
            {
                layerQ.Enqueue(root);
                layerQ.Enqueue(null); // a null indicator
            }

            TreeNode prevNode = null;

            while (layerQ.Count > 0)
            {
                var node = layerQ.Dequeue();

                if (node == null)
                {
                    if (prevNode == null) break;
                    result.Add(prevNode.val);
                    layerQ.Enqueue(null);
                    prevNode = null;
                }
                else
                {
                    prevNode = node;
                    if (node.left != null)
                    {
                        layerQ.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        layerQ.Enqueue(node.right);
                    }
                }
            }

            return result;
        }

        public void Execute()
        {
            var node = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    right = new TreeNode(5)
                },
                right = new TreeNode(3)
                {
                    right = new TreeNode(4)
                    {
                        right = new TreeNode(123)
                    }
                }
            };
            RightSideView(node);

        }
    }
}
