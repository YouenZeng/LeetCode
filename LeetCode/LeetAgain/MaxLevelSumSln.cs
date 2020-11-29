using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    class MaxLevelSumSln : ISolution
    {
        public int MaxLevelSum(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            int maxSum = int.MinValue;
            int sum = 0;
            int layer = 1;
            int maxLayer = 1;
            int layerCount = 1;
            while (q.Count > 0)
            {
                var node = q.Dequeue();
                sum += node.val;
                layerCount--;

                if (node.left != null)
                    q.Enqueue(node.left);
                if (node.right != null)
                    q.Enqueue(node.right);

                if (layerCount == 0)
                {
                    layerCount = q.Count;
                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        maxLayer = layer;
                    }
                    layer++;
                    sum = 0;
                }

            }
            return maxLayer;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
