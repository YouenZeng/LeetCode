using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LeetAgain
{
    public class MinimumTotalSln : ISolution
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            int layerCount = triangle.Count;
            if (layerCount == 0)
                return 0;
            int[] cache = new int[triangle.Last().Count];
            cache[0] = triangle[0][0];

            for (int i = 1; i < layerCount; i++)
            {
                cache[i] = cache[i - 1] + triangle[i][i];
                for (int j = i-1; j >= 1; j--)
                {
                    cache[j] = Math.Min(cache[j], cache[j - 1]) + triangle[i][j];
                }

                cache[0] = cache[0] + triangle[i][0];
            }

            var min = int.MaxValue;
            foreach (var t in cache)
            {
                min = Math.Min(min, t);
            }

            return min;
        }

        void ISolution.Execute()
        {
            IList<IList<int>> list = new List<IList<int>>()
            {
                new List<int>() {2},
                new List<int>() {3, 4},
                new List<int>() {6, 5, 7},
                new List<int>() {4, 1, 8, 3},
            };

            //IList<IList<int>> list = new List<IList<int>>()
            //{
            //    new List<int>() {-1},
            //    new List<int>() {-2, -3},
            //};

            Console.WriteLine(MinimumTotal(list));
        }
    }
}