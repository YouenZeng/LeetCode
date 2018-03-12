using LeetCode.Leets;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class AddTwoNumbersSln : ISolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0);
            ListNode currentRoot = result;
            int prev = 0;
            int current = 0;
            while (l1 != null || l2 != null || prev != 0)
            {
                if (l1 != null)
                {
                    prev += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    prev += l2.val;
                    l2 = l2.next;
                }

                current = prev % 10;
                prev = prev / 10;

                result.next = new ListNode(current);
                result = result.next;
            }

            return currentRoot.next;
        }
        public void Execute()
        {
            AddTwoNumbers(new ListNode(5)
            {
                //next = new ListNode(1)
                //{
                //    next = new ListNode(2)
                //    {
                //        next = new ListNode(3)
                //    }
                //}
            }, new ListNode(5)
            {
                //next = new ListNode(2)
                //{
                //    next = new ListNode(3)
                //}
            });
        }
    }
}
