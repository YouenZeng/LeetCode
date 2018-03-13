using System;
using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    class FindMinHeightTreesSln : ISolution
    {
        public IList<int> FindMinHeightTrees(int n, int[,] edges)
        {
            //restart this after 2 months.

            if (n == 1) return new List<int>() { 0 };

            //https://leetcode.com/problems/minimum-height-trees/description/
            List<HashSet<int>> adj = new List<HashSet<int>>();

            for (int i = 0; i < n; i++)
            {
                adj.Add(new HashSet<int>());
            }

            for (int i = 0; i < edges.GetLength(0); i++)
            {
                adj[edges[i, 0]].Add(edges[i, 1]);
                adj[edges[i, 1]].Add(edges[i, 0]);
            }

            List<int> leaves = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (adj[i].Count == 1)
                    leaves.Add(i);
            }

            while (n > 2)
            {
                n -= leaves.Count;
                List<int> newleaves = new List<int>();
                foreach (int i in leaves)
                {
                    var jEnum = adj[i].GetEnumerator();
                    jEnum.MoveNext();
                    int j = jEnum.Current;
                    adj[j].Remove(i);
                    if (adj[j].Count == 1) newleaves.Add(j);
                }
                leaves = newleaves;
            }
            return leaves;

        }
        public void Execute()
        {
            FindMinHeightTrees(6, new int[,] {
                {0, 3}, {1, 3}, {2, 3}, {4, 3}, {5, 4}
                }
        );
        }
    }
}