using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class UniquePathsWithObstaclesSln : ISolution
    {
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            if (obstacleGrid[0][0] == 1)
                obstacleGrid[0][0] = 0;
            obstacleGrid[0][0] = -1;
            var r = UniquePathsV2(obstacleGrid.GetLength(0) - 1, obstacleGrid[0].Length - 1, obstacleGrid) * -1;
            return r;
        }

        private int UniquePathsV2(int m, int n, int[][] arr)
        {
            if (m < 0 || n < 0)
                return 0;
            if (arr[m][n] == 1)
                return 0;
            if (arr[m][n] < 0)
                return arr[m][n];

            arr[m][n] = UniquePathsV2(m - 1, n, arr) + UniquePathsV2(m, n - 1, arr);
            return arr[m][n];
        }


        public void Execute()
        {
            UniquePathsWithObstacles(new[]
            {
              new int[]{1}
            });
        }
    }
}
