using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    public class NumIslandsSln : ISolution
    {
        public int NumIslands(char[][] grid)
        {
            int count = 0;
            int height = grid.GetLength(0);
            int width = grid[0].Length;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        count++;
                        //mark visisted, BFS
                        Queue<int> q = new Queue<int>();
                        grid[i][j] = '0';
                        q.Enqueue(i * width + j);

                        while (q.Count > 0)
                        {
                            var item = q.Dequeue();
                            int w = item / width;
                            int h = item % width;

                            if (w - 1 >= 0 && grid[w - 1][h] == '1')
                            {
                                grid[w - 1][h] = '0';
                                q.Enqueue((w - 1) * width + h);
                            }

                            if (w + 1 < height && grid[w + 1][h] == '1')
                            {
                                grid[w + 1][h] = '0';
                                q.Enqueue((w + 1) * width + h);
                            }

                            if (h + 1 < width && grid[w][h + 1] == '1')
                            {
                                grid[w][h + 1] = '0';
                                q.Enqueue(item + 1);
                            }

                            if (h - 1 >= 0 && grid[w][h - 1] == '1')
                            {
                                grid[w][h - 1] = '0';
                                q.Enqueue(item - 1);
                            }
                        }
                    }
                }
            }


            return count;
        }

        public void Execute()
        {
            var g = new char[4][];
            g[0] = new[] {'1', '1', '0', '1', '0'};
            g[1] = new[] {'1', '1', '0', '1', '0'};
            g[2] = new[] {'1', '1', '0', '0', '0'};
            g[3] = new[] {'0', '0', '0', '0', '1'};
//            var g = new char[3][];
//            g[0] = new[] {'1', '1', '1'};
//            g[1] = new[] {'0', '1', '0'};
//            g[2] = new[] {'1', '1', '1'};
            NumIslands(g);
        }
    }
}