using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LeetCode.Challenge
{
    class NumIslandsSln : ISolution
    {
        private int[] parent;

        public int NumIslands(char[][] grid)
        {
            int h = grid.Length;
            int w = grid[0].Length;
            parent = new int[w * h];
            Array.Fill(parent,-1);

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        parent[i * w + j] = i * w + j;

                        if (i > 0 && grid[i - 1][j] == '1')
                        {
                            Union(i * w + j, (i - 1) * w + j);
                        }

                        if (j > 0 && grid[i][j - 1] == '1')
                        {
                            Union(i * w + j, i * w + j - 1);
                        }
                    }
                }
            }

            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < parent.Length; i++)
            {
                if (parent[i] != -1)
                {
                    hs.Add(Find(i));
                }
            }


            return hs.Count;
        }


        public void Union(int x, int y)
        {
            int x1 = Find(x);
            int y1 = Find(y);

            parent[x1] = y1;
        }

        public int Find(int node)
        {
            if (parent[node] == node)
            {
                return node;
            }

            parent[node] = Find(parent[node]);
            return parent[node];
        }

        public void Execute()
        {
            UnionFind uf = new UnionFind();
            uf.Init(new[]
            {
                new[] {1, 2},
                new[] {1, 0},
                new[] {2, 2},
            });
        }
    }

    class UnionFind
    {
        private readonly int[] parent = new int[10];

        public void Union(int x, int y)
        {
            int x1 = Find(x);
            int y1 = Find(y);

            parent[x1] = y1;
        }

        public int Find(int node)
        {
            if (parent[node] == -1)
            {
                return node;
            }

            return Find(parent[node]);
        }

        public void Init(int[][] edges)
        {
            Array.Fill(parent, -1);

            foreach (int[] t in edges)
            {
                int x = Find(t[0]);
                int y = Find(t[1]);

                if (x != y)
                {
                    Union(x, y);
                }
                else
                {
                    Console.WriteLine("Cycle detected");
                }
            }
        }
    }
}