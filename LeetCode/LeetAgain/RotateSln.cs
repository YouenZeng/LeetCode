using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class RotateSln : ISolution
    {
        public void Rotate(int[][] matrix)
        {
            int t;
            int max = matrix.GetLength(0);
            //1. rotate from left-up corner
            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    t = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = t;
                }
            }


            //2. rotate from up to down
            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < max / 2; j++)
                {
                    t = matrix[i][j];
                    matrix[i][j] = matrix[i][max - j - 1];
                    matrix[i][max - j - 1] = t;
                }
            }
        }

        private void Swap(int[][] matrix, int x1, int y1, int x2, int y2)
        {
            int t = matrix[x1][y1];
            matrix[x1][y1] = matrix[x2][y2];
            matrix[x2][y2] = t;
        }


        public void Execute()
        {
            Rotate(new[]
            {
                new int[] {1, 2, 3, 4}, new int[] {5, 6, 7, 8}, new int[] {9, 10, 11, 12}, new int[] {13, 14, 15, 16}
            });
        }
    }
}