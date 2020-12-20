using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Leets;

namespace LeetCode.Lof
{
    class ReversePrintSln : ISolution
    {
        public int[] ReversePrint(ListNode head)
        {
            Stack<int> stack = new Stack<int>();
            while (head != null)
            {
                stack.Push(head.val);
                head = head.next;
            }

            return stack.ToArray();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
