using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetAgain
{
    public class MatrixReshapeSln : ISolution
    {
        public int[,] MatrixReshape(int[,] nums, int r, int c)
        {
            int currentR = nums.GetLength(0);
            int currentC = nums.GetLength(1);

            if (currentC * currentR != r * c)
                return nums;

            if (currentR == r)
                return nums;

            int[,] result = new int[r, c];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    int currentIndex = i * c + j;
                    result[i, j] = nums[currentIndex / currentC, currentIndex % currentC];
                }
            }

            return result;
        }

        public void Execute()
        {
            int[,] arr = new int[1, 4] { { 1, 2, 3, 4 } };
            MatrixReshape(arr, 2, 2);
        }
    }
}
