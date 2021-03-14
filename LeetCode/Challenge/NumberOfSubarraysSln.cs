using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Challenge
{
    class NumberOfSubarraysSln : ISolution
    {
        public int NumberOfSubarrays(int[] nums, int k)
        {
            LinkedList<int> deq = new LinkedList<int>();
            deq.AddLast(-1);
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 1)
                {
                    deq.AddLast(i);
                }

                if (deq.Count > k + 1)
                {
                    deq.RemoveFirst();
                }

                if (deq.Count == k + 1)
                {
                    count += (deq.ElementAt(1) - deq.ElementAt(0));
                }
            }

            return count;
        }

        public void Execute()
        {
            int[] arr = new int[] {0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0};
            NumberOfSubarrays(arr, 2);
        }
    }
}