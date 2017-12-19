using LeetCode.Leets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetAgain
{
    class HasCycleSln : ISolution
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null) return false;
            ListNode slowNode = head;
            ListNode fastNode = head;

            while (fastNode.next != null && fastNode.next.next != null)
            {
                slowNode = slowNode.next;
                fastNode = fastNode.next.next;
                if (slowNode == fastNode) return true;
            }
            return false;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
