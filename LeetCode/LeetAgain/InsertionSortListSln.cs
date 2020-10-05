using System;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    public class InsertionSortListSln : ISolution
    {
        public ListNode InsertionSortList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            ListNode previous = head;
            var current = head.next;

            while (current != null)
            {
                var next = current.next;
                var currentVal = current.val;
                if (currentVal > previous.val)
                {
                    previous = current;
                    current = next;
                    continue;
                }

                if (currentVal <= head.val)
                {
                    previous.next = next;
                    current.next = head;
                    head = current;
                    current = next;
                    continue;
                }


                var tempHead = head;
                while (tempHead != null && tempHead.next != null && tempHead.next.val < currentVal)
                {
                    tempHead = tempHead.next;
                }

                var tempNext = tempHead.next;
                tempHead.next = current;
                current.next = tempNext;

                previous.next = next;
                current = next;
            }

            return head;
        }

        public void Execute()
        {
            var node = new ListNode(4)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(1)
                    {
                        next = new ListNode(3)
                        {
                            next = new ListNode(1)
                            {
                                //  next = new ListNode(3)
                            }
                        }
                    }
                }
            };

            InsertionSortList(node);
        }
    }
}