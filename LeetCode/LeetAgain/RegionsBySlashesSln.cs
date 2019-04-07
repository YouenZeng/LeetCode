using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class RegionsBySlashesSln : ISolution
    {
        public int RegionsBySlashes(string[] grid)
        {
            int[,] g = new int[grid.Length * 3, grid.Length * 3];
            int result = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid.Length; j++)
                {
                    if (grid[i][j] == '/')
                    {
                        g[i * 3, j * 3 + 2] = 1;
                        g[i * 3 + 1, j * 3 + 1] = 1;
                        g[i * 3 + 2, j * 3] = 1;
                    }

                    if (grid[i][j] == '\\')
                    {
                        g[i * 3, j * 3] = 1;
                        g[i * 3 + 1, j * 3 + 1] = 1;
                        g[i * 3 + 2, j * 3 + 2] = 1;
                    }
                }
            }


            for (int i = 0; i < g.GetLength(0); i++)
            {
                for (int j = 0; j < g.GetLength(0); j++)
                {
                    if (g[i, j] == 0)
                    {
                        Dfs(g, i, j);
                        ++result;
                    }
                }
            }

            return result;
        }

        void Dfs(int[,] grid, int x, int y)
        {
            if (x >= 0 && y >= 0 && x < grid.GetLength(0) && y < grid.GetLength(0) && grid[x, y] == 0)
            {
                grid[x, y] = 1;
                Dfs(grid, x - 1, y);
                Dfs(grid, x, y - 1);
                Dfs(grid, x + 1, y);
                Dfs(grid, x, y + 1);
            }
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }

    }
}
