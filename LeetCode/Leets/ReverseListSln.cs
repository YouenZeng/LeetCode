namespace LeetCode.Leets
{


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class ReverseListSln : ISolution
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode newHead = null;
            while (head != null)
            {
                ListNode next = head.next;
                head.next = newHead;
                newHead = head;
                head = next;
            }
            return newHead;
        }

        public ListNode ReverseListRecursive(ListNode head)
        {
            return ReverseListInit(head, null);
        }

        public ListNode ReverseListInit(ListNode head, ListNode newHead)
        {
            if (head == null)
            {
                return newHead;
            }
            ListNode next = head.next;
            head.next = newHead;
            return ReverseListInit(next, head);

        }

        public void Execute()
        {
            var listNode = new ListNode(1);
            listNode.next = new ListNode(2).next = new ListNode(3).next = new ListNode(4);
            ReverseList(listNode);
        }
    }
}
