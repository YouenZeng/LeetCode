using LeetCode.Leets;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class LinkedListRandomNodeSln : ISolution
    {
        private int count = 0;
        ListNode currentHead = null;
        ListNode headInternal = null;
        Random rd ;
        /** @param head The linked list's head.
            Note that the head is guaranteed to be not null, so it contains at least one node. */
        public LinkedListRandomNodeSln(ListNode head)
        {
            currentHead = head;
            while (currentHead.next != null)
            {
                count++;
                currentHead = currentHead.next;
            }
            rd = new Random();
            headInternal = head;
            currentHead = head;
        }

        /** Returns a random node's value. */
        public int GetRandom()
        {
            currentHead = headInternal;
            int rdNumber = rd.Next(count);

            while (rdNumber != 0)
            {
                currentHead = currentHead.next;
                rdNumber--;
            }

            return currentHead.val;
        }
        public void Execute()
        {
          
        }
    }
}
