using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class MaxProductSln : ISolution
    {
        public int MaxProduct(string[] words)
        {
            int[] ct = new int[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                int bit = 0;
                for (int j = 0; j < words[i].Length; j++)
                {
                    bit |= 1 << (words[i][j] - 'a');
                }

                ct[i] = bit;
            }

            int max = 0;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if ((ct[i] & ct[j]) == 0)
                    {
                        max = Math.Max(words[i].Length * words[j].Length, max);
                    }
                }
            }

            return max;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}