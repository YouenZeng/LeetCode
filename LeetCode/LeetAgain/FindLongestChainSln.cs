using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.LeetAgain
{
    class FindLongestChainSln : ISolution
    {
        public int FindLongestChain(int[,] pairs)
        {
            Array.Sort(pairs);

            int[] cache = new int[pairs.GetLength(1)];

            for (int i = 0; i < pairs.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    cache[i] = Math.Max(cache[i], pairs[i, 0] > pairs[j, 1] ? cache[j] + 1 : cache[j]);
                }
            }

            return cache[pairs.GetLength(1) - 1];
        }

        public void Execute()
        {
            FindLongestChain(new int[3, 2]
            {
                {1, 2},
                {2, 3},
                {3, 4}
            });
        }
    }
}