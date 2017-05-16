using System;

namespace LeetCode.LeetAgain
{
    //https://leetcode.com/problems/search-a-2d-matrix-ii/#/description
    public class SearchMatrix2D : ISolution
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            int matrixWidth = matrix.GetLength(0);
            int matrixHeight = matrix.GetLength(1);

            //treat this matrix as a tree
            int currentWidth = 0;
            int currentHeight = 0;

            while (currentWidth < matrixWidth || currentHeight < matrixHeight)
            {
                Console.WriteLine(matrix[currentWidth, currentHeight]);

                int left = matrix[currentWidth, currentHeight + 1];
                int right = matrix[currentWidth + 1, currentHeight];



                if (target == matrix[currentWidth, currentHeight])
                    return true;

                if (target > left && target > right)
                {
                    currentWidth++;
                    currentHeight++;
                    continue;
                }

                if (target <= left)
                {
                    //find in this column
                    Console.WriteLine("yy");
                    
                    currentHeight++;
                    continue;
                }

                if (target <= right)
                {
                    //find in this row
                    Console.WriteLine("xxx");
                    currentWidth++;
                    continue;
                }
            }

            return false;
        }
        public void Execute()
        {
            int[,] arr = {
                  { 1,   4,  7, 11, 15 },
  {2,   5,  8, 12, 19},
  {3,   6,  9, 16, 22},
  {10, 13, 14, 17, 24},
  {18, 21, 23, 26, 30}
    };
            Console.WriteLine(SearchMatrix(arr, 26));
            throw new NotImplementedException();
        }
    }
}