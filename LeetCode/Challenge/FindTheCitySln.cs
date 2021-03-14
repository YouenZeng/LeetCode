using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Challenge
{
    class FindTheCitySln : ISolution
    {
        private const int max = 0x3f3f3f3f;

        public int FindTheCity3(int n, int[][] edges, int distanceThreshold)
        {
            int[] dist = new int[n];
            Array.Fill(dist, 0x3f);

            Dictionary<int, HashSet<Tuple<int, int>>> adj = new Dictionary<int, HashSet<Tuple<int, int>>>();
            for (int i = 0; i < n; i++)
            {
                adj[i] = new HashSet<Tuple<int, int>>();
            }
            foreach (int[]  edge in edges)
            {
                adj[edge[0]].Add(new Tuple<int, int>(edge[1], edge[2]));
                adj[edge[1]].Add(new Tuple<int, int>(edge[0], edge[2]));
            }

            Tuple<int, int> result = new Tuple<int, int>(0x3f3f3f3f, n);
            for (int s = 0; s < n; s++)
            {
                Array.Fill(dist, 0x3f);
                dist[s] = 0;

                List<Tuple<int, int>> q = new List<Tuple<int, int>>();
                q.Add(new Tuple<int, int>(0x3f3f3f3f,s));

                while(q.Count > 0)
                {
                    var first = q.OrderBy(c => c.Item1).FirstOrDefault();
                    q.Remove(first);

                    int v = first.Item2;
                    if(dist[v] < first.Item1)
                    {
                        continue;
                    }

                    foreach (var edge in adj[v])
                    {
                        if(dist[edge.Item1] > dist[v] + edge.Item2)
                        {
                            dist[edge.Item1] = dist[v] + edge.Item2;
                            q.Add(new Tuple<int, int>(dist[edge.Item1], edge.Item1));
                        }
                    }
                }

                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    if(dist[i] <= distanceThreshold)
                    {
                        count++;
                    }
                }

                if(count < result.Item1)
                {
                    result = new Tuple<int, int>(count, s);
                }

            }
            return result.Item2;
        }

        

        public int FindTheCity2(int n, int[][] edges, int distanceThreshold)
        {
            int[] dist = new int[n];
            Array.Fill(dist, 1000000007);

            int t = edges.Length;
            Array.Resize(ref edges, 2 * t);
            for (int i = 0; i < t; i++)
            {
                edges[t + i] = new int[] { edges[i][1], edges[i][0], edges[i][2] };
            }

            Tuple<int, int> result = new Tuple<int, int>(1000000007, n);
            for (int k = 0; k < n; k++)
            {
                dist[k] = 0;
                for (int j = 0; j < n -1; j++)
                {
                    for (int i = 0; i < edges.Length; i++)
                    {
                        int from = edges[i][0];
                        int to = edges[i][1];
                        int weight = edges[i][2];

                        if(dist[from] != 1000000007 && dist[to] > dist[from] + weight)
                        {
                            //relax
                            dist[to] = dist[from] + weight;
                        }
                    }
                }

                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    if(dist[i] <= distanceThreshold)
                    {
                        count++;
                    }
                }

                if(count <= result.Item1)
                {
                    result = new Tuple<int, int>(count, k);
                }

                Array.Fill(dist, 1000000007);

            }
            return result.Item2;
        }

        public int FindTheCity(int n, int[][] edges, int distanceThreshold)
        {
            int[][] dp = new int[n][];
            for (int i = 0; i < n; i++)
            {
                dp[i] = new int[n];
                Array.Fill(dp[i], 1000000007);
            }

            foreach (int[] edge in edges)
            {
                dp[edge[0]][edge[1]] = edge[2];
                dp[edge[1]][edge[0]] = edge[2];
            }

            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        dp[i][j] = Math.Min(dp[i][j], dp[i][k] + dp[k][j]);
                    }
                }
            }

            int result = 0;
            int minNumber = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {

                    if (i != j && dp[i][j] <= distanceThreshold)
                    {
                        count++;
                    }
                }

                if (count <= minNumber)
                {
                    minNumber = count;
                    result = i;
                }
            }
            return result;

        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
