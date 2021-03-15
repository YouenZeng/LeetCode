using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class SearchMatrixSln : ISolution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int width = matrix[0].Length;
            int height = matrix.GetLength(0);

            int widthUpper = width - 1;
            int heightUpper = height - 1;

            int widthLower = 0;
            int heightLower = 0;
            while (true)
            {

                if ( widthLower > widthUpper || heightLower > heightUpper)
                {
                    break;
                }

                if (matrix[heightUpper][widthLower] == target)
                {
                    return true;
                }
                if (matrix[heightUpper][widthLower] < target)
                {
                    widthLower++; continue;
                }

                if (matrix[heightLower][widthUpper] < target)
                {
                    heightLower++; continue;
                }
                //[4][0] .. [3][0]
                if (matrix[heightUpper][widthLower] > target)
                {
                    heightUpper--; continue;
                }

                //[0][4] .. [0][3]
                if (matrix[heightLower][widthUpper] > target)
                {
                    widthUpper--; continue;
                }


            }

            return false;
        }

        public void Execute()
        {
            //int[][] matrix = new[]
            //{
            //    new int[] {1, 4, 7, 10, 15}, new int[] {2, 5, 8, 12, 19}, new int[] {3, 6, 9, 16, 22},
            //    new int[] {10, 13, 14, 17, 24}, new int[] {18, 21, 23, 26, 30}
            //};

            int[][] matrix = new[]
            {
                new int[] {23}
            };
            SearchMatrix(matrix, 44);
        }
    }
}