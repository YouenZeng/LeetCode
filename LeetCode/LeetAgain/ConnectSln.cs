using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    public class Node2
    {
        public int val;
        public Node2 left;
        public Node2 right;
        public Node2 next;

        public Node2()
        {
        }

        public Node2(int _val)
        {
            val = _val;
        }

        public Node2(int _val, Node2 _left, Node2 _right, Node2 _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }

    public class ConnectSln : ISolution
    {
        /// <summary>
        /// 117. Populating Next Right Pointers in Each Node II
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public Node2 Connect2(Node2 root)
        {
            throw new NotImplementedException();
        }

        public Node2 Connect(Node2 root)
        {
            //BFS

            if (root == null)
                return null;

            Queue<Node2> q = new Queue<Node2>();
            q.Enqueue(root);
            int layerCount = 1;
            Node2 prevNode = null;
            while (q.Count > 0)
            {
                if (layerCount == 0)
                {
                    layerCount = q.Count;
                    prevNode = null;
                }

                var node = q.Dequeue();
                layerCount--;
                if (prevNode != null)
                    prevNode.next = node;

                prevNode = node;

                if (node.left != null)
                    q.Enqueue(node.left);

                if (node.right != null)
                    q.Enqueue(node.right);
            }

            return root;
        }


        public void Execute()
        {
            var n = new Node2(1)
            {
                //left = new Node2(2)
                //{
                //    left = new Node2(4),
                //    right = new Node2(5)
                //},
                //right = new Node2(3)
                //{
                //    left = new Node2(6),
                //    right = new Node2(7)
                //}
            };

            Connect(n);
        }
    }
}