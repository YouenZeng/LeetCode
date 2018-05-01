using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class NumMatrix : ISolution
    {
        private readonly int[,] _matrix;

        public NumMatrix(int[,] matrix)
        {
            _matrix = new int[matrix.GetLength(0) + 1, matrix.GetLength(1) + 1];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int tmp = 0;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    tmp += matrix[i, j];
                    _matrix[i + 1, j + 1] = _matrix[i, j + 1] + tmp;
                }
            }
        }

        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            return _matrix[row2 + 1, col2 + 1] - _matrix[row1, col2 + 1] - _matrix[row2 + 1, col1] +
                   _matrix[row1, col1];
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}