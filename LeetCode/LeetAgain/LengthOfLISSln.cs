using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LeetAgain
{

    class LengthOfLISSln : ISolution
    {

        public int LengthOfLIS(int[] nums)
        {
            int[] tails = new int[nums.Length];
            int size = 0;
            foreach (int x in nums)
            {
                int i = 0, j = size;
                while (i != j)
                {
                    int m = (i + j) / 2;
                    if (tails[m] < x)
                        i = m + 1;
                    else
                        j = m;
                }
                tails[i] = x;
                if (i == size) ++size;
            }
            return size;
        }

        public void Execute()
        {
            LengthOfLIS(new int[] { 10 });
            LengthOfLIS(new int[] { 10, 9, 2, 5, 3, 7, 101, 18 });
        }
    }
}
