using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Leets;

namespace LeetCode.Challenge
{
    class SwapPairsSln : ISolution
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null) return head;
            ListNode t = head.next;
            if (t == null) return head;
            ListNode prevHead = new ListNode(123);
            prevHead.next = head;
            while (head != null && head.next != null)
            {
                var first = head;
                var second = head.next;

                head = second.next;
                second.next = first;
                first.next = head;
                prevHead.next = second;
                prevHead = first;

            }
            return t;

        }
        public void Execute()
        {
            var n = new ListNode(1) {  };
            SwapPairs(n);
        }
    }
}
