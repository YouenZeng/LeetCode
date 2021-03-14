using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class PossibleBipartitionSln : ISolution
    {
        public bool PossibleBipartition(int N, int[][] dislikes)
        {
            int[] visited = new int[N + 1];

            Dictionary<int, List<int>> vertex = new Dictionary<int, List<int>>();
            for (int i = 1; i <= N; i++)
            {
                vertex[i] = new List<int>();
            }

            foreach (int[] edge in dislikes)
            {
                vertex[edge[0]].Add(edge[1]);
                vertex[edge[1]].Add(edge[0]);
            }

            foreach (var kvp in vertex)
            {
                if (visited[kvp.Key] == 0 && Dfs(vertex, visited, kvp.Key, 1) == false)
                {
                    return false;
                }
            }


            return true;
        }

        //0: unvisited, 1: visited, 2: completed
        private bool Dfs(Dictionary<int, List<int>> vertex, int[] visited, int v, int color)
        {
            if (visited[v] != 0)
            {
                return visited[v] == color;
            }

            visited[v] = color;
            foreach (int next in vertex[v])
            {
                if (Dfs(vertex, visited, next, -color) == false)
                {
                    return false;
                }
            }

            return true;
        }

        public void Execute()
        {
            PossibleBipartition(4, new[]
            {
                new int[] {1, 2},
                new int[] {1, 3},
                new int[] {2, 4},
            });
        }
    }
}