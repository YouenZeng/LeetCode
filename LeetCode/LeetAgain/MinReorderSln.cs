using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    class MinReorderSln : ISolution
    {
        public int MinReorder2(int n, int[][] connections)
        {
            //BFS
            Dictionary<int, List<int>> vertex = new Dictionary<int, List<int>>();
            Dictionary<int, List<int>> vertexWithDirection = new Dictionary<int, List<int>>();
            for (int i = 0; i < connections.Length; i++)
            {
                var e = connections[i];
                if (!vertex.ContainsKey(e[0]))
                {
                    vertex[e[0]] = new List<int>() {e[1]};
                }
                else
                {
                    vertex[e[0]].Add(e[1]);
                }

                if (!vertexWithDirection.ContainsKey(e[0]))
                {
                    vertexWithDirection[e[0]] = new List<int>() {e[1]};
                }
                else
                {
                    vertexWithDirection[e[0]].Add(e[1]);
                }

                if (!vertex.ContainsKey(e[1]))
                {
                    vertex[e[1]] = new List<int>() {e[0]};
                }
                else
                {
                    vertex[e[1]].Add(e[0]);
                }
            }

            Queue<int> q = new Queue<int>();
            bool[] visisted = new bool[n];
            int result = 0;
            q.Enqueue(0);
            while (q.Count > 0)
            {
                int node = q.Dequeue();
                if (visisted[node])
                {
                    continue;
                }

                visisted[node] = true;
                var v = vertex[node];

                for (int i = 0; i < v.Count; i++)
                {
                    if (visisted[v[i]])
                    {
                        continue;
                    }

                    if (vertexWithDirection.ContainsKey(node) && vertexWithDirection[node].Contains(v[i]))
                    {
                        result++;
                    }

                    q.Enqueue(v[i]);
                }
            }

            return result;
        }

        public int MinReorder(int n, int[][] connections)
        {
            //DFS
            Dictionary<int, List<int>> vertex = new Dictionary<int, List<int>>();
            Dictionary<int, List<int>> vertexWithDirection = new Dictionary<int, List<int>>();
            for (int i = 0; i < connections.Length; i++)
            {
                var e = connections[i];
                if (!vertex.ContainsKey(e[0]))
                {
                    vertex[e[0]] = new List<int>() {e[1]};
                }
                else
                {
                    vertex[e[0]].Add(e[1]);
                }

                if (!vertexWithDirection.ContainsKey(e[0]))
                {
                    vertexWithDirection[e[0]] = new List<int>() {e[1]};
                }
                else
                {
                    vertexWithDirection[e[0]].Add(e[1]);
                }

                if (!vertex.ContainsKey(e[1]))
                {
                    vertex[e[1]] = new List<int>() {e[0]};
                }
                else
                {
                    vertex[e[1]].Add(e[0]);
                }
            }


            bool[] visited = new bool[n];
            int result = Dfs(vertex, vertexWithDirection, 0, visited);
            return result;
        }

        private int Dfs(Dictionary<int, List<int>> vertex, Dictionary<int, List<int>> vertexWithDirection, int target,
            bool[] visited)
        {
            if (visited[target])
                return 0;

            visited[target] = true;

            if (!vertex.ContainsKey(target))
            {
                return 0;
            }

            var v = vertex[target];

            int count = 0;
            for (int i = 0; i < v.Count; i++)
            {
                if (!visited[v[i]])
                {
                    if (vertexWithDirection.ContainsKey(target) && vertexWithDirection[target].Contains(v[i]))
                    {
                        count++;
                    }

                    count = count + Dfs(vertex, vertexWithDirection, v[i], visited);
                }
            }

            return count;
        }

        public void Execute()
        {
            MinReorder2(6, new int[5][]
            {
                new[] {0, 1},
                new[] {1, 3},
                new[] {2, 3},
                new[] {4, 0},
                new[] {4, 5},
            });

            MinReorder2(3, new int[][]
            {
                new[] {1, 2},
                new[] {2, 0},
            });
        }
    }
}