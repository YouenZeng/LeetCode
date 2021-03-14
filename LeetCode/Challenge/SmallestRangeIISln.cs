using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class SmallestRangeIISln : ISolution
    {
        public int SmallestRangeII(int[] A, int K)
        {

            int N = A.Length;
            Array.Sort(A);
            int ans = A[N - 1] - A[0];

            for (int i = 0; i < A.Length - 1; ++i)
            {
                int a = A[i], b = A[i + 1];
                int high = Math.Max(A[N - 1] - K, a + K);
                int low = Math.Min(A[0] + K, b - K);
                ans = Math.Min(ans, high - low);
            }
            Console.WriteLine(ans);
            return ans;
        }
        public void Execute()
        {
            SmallestRangeII(new int[] { 0, 3, 4, 7 }, 5);
            SmallestRangeII(new int[] { 1 }, 0);
            SmallestRangeII(new int[] { 0, 10 }, 2);
            SmallestRangeII(new int[] { 1, 3, 6 }, 3);
            SmallestRangeII(new int[] { 3, 1, 10 }, 4);
        }
    }
}
