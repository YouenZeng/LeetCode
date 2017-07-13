using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    public class ReverseBetweenSln : ISolution
    {
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            ListNode fakedHeader = new ListNode(123);
            fakedHeader.next = head;

            int currentIndex = 0;
            ListNode currentHeader = fakedHeader;
            ListNode prevHeader = fakedHeader;

            while (currentIndex <= n)
            {
                if (currentIndex == m)
                {
                    ListNode tmpEnd = currentHeader;

                    ListNode newHeader = null;
                    while (currentIndex <= n)
                    {
                        currentIndex++;
                        tmpEnd = tmpEnd.next;

                        ListNode next = currentHeader.next;
                        currentHeader.next = newHeader;
                        newHeader = currentHeader;
                        currentHeader = next;
                    }

                    prevHeader.next = newHeader;
                    while (prevHeader.next != null)
                    {
                        prevHeader = prevHeader.next;
                    }
                    prevHeader.next = currentHeader;
                }
                else
                {
                    prevHeader = currentHeader;
                    currentHeader = currentHeader.next;
                }
                currentIndex++;
            }
            return fakedHeader.next;
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
            ListNode head = BuildNode(new[] { 1, 2});
            ReverseBetween(head, 1,2);
        }
    }
}
