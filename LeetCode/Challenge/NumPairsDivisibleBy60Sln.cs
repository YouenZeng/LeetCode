using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class NumPairsDivisibleBy60Sln : ISolution
    {
        public int NumPairsDivisibleBy60(int[] time)
        {
            int count = 0;
            int[] cache = new int[60];

            foreach (int t in time)
            {
                cache[t % 60]++;
            }

            for (int i = 0; i < cache[0]; i++)
            {
                count += i;
            }

            for (int i = 0; i < cache[30]; i++)
            {
                count += i;
            }

            for (int i = 1; i < 30; i++)
            {
                count += cache[i] * cache[60 - i];
            }


            return count;
        }

        public void Execute()
        {
            NumPairsDivisibleBy60(new int[] {20, 40, 30, 30});
            NumPairsDivisibleBy60(new int[] {60, 60, 60});
            NumPairsDivisibleBy60(new int[] {30, 20, 150, 100, 40});
        }
    }
}