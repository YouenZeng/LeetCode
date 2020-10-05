using LeetCode.Leets;
using System;
using System.Threading;

namespace LeetCode.LeetAgain
{
    class SortListSln : ISolution
    {
        public ListNode SortList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            ListNode fast = head;
            ListNode slow = head;
            ListNode slowPrevious = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slowPrevious = slow;
                slow = slow.next;
            }

            if (fast == slow)
                return fast;
            slowPrevious.next = null;
            var left = SortList(head);
            var right = SortList(slow);

            return Merge(left, right);
        }

        private ListNode Merge(ListNode left, ListNode right)
        {
            var rr = new ListNode(123);

            var r = new ListNode(123);
            rr.next = r;
            while (left != null || right != null)
            {
                if (left == null)
                {
                    r.next = right;
                    return rr.next.next;
                }

                if (right == null)
                {
                    r.next = left;
                    return rr.next.next;
                }

                if (left.val < right.val)
                {
                    r.next = left;
                    left = left.next;
                }
                else
                {
                    r.next = right;
                    right = right.next;
                }

                r = r.next;
            }

            return rr.next.next;
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
                                 next = new ListNode(3)
                            }
                        }
                    }
                }
            };

            var a = SortList(node);
        }
    }
}