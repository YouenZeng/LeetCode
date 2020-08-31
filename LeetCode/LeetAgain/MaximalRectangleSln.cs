using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LeetAgain
{
    public class MaximalRectangleSln : ISolution
    {
        public int MaximalRectangle(char[][] matrix)
        {
            if (matrix.Length == 0)
                return 0;
            int[] rowCache = new int[matrix.GetLength(0)];

            int width = matrix[0].Length;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                rowCache[i] = LargestRectangleArea(matrix, width, i);
            }

            return rowCache.Max();
        }

        private int LargestRectangleArea(char[][] matrix, int width, int currentRow)
        {
            Dictionary<int, int> cache = new Dictionary<int, int>();

            //describe current row
            int[] heights = new int[width];
            int maxHeight = matrix.GetLength(0);
            for (int i = 0; i < width; i++)
            {
                int c = currentRow;
                int max = 0;
                while (c < maxHeight)
                {
                    if (matrix[c][i] == '1')
                    {
                        max++;
                        c++;
                    }
                    else
                    {
                        break;
                    }
                }

                heights[i] = max;
            }


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
            MaximalRectangle(new[]
            {
                new[] {'1', '0', '1', '0', '0'},
                new[] {'1', '0', '1', '1', '1'},
                new[] {'1', '1', '1', '1', '1'},
                new[] {'1', '0', '0', '1', '0'}
            });
        }
    }
}