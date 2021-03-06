﻿using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    internal class MatrixScoreSln : ISolution
    {
        public int MatrixScore(int[][] A)
        {
            //1. iterate each row, if first is 0 then revert it
            int rowCount = A.Length; //rows
            int firstRowLength = A[0].Length; //columns
            for (int i = 0; i < rowCount; i++)
            {
                if (A[i][0] == 0)
                {
                    FlipRow(A, i);
                }
            }

            //2. iterate each column, make as many 1s as possible
            for (int i = 0; i < firstRowLength; i++)
            {
                int count = 0;
                for (int j = 0; j < rowCount; j++)
                {
                    count += A[j][i];
                }

                if (count * 2 < rowCount)
                {
                    FlipColumn(A, i);
                }
            }

            int result = 0;
            int bin = 1;
            for (int i = firstRowLength - 1; i >= 0; i--)
            {
                for (int j = 0; j < rowCount ; j++)
                {
                    result += A[j][i] * bin;
                }

                bin = bin << 1;
            }

            return result;
        }

        private void FlipRow(int[][] A, int row)
        {
            for (int i = 0; i < A[row].Length; i++)
            {
                A[row][i] = 1 - A[row][i];
            }
        }

        private void FlipColumn(int[][] A, int column)
        {
            for (int i = 0; i < A.Length; i++)
            {
                A[i][column] = 1 - A[i][column];
            }
        }

        public void Execute()
        {
            MatrixScore(new int[][] { new int[] { 0, 0, 1, 1 }, new int[] { 1, 0, 1, 0 }, new int[] { 0, 0 }, new int[] { 1 } });
        }
    }
}
