using LeetCode.Leets;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class RemoveNthFromEndSln : ISolution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int fast = 0;
            int slow = n * -1;
            var fakeNode = new ListNode(-1);
            fakeNode.next = head;
            var slowNode = fakeNode;
            var fastNode = fakeNode;
            while (fastNode.next != null)
            {
                fastNode = fastNode.next;
                if (slow >= 0)
                {
                    slowNode = slowNode.next;
                }

                fast++;
                slow++;
            }

            slowNode.next = slowNode.next.next;

            return fakeNode.next;
        }
        public void Execute()
        {
            ListNode head = new ListNode(1)
            {
                next = new ListNode(2)
            };

            RemoveNthFromEnd(head, 2);
        }
    }
}
