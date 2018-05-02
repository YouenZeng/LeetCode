using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    class LevelOrderSln : ISolution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            TreeNode fakedRoot = new TreeNode(123) {left = root};

            IList<IList<int>> result = new List<IList<int>>();
            Queue<TreeNode> nodes = new Queue<TreeNode>();
            TreeNode layerFirstNode = fakedRoot;
            List<int> layerResult = new List<int>();
            bool newLayerReached = false;

            nodes.Enqueue(fakedRoot);

            while (nodes.Count > 0)
            {
                var node = nodes.Dequeue();

                if (node == layerFirstNode)
                {
                    result.Add(layerResult.ToArray().ToList());
                    layerResult.Clear();
                    newLayerReached = true;
                }

                layerResult.Add(node.val);

                if (node.left != null)
                {
                    if (newLayerReached)
                    {
                        layerFirstNode = node.left;
                        newLayerReached = false;
                    }

                    nodes.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    if (newLayerReached)
                    {
                        layerFirstNode = node.right;
                        newLayerReached = false;
                    }

                    nodes.Enqueue(node.right);
                }
            }

            if (layerResult.Count > 0)
                result.Add(layerResult.ToArray().ToList());

            result.RemoveAt(0);
            result.RemoveAt(0);

            return result;
        }

        public void Execute()
        {
            TreeNode node = new TreeNode(3)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(4)
                    {
                        left = new TreeNode(2),
                        right = new TreeNode(2)
                    },
                    right = new TreeNode(2)
                },
                right = new TreeNode(2)
                {
                    right = new TreeNode(31)
                    {
                        right = new TreeNode(123)
                    }
                }
            };
            LevelOrder(node);
        }
    }
}