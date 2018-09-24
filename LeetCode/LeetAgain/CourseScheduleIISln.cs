using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    class CourseScheduleIISln : ISolution
    {
        public int[] FindOrder(int numCourses, int[,] prerequisites)
        {
            int[] visisted = new int[numCourses];
            int[,] edges = prerequisites;

            List<List<int>> graph = new List<List<int>>(numCourses);
            List<int> list = new List<int>(numCourses);

            if (edges.GetLength(1) == 0)
            {
                List<int> r = new List<int>();
                for (int i = 0; i < numCourses; i++)
                {
                    r.Add(i);
                }

                return r.ToArray();
            }

            for (int i = 0; i < numCourses; i++)
            {
                graph.Add(null);
            }
            for (int j = 0; j < edges.GetLength(0); j++)
            {
                List<int> l = graph[edges[j, 0]];
                if (l == null)
                {
                    l = new List<int>();
                    graph[edges[j, 0]] = l;
                }
                l.Add(edges[j, 1]);
            }

            for (int i = 0; i < numCourses; i++)
            {
                if (visisted[i] == 2) continue;
                if (!Dfs(graph, list, visisted, i)) return new int[0];
            }

            return list.ToArray();
        }

        bool Dfs(List<List<int>> g, List<int> list, int[] visited, int node)
        {
            visited[node] = 1;
            List<int> b = g[node];
            //2: finished
            //1: visisted but not finished
            if (b != null)
            {
                foreach (int i in b)
                {
                    if (visited[i] == 2) continue;
                    //cyclic detected!
                    if (visited[i] == 1) return false;
                    if (!Dfs(g, list, visited, i)) return false;
                }
            }

            visited[node] = 2;
            list.Add(node);
            return true;
        }

        public void Execute()
        {
            FindOrder(2, new int[,] { { } });
            FindOrder(2, new int[,] { {1,0} });
            FindOrder(3, new int[,] { { 2, 0 }, { 2, 1 } });
            FindOrder(5, new int[,] { { 1, 0 }, { 0, 2 } });
            FindOrder(4, new int[,] { { 1, 0 }, { 2, 0 }, { 3, 1 }, { 3, 2 } });
            
        }
    }
}
