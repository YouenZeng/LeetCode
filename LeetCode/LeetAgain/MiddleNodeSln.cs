using LeetCode.Leets;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    internal class MiddleNodeSln : ISolution
    {
        public ListNode MiddleNode(ListNode head)
        {
            if (head.next == null) return head;

            var fast = head;
            var slow = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }
        public void Execute()
        {
            MiddleNode(new ListNode(1)
            {
                next = new ListNode(2)
                {
                    //next = new ListNode(3)
                    //{
                    //    next = new ListNode(4)
                    //}
                }
            });
        }
    }
}
