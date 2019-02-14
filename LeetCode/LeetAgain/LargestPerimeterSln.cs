using System;

namespace LeetCode.LeetAgain
{
    internal class LargestPerimeterSln : ISolution
    {
        public int LargestPerimeter(int[] A)
        {
            Array.Sort(A);

            for (int i = A.Length - 1; i >= 2; i--)
            {
                if (A[i - 1] * 2 <= A[i])
                {
                    continue;
                }

                int thirdMin = A[i] - A[i - 1];
                if (A[i - 2] < thirdMin)
                {
                    continue;
                }

                return A[i] + A[i - 1] + A[i - 2];
            }

            return 0;

        }
        public void Execute()
        {
            Console.WriteLine(LargestPerimeter(new int[]{3, 9, 2, 5, 2, 19}));
            Console.WriteLine(LargestPerimeter(new int[] { 1, 2, 3, 5, 500, 501, 1000 }));
            Console.WriteLine(LargestPerimeter(new int[] { 1, 2, 3, 5, 1001, 999, 1000 }));
        }
    }
}
