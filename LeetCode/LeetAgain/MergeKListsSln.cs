using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Leets;

namespace LeetCode.LeetAgain
{
    class MergeKListsSln : ISolution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0) return null;
            return Sort(lists, 0, lists.Length - 1);
        }

        private ListNode Sort(ListNode[] lists, int lo, int hi)
        {
            if (lo >= hi) return lists[lo];
            int mid = lo + (hi - lo) / 2;
            ListNode l1 = Sort(lists, lo, mid);
            ListNode l2 = Sort(lists, mid + 1, hi);
            return Merge(l1, l2);
        }

        private ListNode Merge(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            if (l1.val < l2.val)
            {
                l1.next = Merge(l1.next, l2);
                return l1;
            }

            l2.next = Merge(l1, l2.next);
            return l2;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}