using System;
using System.Collections.Generic;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    public class ZigzagLevelOrderSln : ISolution
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            //BFS
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
                return result;
            Queue<TreeNode> visit = new Queue<TreeNode>();
            Queue<TreeNode> nextLayerNode = new Queue<TreeNode>();
            visit.Enqueue(root);
            bool shoudlReverse = false;
            List<int> r = new List<int>();
            while (visit.Count > 0 || nextLayerNode.Count > 0)
            {
                if (visit.Count == 0)
                {
                    visit = nextLayerNode;
                    nextLayerNode = new Queue<TreeNode>();
                   
                    if (shoudlReverse)
                        r.Reverse();
                    result.Add(r);
                    shoudlReverse = !shoudlReverse;
                    r = new List<int>();
                }

                var node = visit.Dequeue();
                r.Add(node.val);


                if (node.left != null)
                    nextLayerNode.Enqueue(node.left);
                if (node.right != null)
                    nextLayerNode.Enqueue(node.right);
            }

            if (r.Count > 0)
            {
                if (shoudlReverse)
                    r.Reverse();
                result.Add(r);
            }
            return result;
        }

        public void Execute()
        {
            TreeNode node = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
                {
                    left = new TreeNode(15),
                    right = new TreeNode(7)
                }
            };

            ZigzagLevelOrder(node);
        }
    }
}