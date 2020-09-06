using System;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    public class SortedListToBSTSln : ISolution
    {
        public TreeNode SortedListToBST(ListNode head)
        {
            if (head == null)
                return null;

            if(head.next == null)
                return new TreeNode(head.val);

            var slow = head;
            var fast = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                if (fast != null && fast.next != null)
                {
                    slow = slow.next;
                }
            }

            var node = new TreeNode(slow.next.val);

            var next = slow.next.next;
            slow.next = null;
            node.left = SortedListToBST(head);
            node.right = SortedListToBST(next);

            return node;
        }

        public void Execute()
        {
            ListNode n = new ListNode(-10)
            {
                next = new ListNode(-3)
                {
                    //next = new ListNode(0)
                    //{
                    //    next = new ListNode(5)
                    //    {
                    //        next = new ListNode(9)
                    //        {
                    //            next =  new ListNode(11)
                    //        }
                    //    }
                    //}
                }
            };
            var a = SortedListToBST(n);
        }
    }
}