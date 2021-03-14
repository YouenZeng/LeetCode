using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class ShortestPathBinaryMatrixSln : ISolution
    {
        public int ShortestPathBinaryMatrix(int[][] grid)
        {
            int height = grid[0].Length;

            bool[][] visited = new bool[height][];
            for (int i = 0; i < height; i++)
            {
                visited[i] = new bool[height];
            }

            Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
            q.Enqueue(new Tuple<int, int>(0, 0));
            visited[0][0] = true;
            int[] dir = new int[] {1, -1, -1, 1, 1, 0, -1, 0, 1};
            int result = 0;
            while (q.Count > 0)
            {
                int size = q.Count;
                for (int i = 0; i < size; i++)
                {
                    var item = q.Dequeue();
                    if (item.Item1 == height - 1 && item.Item2 == height - 1)
                    {
                        return 1 + result;
                    }


                    for (int j = 0; j < 8; j++)
                    {
                        int x = item.Item1 + dir[j];
                        int y = item.Item2 + dir[j + 1];

                        if (x < 0 || y < 0 || x >= height || y >= height || visited[x][y] || grid[x][y] == 1)
                        {
                            continue;
                        }

                        q.Enqueue(new Tuple<int, int>(x, y));
                        visited[x][y] = true;
                    }
                }

                result++;
            }

            return -1;
        }

        public int findIntegers(int num)
        {
            int[] f = new int[32];
            f[0] = 1;
            f[1] = 2;
            int i;
            for (i = 2; i < f.Length; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }

            i = 30;
            int sum = 0, prevBit = 0;
            while (i >= 0)
            {
                if ((num & (1 << i)) != 0)
                {
                    sum += f[i];
                    if (prevBit == 1)
                    {
                        sum--;
                        break;
                    }

                    prevBit = 1;
                }
                else
                {
                    prevBit = 0;
                }

                i--;
            }

            return sum + 1;
        }

        public int ArrangeCoins(int n)
        {
            long i = 1;
            while (i * i < n)
            {
                if ((i * (i + 1)) / 2 < n)
                {
                    i++;
                }
            }

            return (int) i;
        }

        public void Execute()
        {
            int[][] grid = new int[3][];
            grid[0] = new int[] {0, 0, 0};
            grid[1] = new int[] {1, 1, 0};
            grid[2] = new int[] {1, 1, 0};

            ShortestPathBinaryMatrix(grid);
        }
    }
}