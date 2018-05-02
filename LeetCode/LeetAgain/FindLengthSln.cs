using System;

namespace LeetCode.LeetAgain
{
    class FindLengthSln : ISolution
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
                        dp[i + 1, j + 1] = 1 + dp[i, j];
                        max = Math.Max(max, dp[i + 1, j + 1]);
                    }
                }
            }

            return max;
        }

        public int FindLength2(int[] A, int[] B)
        {
            int[,] dp = new int[A.Length + 1, B.Length + 1];
            int max = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    dp[i + 1, j + 1] = Math.Max(Math.Max(dp[i, j] + (A[i] == B[j] ? 1 : 0), dp[i, j + 1]),
                        dp[i + 1, j]);
                    max = Math.Max(max, dp[i + 1, j + 1]);
                }
            }

            return max;
        }

        public void Execute()
        {
            FindLength(new[] {1, 2, 3, 2, 1}, new[] {3, 2, 1, 4, 7});
            FindLength(new[] {0, 1, 1, 1, 1, 1}, new[] {1, 0, 0, 1, 0, 1, 0, 1});
        }
    }
}