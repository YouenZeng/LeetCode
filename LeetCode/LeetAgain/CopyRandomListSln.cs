using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace LeetCode.LeetAgain
{
    class CopyRandomListSln
    {
        public Node CopyRandomList(Node head)
        {
            //build node
            Dictionary<Node, Node> dict = new Dictionary<Node, Node>();

            while (head.next != null)
            {
                if (dict.ContainsKey(head))
                {
                    head = dict[head];
                }
                else
                {
                    var newHead = new Node(head.val, head.next, head.random);
                    dict.Add(head.next, newHead);
                    head = newHead;
                }

                if (head.random != null)
                {
                    if (dict.ContainsKey(head.random))
                    {
                        head.random = dict[head.random];
                    }
                    else
                    {
                        var newHead = new Node(head.random.val, head.random.next, head.random.random);
                        dict.Add(head.random, newHead);
                        head.random = newHead;
                    }
                }
                head = head.next;
            }

            //return new Node(fakeHead.next.val, fakeHead.next.next, fakeHead.next.random);

            //build random


        }
    }

    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node()
        {
        }

        public Node(int _val, Node _next, Node _random)
        {
            val = _val;
            next = _next;
            random = _random;
        }
    }
}
