using System;
using System.Collections.Generic;
using System.Net;

namespace LeetCode.LeetAgain.NodeNew
{
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node()
        {
        }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
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
        /// 116
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public Node Connect(Node root)
        {
            if (root == null)
                return null;
            //BFS

            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            int layerCount = 1;
            while (q.Count > 0)
            {
                if (layerCount == 0)
                {
                    layerCount = q.Count;
                }

                var n = q.Dequeue();
                layerCount--;

                if (layerCount > 0)
                {
                    n.next = q.Peek();
                }

                if (n.left != null)
                    q.Enqueue(n.left);
                if (n.right != null)
                    q.Enqueue(n.right);
            }


            return root;
        }

        /// <summary>
        /// 116
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public Node Connect2(Node root)
        {
            var start = root;
            while (start != null)
            {
                var current = start;
                while (current != null)
                {
                    if (current.left != null)
                        current.left.next = current.right;
                    if (current.right != null && current.next != null)
                        current.right.next = current.next.left;

                    current = current.next;
                }

                start = start.left;
            }

            return root;
        }

        /// <summary>
        /// 117
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public Node Connect3(Node root)
        {
            if (root == null)
                return null;

            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            int layerCount = 1;
            Node prevNode = null;
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

        /// <summary>
        /// 117
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public Node Connect4(Node root)
        {
            Node head = root;//The left most node in the lower level
            Node prev = null;//The previous node in the lower level
            Node curr = null;//The current node in the upper level
            while (head != null)
            {
                curr = head;
                prev = null;
                head = null;
                while (curr != null)
                {
                    if (curr.left != null)
                    {
                        if (prev != null)
                            prev.next = curr.left;
                        else
                            head = curr.left;
                        prev = curr.left;
                    }
                    if (curr.right != null)
                    {
                        if (prev != null)
                            prev.next = curr.right;
                        else
                            head = curr.right;
                        prev = curr.right;
                    }
                    curr = curr.next;
                }
            }
            return root;
        }


        public void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}