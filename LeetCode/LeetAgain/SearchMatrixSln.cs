using System;

namespace LeetCode.LeetAgain
{
    public class SearchMatrixSln : ISolution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            var arrayCount = matrix.GetLength(0);
            if (arrayCount == 0)
                return false;
            var eachCount = matrix[0].Length;
            if (eachCount == 0)
                return false;
            int lengthLocation = BinarySearchForMatrix(matrix, 0, arrayCount - 1, target, eachCount);

            if (lengthLocation == -1)
                return false;

            int itemLocation = BinarySerachArray(matrix, lengthLocation, 0, eachCount - 1, target);
            if (itemLocation == -1)
                return false;

            return true;
        }

        private int BinarySearchForMatrix(int[][] matrix, int low, int high, int key, int eachCount)
        {
            if (low > high)
                return -1;
            int mid = (high - low) / 2 + low;
            if (matrix[mid][0] < key && matrix[mid][eachCount - 1] < key)
            {
                return BinarySearchForMatrix(matrix, mid + 1, high, key, eachCount);
            }

            if (matrix[mid][0] > key)
            {
                return BinarySearchForMatrix(matrix, low, mid - 1, key, eachCount);
            }

            return mid;
        }

        private int BinarySerachArray(int[][] matrix, int rowIndex, int low, int high, int key)
        {
            if (low > high)
                return -1;
            int mid = (high - low) / 2 + low;

            if (matrix[rowIndex][mid] < key)
                return BinarySerachArray(matrix, rowIndex, mid + 1, high, key);
            if (matrix[rowIndex][mid] > key)
                return BinarySerachArray(matrix, rowIndex, low, mid - 1, key);
            return mid;
        }

        void ISolution.Execute()
        {
            System.Console.WriteLine(SearchMatrix(
                new int[4][] {new[] {1, 2, 3}, new[] {4, 5, 6}, new[] {7, 8, 9}, new[] {11, 12, 13}},
                2));
            System.Console.WriteLine(SearchMatrix(new int[3][] {new[] {1}, new[] {3}, new[] {5}}, 1));
        }
    }
}