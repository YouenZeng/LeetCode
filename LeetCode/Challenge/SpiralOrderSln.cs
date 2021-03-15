using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class SpiralOrderSln : ISolution
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            int width = matrix[0].Length;
            int height = matrix.Length;

            int up = 0;
            int down = height - 1;
            int left = 0;
            int right = width - 1;
            IList<int> result = new List<int>();

            int count = width * height;
            while (count > 0)
            {
                for (int i = left; i <= right; i++)
                {
                    result.Add(matrix[up][i]);
                }
                up++;
                if(up > down)
                {
                    break;
                }

                for (int i = up; i <= down; i++)
                {
                    result.Add(matrix[i][right]);
                }
                right--;
                if (right < left)
                {
                    break;
                }

                for (int i = right; i >= left; i--)
                {
                    result.Add(matrix[down][i]);
                }
                down--;
                if(down < up)
                {
                    break;
                }


                for (int i = down; i >= up; i--)
                {
                    result.Add(matrix[i][left]);
                }
                left++;
                if(left > right)
                {
                    break;
                }

            }
            return result;
        }
        public void Execute()
        {
            SpiralOrder(new int[][]
{
                new int[]{ 1,2,3,4},
                new int[]{ 5,6,7,8},
                new int[]{9,10,11,12},

});

            SpiralOrder(new int[][]
            {
                new int[]{ 1,2,3,4},
                new int[]{ 12,13,14,5},
                new int[]{ 11,16,15,6},
                new int[]{ 10,9,8,7},
            });
        }
    }
}
