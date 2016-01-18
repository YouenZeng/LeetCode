using System;

namespace LeetCode.Leets
{
    class DeleteDuplicatesSln : ISolution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {


            if (head == null || head.next == null) return head;
            ListNode dummy = head;
            while (dummy.next != null)
            {
                if (dummy.next.val == dummy.val)
                {
                    dummy.next = dummy.next.next;
                }
                else dummy = dummy.next;
            }
            return head;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
