using LeetCode.Leets;
using System;

namespace LeetCode.LeetAgain
{
    internal class RotateRightSln : ISolution
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || head.next == null)
                return head;
            ListNode tail = new ListNode(1);
            tail = head;

            int total = 0;
            while (tail.next != null)
            {
                total++;
                tail = tail.next;
            }
            total++;

            int step = k >= total ? k % total : k;
            step = total - step;

            ListNode temp = new ListNode(0);
            temp = head;
            while (step > 1)
            {
                temp = temp.next;
                step--;
            }
            tail.next = head;
            var result = temp.next;
            temp.next = null;

            return result;

        }
        public void Execute()
        {
            var node = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };


        //     RotateRight(node, 2);

            var node2 = new ListNode(0)
            {
                next = new ListNode(1)
                {
                  
                }
            };

            RotateRight(node2, 2);
        }
    }
}
