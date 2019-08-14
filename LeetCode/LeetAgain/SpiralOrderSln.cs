using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class SpiralOrderSln : ISolution
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> result = new List<int>();
            if (matrix == null || matrix.GetLength(0) == 0)
            {
                return result;
            }

            int width = matrix[0].Length;
            int height = matrix.GetLength(0);
            int max = width * height;

            int left = 0;
            int right = width - 1;
            int up = 0;
            int down = height - 1;

            int direction = 1;


            int currentPosition = 0;

            while (currentPosition < max && result.Count<max)
            {
                if (direction == 1)
                {
                    int current = left;
                    while (current <= right)
                    {
                        result.Add(matrix[up][current]);
                        //Console.WriteLine(matrix[up][current]);
                        current++;
                        currentPosition++;
                    }
                    up++;
                    direction = 2;
                    continue;
                }

                if (direction == 2)
                {
                    int current = up;
                    while (current <= down)
                    {
                        result.Add(matrix[current][right]);
                        //Console.WriteLine(matrix[current][right]);
                        current++;
                        currentPosition++;
                    }
                    right--;
                    direction = 3;
                    continue;
                }

                if (direction == 3)
                {
                    int current = right;
                    while (current >= left)
                    {
                        result.Add(matrix[down][current]);
                        //Console.WriteLine(matrix[down][current]);
                        current--;
                        currentPosition++;
                    }
                    down--;
                    direction = 4;
                    continue;
                }

                if (direction == 4)
                {
                    int current = down;
                    while (current >= up)
                    {
                        result.Add(matrix[current][left]);
                        //Console.WriteLine(matrix[current][left]);
                        current--;
                        currentPosition++;
                    }
                    left++;
                    direction = 1;
                    continue;
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
