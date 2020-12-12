using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class MinReorderSln : ISolution
    {
        public int MinReorder(int n, int[][] connections)
        {
            //DFS
            Dictionary<int, List<int[]>> vertex = new Dictionary<int, List<int[]>>();
            for (int i = 0; i < connections.Length; i++)
            {
                if (vertex.ContainsKey(connections[i][0]) == false)
                {
                    vertex[connections[i][0]] = new List<int[]>() { connections[i] };
                }
                else
                {
                    vertex[connections[i][0]].Add(connections[i]);
                }
            }

            bool[] visited = new bool[n];
            bool[] discovered = new bool[n];

            int result = 0;
            for (int i = 0; i < n; i++)
            {
                if (visited[i] == false)
                {
                    result += Dfs(vertex, i, visited, discovered);
                }
            }

            return result;
        }


        private int Dfs(Dictionary<int, List<int[]>> vertex, int target, bool[] visisted, bool[] discovered)
        {
            if (vertex.ContainsKey(target) == false)
                return 0;

            if (discovered[target])
                return 0;

            discovered[target] = true;
            int count = 0;
            for (int i = 0; i < vertex[target].Count; i++)
            {
                if (visisted[vertex[target][i][1]] == false)
                {
                    count = count + 1 + Dfs(vertex, vertex[target][i][1], visisted, discovered);
                }
            }
            visisted[target] = true;
            return count;
        }



        public void Execute()
        {
            MinReorder(5, new int[4][] { new int[] { 1, 0 }, new int[] { 1, 2 }, new int[] { 3, 2 }, new int[] { 3, 4 } });
        }
    }
}
