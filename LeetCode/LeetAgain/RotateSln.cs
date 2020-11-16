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

        /// <summary>
        /// https://leetcode.com/problems/rotate-array/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public void Rotate(int[] nums, int k)
        {
            int numLength = nums.Length;
            int step = k % numLength;

            var arr1 = new int[step];
            var arr2 = new int[numLength - step];

            Array.Copy(nums, arr2, numLength - step);

            for (int i = 0; i < step; i++)
            {
                arr1[i] = nums[numLength - step + i ];
            }

            for (int i = 0; i < step; i++)
            {
                nums[i] = arr1[i];
            }

            for (int i = 0; i < numLength - step; i++)
            {
                nums[step + i] = arr2[i];
            }


            //int step = k % nums.Length;

            //int startIndex = nums.Length;
            //while (startIndex > 0)
            //{
            //    startIndex = startIndex - step;
            //    //swap range

            //    for (int i = step - 1; i >= 0 && startIndex - step + i >= 0; i--)
            //    {
            //        int t = nums[startIndex - step + i];
            //        nums[startIndex - step + i] = nums[startIndex + i];
            //        nums[startIndex + i] = t;
            //    }
            //}
        }

        public void Execute()
        {
            Rotate(new int[] {1, 2, 3, 4, 5, 6, 7}, 3);

            Rotate(new[]
            {
                new int[] {1, 2, 3, 4}, new int[] {5, 6, 7, 8}, new int[] {9, 10, 11, 12}, new int[] {13, 14, 15, 16}
            });
        }
    }
}