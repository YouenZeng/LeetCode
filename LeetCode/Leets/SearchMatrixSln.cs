using System;

namespace LeetCode.Leets
{
    class SearchMatrixSln : ISolution
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);

            int start = 0;
            int end = m * n - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (matrix[mid / n, mid % n] == target)
                {
                    return true;
                }
                if (matrix[mid / n, mid % n] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return false;
        }
        public void Execute()
        {
            int[,] nums =  
                            {
                                     {1,   3,  5,  7},
                                        {10, 11, 16, 20},
                                     {23, 30, 34, 50}
                            };

           

            Console.WriteLine(SearchMatrix(nums, 1));
        }
    }
}
