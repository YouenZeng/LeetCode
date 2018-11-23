using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    class MinFlipsMonoIncrSln : ISolution
    {
        private int[] cache1;
        private int[] cache0;
        public int MinFlipsMonoIncr(string S)
        {
            if (string.IsNullOrEmpty(S)) return 0;
            if (S.Length == 1) return 0;
            int startIndex = S.Length - 1;

            cache0 = new int[S.Length];
            cache1 = new int[S.Length];

            for (int i = 0; i < S.Length; i++)
            {
                cache0[i] = -1;
                cache1[i] = -1;
            }

            cache1[0] = S[0] == '1' ? 0 : 1;
            cache0[0] = S[0] == '1' ? 1 : 0;

            var res = Math.Min(F1(S, startIndex), F0(S, startIndex));
            return res;
        }

        private int F1(string S, int current)
        {
            if (current == 0)
            {
                return cache1[0];
            }

            if (cache0[current - 1] == -1)
            {
                cache0[current - 1] = F0(S, current - 1);
            }
            if (cache1[current - 1] == -1)
            {
                cache1[current - 1] = F1(S, current - 1);
            }

            return Math.Min(cache0[current - 1], cache1[current - 1]) + (S[current] == '1' ? 0 : 1);
        }

        private int F0(string S, int current)
        {
            if (current == 0)
            {
                return cache1[0];
            }
            if (cache0[current - 1] == -1)
            {
                cache0[current - 1] = F0(S, current - 1);
            }

            return cache0[current - 1] + (S[current] == '0' ? 0 : 1);
        }

        public void Execute()
        {
            MinFlipsMonoIncr("00110");
            MinFlipsMonoIncr("00011000");
            MinFlipsMonoIncr("00");
            MinFlipsMonoIncr("1");
            MinFlipsMonoIncr("0111111110");
        }
    }
}
