using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class FindMinHeightTreesSln : ISolution
    {
        public IList<int> FindMinHeightTrees(int n, int[][] edges)
        {
            int edgeCount = edges[0].Length;

            //1. dict <k,v> k: node , v:List<int> child node list
            //2. BFS

            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

            for (int i = 0; i < edgeCount; i++)
            {
                var node = edges[i][0];
                var node2 = edges[i][1];

                if (dict.ContainsKey(node) == false)
                {
                    dict[node] = new List<int>() { node2 };
                }
                if (dict.ContainsKey(node2) == false)
                {
                    dict[node2] = new List<int>() { node };
                }
            }


            Queue<int> q = new Queue<int>();
            foreach (var item in dict)
            {
                q.Enqueue(item.Key);
            }



            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}