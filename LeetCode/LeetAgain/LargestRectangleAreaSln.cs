using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LeetAgain
{
    public class LargestRectangleAreaSln : ISolution
    {
        public int LargestRectangleArea(int[] heights)
        {
            Dictionary<int, int> cache = new Dictionary<int, int>();

            for (int i = 0; i < heights.Length; i++)
            {
                int max = heights[i];
                int current = heights[i];

                for (int j = i + 1; j < heights.Length; j++)
                {
                    if (current > heights[j])
                        current = heights[j];

                    max = Math.Max(current * (j - i + 1), max);
                }

                cache[i] = max;
            }

            return cache.Max(c => c.Value);
        }

        public void Execute()
        {
            LargestRectangleArea(new int[] {2, 1, 5, 6, 2, 3});

            LargestRectangleArea(new int[] {1, 2, 1, 4, 5, 1, 3, 3, 2, 4});
        }
    }
}