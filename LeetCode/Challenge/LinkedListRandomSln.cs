using System;
using System.Collections.Generic;
using LeetCode.Leets;

namespace LeetCode.Challenge
{
    class Solution : ISolution
    {
        /** @param head The linked list's head.
    Note that the head is guaranteed to be not null, so it contains at least one node. */
        private readonly ListNode head;

        private Random rd;
        public Solution(ListNode head)
        {
            this.head = head;
            rd = new Random();
        }

        /** Returns a random node's value. */
        public int GetRandom()
        {
            int scope = 1;
            ListNode current = head;
            int result = 0;
            while (current != null)
            {
                if (rd.NextDouble() < 1.0 / scope)
                {
                    result = current.val;
                }

                current = current.next;
                scope++;
            }

            return result;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}