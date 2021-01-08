using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Leets;

namespace LeetCode.Challenge
{
    class DeleteDuplicatesSln : ISolution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode fk = new ListNode(123);
            fk.next = head;

            ListNode prevHead = fk;
            while (head != null)
            {
                if (head.next != null && head.val == head.next.val)
                {
                    while (head.next != null && head.val == head.next.val)
                    {
                        head = head.next;
                    }
                    prevHead.next = head.next;
                }
                else
                {
                    prevHead = prevHead.next;
                }

                head = head.next;
            }
            return fk.next;

        }
        public void Execute()
        {
            DeleteDuplicates(new ListNode(1)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(3)
                        {
                            next = new ListNode(4)
                            {
                                next = new ListNode(4)
                                {
                                    next = new ListNode(5)
                                    {

                                    }
                                }
                            }
                        }
                    }
                }
            }
                );
        }
    }
}
