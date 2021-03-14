using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Challenge
{
    class CountPairsSln : ISolution
    {
        public int MinElements(int[] nums, int limit, int goal)
        {
            long sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }

            long gap = goal - sum;
            int l = limit;
            if (gap < 0)
            {
                l = limit * -1 + 1;
            }
            else
            {
                l = limit - 1;
            }
            long count = gap / (l) + (gap % (l) == 0 ? 0 : 1);
            return (int) count;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}