using System;
using LeetCode.Leets;

namespace LeetCode.Challenge
{
    class InsertionSortListSln : ISolution
    {
        public ListNode InsertionSortList(ListNode head)
        {
            ListNode fakeHead = new ListNode(1) { next = head };

            //head as fast pointer
            ListNode prevHead = head;
            while (head != null)
            {
                //insertion sort head
                if (head.val < prevHead.val)
                {
                    prevHead.next = head.next;
                    //loop from head
                    var newHead = fakeHead.next;
                    var innerPrevHead = fakeHead;
                    while (newHead != head)
                    {
                        if (newHead.val > head.val)
                        {
                            innerPrevHead.next = head;
                            head.next = newHead;
                            break;
                        }

                        innerPrevHead = newHead;
                        newHead = newHead.next;
                    }

                    head = prevHead;
                }
                else
                {
                    prevHead = head;
                }

                head = head.next;
            }

            return fakeHead.next;
        }

        public void Execute()
        {
            InsertionSortList(new ListNode(2)
            {
                //next = new ListNode(24)
                //{
                //    next = new ListNode(40)
                //    {
                //        next = new ListNode(40)
                //        {
                //            next = new ListNode(4)
                //            {
                //                next = new ListNode(140)
                //            }
                //        }
                //    }
                //}
            });
        }
    }
}