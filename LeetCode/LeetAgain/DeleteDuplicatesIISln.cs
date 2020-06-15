using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    public class DeleteDuplicatesIISln : ISolution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            var fakeHead = new ListNode(111) {next = head};

            if (fakeHead.next != null)
            {
            }
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
            ListNode head = BuildNode(new[] {1, 1});
            DeleteDuplicates(head);
        }
    }
}