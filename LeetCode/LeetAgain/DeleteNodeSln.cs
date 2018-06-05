using LeetCode.Leets;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class DeleteNodeSln : ISolution
    {
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
