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
            List<IList<int>> result = new List<IList<int>>();

            List<int> r = new List<int>();
            if (root == null)
                return result;
            Queue<TreeNode> currentLayer = new Queue<TreeNode>();

            currentLayer.Enqueue(root);

            int layerCount = 1;
            while (currentLayer.Count > 0)
            {
                if (layerCount == 0)
                {
                    result.Add(r);
                    r = new List<int>();
                    layerCount = currentLayer.Count;
                }

                var node = currentLayer.Dequeue();
                layerCount--;

                r.Add(node.val);
                if (node.left != null)
                {
                    currentLayer.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    currentLayer.Enqueue(node.right);
                }
            }

            if (r.Count > 0)
                result.Add(r);
            result.Reverse();
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
            LevelOrderBottom(node);
        }
    }
}