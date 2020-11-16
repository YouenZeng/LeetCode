using LeetCode.Leets;

namespace LeetCode.Challenge
{
    class GetDecimalValueSln : ISolution
    {
        public int GetDecimalValue(ListNode head)
        {
            int result = 0;
            while (head != null)
            {
                result = (result << 1) + head.val;
                head = head.next;
            }

            return result;
        }
        public void Execute()
        {
            GetDecimalValue(new ListNode(0)
            {
                next = new ListNode(0)
                {
                    next = new ListNode(1)
                }
            });
        }
    }
}
