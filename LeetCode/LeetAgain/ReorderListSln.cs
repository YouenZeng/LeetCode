using System.Collections.Generic;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    public class ReorderListSln : ISolution
    {
        public void ReorderList(ListNode head)
        {
            if (head == null)
                return;
            ListNode fast = head;
            ListNode slow = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            Stack<ListNode> stack = new Stack<ListNode>();
            var rightPart = slow.next;
            slow.next = null;
            
            while (rightPart != null)
            {
                stack.Push(rightPart);
                rightPart = rightPart.next;
            }

            ListNode h = head;
            while (stack.Count > 0)
            {
                var p = stack.Pop();
                var temp = h.next;
                p.next = temp;
                h.next = p;
                h = temp;
            }
        }

        public void Execute()
        {
            ListNode n01 = null;
            var n0 = new ListNode(1){ next = new ListNode(2) };
            var n1 = new ListNode(1){next = new ListNode(2){next = new ListNode(3){next = new ListNode(4){next = new ListNode(5)}}}};
            var n2 = new ListNode(1){next = new ListNode(2){next = new ListNode(3){next = new ListNode(4){}}}};

            ReorderList(n1);
            ReorderList(n0);
            ReorderList(n1);
            ReorderList(n2);
        }
    }
}