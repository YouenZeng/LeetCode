using System;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    class SwapPairsSln : ISolution
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null) return null;
            if (head.next == null) return head;
            ListNode fakeNode = new ListNode(111) {next = head};

            var result = head.next;

            while (fakeNode.next != null)
            {
                ListNode first = fakeNode.next;
                ListNode second = first.next;
                if (second == null)
                {
                    break;
                }

                ListNode third = second.next;
                second.next = first;
                first.next = third;
                fakeNode.next = second;
                fakeNode = first;
            }

            return result;
        }

        public void Execute()
        {
            var node = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    //next = new ListNode(3)
                    //{
                    //    next = new ListNode(4)
                    //    {
                    //        //  next = new ListNode(5)
                    //    }
                    //}
                }
            };

            SwapPairs(node);
        }
    }
}