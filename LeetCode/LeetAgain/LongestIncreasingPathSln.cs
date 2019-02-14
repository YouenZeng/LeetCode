using System;

namespace LeetCode.LeetAgain
{
    internal class LongestIncreasingPathSln : ISolution
    {
        public int LongestIncreasingPath(int[,] matrix)
        {
            int result = 0;
            int m = matrix.GetLength(0) - 1;
            int n = matrix.GetLength(1) - 1;
            int[,] cache = new int[m + 1, n + 1];
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    result = Math.Max(result, Dfs(matrix, i, j, m, n, cache));
                }
            }

            return result;
        }


        private int Dfs(int[,] matrix, int i, int j, int m, int n, int[,] cache)
        {

            if (cache[i, j] > 0)
            {
                return cache[i, j];
            }

            int maxValue = 1;
            if (i > 0 && matrix[i - 1, j] < matrix[i, j])
            {
                int d = Dfs(matrix, i - 1, j, m, n, cache);
                maxValue = Math.Max(maxValue, d + 1);
            }
            if (i + 1 <= m && matrix[i + 1, j] < matrix[i, j])
            {
                int d = Dfs(matrix, i + 1, j, m, n, cache);
                maxValue = Math.Max(maxValue, d + 1);
            }
            if (j > 0 && matrix[i, j - 1] < matrix[i, j])
            {
                int d = Dfs(matrix, i, j - 1, m, n, cache);
                maxValue = Math.Max(maxValue, d + 1);
            }
            if (j + 1 <= n && matrix[i, j + 1] < matrix[i, j])
            {
                int d = Dfs(matrix, i, j + 1, m, n, cache);
                maxValue = Math.Max(maxValue, d + 1);
            }

            cache[i, j] = maxValue;
            return maxValue;
        }

        public void Execute()
        {
            LongestIncreasingPath(new int[,] { { 9, 9, 4 }, { 6, 6, 8 }, { 2, 1, 1 } });
        }
    }
}
