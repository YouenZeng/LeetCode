using System;

namespace LeetCode.LeetAgain
{
    class FindLengthV2Sln : ISolution
    {
        public int FindLength(int[] A, int[] B)
        {
            int[,] dp = new int[A.Length + 1, B.Length + 1];
            int max = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[j])
                    {
                        dp[i + 1, j + 1] = dp[i, j] + 1;
                        max = Math.Max(max, dp[i + 1, j + 1]);
                    }
                }
            }

            return max;
        }
        public void Execute()
        {
            FindLength(new int[] { 1, 2, 3, 22, 1 }, new int[] { 3, 2, 1, 4, 7 });
        }
    }
}
