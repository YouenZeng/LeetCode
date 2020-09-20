using System;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    public class PartitionSln : ISolution
    {
        public ListNode Partition(ListNode head, int x)
        {
            if (head == null)
            {
                return null;
            }
            /*
             * Input: head = 1->4->3->2->5->2, x = 3
             * Output: 1->2->2->4->3->5
             */

            var smallPointerHead = new ListNode(123);
            var smallPointer = smallPointerHead;

            var largePointerHead = new ListNode(123);
            var largerPointer = largePointerHead;

            while (head != null)
            {
                if (head.val < x)
                {
                    smallPointer.next = head;
                    smallPointer = head;
                }
                else
                {
                    largerPointer.next = head;
                    largerPointer = head;
                }

                head = head.next;
            }

            smallPointer.next = largePointerHead.next;
            largerPointer.next = null;

            return smallPointerHead.next;
        }

        public void Execute()
        {
            ListNode n = new ListNode(1)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(2)
                        {
                            next = new ListNode(5)
                            {
                                next = new ListNode(2)
                                {
                                    next = new ListNode(3)
                                    {
                                    }
                                }
                            }
                        }
                    }
                }
            };

            Partition(n, 3);
        }
    }
}