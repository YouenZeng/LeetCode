using System;
using System.Collections.Generic;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    public class DeleteDuplicatesIISln : ISolution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            var fakeHead = new ListNode(111) {next = null};
            var tHead = fakeHead;
            /*
             *Input: 1->1->1->2->3
             *Output: 2->3
             *
             */
            HashSet<int> hs = new HashSet<int>();
            while (head != null)
            {
                if (hs.Add(head.val) && (head.next == null || head.next.val != head.val))
                {
                    fakeHead.next = head;
                    fakeHead = head;
                    hs.Clear();
                }
                else
                {
                    fakeHead.next = null;
                }

                head = head.next;
            }

            return tHead.next;
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
            ListNode head = BuildNode(new[] {1, 2, 3,3,4});
            DeleteDuplicates(head);
        }
    }
}