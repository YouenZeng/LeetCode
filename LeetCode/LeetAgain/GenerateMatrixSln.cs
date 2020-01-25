using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class GenerateMatrixSln : ISolution
    {
        public int[][] GenerateMatrix(int n)
        {
            if (n == 0)
                return null;

            int[][] matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
            }



            int width = n;
            int height = n;
            int max = width * height;

            int left = 0;
            int right = width - 1;
            int up = 0;
            int down = height - 1;

            int direction = 1;


            int currentPosition = 0;
            while (currentPosition < max)
            {
                if (direction == 1)
                {
                    int current = left;
                    while (current <= right)
                    {
                        currentPosition++;
                        matrix[up][current] = currentPosition;
                        current++;
                    }
                    up++;
                    direction = 2;
                }

                if (direction == 2)
                {
                    int current = up;
                    while (current <= down)
                    {
                        currentPosition++;
                        matrix[current][right] = currentPosition;
                        current++;
                    }
                    right--;
                    direction = 3;
                }

                if (direction == 3)
                {
                    int current = right;
                    while (current >= left)
                    {
                        currentPosition++;
                        matrix[down][current] = currentPosition;
                        //Console.WriteLine(matrix[down][current]);
                        current--;

                    }
                    down--;
                    direction = 4;
                }

                if (direction == 4)
                {
                    int current = down;
                    while (current >= up)
                    {
                        currentPosition++;
                        matrix[current][left] = currentPosition;
                        current--;

                    }
                    left++;
                    direction = 1;
                }

            }

            return matrix;
        }
        public void Execute()
        {
            GenerateMatrix(1);
        }
    }
}
