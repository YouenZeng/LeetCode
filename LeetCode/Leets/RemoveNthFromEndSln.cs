using System;

namespace LeetCode.Leets
{
    class RemoveNthFromEndSln : ISolution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode head1 = head;
            ListNode head2 = head;

            while (n-- > 0)
            {
                head2 = head2.next;
            }
            if (head2 == null)
            {
                return head.next;
            }

            while (head2.next != null)
            {
                head1 = head1.next;
                head2 = head2.next;
            }

            head1.next = head1.next.next;
            return head;

//            ListNode start = new ListNode(0);
//            ListNode slow = start, fast = start;
//            slow.next = head;
//
//            //Move fast in front so that the gap between slow and fast becomes n
//            for (int i = 1; i <= n + 1; i++)
//            {
//                fast = fast.next;
//            }
//            //Move fast to the end, maintaining the gap
//            while (fast != null)
//            {
//                slow = slow.next;
//                fast = fast.next;
//            }
//            //Skip the desired node
//            slow.next = slow.next.next;
//            return start.next;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
