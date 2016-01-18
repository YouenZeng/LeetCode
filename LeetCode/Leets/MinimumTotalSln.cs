using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Leets
{
    class MinimumTotalSln : ISolution
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            List<int> minLen = triangle[triangle.Count - 1].ToList();
            for (int i = triangle.Count - 2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    minLen[j] = Math.Min(minLen[j], minLen[j + 1]) + triangle[i][j];
                }
            }
            return minLen[0];
        }
        public void Execute()
        {
            IList<IList<int>> triangle = new List<IList<int>>();
            triangle.Add(new List<int>() { 2 });
            triangle.Add(new List<int>() { 3, 4 });
            triangle.Add(new List<int>() { 6, 5, 7 });
            triangle.Add(new List<int>() { 4, 1, 8, 3 });

            Console.WriteLine(MinimumTotal(triangle));




        }
    }
}
