using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Infra
{
    class NQueens : ISolution
    {
        private int count = 0;
        public void Execute()
        {
            int n = 8;
            int[] x = new int[n + 1];
            BackTrack(1, n, x);
            Console.WriteLine(count);
        }

        void BackTrack(int t, int n, int[] x)
        {
            if (t > n) count++;
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    x[t] = i;
                    if (PlaceTest(t, x)) BackTrack(t + 1, n, x);
                }
            }
        }

        bool PlaceTest(int k, int[] x)
        {
            for (int i = 1; i <= k - 1; i++)
            {
                if (x[i] == x[k] || Math.Abs(x[i] - x[k]) == Math.Abs(i - k)) return false;
            }
            return true;
        }
    }
}
