using System;

namespace LeetCode.Challenge
{
    class FindDiagonalOrderSln : ISolution
    {
        public int[] FindDiagonalOrder(int[][] matrix)
        {
            //BFS
            int row = 0;
            int col = 0;
            bool isUp = true;
            int width = matrix[0].Length;
            int height = matrix.GetLength(0);
            int[] result = new int[matrix.Length];

            while (row < height || col < width)
            {
                DragonalVisit(matrix, row, col, result, isUp);
                if (isUp)
                {

                }
                isUp = !isUp;
            }

            return result;
        }

        private void DragonalVisit(int[][] matrix, int rowIndex, int colIndex, int[] data, bool isUp)
        {
            if (isUp)
            {

            }
            else
            {

            }
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
