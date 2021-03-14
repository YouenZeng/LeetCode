using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Challenge
{
    class ThreeSumMultiSln : ISolution
    {
        public int ThreeSumMulti(int[] arr, int target)
        {
            long[] c = new long[101];
            foreach (int a in arr)
            {
                c[a]++;
            }


            long res = 0;
            for (int i = 0; i <= 100; i++)
            for (int j = i; j <= 100; j++)
            {
                int k = target - i - j;
                if (k > 100 || k < 0)
                {
                    continue;
                }

                if (i == j && j == k)
                {
                    res += c[i] * (c[i] - 1) * (c[i] - 2) / 6;
                }
                else if (i == j && j != k)
                {
                    res += c[i] * (c[i] - 1) / 2 * c[k];
                }
                else if (j < k)
                {
                    res += c[i] * c[j] * c[k];
                }
            }

            return (int) (res % (1e9 + 7));
        }

        public void Execute()
        {
            ThreeSumMulti(new[] {1, 1, 2, 2, 3, 3, 4, 4, 5, 5}, 8);
        }
    }
}