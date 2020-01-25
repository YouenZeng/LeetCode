using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class SortedSquaresSln : ISolution
    {
        public int[] SortedSquares(int[] A)
        {
            int leftPointer = 0;
            int rightPointer = A.Length - 1;

            int[] result = new int[A.Length];

            int currentIndex = A.Length - 1;
            while (leftPointer <= rightPointer)
            {
                if (A[rightPointer] >= Math.Abs(A[leftPointer]))
                {
                    result[currentIndex] = A[rightPointer] * A[rightPointer];
                    rightPointer--;
                    currentIndex--;
                }
                else
                {
                    result[currentIndex] = A[leftPointer] * A[leftPointer];
                    leftPointer++;
                    currentIndex--;
                }
            }

            return result;
        }
        public void Execute()
        {
            SortedSquares(new[] { -4, -1, 0, 3, 10 });
            SortedSquares(new[] { -7, -3, 2, 3, 11 });
        }
    }
}
