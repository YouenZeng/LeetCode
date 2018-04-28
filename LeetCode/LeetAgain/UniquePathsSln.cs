using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class UniquePathsSln : ISolution
    {
        public int UniquePaths(int m, int n)
        {
            int[,] arr = new int[n, m];
            arr[0, 0] = 1;
            return UniquePathsV2(n - 1, m - 1, arr);
        }

        private int UniquePathsV2(int m, int n, int[,] arr)
        {
            if (m < 0 || n < 0)
                return 0;
            if (arr[m, n] != 0)
                return arr[m, n];

            arr[m, n] = UniquePathsV2(m - 1, n, arr) + UniquePathsV2(m, n - 1, arr);
            return arr[m, n];
        }

        public void Execute()
        {
            UniquePaths(7, 3);
        }
    }
}