using System.Collections.Generic;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    class LargestValuesSln : ISolution
    {
        private readonly Queue<TreeNode> _nodeQuqeue = new Queue<TreeNode>();
        private readonly List<int> _result = new List<int>();

        public IList<int> LargestValues(TreeNode root)
        {
            if (root == null) return _result;

            _nodeQuqeue.Enqueue(root);

            TreeNode layerBoundary = root;
            int nextLayer = 0;
            bool nextLayerRequired = false;
            _result.Add(int.MinValue);
            while (_nodeQuqeue.Count > 0)
            {
                var poped = _nodeQuqeue.Dequeue();
                if (poped == layerBoundary)
                {
                    nextLayer++;
                    nextLayerRequired = true;
                }

                if (poped.val > _result[nextLayer - 1])
                {
                    _result[nextLayer - 1] = poped.val;
                }

                if (poped.left != null)
                {
                    _nodeQuqeue.Enqueue(poped.left);
                    if (nextLayerRequired)
                    {
                        nextLayerRequired = false;
                        layerBoundary = poped.left;
                        _result.Add(int.MinValue);
                    }
                }

                if (poped.right != null)
                {
                    _nodeQuqeue.Enqueue(poped.right);
                    if (nextLayerRequired)
                    {
                        nextLayerRequired = false;
                        layerBoundary = poped.right;
                        _result.Add(int.MinValue);
                    }
                }
            }

            return _result;
        }

        public void Execute()
        {
            TreeNode node2 = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(2)
                },
                right = new TreeNode(3)
            };

            LargestValues(node2);
        }
    }
}