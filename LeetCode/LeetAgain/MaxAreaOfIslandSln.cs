using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class MaxAreaOfIslandSln : ISolution
    {
        private int width;
        private int height;
        private int count;

        public int MaxAreaOfIsland(int[,] grid)
        {
            width = grid.GetLength(1);
            height = grid.GetLength(0);

            bool[,] visited = new bool[height, width];

            int result = 0;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (grid[i, j] == 1 && visited[i, j] == false)
                    {
                        count = 0;
                        Handle(grid, visited, i, j);
                        result = Math.Max(result, count);
                    }
                }
            }

            return result;
        }

        private void Handle(int[,] grid, bool[,] visited, int x, int y)
        {
            if (x < 0 || x >= height) return;
            if (y < 0 || y >= width) return;

            if (visited[x, y]) return;
            if (grid[x, y] == 0) return;
            count++;
            visited[x, y] = true;
            Handle(grid, visited, x - 1, y);
            Handle(grid, visited, x + 1, y);
            Handle(grid, visited, x, y - 1);
            Handle(grid, visited, x, y + 1);
        }

        public void Execute()
        {
            MaxAreaOfIsland(new int[,] { { 1, 1, 0, 0, 0 }, { 1, 1, 0, 0, 0 }, { 0, 0, 0, 1, 1 }, { 0, 0, 0, 1, 1 } });
        }
    }
}