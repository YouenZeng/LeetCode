using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LeetAgain
{
    class MaxSlidingWindowSln : ISolution
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            var q = new LinkedList<int>();
            int n = nums.Length;
            var ans = new int[n - k + 1];

            for (var i = 0; i < n; i++)
            {
                if (q.Count > 0 && q.First.Value <= i - k)
                    q.RemoveFirst();

                while (q.Count > 0 && nums[i] >= nums[q.Last.Value])
                    q.RemoveLast();

                q.AddLast(i);
                if (i - k + 1 >= 0)
                    ans[i - k + 1] = nums[q.First.Value];
            }

            return ans;
        }


        public void Execute()
        {
            //3325
            //5233
            MaxSlidingWindow(new int[] { 6, 4, 5, 4, 6, 5 }, 4);
            MaxSlidingWindow(new int[] { 9, 10, 9, -7, -4, -8, 2, -6 }, 5);

            MaxSlidingWindow(new int[] { 9, 11 }, 2);
        }
    }
}
