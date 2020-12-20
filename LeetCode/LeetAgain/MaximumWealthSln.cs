using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class MaximumWealthSln : ISolution
    {
        public int MaximumWealth(int[][] accounts)
        {
            int max = 0;
            for (int i = 0; i < accounts.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < accounts[0].Length; j++)
                {
                    sum += accounts[i][j];
                }
                max = Math.Max(sum, max);
            }

            return max;
        }
        public void Execute()
        {
            var a = new int[2][];
            a[0] = new int[] { 1, 2, 3 };
            a[1] = new int[] { 3, 2, 1 };

            MaximumWealth(a);
        }
    }
}
