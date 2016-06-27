using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leets
{
    class DeleteDuplicatesTwo : ISolution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode fakedHead = new ListNode(-1);
            fakedHead.next = head;

            ListNode prevHead = fakedHead;
            ListNode currentNode = fakedHead.next;

            while (currentNode != null)
            {
                while (currentNode.next != null && currentNode.val == currentNode.next.val)
                {
                    currentNode = currentNode.next;
                }
                if (prevHead.next == currentNode)
                {
                    prevHead = prevHead.next;
                }
                else
                {
                    prevHead.next = currentNode.next;
                }
                currentNode = currentNode.next;
            }
            return fakedHead.next;
        }
        public void Execute()
        {
            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(3);
//            ListNode node4 = new ListNode(2);
//            ListNode node5 = new ListNode(3);
//            ListNode node6 = new ListNode(4);
//            ListNode node7 = new ListNode(4);
            node1.next = node2;
            node2.next = node3;
            node3.next = null;
//            node2.next = node3;
//            node3.next = node4;
//            node4.next = node5;
//            node5.next = node6;
//            node6.next = node7;
//            node7.next = null;
            DeleteDuplicates(node1);

        }
    }
}
