using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Challenge
{
    internal class MaxEqualRowsAfterFlipsSln : ISolution
    {
        public int MaxEqualRowsAfterFlips(int[][] matrix)
        {
            int width = matrix[0].Length;
            int height = matrix.Length;

            int result = 1;
            int[] reversed = new int[width];
            Dictionary<string, int> map = new Dictionary<string, int>();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    reversed[j] = matrix[i][j] ^ 1;
                }

                string s1 = string.Join("", matrix[i]);
                string s2 = string.Join("", reversed);

                if (map.ContainsKey(s1))
                {
                    map[s1]++;
                }
                else
                {
                    map[s1] = 1;
                }

                if (map.ContainsKey(s2))
                {
                    map[s2]++;
                }
                else
                {
                    map[s2] = 1;
                }

                result = Math.Max(Math.Max(map[s1], map[s2]), result);
            }

            return result;
        }

        public void Execute()
        {
            MaxEqualRowsAfterFlips(new[]
            {
                new int[] {0, 0, 0},
                new int[] {0, 0, 1},
                new int[] {1, 1, 0},
            });
        }
    }
}