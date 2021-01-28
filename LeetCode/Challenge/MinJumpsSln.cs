using System;
using System.Collections.Generic;

namespace LeetCode.Challenge
{
    class MinJumpsSln : ISolution
    {
        public int MinJumps(int[] arr)
        {
            if (arr.Length == 1)
            {
                return 0;
            }

            Dictionary<int, List<int>> itemLocationDict = new Dictionary<int, List<int>>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (itemLocationDict.ContainsKey(arr[i]))
                {
                    itemLocationDict[arr[i]].Add(i);
                }
                else
                {
                    itemLocationDict[arr[i]] = new List<int>() { i };
                }
            }

            Dictionary<int, List<int>> vertex = new Dictionary<int, List<int>>();
            for (int i = 0; i < arr.Length; i++)
            {
                vertex[i] = new List<int>();
                vertex[i].Add(i - 1);
                vertex[i].Add(i + 1);

                vertex[i].AddRange(itemLocationDict[arr[i]]);
            }

            Queue<int> q = new Queue<int>(vertex[0]);

            bool[] visited = new bool[arr.Length];
            int targetIndex = arr.Length - 1;
            int layer = 1;
            int layerCount = vertex[0].Count;
            visited[0] = true;
            HashSet<int> visitedValue = new HashSet<int>();
            while (q.Count > 0)
            {
                int item = q.Dequeue();
                layerCount--;
                if (item >= 0 && item <= targetIndex && !visited[item] && visitedValue.Add(arr[item]))
                {
                    visited[item] = true;
                    for (int i = 0; i < vertex[item].Count; i++)
                    {
                        q.Enqueue(vertex[item][i]);
                    }
                }

                if (item == targetIndex)
                {
                    return layer;
                }
                if (layerCount == 0)
                {
                    layer++;
                    layerCount = q.Count;
                }

            }

            return arr.Length - 1;
        }

        public void Execute()
        {
            Console.WriteLine(MinJumps(new[] { 2 }));
            Console.WriteLine(MinJumps(new[]
            {
                80, -86, 40, 12, 40, -98, 12, -86, -79, -4, -79, 71, 44, -43, -9, -88, 88, -43, 31, 4, 71, -86, 55, -9,
                -65
            }));
            Console.WriteLine(MinJumps(new[] { 7 }));
            Console.WriteLine(MinJumps(new[] { 7, 6, 9, 6, 9, 6, 9, 7 }));
            Console.WriteLine(MinJumps(new[] { 6, 1, 9 }));
            Console.WriteLine(MinJumps(new[] { 11, 22, 7, 7, 7, 7, 7, 7, 7, 22, 13 }));
            Console.WriteLine(MinJumps(new[] { 1, 1, 1, 1, 1 }));
        }
    }
}