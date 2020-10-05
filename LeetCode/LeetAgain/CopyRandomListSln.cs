using System.Collections.Generic;

namespace LeetCode.LeetAgain.CopyRandomList
{
    internal class CopyRandomListSln
    {
        Dictionary<Node, Node> dict = new Dictionary<Node, Node>();

        //https://leetcode.com/problems/copy-list-with-random-pointer/
        public Node CopyRandomList(Node head)
        {
            if (head == null)
                return null;
            var newHead = new Node(head.val, null, null);
            dict[head] = newHead;

            if (head.next != null && dict.ContainsKey(head.next))
            {
                newHead.next = dict[head.next];
            }
            else
            {
                newHead.next = CopyRandomList(head.next);
            }

            if (head.random != null && dict.ContainsKey(head.random))
            {
                newHead.random = dict[head.random];
            }
            else
            {
                newHead.random = CopyRandomList(head.random);
            }

            return newHead;
        }


        public Node CopyRandomListII(Node head)
        {

            //TODO: NOT COMPLETED
            if (head == null)
                return null;

            //1. Copy next
            //2. Copy random
            //3. Seperate ..

            var dh = head;
            while (dh != null)
            {
                var tempHead = new Node(dh.val, dh.next, dh.random);
                dh.next = tempHead;
                dh = tempHead.next;
            }

            var result = head;
            while (result != null)
            {
                var copyNode = result.next;
               
                result.next = copyNode.next;

                result = result.next;
                copyNode.next = result == null ? null : result.next;
                copyNode.random = copyNode.random == null ? null : copyNode.random.next;
            }


            return head.next;
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