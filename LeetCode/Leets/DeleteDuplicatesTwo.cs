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
            ListNode prevDiff = fakedHead.next;

            while (prevDiff != null)
            {
                if (prevDiff.next != null && prevDiff.val == prevDiff.next.val)
                {
                    int currV = prevDiff.val;
                    while (prevDiff.next != null)
                    {
                        prevDiff = prevDiff.next;
                        if (prevDiff.next == null || prevDiff.next.val != currV)
                        {
                            break;
                        }
                    }
                }

                if (prevHead.next == prevDiff)
                {
                    prevHead = prevHead.next;
                }
                else
                {
                    prevHead.next = prevDiff.next;
                }
                prevDiff = prevDiff.next;


                //                else
                //                {
                //                    prevHead.next = prevDiff;
                //                    prevHead = prevHead.next;
                //                    
                //                    prevDiff = prevDiff.next;
                //                }
            }
            return fakedHead.next;
        }
        public void Execute()
        {
            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(1);
            ListNode node3 = new ListNode(1);
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
