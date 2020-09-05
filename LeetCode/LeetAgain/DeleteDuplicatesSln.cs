using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    public class DeleteDuplicatesSln : ISolution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head?.next == null) return head;

            ListNode fakeHead = head;

            while (head.next != null)
            {
                if (head.val == head.next.val)
                    head.next = head.next.next;
                else
                    head = head.next;
            }
            return fakeHead;
        }
        ListNode BuildNode(int[] arr)
        {
            ListNode header = new ListNode(arr[0]);
            ListNode tempheader = header;
            for (int i = 1; i < arr.Length; i++)
            {
                ListNode tmp = new ListNode(arr[i]);
                tempheader.next = tmp;
                tempheader = tmp;
            }
            return header;
        }

        void ISolution.Execute()
        {
            ListNode head = BuildNode(new[] { 1, 1 });
            DeleteDuplicates(head);
        }
    }
}
