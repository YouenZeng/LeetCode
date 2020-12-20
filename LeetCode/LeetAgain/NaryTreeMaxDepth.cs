using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class NaryTreeMaxDepth : ISolution
    {
        public int MaxDepth(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            int layer = 0;
            int layerCount = 1;
            while (q.Count > 0)
            {
                var node = q.Dequeue();
                layerCount--;
                foreach (var item in node.children)
                {
                    q.Enqueue(item);
                }
                if (layerCount == 0)
                {
                    layerCount = q.Count;
                    layer++;
                }

            }
            return layer;
        }

        private int max = 0;
        public int MaxDepth2(Node root)
        {
            if (root == null || root.children.Count == 0)
            {
                return 0;
            }
            foreach (var item in root.children)
            {
                var r = 1 + MaxDepth2(item);
                max = Math.Max(r, max);
            }
            return max;
        }
        public void Execute()
        {
        }
    }

    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}
