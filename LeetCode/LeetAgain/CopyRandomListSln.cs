using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    internal class CopyRandomListSln
    {
        //https://leetcode.com/problems/copy-list-with-random-pointer/
        public Node CopyRandomList(Node head)
        {
            if (head == null) return null;
            Dictionary<Node, Node> dict = new Dictionary<Node, Node>();
            Node tempHead = head;
            while (tempHead != null)
            {
                Node newHead = new Node(tempHead.val, tempHead.next, tempHead.random);
                dict.Add(tempHead, newHead);
                tempHead = tempHead.next;
            }

            tempHead = head;
            while (tempHead != null)
            {
                if(tempHead.next!=null)
                    dict[tempHead].next = dict[tempHead.next];

                if(tempHead.random!=null)
                    dict[tempHead].random = dict[tempHead.random];

                tempHead = tempHead.next;
            }

            return dict[head];

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
