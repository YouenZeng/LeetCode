using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class NaryLevelOrderSln : ISolution
    {
        public IList<IList<int>> LevelOrder(Node root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
            {
                return result;
            }
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            int layerCount = 1;
            List<int> layerList = new List<int>();
            while (q.Count > 0)
            {
                var node = q.Dequeue();
                layerCount--;
                layerList.Add(node.val);
                foreach (var item in node.children)
                {
                    q.Enqueue(item);
                }
                if (layerCount == 0)
                {
                    result.Add(layerList);
                    layerList = new List<int>();
                    layerCount = q.Count;
                }

            }
            return result;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }


}
