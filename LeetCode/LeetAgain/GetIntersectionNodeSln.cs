using System;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    public class GetIntersectionNodeSln : ISolution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode a = headA;
            ListNode b = headB;

            while (headA != null && headB != null)
            {
                headA = headA.next;
                headB = headB.next;
            }

            while (headA != null)
            {
                a = a.next;
                headA = headA.next;
            }

            while (headB != null)
            {
                b = b.next;
                headB = headB.next;
            }

            while (a != b)
            {
                a = a.next;
                b = b.next;
            }

            return a;
        }

        public void Execute()
        {
            var common = new ListNode(8)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(5)
                }
            };

            var a = new ListNode(4)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(1)
                    {
                        next = new ListNode(1)
                        {
                            next = common
                        }
                    }
                }
            };

            var b = new ListNode(5)
            {
                next = new ListNode(6)
                {
                    next = new ListNode(1)
                    {
                       next = common
                    }
                }
            };

            GetIntersectionNode(a, b);
        }
    }
}