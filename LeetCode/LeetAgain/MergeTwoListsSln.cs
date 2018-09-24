using LeetCode.Leets;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class MergeTwoListsSln : ISolution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            var result = new ListNode(-1);
            var resultTemp = result;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    result.next = l1;
                    result = l1;
                    l1 = l1.next;
                }
                else
                {
                    result.next = l2;
                    result = l2;
                    l2 = l2.next;
                }
            }
            if (l1 != null) result.next = l1;

            if (l2 != null) result.next = l2;


            return resultTemp.next;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
