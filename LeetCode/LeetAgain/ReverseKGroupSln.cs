using System;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    class ReverseKGroupSln : ISolution
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            while (head.next != null)
            {
                int j = k;

                while (j >= 0)
                {
                    j--;
                }
            }

            throw new NotImplementedException();
        }

        public void Execute()
        {
            var node = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };
            ReverseKGroup(node, 3);
        }
    }
}