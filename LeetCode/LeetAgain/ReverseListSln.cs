using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    public class ReverseListSln : ISolution
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode newHeader = null;

            while (head != null)
            {
                ListNode next = head.next;
                head.next = newHeader;
                newHeader = head;
                head = next;
            }
            return newHeader;
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
            ListNode head = BuildNode(new[] { 3, 2, 1, 0, 1, 2, 3 });
            //ReverseList(head);

            ListNode head1 = new ListNode(123);
            ListNode head2 = head1;
            head1 = new ListNode(111);
        }
    }
}
