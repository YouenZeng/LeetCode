using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class IntegerBreakSln : ISolution
    {

        public int IntegerBreak(int n)
        {
            int[] cache = new int[n + 1];
            cache[0] = 1;
            cache[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    cache[i] = Math.Max(cache[i], Math.Max(j, cache[j]) * Math.Max(i - j, cache[i - j]));
                }
            }
            return cache[n];
            //return IntegerBrakerInternal(n, cache);
        }

        public int IntegerBreak2(int n)
        {
            int[] cache = new int[n + 1];
            cache[0] = 1;
            cache[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    cache[i] = Math.Max(cache[i], Math.Max(j, cache[j]) * Math.Max(i - j, cache[i - j]));
                }
            }
            return cache[n];
            //return IntegerBrakerInternal(n, cache);
        }

        int IntegerBrakerInternal(int n, int[] cache)
        {
            if (cache[n] != 0) return cache[n];

            for (int i = 2; i < n; i++)
            {
                cache[i] = IntegerBrakerInternal(i, cache);
                cache[n - i] = IntegerBrakerInternal(n - i, cache);

                if (cache[i] < i) cache[i] = i;
                if (cache[n - i] < n - i) cache[n - i] = n - i;
            }

            int result = 0;
            for (int i = 0; i < n; i++)
            {
                if (cache[i] * cache[n - i] > result)
                    result = cache[i] * cache[n - i];
            }
            return result;
        }
        public void Execute()
        {
            Console.WriteLine(IntegerBreak(2));
        }
    }
}
