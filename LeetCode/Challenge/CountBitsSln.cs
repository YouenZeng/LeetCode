using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Challenge
{
    class CountBitsSln:ISolution
    {
        public int[] CountBits(int num)
        {
            int[] bits = new int[num + 1];
            int highBit = 0;
            for (int i = 1; i <= num; i++)
            {
                if ((i & (i - 1)) == 0)
                {
                    highBit = i;
                }
                bits[i] = bits[i - highBit] + 1;
            }
            return bits;
        }

        public int[] countBits2(int num)
        {
            int[] bits = new int[num + 1];
            for (int i = 1; i <= num; i++)
            {
                bits[i] = bits[i >> 1] + (i & 1);
            }
            return bits;
        }

        public int[] countBits3(int num)
        {
            int[] bits = new int[num + 1];
            for (int i = 1; i <= num; i++)
            {
                bits[i] = bits[i & (i - 1)] + 1;
            }
            return bits;
        }

       

        public void Execute()
        {
            CountBits(10);
        }
    }
}
