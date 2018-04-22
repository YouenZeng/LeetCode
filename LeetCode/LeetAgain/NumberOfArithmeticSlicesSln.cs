using System;
using System.Linq;

namespace LeetCode.LeetAgain
{
    class NumberOfArithmeticSlicesSln : ISolution
    {
        public int NumberOfArithmeticSlices(int[] A)
        {
            if (A.Length <= 2)
            {
                return 0;
            }
            int[] cache = new int[A.Length];
            int[] diffCache = new int[A.Length];

            for (int i = 1; i < A.Length; i++)
            {
                diffCache[i] = A[i] - A[i - 1];
            }

            int prevDiff = diffCache[1];
            int sameDiffCount = 1;
            for (int i = 2; i < A.Length; i++)
            {
                if (diffCache[i] == prevDiff)
                {
                    sameDiffCount++;
                    if (sameDiffCount >= 2)
                    {
                        cache[i] = cache[i - 1] + 1;
                    }
                }
                else
                {
                    prevDiff = diffCache[i];
                    sameDiffCount = 1;
                }
            }

            return cache.ToList().Sum();
        }

        public void Execute()
        {
            Console.WriteLine(NumberOfArithmeticSlices(new[] { 1, 2, 3, 8,9,10}));
        }
    }
}