using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LeetCode.LeetAgain
{
    class MinPathSumSln : ISolution
    {

        /*
         * Given a m x n grid filled with non-negative numbers,
         * find a path from top left to bottom right which minimizes the sum of all numbers along its path.
         */

        public int MinPathSum(int[][] grid)
        {
            int height = grid.GetLength(0);
            int weight = grid[0].Length;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < weight; j++)
                {
                    if (i == 0 && j == 0) continue;
                    ;
                    int left = int.MaxValue;
                    if (i > 0)
                    {
                        left = grid[i - 1][j] + grid[i][j];
                    }

                    int right = int.MaxValue;
                    if (j > 0)
                    {
                        right = grid[i][j - 1] + grid[i][j];
                    }

                    grid[i][j] = Math.Min(left, right);
                }
            }

            return grid[height - 1][weight - 1];
        }
        public void Execute()
        {
            /*
             *  [1,3,1],
  [1,5,1],
  [4,2,1]
             */

            MinPathSum(new int[3][]
            {
                new int[3] {1, 3, 1},
                new int[3] {1,5,1},
                new int[3] {4,2,1},
            });
        }
    }
}
