using System;

namespace LeetCode.LeetAgain
{
    public class SearchMatrixSlnNew : ISolution
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            if (matrix.Length == 0)
                return false;
            int width = matrix.Length / matrix.GetLength(0);
            int start = 0;
            int end = matrix.Length - 1;

            while (start != end)
            {
                int mid = (start + end - 1) >> 1;
                if (matrix[mid / width, mid % width] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid;
                }
            }
            return matrix[end / width, end % width] == target;
        }

        private int BinarySearchMatrix(int[,] matrix, int start, int end, int target, int matrixWidth)
        {

            if (start > end)
                return -1;
            int mid = start + (end - start) / 2;

            if (matrix[mid / matrixWidth, mid % matrixWidth] < target)
            {
                return BinarySearchMatrix(matrix, mid + 1, end, target, matrixWidth);
            }
            else if (matrix[mid / matrixWidth, mid % matrixWidth] > target)
            {
                return BinarySearchMatrix(matrix, start, mid - 1, target, matrixWidth);
            }
            else
            {
                return mid;
            }
        }

        void ISolution.Execute()
        {
            System.Console.WriteLine(SearchMatrix(new int[4, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 11, 12, 13 } }, 10));
            System.Console.WriteLine(SearchMatrix(new int[3, 1] { { 1 }, { 3 }, { 5 } }, 1));
        }
    }
}