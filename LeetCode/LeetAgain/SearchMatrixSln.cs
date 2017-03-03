using System;

namespace LeetCode.LeetAgain
{
    public class SearchMatrixSln : ISolution
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            int eachCount = 0;
            int arrayCount = 0;

            arrayCount = matrix.GetLength(0);
            if (arrayCount == 0)
                return false;
            eachCount = matrix.Length / arrayCount;
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

        private int BinarySearchForMatrix(int[,] matrix, int low, int high, int key, int eachCount)
        {
            if (low > high)
                return -1;
            int mid = (high - low) / 2 + low;
            if (matrix[mid, 0] < key && matrix[mid, eachCount - 1] < key)
            {
                return BinarySearchForMatrix(matrix, mid + 1, high, key, eachCount);
            }
            if (matrix[mid, 0] > key)
            {
                return BinarySearchForMatrix(matrix, low, mid - 1, key, eachCount);
            }
            return mid;
        }

        private int BinarySerachArray(int[,] matrix, int rowIndex, int low, int high, int key)
        {
            if (low > high)
                return -1;
            int mid = (high - low) / 2 + low;

            if (matrix[rowIndex, mid] < key)
                return BinarySerachArray(matrix, rowIndex, mid + 1, high, key);
            else if (matrix[rowIndex, mid] > key)
                return BinarySerachArray(matrix, rowIndex, low, mid - 1, key);
            else
                return mid;
        }

        void ISolution.Execute()
        {
            // System.Console.WriteLine(BinarySearchForMatrix(new int[4, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } }, 0, 3, 5, 2));

            // System.Console.WriteLine(SearchMatrix(new int[4, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 11, 12, 13 } }, 10));
            System.Console.WriteLine(SearchMatrix(new int[3, 1] { { 1 }, { 3 }, { 5 } }, 1));
        }
    }
}