using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class MinPathSumSln : ISolution
    {
        public int MinPathSum(int[,] grid)
        {
            int width = grid.GetLength(0);
            int height = grid.GetLength(1);

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (i == 0 && j == 0) continue;

                    grid[i, j] = Math.Min(
                     j == 0 ? int.MaxValue : (grid[i, j - 1] + grid[i, j]),
                     i == 0 ? int.MaxValue : (grid[i - 1, j] + grid[i, j])
                    );
                }
            }

            return grid[width - 1, height - 1];
        }
        public void Execute()
        {
            MinPathSum(new int[,] { { 1, 2 }, { 1, 1 } });
            MinPathSum(new int[,] { { 1, 3, 1},
                 {1, 5, 1},
                 {4, 2, 1} });
        }
    }
}
