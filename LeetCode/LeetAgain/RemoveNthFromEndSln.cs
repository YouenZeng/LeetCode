using LeetCode.Leets;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class RemoveNthFromEndSln : ISolution
    {
        /// <summary>
        /// 思路为让慢节点晚n步启动, 这样当快节点到达终点时, 正好差n步慢节点到达终点, 这样即为倒数第n个节点
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int fast = 0;
            int slow = n * -1;
            var fakeNode = new ListNode(-1);
            fakeNode.next = head;
            var slowNode = fakeNode;
            var fastNode = fakeNode;
            while (fastNode.next != null)
            {
                fastNode = fastNode.next;
                if (slow >= 0)
                {
                    slowNode = slowNode.next;
                }

                fast++;
                slow++;
            }

            slowNode.next = slowNode.next.next;

            return fakeNode.next;
        }
        public void Execute()
        {
            ListNode head = new ListNode(1)
            {
                next = new ListNode(2)
            };

            RemoveNthFromEnd(head, 2);
        }
    }
}
